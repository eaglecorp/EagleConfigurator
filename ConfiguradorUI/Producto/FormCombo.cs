using MetroFramework.Forms;
using System;
using ConfigBusinessEntity;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigBusinessLogic;
using ConfigUtilitarios.KeyValues;
using ConfigBusinessLogic.Producto;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfiguradorUI.Producto.Auxiliares;
using ConfiguradorUI.Buscadores;

namespace ConfiguradorUI.Producto
{
    public partial class FormCombo : MetroForm
    {

        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        public bool actualizar = false;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        enum Detail { Producto, ComboVariable }
        Detail DetailView = Detail.Producto;

        string codSelected = "";

        PROt09_producto product = null;
        PROt15_combo_variable cboVar = null;
        List<PROt14_combo_fixed_dtl> details = null;
        int maxNumItems = 6;

        enum DeleteDtlAction { Remove, ActiveDesactive };
        #endregion

        public FormCombo()
        {
            InitializeComponent();
        }

        #region Métodos de ventana
        #region Métodos Details

        private void SetItem(PROt09_producto producto)
        {
            try
            {
                product = new PROt09_producto();
                product = producto;
                txtItemCod.Text = producto.cod_producto;
                txtItemDesc.Text = producto.txt_desc;
                txtItemPriceConImp.Text = producto.mto_pvpu_con_igv?.ToString();
                txtItemPriceSinImp.Text = producto.mto_pvpu_sin_igv?.ToString();
                txtItemQuantity.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar el producto. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetItem(PROt15_combo_variable obj)
        {
            try
            {
                cboVar = new PROt15_combo_variable();
                cboVar = obj;
                txtItemCod.Text = obj.cod_combo_variable;
                txtItemDesc.Text = obj.txt_desc;
                txtItemPriceConImp.Text = obj.mto_pvpu_con_tax.ToString();
                txtItemPriceSinImp.Text = obj.mto_pvpu_sin_tax.ToString();
                txtItemQuantity.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar el combo variable. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PROt14_combo_fixed_dtl GetItem()
        {
            try
            {
                var detailItem = new PROt14_combo_fixed_dtl();
                detailItem.PROt09_producto = new PROt09_producto();

                detailItem.id_producto = product.id_producto;
                detailItem.cod_combo_fixed_dtl = txtItemCod.Text.Trim();
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
            if (includeItem)
            {
                product = null;
                cboVar = null;
            }
        }

        private void CleanDetail(bool includeDetails = false)
        {
            SetCabeceraGridDetailProduct();
            DefinirCabeceraGridDetailProduct();

            SetCabeceraGridDetailCboVariable();
            DefinirCabeceraGridDetailCboVariable();

            if (includeDetails) details = null;
        }

        private bool EditItem(PROt14_combo_fixed_dtl item, bool accumulateQuantity = false)
        {
            try
            {
                var index = details.FindIndex(x => x.id_producto == item.id_producto);
                if (index != -1)
                {
                    var oldItem = details[index];
                    //Actualizamos los valores
                    oldItem.cod_combo_fixed_dtl = item.cod_combo_fixed_dtl;

                    if (accumulateQuantity) oldItem.cantidad += item.cantidad;
                    else oldItem.cantidad = item.cantidad;

                    oldItem.mto_pvpu_con_tax = item.mto_pvpu_con_tax;
                    oldItem.mto_pvpu_sin_tax = item.mto_pvpu_sin_tax;
                    oldItem.id_estado = item.id_estado;
                    oldItem.txt_estado = item.txt_estado;
                    details[index] = oldItem;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void AddItem()
        {
            if (ValidItem())
            {
                var itemObtained = GetItem();
                if (itemObtained != null)
                {
                    if (details == null) details = new List<PROt14_combo_fixed_dtl>();
                    try
                    {
                        if (EditItem(itemObtained, true))
                        {
                            CargarGridProd(details);
                        }
                        //Si el producto no existe en el detalle -> agrega item
                        else if (details.Count < maxNumItems)
                        {
                            long idMaster = 0;
                            //Si no se trata de inserción se asumo que 
                            //que es una modificación y se trata de ingresar un item
                            //en un master ya creado. Por tanto se debe traer su id.
                            if (TipoOperacion != TipoOperacionABM.Nuevo)
                            {
                                long.TryParse(lblIdCombo.Text, out idMaster);
                            }
                            itemObtained.id_combo = idMaster;
                            details.Add(itemObtained);
                            CargarGridProd(details);
                        }
                        else
                            Msg.Ok_Info($"No puede agregar más items. Ha alcanzado el número máximo de items({maxNumItems}).", "Mensaje Eagle");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"No se pudo agregar el item. Excepción: {e.Message}", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        CleanItem(true);
                        errorProvDtl.Clear();
                        txtItemCod.Focus();

                    }
                }
            }
        }

        private void RemoveItem(DeleteDtlAction actionDeleteDtl)
        {
            try
            {
                //Item1 : item selected
                //Item2 : index

                var itemSelected_index = GetItemSelected();
                if (details != null && itemSelected_index.Item1 != null)
                {
                    var oldItem = itemSelected_index.Item1;
                    var itemDesc = oldItem.PROt09_producto?.txt_desc;

                    if (actionDeleteDtl == DeleteDtlAction.Remove)
                    {
                        if (oldItem.id_combo_fixed_dtl <= 0)
                        {
                            if (Msg.YesNo_Ques($"¿Está seguro de QUITAR el item '{itemDesc}'?") == DialogResult.Yes)
                            {
                                details.RemoveAt(itemSelected_index.Item2);
                                isChangedRow = false;
                                if (details.Count == 0) details = null;
                                CargarGridProd(details);
                            }
                        }
                        else
                        {
                            Msg.Ok_Info($"No puede QUITAR un item que ha guardado. Puede activar/desactivar según sea el caso.");
                        }
                    }
                    else if ((actionDeleteDtl == DeleteDtlAction.ActiveDesactive))
                    {
                        //Para activar
                        if (oldItem.id_estado != Estado.IdActivo)
                        {
                            if (Msg.YesNo_Ques($"¿Está seguro de ACTIVAR el item '{itemDesc}'?") == DialogResult.Yes)
                            {
                                oldItem.id_estado = Estado.IdActivo;
                                oldItem.txt_estado = Estado.TxtActivo;
                                details[itemSelected_index.Item2] = oldItem;
                                CargarGridProd(details);
                            }
                        }
                        //Para desactivar
                        else
                        {
                            if (Msg.YesNo_Ques($"¿Está seguro de DESACTIVAR el item '{itemDesc}'?") == DialogResult.Yes)
                            {
                                oldItem.id_estado = Estado.IdInactivo;
                                oldItem.txt_estado = Estado.TxtInactivo;
                                details[itemSelected_index.Item2] = oldItem;
                                CargarGridProd(details);
                            }
                        }
                    }
                }
                else
                    Msg.Ok_Info($"No hay ningún item .");
            }
            catch (Exception e)
            {
                Msg.Ok_Err($"No se pudo eliminar el item correctamente. Excepción: {e.Message}", "Excepción encontrada");
            }
            finally
            {
                dgvDetailProduct.Focus();
            }
        }
        private void SearchAndSetItem()
        {
            if (!BuscarItem())
            {
                if (DetailView == Detail.Producto)
                {
                    var form = new FormBuscarProducto();
                    form.ShowDialog();
                    if (form.producto != null)
                    {
                        CleanItem(true);
                        errorProvDtl.Clear();
                        SetItem(form.producto);
                    }
                }
                else if (DetailView == Detail.ComboVariable)
                {
                    var form = new FormBuscarComboVariable();
                    form.ShowDialog();
                    if (form.cboVariable != null)
                    {
                        CleanItem(true);
                        errorProvDtl.Clear();
                        SetItem(form.cboVariable);
                    }
                }

            }
        }
        private Tuple<PROt14_combo_fixed_dtl, int> GetItemSelected()
        {
            if (long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvDetailProduct, 0), out long id))
            {
                int index = details.FindIndex(x => x.id_producto == id);
                if (index != -1 && details[index] != null)
                {
                    return new Tuple<PROt14_combo_fixed_dtl, int>(details[index], index);
                }
            }
            return new Tuple<PROt14_combo_fixed_dtl, int>(null, -1);
        }
        private bool BuscarItem()
        {
            string cod = txtItemCod.Text.Trim();
            //Si está vació el txt -> abre el form
            if (cod == "")
                return false;

            //De lo contrario hace la búsqueda del producto

            if (DetailView == Detail.Producto)
            {
                var list = new ProductoBL().BuscarProducto(cod, "", "", Estado.IdActivo, Estado.Ignorar, Estado.IdActivo);
                //Si solo hay un producto con ese filtro
                if (list != null && list.Count() == 1)
                {
                    foreach (var i in list)
                    {
                        //Si el prouducto encontrado es distinto al prouducto ya cargado -> carga prod y no abre form
                        if (product == null || i.id_producto != product.id_producto)
                        {
                            CleanItem();
                            errorProvDtl.Clear();
                            SetItem(i);
                            return true;
                        }
                    }
                    //Si el producto encontrado es el mismo que el que ya estaba cargado -> abre from
                    return false;
                }
                else return false;
            }
            else if (DetailView == Detail.ComboVariable)
            {
                var list = new ComboVariableBL().BuscarComboVariable(cod, "", Estado.IdActivo);
                if (list != null && list.Count() == 1)
                {
                    foreach (var i in list)
                    {
                        if (cboVar == null || i.id_combo_variable != cboVar.id_combo_variable)
                        {
                            CleanItem();
                            errorProvDtl.Clear();
                            SetItem(i);
                            return true;
                        }
                    }
                    return false;
                }
                else return false;
            }
            else return false;
        }
        private bool ValidItem()
        {
            errorProvDtl.Clear();
            var valid = true;

            if (!(product != null && product.id_producto > 0))
            {
                valid = false;
                Msg.Ok_Info("No se ha seleccionado a ningún producto. Presione Enter y seleccione.");
                txtItemCod.Focus();
            }
            else
            {
                if (!Validation.PositiveAmount(txtItemPriceSinImp.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblPrecioSinImp, ValidationMsj.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblPrecioConImp, ValidationMsj.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblCantidad, ValidationMsj.Amount);
                    txtItemQuantity.Focus();
                }
                if (txtItemDesc.Text.Trim() == "")
                {
                    valid = false;
                    errorProvDtl.SetError(lblProducto, ValidationMsj.Required);
                    txtItemDesc.Focus();
                }
            }

            return valid;
        }

        private void CargarGridProd(IEnumerable<PROt14_combo_fixed_dtl> list)
        {
            if (list != null)
            {
                dgvDetailProduct.DataSource = list.Select(x => new
                {
                    ID_PROD = x.id_producto,
                    PRODUCTO = x.PROt09_producto != null ? x.PROt09_producto.txt_desc : "NO SE PUEDE MOSTRAR",
                    CANTIDAD = x.cantidad.RemoveTrailingZeros(),
                    P_UNIT_C_TAX = x.mto_pvpu_con_tax.RemoveTrailingZeros(),
                    P_UNIT_S_TAX = x.mto_pvpu_sin_tax.RemoveTrailingZeros(),
                    ACTIVO = x.id_estado == Estado.IdActivo ? true : false
                }).ToList();

            }
            else
            {
                SetCabeceraGridDetailProduct();
            }
            DefinirCabeceraGridDetailProduct();
        }

        #region Métodos para eventos

        private void SearchAndSetItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                SearchAndSetItem();
            }
        }

        #endregion

        #region útiles

        private void SetCabeceraGridDetailCboVariable()
        {
            var detailHeader = new List<PROt14_combo_fixed_dtl>();
            dgvDetailCboVariable.DataSource = detailHeader.Select(x => new
            {
                ID_CBO_VAR = "",
                DESC = "",
                CANTIDAD = "",
                P_UNIT_C_TAX = "",
                P_UNIT_S_TAX = "",
                ACTIVO = true
            }).ToList();
        }

        private void DefinirCabeceraGridDetailCboVariable()
        {
            try
            {
                //PROt14_combo_fixed_dtl s = new PROt14_combo_fixed_dtl();
                //PROt15_combo_variable d = new PROt15_combo_variable();
                //s.id_combo_variable


                dgvDetailCboVariable.Columns["ID_CBO_VAR"].Visible = false;
                dgvDetailCboVariable.Columns["P_UNIT_S_TAX"].Visible = false;

                dgvDetailCboVariable.Columns["DESC"].HeaderText = "CBO. ELECTIVO";

                dgvDetailCboVariable.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailCboVariable.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailCboVariable.Columns["P_UNIT_C_TAX"].HeaderText = "P. UNIT. C/I";
                dgvDetailCboVariable.Columns["P_UNIT_C_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailCboVariable.Columns["P_UNIT_C_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailCboVariable.Columns["P_UNIT_S_TAX"].HeaderText = "P. UNIT. S/I";
                dgvDetailCboVariable.Columns["P_UNIT_S_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailCboVariable.Columns["P_UNIT_S_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailCboVariable.Columns["ACTIVO"].Width = 55;
                dgvDetailCboVariable.Columns["CANTIDAD"].Width = 80;
                dgvDetailCboVariable.Columns["DESC"].Width = 120;
                dgvDetailCboVariable.Columns["P_UNIT_C_TAX"].Width = 90;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCabeceraGridDetailProduct()
        {
            var detailHeader = new List<PROt14_combo_fixed_dtl>();
            dgvDetailProduct.DataSource = detailHeader.Select(x => new
            {
                ID_PROD = "",
                PRODUCTO = "",
                CANTIDAD = "",
                P_UNIT_C_TAX = "",
                P_UNIT_S_TAX = "",
                ACTIVO = true
            }).ToList();
        }

        private void DefinirCabeceraGridDetailProduct()
        {
            try
            {
                dgvDetailProduct.Columns["ID_PROD"].Visible = false;

                dgvDetailProduct.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailProduct.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailProduct.Columns["P_UNIT_C_TAX"].HeaderText = "P. UNIT. C/I";
                dgvDetailProduct.Columns["P_UNIT_C_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailProduct.Columns["P_UNIT_C_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailProduct.Columns["P_UNIT_S_TAX"].HeaderText = "P. UNIT. S/I";
                dgvDetailProduct.Columns["P_UNIT_S_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailProduct.Columns["P_UNIT_S_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetailProduct.Columns["PRODUCTO"].Width = 195;
                dgvDetailProduct.Columns["P_UNIT_C_TAX"].Width = 95;
                dgvDetailProduct.Columns["P_UNIT_S_TAX"].Width = 95;
                dgvDetailProduct.Columns["CANTIDAD"].Width = 80;
                dgvDetailProduct.Columns["ACTIVO"].Width = 55;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Métodos Master

        private void addHandlers()
        {
            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            txtItemPriceConImp.KeyPress += ControlHelper.TxtValidDecimal;
            txtItemQuantity.KeyPress += ControlHelper.TxtValidInteger;
            txtItemCod.KeyPress += SearchAndSetItem_KeyPress;
            txtItemDesc.KeyPress += SearchAndSetItem_KeyPress;

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

            dgvDetailProduct.DataSourceChanged += new EventHandler(OnContentChanged);

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
                        var obj = new PROt13_combo();
                        obj = GetObjeto();
                        long id = new ComboBL().InsertarCombo(obj);
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
                if (dgvCombo.RowCount > 0)
                {
                    if (dgvCombo.SelectedRows.Count > 0)
                    {
                        try
                        {
                            long id = 0;
                            if (long.TryParse(lblIdCombo.Text, out id) && id > 0)
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
                        PROt13_combo obj = new PROt13_combo();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdCombo.Text, out id))
                        {
                            obj.id_combo = id;
                            new ComboBL().ActualizarCombo(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_combo);
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
                        PROt13_combo obj = new PROt13_combo();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdCombo.Text, out id))
                        {
                            obj.id_combo = id;
                            new ComboBL().ActualizarCombo(obj);
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

        private PROt13_combo GetObjeto()
        {
            PROt13_combo obj = new PROt13_combo();
            try
            {
                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_combo = txtCodigo.Text.Trim();
                obj.mto_pvpu_con_tax = decimal.Parse(txtPrecioCboConTax.Text.Trim());
                obj.mto_pvpu_sin_tax = decimal.Parse(txtPrecioCboSinTax.Text.Trim());
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                //IMPORTANTE
                /*
                 Colocar null al producto y cbo variable de cada detalle. De los contrario EF al
                 momento de grabar insertería también estos productos.
                 */
                if (details != null)
                {
                    details.ForEach(x => x.PROt09_producto = null);
                    details.ForEach(x => x.PROt15_combo_variable = null);
                }
                obj.PROt14_combo_fixed_dtl = details;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(PROt13_combo obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdCombo.Text = obj.id_combo.ToString();
                codSelected = obj.cod_combo;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_combo;
                txtPrecioCboConTax.Text = obj.mto_pvpu_con_tax.RemoveTrailingZeros();
                txtPrecioCboSinTax.Text = obj.mto_pvpu_sin_tax.RemoveTrailingZeros();
                details = obj.PROt14_combo_fixed_dtl?.ToList();
                CargarGridProd(obj.PROt14_combo_fixed_dtl);

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
            errorProvDtl.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabCombo.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (!Validation.PositiveAmount(txtPrecioCboSinTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboSinTax, ValidationMsj.Amount);
                txtPrecioCboSinTax.Focus();
                no_error = false;
            }
            if (!Validation.PositiveAmount(txtPrecioCboConTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboConTax, ValidationMsj.Amount);
                txtPrecioCboConTax.Focus();
                no_error = false;
            }

            #region Validación Details
            if (details == null || details.Count == 0)
            {
                errorProvDtl.SetError(dgvDetailProduct, "Se requiere al menos de un item.");
                txtItemCod.Focus();
                no_error = false;
            }
            else
            {
                var msjValid = "";
                var numActivos = 0;
                foreach (var item in details)
                {
                    if (!Validation.PositiveAmount((decimal)item.cantidad))
                    {
                        no_error = false;
                        msjValid += $"- La cantidad de:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }
                    if (!Validation.PositiveAmount(item.mto_pvpu_con_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta con impuesto de:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }

                    if (!Validation.PositiveAmount(item.mto_pvpu_sin_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta sin impuesto de:'{item.PROt09_producto.txt_desc}' " +
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
                    Msg.Ok_Info(msjValid, "VALIDACIÓN DEL COMBO VARIABLE DETALLE");
                }
            }
            #endregion

            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var obj = new ComboBL().ComboXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (obj != null && obj.id_combo > 0)
                        {
                            tabCombo.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && obj != null && obj.id_combo > 0)
                        {
                            tabCombo.SelectedTab = tabPagGeneral;
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
                long id = 0;
                if (long.TryParse(lblIdCombo.Text, out id))
                {
                    bool validDelete = false;
                    validDelete = new UtilBL().ValidarDelete(id, CodValDelete.ComboVariable_ComboFixedDtl);
                    if (!validDelete)
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabCombo.SelectedTab = tabPagGeneral;
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
                    DataGridViewRow row = dgvCombo.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvCombo.Rows.Count > 0)
                        {
                            dgvCombo.Rows[index].Selected = true;
                            dgvCombo.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvCombo.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvCombo.Rows.Count > 0)
                        {
                            dgvCombo.Rows[index].Selected = true;
                            dgvCombo.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el producto: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(long id)
        {
            //Deberá ser capaz de buscar de posicionarse  en ese producto
            //si es que existe para los datos actuales de grilla
            // en caso no exista sencillamente se posicionará 
            //por defecto en el 1er registro si lo hubiera.
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvCombo.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_combo"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvCombo.Rows.Count > 0)
                    {
                        dgvCombo.Rows[index].Selected = true;
                        dgvCombo.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvCombo.RowCount > 0 &&
                dgvCombo.SelectedRows.Count > 0)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ComboBL().ComboXId(id);
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
                if (dgvCombo.SelectedRows.Count > 0 && dgvCombo.Rows.Count > 0)
                {
                    id = dgvCombo.SelectedRows[0].Cells[0].Value.ToString();
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
            lblIdCombo.Text = 0 + "";
            codSelected = "";
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecioCboConTax.Clear();
            txtPrecioCboSinTax.Clear();
            errorProvDtl.Clear();
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
        private void ControlarEventosABM(long? id = null)
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
                    tabCombo.SelectedTab = tabPagGeneral;
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
                        SeleccionarPorId(idInsertado);
                        tabCombo.SelectedTab = tabPagGeneral;
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
                            tabCombo.SelectedTab = tabPagGeneral;
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
                                tabCombo.SelectedTab = tabPagGeneral;
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

                                        tabCombo.SelectedTab = tabPagGeneral;

                                        if (id != null)
                                        {
                                            long idAct = (long)id;
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
                var lista = new ComboBL().ListaCombo(id_estado);
                var listaView = lista.Select(x => new { x.id_combo, CODIGO = x.cod_combo, NOMBRE = x.txt_desc })
                .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvCombo.DataSource = listaView;
                    dgvCombo.Columns["id_combo"].Visible = false;
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
            dgvCombo.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvCombo.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvCombo.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvCombo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvCombo.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvCombo.EnableHeadersVisualStyles = false;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtItemCod.MaxLength = 50;
            txtNombre.MaxLength = 250;
        }
        private void ContarEstados(List<PROt13_combo> lista)
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
        private void CheckChangeTab()
        {
            if (tabDetails.SelectedTab == tabDetails.TabPages["tabPagProductos"])
            {
                DetailView = Detail.Producto;
            }
            else if (tabDetails.SelectedTab == tabDetails.TabPages["tabPagCboElectivo"])
            {
                DetailView = Detail.ComboVariable;
            }
            txtCodigo.Focus();
        }
        private void SetInit()
        {

            #region Controls
            lblIdCombo.Visible = false;
            txtItemDesc.ReadOnly = true;
            txtItemPriceConImp.ReadOnly = true;
            txtItemPriceSinImp.ReadOnly = true;
            txtItemQuantity.TextAlign = HorizontalAlignment.Right;
            txtPrecioCboConTax.TextAlign = HorizontalAlignment.Right;
            txtPrecioCboSinTax.TextAlign = HorizontalAlignment.Right;

            #region Dgv
            SetCabeceraGridDetailProduct();
            DefinirCabeceraGridDetailProduct();
            ControlHelper.DgvReadOnly(dgvDetailProduct);
            ControlHelper.DgvLightStyle(dgvDetailProduct);

            SetCabeceraGridDetailCboVariable();
            DefinirCabeceraGridDetailCboVariable();
            ControlHelper.DgvReadOnly(dgvDetailCboVariable);
            ControlHelper.DgvLightStyle(dgvDetailCboVariable);

            #endregion

            #endregion

            SetMaxLengthTxt();
            CheckChangeTab();
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

        private void FormCombo_Load(object sender, EventArgs e)
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

        private void dgvCombo_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdCombo.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
                                SeleccionarPorId(long.Parse(idSelect));
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
                    if (idSelect != lblIdCombo.Text && idSelect != "-1")
                    {
                        isValid = Actualizar();
                        if (isValid)
                        {
                            SeleccionarPorId(long.Parse(idSelect));
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

        #region Eventos del Dtl

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                AddItem();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItem(DeleteDtlAction.Remove);
        }

        //PARA FINES DE TEST
        private void button1_Click(object sender, EventArgs e)
        {

            if (product == null) Msg.Ok_Info("Producto es nulo");
            else Msg.Ok_Info("Producto No es nulo " + product.txt_desc);

            if (cboVar == null) Msg.Ok_Info("Cbo. variable es nulo");
            else Msg.Ok_Info("Cbo. Variable No es nulo " + product.txt_desc);

            if (details == null) Msg.Ok_Info("Details Es nulo");
            else Msg.Ok_Info("Details No es nulo ");




            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                Msg.Ok_Info("EN CONTEXTO DE INSETAR");
            }
            else if (TipoOperacion == TipoOperacionABM.Cambio)
            {
                Msg.Ok_Info("EN CONTEXTO DE MODIFICAR");
            }
            else Msg.Ok_Info("EN CONTEXTO DE NO MODIFICAR NI INSETAR");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var form = new FormProducto();
            form.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SearchAndSetItem();
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null && dgv.CurrentCell != null &&
                dgv.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                RemoveItem(DeleteDtlAction.ActiveDesactive);
            }
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var itemSelected = GetItemSelected();
            if (itemSelected.Item1 != null)
            {
                var form = new FormComboItem(itemSelected.Item1);
                form.ShowDialog();
                if (form._itemEdited && form._itemFix != null)
                {
                    if (EditItem(form._itemFix))
                        CargarGridProd(details);
                    else
                        Msg.Ok_Wng("No se pudo editar el item.");
                }
            }
        }
        #endregion

        #endregion

        private void btnComboGrupo_Click(object sender, EventArgs e)
        {

        }

        private void tabDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChangeTab();
        }
    }
}

