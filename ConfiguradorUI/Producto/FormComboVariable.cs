﻿using MetroFramework.Forms;
using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigUtilitarios;
using ConfigBusinessLogic.Producto;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios.HelperControl;
using ConfiguradorUI.Buscadores;
using ConfigBusinessLogic;
using ConfigUtilitarios.KeyValues;

namespace ConfiguradorUI.Producto
{
    public partial class FormComboVariable : MetroForm
    {

        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        public bool actualizar = false;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";

        PROt09_producto item = null;
        List<PROt16_combo_variable_dtl> details = null;
        int maxNumItems = 3;
        #endregion

        public FormComboVariable()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        #region Métodos Details

        private void SetItem(PROt09_producto producto)
        {
            try
            {
                item = new PROt09_producto();
                item = producto;

                txtItemCod.Text = producto.cod_producto;
                txtItemDesc.Text = producto.txt_desc;
                txtItemPriceConImp.Text = producto.mto_pvpu_con_igv?.ToString();
                txtItemPriceSinImp.Text = producto.mto_pvpu_sin_igv?.ToString();
                txtItemQuantity.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo setear el producto. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PROt16_combo_variable_dtl GetItem()
        {
            try
            {
                var detailItem = new PROt16_combo_variable_dtl();
                detailItem.PROt09_producto = new PROt09_producto();

                detailItem.id_producto = item.id_producto;
                detailItem.cod_combo_variable_dtl = item.cod_producto;
                detailItem.cantidad = decimal.Parse(txtItemQuantity.Text.Trim());
                detailItem.mto_pvpu_sin_tax = decimal.Parse(txtItemPriceSinImp.Text.Trim());
                detailItem.mto_pvpu_con_tax = decimal.Parse(txtItemPriceConImp.Text.Trim());
                detailItem.id_estado = Estado.IdActivo;
                detailItem.txt_estado = Estado.TxtActivo;

                detailItem.PROt09_producto.txt_desc = txtItemDesc.Text.Trim();
                return detailItem;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo obtener el producto. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CleanItem(bool includeItem = false)
        {
            txtItemCod.Clear();
            txtItemDesc.Clear();
            txtItemPriceConImp.Clear();
            txtItemPriceSinImp.Clear();
            txtItemQuantity.Clear();
            if (includeItem) item = null;
        }

        private void CleanDetail(bool includeDetails = false)
        {
            SetCabeceraGridDetail();
            DefinirCabeceraGridDetail();
            if (includeDetails) details = null;
        }

        private bool BuscarItem()
        {
            string codProd = txtItemCod.Text.Trim();
            //Si está vació el txt -> abre el form
            if (codProd == "")
                return false;

            //De lo contrario hace la búsqueda del producto
            var list = new ProductoBL().BuscarProducto(codProd, "", "", Estado.IdActivo, Estado.Ignorar, Estado.IdActivo);
            //Si solo hay un producto con ese filtro
            if (list != null && list.Count() == 1)
            {
                foreach (var i in list)
                {
                    //Si el prouducto encontrado es distinto al prouducto ya cargado -> carga prod y no abre form
                    if (item == null || i.id_producto != item.id_producto)
                    {
                        CleanItem();
                        SetItem(i);
                        return true;
                    }
                }
                //Si el producto encontrado es el mismo que el que ya estaba cargado -> abre from
                return false;
            }
            //si no hay ningún producto con esa característica o hay más de uno -> abre form
            else
                return false;
        }

        private bool ValidAmount(string amount)
        {
            return decimal.TryParse(amount, out decimal _amount) &&
                    _amount > 0 &&
                    _amount <= KeyAmounts.MaxAmount;

        }

        private bool ValidAmountRange(decimal amount)
        {
            return amount > 0 &&
                    amount <= KeyAmounts.MaxAmount;

        }

        private bool ValidarItem()
        {
            errorProv.Clear();
            var valid = true;

            if (!(item != null && item.id_producto > 0))
            {
                valid = false;
                Msj.Ok_Info("No se ha seleccionado a ningún producto. Presione Enter y seleccione.");
                txtItemCod.Focus();
            }
            else
            {
                if (!ValidAmount(txtItemPriceSinImp.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(lblPrecioSinImp, ValidationMsj.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!ValidAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(lblPrecioConImp, ValidationMsj.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!ValidAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(lblCantidad, ValidationMsj.Amount);
                    txtItemQuantity.Focus();
                }
                if (txtItemDesc.Text.Trim() == "")
                {
                    valid = false;
                    errorProv.SetError(lblProducto, ValidationMsj.Required);
                    txtItemDesc.Focus();
                }
            }

            return valid;
        }

        private void AddItem()
        {
            if (ValidarItem())
            {
                var _item = GetItem();
                if (_item != null)
                {
                    if (details == null) details = new List<PROt16_combo_variable_dtl>();
                    try
                    {
                        var index = details.FindIndex(x => x.id_producto == _item.id_producto);
                        //Si el producto ya existe en el detalle -> edita item
                        if (index != -1)
                        {
                            var oldItem = details[index];
                            _item.cantidad += oldItem.cantidad;
                            details[index] = _item;
                            CargarGridProd(details);
                        }
                        //Si el producto no existe en el detalle -> agrega item
                        else if (details.Count < maxNumItems)
                        {
                            details.Add(_item);
                            CargarGridProd(details);
                        }
                        else
                            Msj.Ok_Info($"No puede agregar más items. Ha alcanzado el número máximo de items({maxNumItems}).", "Mensaje Eagle");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"No se pudo agregar el item. Excepción: {e.Message}", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        CleanItem(true);
                        errorProv.Clear();
                        txtItemCod.Focus();
                    }
                }
            }
        }

        private void RemoveItem()
        {
            int id = 0;
            try
            {
                //comprobante y obteniendo el id del producto
                if (details != null &&
                    dgvDetail.CurrentRow != null &&
                    dgvDetail.SelectedRows.Count > 0 &&
                    int.TryParse(dgvDetail.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    string item = dgvDetail.SelectedRows[0].Cells[1].Value != null ? dgvDetail.SelectedRows[0].Cells[1].Value.ToString() : "";

                    if (Msj.YesNo_Ques($"¿Está seguro eliminar el item '{item}'?") == DialogResult.Yes)
                    {
                        int index = details.FindIndex(x => x.id_producto == id);
                        if (index != -1)
                        {
                            details.RemoveAt(index);
                            if (details.Count == 0) details = null;
                            CargarGridProd(details);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Msj.Ok_Err($"No se pudo eliminar el item correctamente. Excepción: {e.Message}", "Excepción encontrada");
            }
            finally
            {
                dgvDetail.Focus();
            }

        }

        private void CargarGridProd(IEnumerable<PROt16_combo_variable_dtl> list)
        {
            if (list != null)
            {
                dgvDetail.DataSource = list.Select(x => new
                {
                    ID_PROD = x.id_producto,
                    PRODUCTO = x.PROt09_producto != null ? x.PROt09_producto.txt_desc : "NO SE PUEDE MOSTRAR",
                    CANTIDAD = x.cantidad.RoundOut(),
                    P_UNIT_C_TAX = x.mto_pvpu_con_tax.RoundOut(),
                    P_UNIT_S_TAX = x.mto_pvpu_sin_tax.RoundOut()
                }).ToList();

            }
            else
            {
                SetCabeceraGridDetail();
            }
            DefinirCabeceraGridDetail();
        }

        #region útiles

        private void SetCabeceraGridDetail()
        {
            var detailHeader = new List<PROt16_combo_variable_dtl>();
            dgvDetail.DataSource = detailHeader.Select(x => new
            {
                ID_PROD = "",
                PRODUCTO = "",
                CANTIDAD = "",
                P_UNIT_C_TAX = "",
                P_UNIT_S_TAX = ""
            }).ToList();
        }

        private void DefinirCabeceraGridDetail()
        {
            try
            {
                dgvDetail.Columns["ID_PROD"].Visible = false;

                dgvDetail.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["P_UNIT_C_TAX"].HeaderText = "P. UNIT. C/I";
                dgvDetail.Columns["P_UNIT_C_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["P_UNIT_C_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["P_UNIT_S_TAX"].HeaderText = "P. UNIT. S/I";
                dgvDetail.Columns["P_UNIT_S_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["P_UNIT_S_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["PRODUCTO"].Width = 230;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Combo Master

        private void addHandlers()
        {
            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            txtItemPriceConImp.KeyPress += ControlHelper.TxtValidDecimal;
            txtItemQuantity.KeyPress += ControlHelper.TxtValidInteger;

            var txts = new[] { txtNombre, txtCodigo, txtPrecioCboConTax, txtPrecioCboSinTax };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }

            var chks = new[] { chkActivo };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

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
            //invocado con el IDE (por repetición).
            isChangedRow = false;
        }

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (esValido())
                    {
                        var obj = new PROt15_combo_variable();
                        obj = GetObjeto();
                        int id = new ComboVariableBL().InsertarComboVariable(obj);
                        if (id > 0)
                            actualizar = true;
                        ControlarEventosABM(id);
                    }
                }
                else
                {
                    Actualizar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción en el commit:" + e.Message, "MENSAJE");
            }

        }
        private void Eliminar()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvComboVariable.RowCount > 0)
                {
                    if (dgvComboVariable.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdComboVariable.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.ComboVariable_ComboFixedDtl);
                                    if (validDelete)
                                    {
                                        new ComboVariableBL().EliminarComboVariable(id);
                                        actualizar = true;
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
                                MessageBox.Show(this, "El ID es incorrecto.", "MENSAJE");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(this, "Ocurrió una excepción en el intento de eliminación: " + e.Message, "MENSAJE");
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha seleccinado ningún registro.", "MENNSAJE");
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay registros", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private bool Actualizar()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (esValido())
                    {
                        Msj.Ok_Info("Pasó la validación. Listo para actualizar");
                        PROt15_combo_variable obj = new PROt15_combo_variable();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdComboVariable.Text, out id))
                        {
                            obj.id_combo_variable = id;
                            //new ComboVariableBL().ActualizarComboVariable(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_combo_variable);
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
        private bool ActualizarEnCheck()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (esValido())
                    {
                        Msj.Ok_Info("Pasó la validación. Listo para actualizar en check");
                        PROt15_combo_variable obj = new PROt15_combo_variable();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdComboVariable.Text, out id))
                        {
                            obj.id_combo_variable = id;
                            //new ComboVariableBL().ActualizarComboVariable(obj);
                            actualizar = true;
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar en Check: " + e.Message);
            }
            return isValid;
        }

        private PROt15_combo_variable GetObjeto()
        {
            PROt15_combo_variable obj = new PROt15_combo_variable();
            try
            {
                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_combo_variable = txtCodigo.Text.Trim();
                obj.mto_pvpu_con_tax = decimal.Parse(txtPrecioCboConTax.Text.Trim());
                obj.mto_pvpu_sin_tax = decimal.Parse(txtPrecioCboSinTax.Text.Trim());
                obj.PROt16_combo_variable_dtl = details;
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(PROt15_combo_variable obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdComboVariable.Text = obj.id_combo_variable.ToString();
                codSelected = obj.cod_combo_variable;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_combo_variable;
                txtPrecioCboConTax.Text = obj.mto_pvpu_con_tax.ToString();
                txtPrecioCboSinTax.Text = obj.mto_pvpu_sin_tax.ToString();
                CargarGridProd(obj.PROt16_combo_variable_dtl);

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }

        }

        private bool esValido()
        {
            bool no_error = true;
            errorProv.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabComboVariable.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (!ValidAmount(txtPrecioCboSinTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboSinTax, ValidationMsj.Amount);
                txtPrecioCboSinTax.Focus();
                no_error = false;
            }
            if (!ValidAmount(txtPrecioCboConTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboConTax, ValidationMsj.Amount);
                txtPrecioCboConTax.Focus();
                no_error = false;
            }

            #region Validación Details
            if (details == null || details.Count == 0)
            {
                errorProv.SetError(dgvDetail, "Se requiere al menos de un item.");
                txtItemCod.Focus();
                no_error = false;
            }
            else
            {
                var msjValid = "";
                var numActivos = 0;
                foreach (var item in details)
                {
                    if (!ValidAmountRange(item.cantidad))
                    {
                        no_error = false;
                        msjValid += $"- La cantidad del producto:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }
                    if (!ValidAmountRange(item.mto_pvpu_con_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta con impuesto del producto:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }

                    if (!ValidAmountRange(item.mto_pvpu_sin_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta sin impuesto del producto:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }
                    if (item.id_estado == Estado.IdActivo)
                    {
                        numActivos++;
                    }
                }
                if (numActivos == 0)
                {
                    no_error = false;
                    msjValid = "- Al menos un producto del combo debe estar activo.\n" + msjValid;
                }
                if (msjValid != "")
                {
                    Msj.Ok_Info(msjValid, "VALIDACIÓN DEL COMBO VARIABLE DETALLE");
                }
            }
            #endregion

            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var obj = new ComboVariableBL().ComboVariableXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (obj != null && obj.id_combo_variable > 0)
                        {
                            tabComboVariable.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && obj != null && obj.id_combo_variable > 0)
                        {
                            tabComboVariable.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            #endregion

            #region validación delete

            if (no_error && !chkActivo.Checked && TipoOperacion == TipoOperacionABM.Modificar)
            {
                int id = 0;
                if (int.TryParse(lblIdComboVariable.Text, out id))
                {
                    bool validDelete = false;
                    validDelete = new UtilBL().ValidarDelete(id, CodValDelete.ComboVariable_ComboFixedDtl);
                    if (!validDelete)
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabComboVariable.SelectedTab = tabPagGeneral;
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


            #endregion

            return no_error;
        }
        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvComboVariable.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvComboVariable.Rows.Count > 0)
                        {
                            dgvComboVariable.Rows[index].Selected = true;
                            dgvComboVariable.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvComboVariable.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvComboVariable.Rows.Count > 0)
                        {
                            dgvComboVariable.Rows[index].Selected = true;
                            dgvComboVariable.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el producto: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(int id)
        {
            //Deberá ser capaz de buscar de posicionarse  en ese producto
            //si es que existe para los datos actuales de grilla
            // en caso no exista sencillamente se posicionará 
            //por defecto en el 1er registro si lo hubiera.
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvComboVariable.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_combo_variable"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvComboVariable.Rows.Count > 0)
                    {
                        dgvComboVariable.Rows[index].Selected = true;
                        dgvComboVariable.FirstDisplayedScrollingRowIndex = index;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el producto por ID: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarRegistro()
        {
            isPending = false;
            if (dgvComboVariable.RowCount > 0 && dgvComboVariable.SelectedRows.Count > 0 && dgvComboVariable.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ComboVariableBL().ComboVariableXId(id);
                        if (obj != null)
                        {
                            //la primera vez no se ejecuta el evento enlazado.
                            isSelected = false;
                            SetObjeto(obj);
                            isChangedRow = true;
                            isSelected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string GetIdSelected()
        {
            string id = "-1";
            try
            {
                if (dgvComboVariable.SelectedRows.Count > 0 && dgvComboVariable.Rows.Count > 0)
                {
                    id = dgvComboVariable.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }


        //Métodos utilitarios de lógica del Form
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
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de Filtro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LimpiarForm()
        {
            isSelected = false;
            lblIdComboVariable.Text = 0 + "";
            codSelected = "";
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecioCboConTax.Clear();
            txtPrecioCboSinTax.Clear();
            CleanItem(true);
            CleanDetail(true);

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;
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
        private void ControlarEventosABM(int? id = null)
        {

            if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
                errorProv.Clear();
                //tabProducto.SelectedTab = tabPagGeneral;
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabComboVariable.SelectedTab = tabPagGeneral;
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

                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        tabComboVariable.SelectedTab = tabPagGeneral;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        //Después de hacer commit-eliminar
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
                            tabComboVariable.SelectedTab = tabPagGeneral;
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
                                tabComboVariable.SelectedTab = tabPagGeneral;
                                btnNuevo.Focus();
                            }
                            else
                            {
                                //ver lo del error provider
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

                                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                                        tabComboVariable.SelectedTab = tabPagGeneral;

                                        if (id != null)
                                        {
                                            int idAct = (int)id;
                                            SeleccionarPorId(idAct);
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
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new ComboVariableBL().ListaComboVariable(id_estado);
                var listaView = lista.Select(x => new { x.id_combo_variable, CODIGO = x.cod_combo_variable, NOMBRE = x.txt_desc })
                .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvComboVariable.DataSource = listaView;
                    dgvComboVariable.Columns["id_combo_variable"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}");

            }
        }
        private void ActualizarGrilla(int? id_estado = null)
        {
            CargarGrilla(id_estado);
        }
        private void ConfigurarGrilla()
        {
            dgvComboVariable.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvComboVariable.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvComboVariable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvComboVariable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvComboVariable.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvComboVariable.EnableHeadersVisualStyles = false;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 250;

        }
        private void ContarEstados(List<PROt15_combo_variable> lista)
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

            #region Controls
            lblIdComboVariable.Visible = false;
            txtItemDesc.ReadOnly = true;
            txtItemPriceConImp.ReadOnly = true;
            txtItemPriceSinImp.ReadOnly = true;
            txtItemQuantity.TextAlign = HorizontalAlignment.Right;
            txtPrecioCboConTax.TextAlign = HorizontalAlignment.Right;
            txtPrecioCboSinTax.TextAlign = HorizontalAlignment.Right;

            #region Dgv
            var detailHeader = new List<PROt15_combo_variable>();
            dgvDetail.DataSource = detailHeader.Select(x => new
            {
                ID_PROD = "",
                PRODUCTO = "",
                CANTIDAD = "",
                P_UNIT_C_TAX = "",
                P_UNIT_S_TAX = ""
            }).ToList();
            DefinirCabeceraGridDetail();
            ControlHelper.DgvReadOnly(dgvDetail);
            ControlHelper.DgvLightStyle(dgvDetail);
            #endregion

            #endregion

            SetMaxLengthTxt();
            ControlarEventosABM();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            addHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
        }
        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }
        #endregion

        #endregion

        #region Eventos de ventana

        private void FormComboVariable_Load(object sender, EventArgs e)
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
            Eliminar();
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
            Commit();
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Rollback;
            ControlarEventosABM();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (item == null) Msj.Ok_Info("Item Es nulo");
            else Msj.Ok_Info("Item No es nulo " + item.txt_desc);

            if (details == null) Msj.Ok_Info("Details Es nulo");
            else Msj.Ok_Info("Details No es nulo ");
            if (panelFiltro.Visible)
            {
                panelFiltro.Visible = false;
            }
            else
            {
                panelFiltro.Visible = true;
            }
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

        private void dgvComboVariable_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdComboVariable.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
                                SeleccionarPorId(int.Parse(idSelect));
                            }
                        }
                        else
                        {
                            Actualizar();
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
                    if (idSelect != lblIdComboVariable.Text && idSelect != "-1")
                    {
                        isValid = Actualizar();
                        if (isValid)
                        {
                            SeleccionarPorId(int.Parse(idSelect));
                        }
                    }
                    else
                    {
                        Actualizar();
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
                        isValid = ActualizarEnCheck();
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
                    isValid = ActualizarEnCheck();
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
                        isValid = Actualizar();
                        if (isValid)
                        {
                            isPending = false;
                            CerrarForm();
                        }

                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        CerrarForm();
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = Actualizar();
                    if (isValid)
                    {
                        isPending = false;
                        CerrarForm();
                    }
                }
            }
            else
            {
                CerrarForm();
            }
        }

        private void txtItemCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                if (!BuscarItem())
                {
                    var form = new FormBuscarProducto();
                    form.ShowDialog();
                    if (form.producto != null)
                    {
                        CleanItem();
                        SetItem(form.producto);
                    }
                }
            }
        }
        #endregion

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                AddItem();
            }
        }

        private void txtItemDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                if (!BuscarItem())
                {
                    var form = new FormBuscarProducto();
                    form.ShowDialog();
                    if (form.producto != null)
                    {
                        CleanItem();
                        SetItem(form.producto);
                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveItem();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }
    }
}