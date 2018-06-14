using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfiguradorUI.Maestro;
using ConfigUtilitarios;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConfiguradorUI.Producto
{
    public partial class FormProducto : MetroForm
    {
        #region Variables

        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codBarraSelected = "";
        string cod1Selected = "";
        string cod2Selected = "";
        #endregion

        public FormProducto()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            var txts = new[] {  txtNombre, txtCodBarra, txtCodigo01,txtCodigo02,
                                txtReferencia,txtAltura,txtAncho,txtLargo,txtPeso,txtDiametro,
                                txtPvPuSinImpto,txtPvMiSinImpto,txtPvMaSinImpto,
                                txtPvPuConImpto,txtPvMiConImpto,txtPvMaConImpto,txtCostoProd};
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }

            var cbos = new[] {  cboUnidadMedida,cboFamilia,cboSubFamilia,
                                cboMarca,cboModelo,cboTipoProd,cboTipoExistencia,
                                cboGrupoProd,cboClaseProd,cboTipoMoneda,
                                cboImpuesto};
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);

                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cbo);
            }

            var chks = new[] {chkProductoVenta,chkProductoCompra,chkCombo,chkReceta,
                                chkActivo,chkImpto, chkExento,chkInafecto};

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            txtPvPuSinImpto.KeyPress += ValidarTxtDecimal;
            txtPvMiSinImpto.KeyPress += ValidarTxtDecimal;
            txtPvMaSinImpto.KeyPress += ValidarTxtDecimal;

            txtPvPuConImpto.KeyPress += ValidarTxtDecimal;
            txtPvMiConImpto.KeyPress += ValidarTxtDecimal;
            txtPvMaConImpto.KeyPress += ValidarTxtDecimal;

            txtCostoProd.KeyPress += ValidarTxtDecimal;
        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            if (isSelected && isChangedRow == false && TipoOperacion != TipoOperacionABM.Cambio)
            {
                TipoOperacion = TipoOperacionABM.Cambio;
                ControlarEventosABM();
            }
        }
        private void CambioEnControl(object sender, EventArgs e)
        {
            isChangedRow = false;
        }
        private void ValidarTxtDecimal(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = txt.Text.Contains(".") || txt.Text.Equals("") ?
                           true : false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void CommitProducto()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        PROt09_producto oProducto = new PROt09_producto();
                        oProducto = GetProducto();
                        long id = new ProductoBL().InsertarProducto(oProducto);
                        ControlarEventosABM(id);
                    }
                }
                else
                {
                    ActualizarProducto();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió un error en commit. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EliminarProducto()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvProducto.RowCount > 0)
                {
                    if (dgvProducto.SelectedRows.Count > 0)
                    {
                        try
                        {
                            long id = 0;
                            if (long.TryParse(lblIdProducto.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el producto?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    if (EsEliminacionValida(id))
                                    {
                                        new ProductoBL().EliminarProducto(id);
                                        ControlarEventosABM();
                                    }
                                    else
                                    {
                                        TipoOperacion = TipoOperacionABM.No_Action;
                                        ControlarEventosABM();
                                        MessageBox.Show(this, "Este registro no se puede eliminar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "El ID del producto es incorrecto.", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(this, "Ocurrió una excepción en el intento de eliminación: " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha seleccinado un producto.", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay registros", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private bool ActualizarProducto()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {

                        PROt09_producto oProducto = new PROt09_producto();
                        oProducto = GetProducto();
                        long id = 0;
                        if (long.TryParse(lblIdProducto.Text, out id))
                        {
                            oProducto.id_producto = id;
                            bool success = new ProductoBL().ActualizarProducto(oProducto);
                            ControlarEventosABM(oProducto.id_producto);
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar Producto: " + e.Message);
            }
            return isValid;
        }
        private bool ActualizarProductoEnCheck()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        PROt09_producto oProducto = new PROt09_producto();
                        oProducto = GetProducto();
                        long id = 0;
                        if (long.TryParse(lblIdProducto.Text, out id))
                        {
                            oProducto.id_producto = id;
                            bool success = new ProductoBL().ActualizarProducto(oProducto);
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar Producto en Check: " + e.Message);
            }
            return isValid;
        }

        private PROt09_producto GetProducto()
        {
            var oProducto = new PROt09_producto();
            try
            {
                oProducto.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                oProducto.txt_desc = txtNombre.Text.Trim();
                oProducto.cod_barra = txtCodBarra.Text.Trim();
                oProducto.cod_producto = txtCodigo01.Text.Trim();
                oProducto.cod_producto2 = txtCodigo02.Text.Trim();
                oProducto.txt_referencia = txtReferencia.Text.Trim();

                oProducto.peso_prod = txtPeso.Text.Trim();
                oProducto.largo_prod = txtLargo.Text.Trim();
                oProducto.ancho_prod = txtAncho.Text.Trim();
                oProducto.altura_prod = txtAltura.Text.Trim();
                oProducto.diametro_prod = txtDiametro.Text.Trim();


                if (cboUnidadMedida.SelectedValue != null)
                    oProducto.id_um = int.Parse(cboUnidadMedida.SelectedValue.ToString());

                if (cboSubFamilia.SelectedValue != null)
                    oProducto.id_subfamilia = int.Parse(cboSubFamilia.SelectedValue.ToString());

                if (cboModelo.SelectedValue != null)
                    oProducto.id_modelo = int.Parse(cboModelo.SelectedValue.ToString());

                if (cboTipoProd.SelectedValue != null)
                    oProducto.id_tipo_prod = int.Parse(cboTipoProd.SelectedValue.ToString());

                if (cboClaseProd.SelectedValue != null)
                    oProducto.id_clase_prod = int.Parse(cboClaseProd.SelectedValue.ToString());

                if (cboTipoExistencia.SelectedValue != null)
                    oProducto.id_tipo_existencia = int.Parse(cboTipoExistencia.SelectedValue.ToString());

                if (cboTipoMoneda.SelectedValue != null)
                    oProducto.id_tipo_moneda = int.Parse(cboTipoMoneda.SelectedValue.ToString());



                oProducto.sn_venta = chkProductoVenta.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_compra = chkProductoCompra.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_receta = chkReceta.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_combo = chkCombo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_exento = chkExento.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_inafecto = chkInafecto.Checked ? Estado.IdActivo : Estado.IdInactivo;
                oProducto.sn_incluye_impto = chkImpto.Checked ? Estado.IdActivo : Estado.IdInactivo;


                if (string.IsNullOrEmpty(txtPvPuSinImpto.Text.Trim()))
                    oProducto.mto_pvpu_sin_igv = null;
                else oProducto.mto_pvpu_sin_igv = decimal.Parse(txtPvPuSinImpto.Text);

                if (string.IsNullOrEmpty(txtPvMiSinImpto.Text.Trim()))
                    oProducto.mto_pvmi_sin_igv = null;
                else oProducto.mto_pvmi_sin_igv = decimal.Parse(txtPvMiSinImpto.Text);

                if (string.IsNullOrEmpty(txtPvMaSinImpto.Text.Trim()))
                    oProducto.mto_pvma_sin_igv = null;
                else oProducto.mto_pvma_sin_igv = decimal.Parse(txtPvMaSinImpto.Text);

                if (string.IsNullOrEmpty(txtPvPuConImpto.Text.Trim()))
                    oProducto.mto_pvpu_con_igv = null;
                else oProducto.mto_pvpu_con_igv = decimal.Parse(txtPvPuConImpto.Text);

                if (string.IsNullOrEmpty(txtPvMiConImpto.Text.Trim()))
                    oProducto.mto_pvmi_con_igv = null;
                else oProducto.mto_pvmi_con_igv = decimal.Parse(txtPvMiConImpto.Text);

                if (string.IsNullOrEmpty(txtPvMaConImpto.Text.Trim()))
                    oProducto.mto_pvma_con_igv = null;
                else oProducto.mto_pvma_con_igv = decimal.Parse(txtPvMaConImpto.Text);

                if (string.IsNullOrEmpty(txtCostoProd.Text.Trim()))
                    oProducto.costo_prod = null;
                else oProducto.costo_prod = decimal.Parse(txtCostoProd.Text);

                if (int.TryParse(cboImpuesto.SelectedValue?.ToString(), out int id_impto))
                {
                    oProducto.id_impuesto = id_impto;
                    oProducto.por_impto = GetPorcentajeImpuesto();
                }
                else
                {
                    oProducto.id_impuesto = null;
                    oProducto.por_impto = null;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error en la asignación de datos. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return oProducto;
        }
        private void SetProducto(PROt09_producto obj)
        {

            isChangedRow = true;

            LimpiarForm();

            chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

            lblIdProducto.Text = obj.id_producto.ToString();
            txtNombre.Text = obj.txt_desc;
            txtCodBarra.Text = obj.cod_barra;
            txtCodigo01.Text = obj.cod_producto;
            txtCodigo02.Text = obj.cod_producto2;

            codBarraSelected = obj.cod_barra;
            cod1Selected = obj.cod_producto;
            cod2Selected = obj.cod_producto2;


            if (obj.id_um != null)
                cboUnidadMedida.SelectedValue = obj.id_um;
            else
                cboUnidadMedida.SelectedIndex = -1;

            if (obj.PROt04_subfamilia != null)
                cboFamilia.SelectedValue = obj.PROt04_subfamilia.id_familia;
            else
                cboFamilia.SelectedIndex = -1;

            if (obj.id_subfamilia != null)
                cboSubFamilia.SelectedValue = obj.id_subfamilia;
            else
                cboSubFamilia.SelectedIndex = -1;

            if (obj.PROt02_modelo != null)
                cboMarca.SelectedValue = obj.PROt02_modelo.id_marca;
            else
                cboMarca.SelectedIndex = -1;

            if (obj.id_modelo != null)
                cboModelo.SelectedValue = obj.id_modelo;
            else
                cboModelo.SelectedIndex = -1;

            if (obj.id_tipo_prod != null)
                cboTipoProd.SelectedValue = obj.id_tipo_prod;
            else
                cboTipoProd.SelectedIndex = -1;

            if (obj.id_tipo_existencia != null)
                cboTipoExistencia.SelectedValue = obj.id_tipo_existencia;
            else
                cboTipoExistencia.SelectedIndex = -1;

            if (obj.PROt06_clase_prod != null)
                cboGrupoProd.SelectedValue = obj.PROt06_clase_prod.id_grupo_prod;
            else
                cboGrupoProd.SelectedIndex = -1;

            if (obj.id_clase_prod != null)
                cboClaseProd.SelectedValue = obj.id_clase_prod;
            else
                cboClaseProd.SelectedIndex = -1;

            chkProductoVenta.Checked = (obj.sn_venta == 1) ? true : false;
            chkProductoCompra.Checked = (obj.sn_compra == 1) ? true : false;
            chkCombo.Checked = (obj.sn_combo == 1) ? true : false;
            chkReceta.Checked = (obj.sn_receta == 1) ? true : false;

            txtReferencia.Text = obj.txt_referencia;

            txtPeso.Text = obj.peso_prod;
            txtLargo.Text = obj.largo_prod;
            txtAncho.Text = obj.ancho_prod;
            txtAltura.Text = obj.altura_prod;
            txtDiametro.Text = obj.diametro_prod;

            if (obj.id_tipo_moneda != null)
                cboTipoMoneda.SelectedValue = obj.id_tipo_moneda;
            else
                cboTipoMoneda.SelectedIndex = -1;


            if (obj.id_impuesto != null)
                cboImpuesto.SelectedValue = obj.id_impuesto;
            else
                cboImpuesto.SelectedIndex = -1;

            lblPorcentajeAcumuladoImpto.Text = obj.por_impto == null ? "-" : obj.por_impto.RemoveTrailingZeros();
            chkExento.Checked = obj.sn_exento == 1 ? true : false;
            chkInafecto.Checked = obj.sn_inafecto == 1 ? true : false;

            if (obj.sn_incluye_impto == Estado.IdActivo)
            {
                chkImpto.Checked = true;
                grbSinImpto.Enabled = false;
                grbConImpto.Enabled = true;
            }
            else
            {
                chkImpto.Checked = false;
                grbSinImpto.Enabled = true;
                grbConImpto.Enabled = false;
            }

            //Importante el orden, sobreescribe las acciones del evento.
            txtPvPuConImpto.Text = (obj.mto_pvpu_con_igv == null) ? "" : obj.mto_pvpu_con_igv.RemoveTrailingZeros();
            txtPvMiConImpto.Text = (obj.mto_pvmi_con_igv == null) ? "" : obj.mto_pvmi_con_igv.RemoveTrailingZeros();
            txtPvMaConImpto.Text = (obj.mto_pvma_con_igv == null) ? "" : obj.mto_pvma_con_igv.RemoveTrailingZeros();

            txtPvPuSinImpto.Text = (obj.mto_pvpu_sin_igv == null) ? "" : obj.mto_pvpu_sin_igv.RemoveTrailingZeros();
            txtPvMiSinImpto.Text = (obj.mto_pvmi_sin_igv == null) ? "" : obj.mto_pvmi_sin_igv.RemoveTrailingZeros();
            txtPvMaSinImpto.Text = (obj.mto_pvma_sin_igv == null) ? "" : obj.mto_pvma_sin_igv.RemoveTrailingZeros();

            txtCostoProd.Text = (obj.costo_prod == null) ? "" : obj.costo_prod.RemoveTrailingZeros();
        }

        private bool EsValido()
        {
            errorProv.Clear();

            bool no_error = true;

            if (txtNombre.Text.Trim().Length == 0)
            {
                tabProducto.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            #region cod1 único

            if (no_error)
            {
                string cod = txtCodigo01.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabProducto.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo01, msg);
                        txtCodigo01.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ProductoBL().ProductoXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo01, "El código ya está en uso.");
                                txtCodigo01.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != cod1Selected && obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo01, "El código ya está en uso.");
                                txtCodigo01.Focus();
                                no_error = false;
                            }
                        }

                    }
                }
            }

            #endregion

            #region cod2 único

            if (no_error)
            {
                string cod = txtCodigo02.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabProducto.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo02, msg);
                        txtCodigo02.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ProductoBL().ProductoXCod2(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo02, "El código ya está en uso.");
                                txtCodigo02.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != cod2Selected && obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo02, "El código ya está en uso.");
                                txtCodigo02.Focus();
                                no_error = false;
                            }
                        }

                    }

                }
            }

            #endregion

            #region codBarra único

            if (no_error)
            {
                string cod = txtCodBarra.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabProducto.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodBarra, msg);
                        txtCodBarra.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ProductoBL().ProductoXCodBarra(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código de barras ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodBarra, "El código de barras ya está en uso.");
                                txtCodBarra.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codBarraSelected && obj != null && obj.id_producto > 0)
                            {
                                tabProducto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código de barras ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodBarra, "El código de barras ya está en uso.");
                                txtCodBarra.Focus();
                                no_error = false;
                            }
                        }
                    }
                }
            }

            #endregion



            #region precios y costo

            if (no_error)
            {
                if ((chkImpto.Checked && grbSinImpto.Enabled == false))
                {
                    decimal nro = 0;

                    if (txtPvPuConImpto.Text.Length > 0)
                    {
                        if (!decimal.TryParse(txtPvPuConImpto.Text, out nro))
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txtPvPuConImpto, "Tiene que ingresar un número.");
                            txtPvPuConImpto.Focus();
                            no_error = false;
                        }
                    }
                    else
                    {
                        if (chkProductoVenta.Checked || (chkProductoVenta.Checked == false && chkProductoCompra.Checked == false && txtCostoProd.Text.Length <= 0))
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txtPvPuConImpto, "Este campo es requerido.");
                            txtPvPuConImpto.Focus();
                            no_error = false;
                        }
                    }

                    if (no_error)
                    {
                        var txtsNumericos = new[] { txtPvMiConImpto, txtPvMaConImpto };
                        foreach (var txtNum in txtsNumericos)
                        {

                            if (txtNum.Text.Length > 0)
                            {
                                decimal montoPv = 0;

                                if (!decimal.TryParse(txtNum.Text, out montoPv))
                                {
                                    tabProducto.SelectedTab = tabPagPrecio;
                                    errorProv.SetError(txtNum, "Tiene que ingresar un número.");
                                    txtNum.Focus();
                                    no_error = false;
                                    break;
                                }
                                else
                                {

                                    if (!(montoPv > 0 && montoPv < Math.Round(KeyAmounts.MaxAmount)))
                                    {
                                        tabProducto.SelectedTab = tabPagPrecio;
                                        errorProv.SetError(txtNum, $"Este precio tiene que ser mayor que 0 y menor que {Math.Round(KeyAmounts.MaxAmount)}.");
                                        txtNum.Focus();
                                        no_error = false;
                                        break;
                                    }

                                }
                            }
                        }
                    }
                    if (no_error)
                    {
                        decimal pvMa = 0, pvMi = 0, pvUn = 0;

                        if (txtPvMaConImpto.Text.Length > 0) pvMa = decimal.Parse(txtPvMaConImpto.Text);
                        if (txtPvMiConImpto.Text.Length > 0) pvMi = decimal.Parse(txtPvMiConImpto.Text);
                        if (txtPvPuConImpto.Text.Length > 0) pvUn = decimal.Parse(txtPvPuConImpto.Text);

                        if (pvMa != 0 && pvUn != 0 && pvUn >= pvMa)
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            MessageBox.Show("El precio unitario no puede ser mayor o igual al máximo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProv.SetError(txtPvPuConImpto, "El precio unitario no puede ser mayor o igual al precio máximo.");
                            txtPvPuConImpto.Focus();
                            no_error = false;
                        }
                        else
                        {
                            if (pvMa != 0 && pvMi != 0 && pvMi >= pvMa)
                            {
                                tabProducto.SelectedTab = tabPagPrecio;
                                MessageBox.Show("El precio mínimo no puede ser mayor o igual al precio máximo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                errorProv.SetError(txtPvMiConImpto, "El precio mínimo no puede ser mayor o igual al precio máximo.");
                                txtPvMiConImpto.Focus();
                                no_error = false;
                            }
                            else if (pvUn != 0 && pvMi != 0 && pvMi >= pvUn)
                            {
                                tabProducto.SelectedTab = tabPagPrecio;
                                MessageBox.Show("El precio mínimo no puede ser mayor o igual al precio unitario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                errorProv.SetError(txtPvMiConImpto, "El precio mínimo no puede ser mayor o igual al precio unitario.");
                                txtPvMiConImpto.Focus();
                                no_error = false;
                            }

                        }
                    }
                }
                else if (chkImpto.Checked == false && grbConImpto.Enabled == false)
                {
                    decimal num = 0;

                    if (txtPvPuSinImpto.Text.Length > 0)
                    {
                        if (!decimal.TryParse(txtPvPuSinImpto.Text, out num))
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txtPvPuSinImpto, "Tiene que ingresar un número.");
                            txtPvPuSinImpto.Focus();
                            no_error = false;
                        }
                    }
                    else
                    {
                        if (chkProductoVenta.Checked || (chkProductoVenta.Checked == false && chkProductoCompra.Checked == false && txtCostoProd.Text.Length <= 0))
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txtPvPuSinImpto, "Este campo es requerido.");
                            txtPvPuSinImpto.Focus();
                            no_error = false;
                        }
                    }

                    if (no_error)
                    {
                        var txtsNumericos = new[] { txtPvMiSinImpto, txtPvMaSinImpto };
                        foreach (var txtNum in txtsNumericos)
                        {

                            if (txtNum.Text.Length > 0)
                            {
                                decimal montoPv = 0;

                                if (!decimal.TryParse(txtNum.Text, out montoPv))
                                {
                                    tabProducto.SelectedTab = tabPagPrecio;
                                    errorProv.SetError(txtNum, "Tiene que ingresar un número.");
                                    txtNum.Focus();
                                    no_error = false;
                                    break;
                                }
                                else
                                {
                                    if (!(montoPv > 0 && montoPv < Math.Round(KeyAmounts.MaxAmount)))
                                    {
                                        tabProducto.SelectedTab = tabPagPrecio;
                                        errorProv.SetError(txtNum, $"Este precio tiene que ser mayor que 0 y menor que {Math.Round(KeyAmounts.MaxAmount)}.");
                                        txtNum.Focus();
                                        no_error = false;
                                        break;
                                    }

                                }
                            }
                        }
                    }

                    if (no_error)
                    {
                        decimal pvMa = 0, pvMi = 0, pvUn = 0;

                        if (txtPvMaSinImpto.Text.Length > 0) pvMa = decimal.Parse(txtPvMaSinImpto.Text);
                        if (txtPvMiSinImpto.Text.Length > 0) pvMi = decimal.Parse(txtPvMiSinImpto.Text);
                        if (txtPvPuSinImpto.Text.Length > 0) pvUn = decimal.Parse(txtPvPuSinImpto.Text);

                        if (pvMa != 0 && pvUn != 0 && pvUn >= pvMa)
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            MessageBox.Show("El precio unitario no puede ser mayor o igual al máximo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProv.SetError(txtPvPuSinImpto, "El precio unitario no puede ser mayor o igual al precio máximo.");
                            txtPvPuSinImpto.Focus();
                            no_error = false;
                        }
                        else
                        {
                            if (pvMa != 0 && pvMi != 0 && pvMi >= pvMa)
                            {
                                tabProducto.SelectedTab = tabPagPrecio;
                                MessageBox.Show("El precio mínimo no puede ser mayor o igual al precio máximo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                errorProv.SetError(txtPvMiSinImpto, "El precio mínimo no puede ser mayor o igual al precio máximo.");
                                txtPvMiSinImpto.Focus();
                                no_error = false;
                            }
                            else if (pvUn != 0 && pvMi != 0 && pvMi >= pvUn)
                            {
                                tabProducto.SelectedTab = tabPagPrecio;
                                MessageBox.Show("El precio mínimo no puede ser mayor o igual al precio unitario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                errorProv.SetError(txtPvMiSinImpto, "El precio mínimo no puede ser mayor o igual al precio unitario.");
                                txtPvMiSinImpto.Focus();
                                no_error = false;
                            }

                        }
                    }
                }

            }
            if (no_error)
            {
                var txtcosto = new[] { txtCostoProd };
                foreach (var txt in txtcosto)
                {
                    if (txt.Text.Length > 0)
                    {
                        decimal costo = 0;

                        if (!decimal.TryParse(txt.Text, out costo))
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txt, "Tiene que ingresar un número.");
                            txt.Focus();
                            no_error = false;
                            break;
                        }
                        else
                        {
                            if (!(costo > 0 && costo < Math.Round(KeyAmounts.MaxAmount)))
                            {
                                tabProducto.SelectedTab = tabPagPrecio;
                                errorProv.SetError(txt, $"El costo tiene que ser mayor que 0 y menor que {Math.Round(KeyAmounts.MaxAmount)}.");
                                txt.Focus();
                                no_error = false;
                                break;
                            }

                        }
                    }
                    else
                    {
                        if (chkProductoCompra.Checked)
                        {
                            tabProducto.SelectedTab = tabPagPrecio;
                            errorProv.SetError(txt, "Este campo es requerido");
                            txt.Focus();
                            no_error = false;
                            break;
                        }
                    }
                }
            }
            #endregion

            if (no_error && !chkActivo.Checked && TipoOperacion == TipoOperacionABM.Modificar)
            {
                long id = 0;
                if (long.TryParse(lblIdProducto.Text, out id))
                {
                    if (!EsEliminacionValida(id))
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabProducto.SelectedTab = tabPagGeneral;
                        errorProv.SetError(chkActivo, "No puede desactivarlo, está usándose en otro lado.");
                        chkActivo.Focus();
                        no_error = false;
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo obtener el id para verificar la validación.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    no_error = false;
                }
            }

            return no_error;
        }

        private bool EsEliminacionValida(long id)
        {
            bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Producto_ComboFixedDtl);
            if (validDelete)
            {
                validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Producto_ComboVariableDtl);
            }
            return validDelete;
        }

        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvProducto.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvProducto.Rows.Count > 0)
                        {
                            dgvProducto.Rows[index].Selected = true;
                            dgvProducto.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvProducto.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvProducto.Rows.Count > 0)
                        {
                            dgvProducto.Rows[index].Selected = true;
                            dgvProducto.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el producto. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarProdPorId(long id)
        {
            //Deberá ser capaz de buscar de posicionarse  en ese producto
            //si es que existe para los datos actuales de grilla
            // en caso no exista sencillamente se posicionará 
            //por defecto en el 1er registro si lo hubiera.
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvProducto.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_producto"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvProducto.Rows.Count > 0)
                    {
                        dgvProducto.Rows[index].Selected = true;
                        dgvProducto.FirstDisplayedScrollingRowIndex = index;

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el producto. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarRegistro()
        {
            isPending = false;
            if (dgvProducto.RowCount > 0 && dgvProducto.SelectedRows.Count > 0 && dgvProducto.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var oProducto = new ProductoBL().ProductoViewXId(id);
                        if (oProducto != null)
                        {
                            isSelected = false;
                            SetProducto(oProducto);
                            dgvProducto.Focus();
                            isChangedRow = true;
                            isSelected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string GetIdSelected()
        {
            string id = "-1";
            try
            {
                if (dgvProducto.SelectedRows.Count > 0 && dgvProducto.Rows.Count > 0)
                {
                    id = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }

        private string CalPrecioSinImpuesto(decimal precio_con_impto)
        {
            string precio_sin_impt = "0";
            try
            {
                decimal por_impto = GetPorcentajeImpuesto();
                precio_sin_impt = por_impto == 0 ? precio_con_impto.RemoveTrailingZeros() :
                                                    ((100 * precio_con_impto) / (100 + por_impto)).RemoveTrailingZeros();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "No se puedo calcular el precio sin impuesto. Excepción:" + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return precio_sin_impt;
        }
        private string CalPrecioConImpuesto(decimal precio_sin_impto)
        {
            string precio_con_impt = "0";
            try
            {
                decimal por_impto = GetPorcentajeImpuesto();
                precio_con_impt = por_impto == 0 ? precio_sin_impto.RemoveTrailingZeros() :
                                                    (precio_sin_impto * (1 + (por_impto / 100))).RemoveTrailingZeros();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "No se puedo calcular el precio con impuesto. Excepción:" + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return precio_con_impt;
        }

        private decimal GetPorcentajeImpuesto()
        {
            decimal.TryParse(lblPorcentajeAcumuladoImpto.Text, out decimal porcentaje);
            return porcentaje;
        }

        private void ActualizarPreciosSinImpto()
        {
            if (decimal.TryParse(txtPvPuConImpto.Text, out decimal pvPuConImpto))
            {
                txtPvPuSinImpto.Text = CalPrecioSinImpuesto(pvPuConImpto);
            }
            if (decimal.TryParse(txtPvMiConImpto.Text, out decimal pvMiConImpto))
            {
                txtPvMiSinImpto.Text = CalPrecioSinImpuesto(pvMiConImpto);
            }
            if (decimal.TryParse(txtPvMaConImpto.Text, out decimal pvMaConImpto))
            {
                txtPvMaSinImpto.Text = CalPrecioSinImpuesto(pvMaConImpto);
            }
        }
        private void ActualizarPreciosConImpto()
        {
            if (decimal.TryParse(txtPvPuSinImpto.Text, out decimal pvPuSinImpto))
            {
                txtPvPuConImpto.Text = CalPrecioConImpuesto(pvPuSinImpto);
            }
            else
            {
                txtPvPuSinImpto.Clear();
            }
            if (decimal.TryParse(txtPvMiSinImpto.Text, out decimal pvMiSinImpto))
            {
                txtPvMiConImpto.Text = CalPrecioConImpuesto(pvMiSinImpto);
            }
            else
            {
                txtPvMiSinImpto.Clear();
            }

            if (decimal.TryParse(txtPvMaSinImpto.Text, out decimal pvMaSinImpto))
            {
                txtPvMaConImpto.Text = CalPrecioConImpuesto(pvMaSinImpto);
            }
            else
            {
                txtPvMaSinImpto.Clear();
            }
        }
        private void ControlarCheckImpto()
        {
            try
            {
                if (!chkImpto.Checked)
                {
                    txtPvPuConImpto.Text = txtPvPuSinImpto.Text;
                    txtPvMiConImpto.Text = txtPvMiSinImpto.Text;
                    txtPvMaConImpto.Text = txtPvMaSinImpto.Text;

                    grbConImpto.Enabled = false;
                    grbSinImpto.Enabled = true;

                    cboImpuesto.Enabled = false;
                    cboImpuesto.SelectedIndex = cboImpuesto.Items.Count > 0 ? 0 : -1;

                    txtPvPuSinImpto.Focus();
                }
                else
                {
                    grbSinImpto.Enabled = false;
                    grbConImpto.Enabled = true;

                    cboImpuesto.Enabled = true;
                    cboImpuesto.SelectedValue = (int)DefaultValueInComboBox.Impuesto;

                    ActualizarPreciosConImpto();
                    txtPvPuConImpto.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió un error reseteando el check. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboFiltro()
        {
            try
            {
                var listFiltro = new ComboFiltro().ListarFiltros();
                cboFiltro.DisplayMember = "TxtCampo";
                cboFiltro.ValueMember = "IdCampo";
                cboFiltro.DataSource = listFiltro;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de Filtro: " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LimpiarForm()
        {
            isSelected = false;

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            lblIdProducto.Text = 0 + "";
            codBarraSelected = "";
            cod1Selected = "";
            cod2Selected = "";

            txtNombre.Clear();
            txtCodigo01.Clear();
            txtCodigo02.Clear();
            txtCodBarra.Clear();

            txtReferencia.Clear();
            txtPeso.Clear();
            txtLargo.Clear();
            txtAltura.Clear();
            txtAncho.Clear();
            txtDiametro.Clear();


            cboUnidadMedida.SelectedIndex = (cboUnidadMedida.Items.Count > 0) ? 0 : -1;

            cboFamilia.SelectedIndex = (cboFamilia.Items.Count > 0) ? 0 : -1;
            cboSubFamilia.SelectedIndex = (cboSubFamilia.Items.Count > 0) ? 0 : -1;

            cboMarca.SelectedIndex = (cboMarca.Items.Count > 0) ? 0 : -1;
            cboModelo.SelectedIndex = (cboModelo.Items.Count > 0) ? 0 : -1;

            cboTipoProd.SelectedIndex = (cboTipoProd.Items.Count > 0) ? 0 : -1;
            cboTipoExistencia.SelectedIndex = (cboTipoExistencia.Items.Count > 0) ? 0 : -1;

            cboGrupoProd.SelectedIndex = (cboGrupoProd.Items.Count > 0) ? 0 : -1;
            cboClaseProd.SelectedIndex = (cboClaseProd.Items.Count > 0) ? 0 : -1;

            cboTipoMoneda.SelectedIndex = (cboTipoMoneda.Items.Count > 0) ? 0 : -1;

            chkProductoVenta.Checked = true;
            chkProductoCompra.Checked = false;
            chkCombo.Checked = false;
            chkReceta.Checked = false;

            chkExento.Checked = false;
            chkInafecto.Checked = false;

            txtPvPuConImpto.Clear();
            txtPvMiConImpto.Clear();
            txtPvMaConImpto.Clear();

            chkImpto.Checked = true;
            cboImpuesto.SelectedValue = (int)DefaultValueInComboBox.Impuesto;

            grbSinImpto.Enabled = false;
            grbConImpto.Enabled = true;

            txtPvPuSinImpto.Clear();
            txtPvMiSinImpto.Clear();
            txtPvMaSinImpto.Clear();

            txtCostoProd.Clear();
        }
        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
        {
            btnNuevo.Enabled = eNuevo;
            btnDelete.Enabled = eDelete;
            btnCommit.Enabled = eCommit;
            btnRollback.Enabled = eRollback;
            btnSearch.Enabled = eSearch;
            btnFilter.Enabled = eFilter;
        }
        private void ControlarEventosABM(long? id = null)
        {

            if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
                errorProv.Clear();
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabProducto.SelectedTab = tabPagGeneral;
                    txtNombre.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        long idInsertado = (long)id;
                        SeleccionarProdPorId(idInsertado);
                        btnNuevo.Focus();
                    }
                    else
                    {
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked)
                            { ActualizarGrilla(); }
                            else { ActualizarGrilla(Estado.IdActivo); }
                            btnNuevo.Focus();
                        }
                        else
                        {
                            if (TipoOperacion == TipoOperacionABM.Rollback)
                            {
                                ControlarBotones(true, true, false, false, true, true);
                                isPending = false;
                                errorProv.Clear();
                                LimpiarForm();
                                SeleccionarRegistro();
                                btnNuevo.Focus();
                            }
                            else
                            {
                                if (TipoOperacion == TipoOperacionABM.Cambio)
                                {
                                    ControlarBotones(false, false, true, true, false, false);
                                    isPending = true;
                                }
                                else
                                {
                                    if (TipoOperacion == TipoOperacionABM.Modificar)
                                    {
                                        errorProv.Clear();
                                        LimpiarForm();
                                        ControlarBotones(true, true, false, false, true, true);
                                        isSelected = false;
                                        isPending = false;
                                        isChangedRow = false;
                                        if (tglListarInactivos.Checked)
                                        { ActualizarGrilla(); }
                                        else { ActualizarGrilla(Estado.IdActivo); }
                                        if (id != null)
                                        {
                                            long idAct = (long)id;
                                            SeleccionarProdPorId(idAct);
                                        }
                                        btnNuevo.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void MantenerEstadoABM()
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                ControlarBotones(false, false, true, true, false, false);
            }
            else if (TipoOperacion == TipoOperacionABM.Cambio)
            {
                ControlarBotones(false, false, true, true, false, false);
                isPending = true;
            }
            else if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
            else
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
        }
        private void CargarCombos()
        {
            try
            {
                //Averiguar sobre bindingList
                cboUnidadMedida.DataSource = null;
                cboUnidadMedida.DisplayMember = "txt_desc";
                cboUnidadMedida.ValueMember = "id_um";
                cboUnidadMedida.DataSource = new UnidadMedidaBL().ListaUnidadMed(Estado.IdActivo, true);

                cboFamilia.DataSource = null;
                cboFamilia.DisplayMember = "txt_desc";
                cboFamilia.ValueMember = "id_familia";
                cboFamilia.DataSource = new FamiliaBL().ListaFamiliaProd(Estado.IdActivo, false, true);

                cboSubFamilia.DataSource = null;
                cboSubFamilia.DisplayMember = "txt_desc";
                cboSubFamilia.ValueMember = "id_subfamilia";
                cboSubFamilia.DataSource = (cboFamilia.SelectedValue != null) ? new SubFamiliaBL().ListaSubFamXFam(int.Parse(cboFamilia.SelectedValue.ToString()), Estado.IdActivo) : null;

                cboMarca.DataSource = null;
                cboMarca.DisplayMember = "txt_desc";
                cboMarca.ValueMember = "id_marca";
                cboMarca.DataSource = new MarcaBL().ListaMarca(Estado.IdActivo, false, true);

                cboModelo.DataSource = null;
                cboModelo.DisplayMember = "txt_desc";
                cboModelo.ValueMember = "id_modelo";
                cboModelo.DataSource = (cboMarca.SelectedValue != null) ? new ModeloBL().ListaModeloXMarca(int.Parse(cboMarca.SelectedValue.ToString()), Estado.IdActivo) : null;


                cboTipoProd.DataSource = null;
                cboTipoProd.DisplayMember = "txt_desc";
                cboTipoProd.ValueMember = "id_tipo_prod";
                cboTipoProd.DataSource = new TipoProdBL().ListaTipoProd(Estado.IdActivo, false, true);

                cboTipoExistencia.DataSource = null;
                cboTipoExistencia.DisplayMember = "txt_desc";
                cboTipoExistencia.ValueMember = "id_tipo_existencia";
                cboTipoExistencia.DataSource = new TipoExistenciaBL().ListaTipoExistencia(Estado.IdActivo, true);

                cboGrupoProd.DataSource = null;
                cboGrupoProd.DisplayMember = "txt_desc";
                cboGrupoProd.ValueMember = "id_grupo_prod";
                cboGrupoProd.DataSource = new GrupoProdBL().ListaGrupoProd(Estado.IdActivo, false, true);

                cboClaseProd.DataSource = null;
                cboClaseProd.DisplayMember = "txt_desc";
                cboClaseProd.ValueMember = "id_clase_prod";
                cboClaseProd.DataSource = (cboGrupoProd.SelectedValue != null) ? new ClaseProdBL().ListaClaseProdXGrupo(int.Parse(cboGrupoProd.SelectedValue.ToString()), Estado.IdActivo) : null;

                cboTipoMoneda.DataSource = null;
                cboTipoMoneda.DisplayMember = "txt_desc";
                cboTipoMoneda.ValueMember = "id_tipo_moneda";
                cboTipoMoneda.DataSource = new TipoMonedaBL().ListaTipoMoneda(Estado.IdActivo, true);

                cboImpuesto.DataSource = null;
                cboImpuesto.DisplayMember = "txt_abrv";
                cboImpuesto.ValueMember = "id_impuesto";
                cboImpuesto.DataSource = new ImpuestoBL().ListaImpuesto(Estado.IdActivo, false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos aquí: " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new ProductoBL().ListaProducto(id_estado, true);
                var listaView = lista.Select(x => new { x.id_producto, CODIGO = x.cod_producto, NOMBRE = x.txt_desc })
               .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvProducto.DataSource = listaView;
                    dgvProducto.Columns["id_producto"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarGrilla(int? id_estado = null)
        {
            CargarGrilla(id_estado);
        }
        private void ConfigurarGrilla()
        {
            dgvProducto.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvProducto.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            dgvProducto.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvProducto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvProducto.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dgvProducto.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvProducto.AllowUserToResizeColumns = true;
            dgvProducto.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvProducto.Columns["CODIGO"].Width = 100;
            dgvProducto.Columns["NOMBRE"].Width = 300;
        }
        private void ConfigurarControles()
        {
            txtPvPuConImpto.TextAlign = HorizontalAlignment.Right;
            txtPvMiConImpto.TextAlign = HorizontalAlignment.Right;
            txtPvMaConImpto.TextAlign = HorizontalAlignment.Right;

            txtPvPuSinImpto.TextAlign = HorizontalAlignment.Right;
            txtPvMiSinImpto.TextAlign = HorizontalAlignment.Right;
            txtPvMaSinImpto.TextAlign = HorizontalAlignment.Right;

            txtCostoProd.TextAlign = HorizontalAlignment.Right;

            txtCodigo01.MaxLength = 50;
            txtCodigo02.MaxLength = 50;
            txtCodBarra.MaxLength = 20;
            txtNombre.MaxLength = 350;
            txtPvPuConImpto.MaxLength = 19;
            txtPvMiConImpto.MaxLength = 19;
            txtPvMaConImpto.MaxLength = 19;
            txtPvPuSinImpto.MaxLength = 19;
            txtPvMaSinImpto.MaxLength = 19;
            txtPvMiSinImpto.MaxLength = 19;
            txtCostoProd.MaxLength = 19;
            txtPeso.MaxLength = 10;
            txtLargo.MaxLength = 10;
            txtAncho.MaxLength = 10;
            txtAltura.MaxLength = 10;
            txtDiametro.MaxLength = 10;
            txtReferencia.MaxLength = 300;

        }
        private void ContarEstados(List<PROt09_producto> lista)
        {
            try
            {
                int numReg = lista.Count;
                int numAct = lista.Where(x => x.id_estado == Estado.IdActivo).ToList().Count;
                int numInac = lista.Where(x => x.id_estado == Estado.IdInactivo).ToList().Count;

                lblNumReg.Text = "Total: " + numReg;
                lblNumActivo.Text = "Activos: " + numAct;
                lblNumInactivo.Text = "Inactivos: " + numInac;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción el contar los estados: {e.Message}");
            }
        }
        private void SetInit()
        {
            lblIdProducto.Visible = false;
            ConfigurarControles();
            ControlarEventosABM();
            CargarCombos();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
        }

        #endregion

        #region Eventos de ventana

        private void FormProducto_Load(object sender, EventArgs e)
        {
            SetInit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Nuevo;
            ControlarEventosABM();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Eliminar;
            EliminarProducto();
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                TipoOperacion = TipoOperacionABM.Insertar;
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Cambio)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                }
            }
            CommitProducto();
        }
        private void btnRollback_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Rollback;
            ControlarEventosABM();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelFiltro.Visible = !panelFiltro.Visible;
            txtFiltro.Focus();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                string criterio = "";
                if (cboFiltro.SelectedValue != null)
                {
                    criterio = cboFiltro.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(criterio) && !filtro.Equals(""))
                    {

                        int idCriterio = int.Parse(criterio);
                        if (idCriterio == Filtro.Nombre)
                        {
                            Filtrar(Filtro.Nombre, filtro);
                        }
                        else if (idCriterio == Filtro.Codigo)
                        {
                            Filtrar(Filtro.Codigo, filtro);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrió una excepción al filtrar: " + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }

        #region Eventos de Cálculos
        private void txtPvPuConImpto_TextChanged(object sender, EventArgs e)
        {
            if (chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvPuConImpto.Text, out decimal pvPuConImpto))
                {
                    txtPvPuSinImpto.Text = CalPrecioSinImpuesto(pvPuConImpto);
                }
                else
                {
                    txtPvPuSinImpto.Clear();
                }
            }
            isChangedRow = false;
        }
        private void txtPvMiConImpto_TextChanged(object sender, EventArgs e)
        {
            if (chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvMiConImpto.Text, out decimal pvMiConImpto))
                {
                    txtPvMiSinImpto.Text = CalPrecioSinImpuesto(pvMiConImpto);
                }
                else
                {
                    txtPvMiSinImpto.Clear();
                }
            }
            isChangedRow = false;
        }
        private void txtPvMaConImpto_TextChanged(object sender, EventArgs e)
        {
            if (chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvMaConImpto.Text, out decimal pvMaConImpto))
                {
                    txtPvMaSinImpto.Text = CalPrecioSinImpuesto(pvMaConImpto);
                }
                else
                {
                    txtPvMaSinImpto.Clear();
                }
            }
            isChangedRow = false;
        }

        private void txtPvPuSinImpto_TextChanged(object sender, EventArgs e)
        {
            if (!chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvPuSinImpto.Text, out decimal pvPuSinImpto))
                {
                    txtPvPuConImpto.Text = txtPvPuSinImpto.Text;
                }
                else
                {
                    txtPvPuConImpto.Clear();
                }
            }
            isChangedRow = false;
        }
        private void txtPvMiSinImpto_TextChanged(object sender, EventArgs e)
        {
            if (!chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvMiSinImpto.Text, out decimal pvMiSinImpto))
                {
                    txtPvMiConImpto.Text = txtPvMiSinImpto.Text;
                }
                else
                {
                    txtPvMiConImpto.Clear();
                }
            }
            isChangedRow = false;
        }
        private void txtPvMaSinImpto_TextChanged(object sender, EventArgs e)
        {
            if (!chkImpto.Checked)
            {
                if (decimal.TryParse(txtPvMaSinImpto.Text, out decimal pvMaSinImpto))
                {
                    txtPvMaConImpto.Text = txtPvMaSinImpto.Text;
                }
                else
                {
                    txtPvMaConImpto.Clear();
                }
            }
            isChangedRow = false;
        }

        private void chkImpto_CheckedChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
            ControlarCheckImpto();
            isChangedRow = false;
        }
        #endregion

        private void cboImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal? porcentajeAcumulado = null;

            if (int.TryParse(cboImpuesto.SelectedValue?.ToString(), out int id))
            {
                porcentajeAcumulado = new ImpuestoBL().GetPorcentajeAcumulado(id);
            }

            lblPorcentajeAcumuladoImpto.Text = porcentajeAcumulado == null ? "-" : porcentajeAcumulado.RemoveTrailingZeros();

            if (chkImpto.Checked)
            {
                ActualizarPreciosSinImpto();
            }

            isChangedRow = false;
        }

        private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFamilia.SelectedValue != null)
            {
                cboSubFamilia.DataSource = null;
                cboSubFamilia.DisplayMember = "txt_desc";
                cboSubFamilia.ValueMember = "id_subfamilia";
                cboSubFamilia.DataSource = new SubFamiliaBL().ListaSubFamXFam(int.Parse(cboFamilia.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboSubFamilia.DataSource = null;

            cboSubFamilia.DropDownWidth = ControlHelper.DropDownWidth(cboSubFamilia);

            isChangedRow = false;
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedValue != null)
            {
                cboModelo.DataSource = null;
                cboModelo.DisplayMember = "txt_desc";
                cboModelo.ValueMember = "id_modelo";
                cboModelo.DataSource = new ModeloBL().ListaModeloXMarca(int.Parse(cboMarca.SelectedValue.ToString()), 1);
            }
            else cboModelo.DataSource = null;

            cboModelo.DropDownWidth = ControlHelper.DropDownWidth(cboModelo);

            isChangedRow = false;
        }

        private void cboGrupoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrupoProd.SelectedValue != null)
            {
                cboClaseProd.DataSource = null;
                cboClaseProd.DisplayMember = "txt_desc";
                cboClaseProd.ValueMember = "id_clase_prod";
                cboClaseProd.DataSource = new ClaseProdBL().ListaClaseProdXGrupo(int.Parse(cboGrupoProd.SelectedValue.ToString()), 1);
            }
            else cboClaseProd.DataSource = null;

            cboClaseProd.DropDownWidth = ControlHelper.DropDownWidth(cboClaseProd);

            isChangedRow = false;
        }

        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        TipoOperacion = TipoOperacionABM.Modificar;
                        //al intentar cambiar la fila si no es válido
                        //la actualización, no pasará hasta que sea válido
                        //o se dea rollback.
                        bool isValid = false;
                        string idSelect = GetIdSelected();

                        //Indica que está seleccionado otro registro
                        //que el que se quiere modificar
                        if (idSelect != lblIdProducto.Text && idSelect != "-1")
                        {
                            isValid = ActualizarProducto();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
                                SeleccionarProdPorId(long.Parse(idSelect));
                            }
                        }
                        else
                        {
                            ActualizarProducto();
                        }


                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        SeleccionarRegistro();
                        TipoOperacion = TipoOperacionABM.No_Action;
                        ControlarEventosABM();
                    }

                }
                else if (preguntar == false)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                    //al intentar cambiar la fila si no es válido
                    //la actualización, no pasará hasta que sea válido
                    //o se dea rollback.
                    bool isValid = false;
                    string idSelect = GetIdSelected();

                    //Indica que está seleccionado otro registro
                    //que el que se quiere modificar
                    if (idSelect != lblIdProducto.Text && idSelect != "-1")
                    {
                        isValid = ActualizarProducto();
                        if (isValid)
                        {
                            SeleccionarProdPorId(long.Parse(idSelect));
                        }
                    }
                    else
                    {
                        ActualizarProducto();
                    }
                }
            }
            else
            {
                SeleccionarRegistro();
                TipoOperacion = TipoOperacionABM.No_Action;
                ControlarEventosABM();
            }

        }

        private void tglListarInactivos_Click(object sender, EventArgs e)
        {
            //Controla que no se quede pegado la data del registro en caso 
            //no haya registro cambiando de estado del tgl
            // var check = sender as MetroToggle;

            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();

                    if (rp == DialogResult.Yes)
                    {
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = ActualizarProductoEnCheck();
                        //Ya se validó y actualizó pero aún no recarga la grilla
                        if (isValid)
                        {
                            if (tglListarInactivos.Checked)
                                tglListarInactivos.Checked = false;
                            else
                                tglListarInactivos.Checked = true;
                            ControlarEventosABM();
                        }
                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        LimpiarForm();
                        if (tglListarInactivos.Checked)
                        {
                            tglListarInactivos.Checked = false;
                            ActualizarGrilla(Estado.IdActivo);
                        }
                        else
                        {
                            tglListarInactivos.Checked = true;
                            ActualizarGrilla();
                        }
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = ActualizarProductoEnCheck();
                    //Ya se validó y actualizó pero aún no recarga la grilla
                    if (isValid)
                    {
                        if (tglListarInactivos.Checked)
                            tglListarInactivos.Checked = false;
                        else
                            tglListarInactivos.Checked = true;
                        ControlarEventosABM();
                    }
                }
            }

            else
            {
                LimpiarForm();
                if (tglListarInactivos.Checked)
                {
                    tglListarInactivos.Checked = false;
                    ActualizarGrilla(Estado.IdActivo);
                }
                else
                {
                    tglListarInactivos.Checked = true;
                    ActualizarGrilla();
                }

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }

        #region Eventos de ventanas emergentes

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboFamilia.SelectedValue != null)
                    oldValue = int.Parse(cboFamilia.SelectedValue.ToString());

                var frm = new FormFamilia();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboFamilia.DataSource = null;
                    cboFamilia.DisplayMember = "txt_desc";
                    cboFamilia.ValueMember = "id_familia";
                    cboFamilia.DataSource = new FamiliaBL().ListaFamiliaProd(Estado.IdActivo, false, true);
                    cboFamilia.DropDownWidth = ControlHelper.DropDownWidth(cboFamilia);

                    cboFamilia.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubFamilia_Click(object sender, EventArgs e)
        {
            int oldValue = 0;
            int op = TipoOperacion;

            if (cboSubFamilia.SelectedValue != null)
                oldValue = int.Parse(cboSubFamilia.SelectedValue.ToString());

            var frm = new FormSubFamilia();
            frm.ShowDialog();

            if (frm.actualizar)
            {
                if (cboFamilia.SelectedValue != null)
                {
                    cboSubFamilia.DataSource = null;
                    cboSubFamilia.DisplayMember = "txt_desc";
                    cboSubFamilia.ValueMember = "id_subfamilia";
                    cboSubFamilia.DataSource = new SubFamiliaBL().ListaSubFamXFam(int.Parse(cboFamilia.SelectedValue.ToString()), Estado.IdActivo);
                }
                else cboSubFamilia.DataSource = null;

                cboSubFamilia.SelectedValue = oldValue;
                TipoOperacion = op;
                MantenerEstadoABM();
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboMarca.SelectedValue != null)
                    oldValue = int.Parse(cboMarca.SelectedValue.ToString());

                var frm = new FormMarca();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboMarca.DataSource = null;
                    cboMarca.DisplayMember = "txt_desc";
                    cboMarca.ValueMember = "id_marca";
                    cboMarca.DataSource = new MarcaBL().ListaMarca(Estado.IdActivo, false, true);
                    cboMarca.DropDownWidth = ControlHelper.DropDownWidth(cboMarca);

                    cboMarca.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            int oldValue = 0;
            int op = TipoOperacion;

            if (cboModelo.SelectedValue != null)
                oldValue = int.Parse(cboModelo.SelectedValue.ToString());

            var frm = new FormModelo();
            frm.ShowDialog();

            if (frm.actualizar)
            {
                if (cboMarca.SelectedValue != null)
                {
                    cboModelo.DataSource = null;
                    cboModelo.DisplayMember = "txt_desc";
                    cboModelo.ValueMember = "id_modelo";
                    cboModelo.DataSource = new ModeloBL().ListaModeloXMarca(int.Parse(cboMarca.SelectedValue.ToString()), Estado.IdActivo);
                }
                else cboModelo.DataSource = null;

                cboModelo.SelectedValue = oldValue;
                TipoOperacion = op;
                MantenerEstadoABM();
            }
        }

        private void btnTipoProd_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboTipoProd.SelectedValue != null)
                    oldValue = int.Parse(cboTipoProd.SelectedValue.ToString());

                var frm = new FormTipoProd();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboTipoProd.DataSource = null;
                    cboTipoProd.DisplayMember = "txt_desc";
                    cboTipoProd.ValueMember = "id_tipo_prod";
                    cboTipoProd.DataSource = new TipoProdBL().ListaTipoProd(Estado.IdActivo, false, true);
                    cboTipoProd.DropDownWidth = ControlHelper.DropDownWidth(cboTipoProd);

                    cboTipoProd.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrupoProd_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboGrupoProd.SelectedValue != null)
                    oldValue = int.Parse(cboGrupoProd.SelectedValue.ToString());

                var frm = new FormGrupo();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboGrupoProd.DataSource = null;
                    cboGrupoProd.DisplayMember = "txt_desc";
                    cboGrupoProd.ValueMember = "id_grupo_prod";
                    cboGrupoProd.DataSource = new GrupoProdBL().ListaGrupoProd(Estado.IdActivo, false, true);
                    cboGrupoProd.DropDownWidth = ControlHelper.DropDownWidth(cboGrupoProd);

                    cboGrupoProd.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClaseProd_Click(object sender, EventArgs e)
        {
            int oldValue = 0;
            int op = TipoOperacion;

            if (cboClaseProd.SelectedValue != null)
                oldValue = int.Parse(cboClaseProd.SelectedValue.ToString());

            var frm = new FormClase();
            frm.ShowDialog();

            if (frm.actualizar)
            {
                if (cboGrupoProd.SelectedValue != null)
                {
                    cboClaseProd.DataSource = null;
                    cboClaseProd.DisplayMember = "txt_desc";
                    cboClaseProd.ValueMember = "id_clase_prod";
                    cboClaseProd.DataSource = new ClaseProdBL().ListaClaseProdXGrupo(int.Parse(cboGrupoProd.SelectedValue.ToString()), Estado.IdActivo);
                }
                else cboClaseProd.DataSource = null;

                cboClaseProd.SelectedValue = oldValue;
                TipoOperacion = op;
                MantenerEstadoABM();
            }
        }

        private void btnImpuesto_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboImpuesto.SelectedValue != null)
                    oldValue = int.Parse(cboImpuesto.SelectedValue.ToString());

                var frm = new FormImpuesto();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboImpuesto.DataSource = null;
                    cboImpuesto.DisplayMember = "txt_abrv";
                    cboImpuesto.ValueMember = "id_impuesto";
                    cboImpuesto.DataSource = new ImpuestoBL().ListaImpuesto(Estado.IdActivo, false, true);
                    cboImpuesto.DropDownWidth = ControlHelper.DropDownWidth(cboImpuesto);

                    cboImpuesto.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        preguntar = !checkDialog.check;
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = ActualizarProducto();
                        if (isValid)
                        {
                            isPending = false;
                            Dispose();
                            Hide();
                            Close();
                        }

                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        Dispose();
                        Hide();
                        Close();
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = ActualizarProducto();
                    if (isValid)
                    {
                        isPending = false;
                        Dispose();
                        Hide();
                        Close();
                    }
                }
            }
            else
            {
                Dispose();
                Hide();
                Close();
            }
        }

        #endregion
    }
}
