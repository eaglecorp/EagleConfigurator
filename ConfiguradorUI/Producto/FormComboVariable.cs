using MetroFramework.Forms;
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
using ConfiguradorUI.Producto.Auxiliares;
using ConfiguradorUI.Maestro;

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
        int maxNumItems = 10;

        enum DeleteDtlAction { Remove, ActiveDesactive };
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
                txtItemPriceConImp.Text = producto.mto_pvpu_con_igv?.RemoveTrailingZeros();
                txtItemPriceSinImp.Text = producto.mto_pvpu_sin_igv?.RemoveTrailingZeros();
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
                detailItem.cod_combo_variable_dtl = txtItemCod.Text.Trim();
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

        private bool EditItem(PROt16_combo_variable_dtl item, bool accumulateQuantity = false)
        {
            try
            {
                var index = details.FindIndex(x => x.id_producto == item.id_producto);
                if (index != -1)
                {
                    var oldItem = details[index];
                    //Actualizamos los valores
                    oldItem.cod_combo_variable_dtl = item.cod_combo_variable_dtl;

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
                    if (details == null) details = new List<PROt16_combo_variable_dtl>();
                    try
                    {
                        if (EditItem(itemObtained, true))
                        {
                            CargarGridProd(details, chkMostrarInactivos.Checked);
                        }
                        //Si el producto no existe en el detalle -> agrega item
                        else if (details.Count < maxNumItems)
                        {
                            long idMaster = 0;
                            if (TipoOperacion != TipoOperacionABM.Nuevo)
                            {
                                long.TryParse(lblIdComboVariable.Text, out idMaster);
                            }
                            itemObtained.id_combo_variable = idMaster;
                            details.Add(itemObtained);
                            CargarGridProd(details, chkMostrarInactivos.Checked);
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
                        if (oldItem.id_combo_variable_dtl <= 0)
                        {
                            if (Msg.YesNo_Ques($"¿Está seguro de QUITAR el item '{itemDesc}'?") == DialogResult.Yes)
                            {
                                details.RemoveAt(itemSelected_index.Item2);
                                isChangedRow = false;
                                if (details.Count == 0) details = null;
                                CargarGridProd(details, chkMostrarInactivos.Checked);
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
                                CargarGridProd(details, chkMostrarInactivos.Checked);
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
                                CargarGridProd(details, chkMostrarInactivos.Checked);
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
                dgvDetail.Focus();
            }
        }
        private void SearchAndSetItem()
        {
            if (!BuscarItem())
            {
                var form = new FormBuscarProducto();
                form.ShowDialog();
                if (form.producto != null)
                {
                    CleanItem();
                    errorProvDtl.Clear();
                    SetItem(form.producto);
                }
            }
        }
        private Tuple<PROt16_combo_variable_dtl, int> GetItemSelected()
        {
            if (long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvDetail, 0), out long id))
            {
                int index = details.FindIndex(x => x.id_producto == id);
                if (index != -1 && details[index] != null)
                {
                    return new Tuple<PROt16_combo_variable_dtl, int>(details[index], index);
                }
            }
            return new Tuple<PROt16_combo_variable_dtl, int>(null, -1);
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
                        errorProvDtl.Clear();
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
        private bool ValidItem()
        {
            errorProvDtl.Clear();
            var valid = true;

            if (!(item != null && item.id_producto > 0))
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
                    errorProvDtl.SetError(txtItemPriceSinImp, ValidationMsg.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(txtItemPriceConImp, ValidationMsg.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(txtItemQuantity, ValidationMsg.Amount);
                    txtItemQuantity.Focus();
                }
                if (txtItemDesc.Text.Trim() == "")
                {
                    valid = false;
                    errorProvDtl.SetError(txtItemDesc, ValidationMsg.Required);
                    txtItemDesc.Focus();
                }
            }

            return valid;
        }

        private void CargarGridProd(IEnumerable<PROt16_combo_variable_dtl> list, bool showInactive = false)
        {
            if (list != null)
            {
                var finalList = showInactive ? list : list.Where(x => x.id_estado == Estado.IdActivo);

                dgvDetail.DataSource = finalList.Select(x => new
                {
                    ID_PROD = x.id_producto,
                    PRODUCTO = x.PROt09_producto != null ? x.PROt09_producto.txt_desc : "NO SE PUEDE MOSTRAR",
                    CANTIDAD = x.cantidad.RemoveTrailingZeros(),
                    P_UNIT_C_TAX = x.mto_pvpu_con_tax.RemoveTrailingZeros(),
                    P_UNIT_S_TAX = x.mto_pvpu_sin_tax.RemoveTrailingZeros(),
                    ACTIVO = x.id_estado == Estado.IdActivo ? true : false
                }).OrderBy(x => x.PRODUCTO).ThenByDescending(x => x.P_UNIT_C_TAX).ToList();

            }
            else
            {
                SetCabeceraGridDetail();
            }
            DefinirCabeceraGridDetail();
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

        private void SetCabeceraGridDetail()
        {
            var detailHeader = new List<PROt16_combo_variable_dtl>();
            dgvDetail.DataSource = detailHeader.Select(x => new
            {
                ID_PROD = "",
                PRODUCTO = "",
                CANTIDAD = "",
                P_UNIT_C_TAX = "",
                P_UNIT_S_TAX = "",
                ACTIVO = true
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

                dgvDetail.Columns["PRODUCTO"].Width = 200;
                dgvDetail.Columns["CANTIDAD"].Width = 70;
                dgvDetail.Columns["P_UNIT_C_TAX"].Width = 97;
                dgvDetail.Columns["P_UNIT_S_TAX"].Width = 97;
                dgvDetail.Columns["ACTIVO"].Width = 54;

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

            txtPrecioCboSinTax.KeyPress += ControlHelper.TxtValidDecimal;
            txtPrecioCboConTax.KeyPress += ControlHelper.TxtValidDecimal;

            txtItemCod.KeyPress += SearchAndSetItem_KeyPress;
            txtItemDesc.KeyPress += SearchAndSetItem_KeyPress;

            var txts = new[] { txtNombre, txtCodigo, txtPrecioCboConTax, txtPrecioCboSinTax };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }

            var chks = new[] { chkActivo, chkIncluyeImpto };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            cboImpuesto.SelectedIndexChanged += new EventHandler(OnContentChanged);
            dgvDetail.DataSourceChanged += new EventHandler(OnContentChanged);

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
                        long id = new ComboVariableBL().InsertarComboVariable(obj);
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
                            long id = 0;
                            if (long.TryParse(lblIdComboVariable.Text, out id) && id > 0)
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
                        PROt15_combo_variable obj = new PROt15_combo_variable();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdComboVariable.Text, out id))
                        {
                            obj.id_combo_variable = id;
                            bool success = new ComboVariableBL().ActualizarComboVariable(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_combo_variable);
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el combo electivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool ActualizarEnCheck()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (esValido())
                    {
                        PROt15_combo_variable obj = new PROt15_combo_variable();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdComboVariable.Text, out id))
                        {
                            obj.id_combo_variable = id;
                            bool success = new ComboVariableBL().ActualizarComboVariable(obj);
                            actualizar = true;
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el combo electivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                obj.sn_incluye_impto = chkIncluyeImpto.Checked ? Estado.IdActivo : Estado.IdInactivo;
                //IMPORTANTE
                /*
                 Colocar null al producto de cada detalle. De los contrario EF al
                 momento de grabar insertería también estos productos.
                 */
                if (details != null)
                    details.ForEach(x => x.PROt09_producto = null);
                obj.PROt16_combo_variable_dtl = details;


                if (cboImpuesto.SelectedValue != null)
                    obj.id_impuesto = int.Parse(cboImpuesto.SelectedValue.ToString());


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

                if (obj.sn_incluye_impto == Estado.IdActivo)
                {
                    chkIncluyeImpto.Checked = true;
                    txtPrecioCboConTax.Enabled = true;
                    txtPrecioCboSinTax.Enabled = false;
                    cboImpuesto.Enabled = true;
                }
                else
                {
                    chkIncluyeImpto.Checked = false;
                    txtPrecioCboConTax.Enabled = false;
                    txtPrecioCboSinTax.Enabled = true;
                    cboImpuesto.Enabled = false;
                }

                if (obj.id_impuesto != null)
                    cboImpuesto.SelectedValue = obj.id_impuesto;
                else
                    cboImpuesto.SelectedIndex = -1;

                txtPrecioCboConTax.Text = obj.mto_pvpu_con_tax.RemoveTrailingZeros();
                txtPrecioCboSinTax.Text = obj.mto_pvpu_sin_tax.RemoveTrailingZeros();

                details = obj.PROt16_combo_variable_dtl?.ToList();
                CargarGridProd(obj.PROt16_combo_variable_dtl, chkMostrarInactivos.Checked);

                dgvComboVariable.Focus();

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
                tabComboVariable.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (!chkIncluyeImpto.Checked && !Validation.PositiveAmount(txtPrecioCboSinTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboSinTax, ValidationMsg.Amount);
                txtPrecioCboSinTax.Focus();
                no_error = false;
            }
            else if (!Validation.PositiveAmount(txtPrecioCboConTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboConTax, ValidationMsg.Amount);
                txtPrecioCboConTax.Focus();
                no_error = false;
            }

            #region Validación Details
            if (details == null || details.Count == 0)
            {
                errorProvDtl.SetError(dgvDetail, "Se requiere al menos de un item.");
                txtItemCod.Focus();
                no_error = false;
            }
            else
            {
                var msjValid = "";
                var numActivos = 0;
                foreach (var item in details)
                {
                    //if (!ValidAmountRange(item.cantidad))
                    if (!Validation.PositiveAmount(item.cantidad))
                    {
                        no_error = false;
                        msjValid += $"- La cantidad del producto:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }
                    if (!Validation.PositiveAmount(item.mto_pvpu_con_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta con impuesto del producto:'{item.PROt09_producto.txt_desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }

                    if (!Validation.PositiveAmount(item.mto_pvpu_sin_tax))
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
                    Msg.Ok_Info(msjValid, "VALIDACIÓN DEL COMBO ELECTIVO");
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
                long id = 0;
                if (long.TryParse(lblIdComboVariable.Text, out id))
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
            if (dgvComboVariable.RowCount > 0 &&
                dgvComboVariable.SelectedRows.Count > 0)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
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


        //Métodos para calcular precios
        private decimal GetPorcentajeImpuesto()
        {
            decimal.TryParse(lblPorcentajeAcumuladoImpto.Text, out decimal porcentaje);
            return porcentaje;
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
        private void ActualizarPreciosConImpto()
        {
            if (decimal.TryParse(txtPrecioCboSinTax.Text, out decimal pvPuSinImpto))
            {
                txtPrecioCboConTax.Text = CalPrecioConImpuesto(pvPuSinImpto);
            }
            else
            {
                txtPrecioCboSinTax.Clear();
            }
        }
        private void ActualizarPreciosSinImpto()
        {
            if (decimal.TryParse(txtPrecioCboConTax.Text, out decimal pvPuConImpto))
            {
                txtPrecioCboSinTax.Text = CalPrecioSinImpuesto(pvPuConImpto);
            }
        }
        private void ControlarCheckImpto()
        {
            try
            {
                if (!chkIncluyeImpto.Checked)
                {
                    txtPrecioCboConTax.Text = txtPrecioCboSinTax.Text;

                    txtPrecioCboConTax.Enabled = false;
                    txtPrecioCboSinTax.Enabled = true;

                    cboImpuesto.Enabled = false;
                    cboImpuesto.SelectedIndex = cboImpuesto.Items.Count > 0 ? 0 : -1;

                    txtPrecioCboSinTax.Focus();
                }
                else
                {
                    txtPrecioCboConTax.Enabled = true;
                    txtPrecioCboSinTax.Enabled = false;

                    cboImpuesto.Enabled = true;
                    cboImpuesto.SelectedIndex = cboImpuesto.Items.Count > 0 ? 0 : -1;

                    ActualizarPreciosConImpto();

                    txtPrecioCboConTax.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió un error reseteando el check. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            lblIdComboVariable.Text = 0 + "";

            chkActivo.Checked = true;
            chkIncluyeImpto.Checked = true;
            codSelected = "";
            txtNombre.Clear();
            txtCodigo.Clear();
            errorProvDtl.Clear();
            CleanItem(true);
            CleanDetail(true);

            cboImpuesto.SelectedIndex = (cboImpuesto.Items.Count > 0) ? 0 : -1;

            txtPrecioCboConTax.Clear();
            txtPrecioCboSinTax.Clear();

        }
        private void CargarCombos()
        {
            try
            {
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

                        long idInsertado = (long)id;
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
            txtItemCod.MaxLength = 50;
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
            txtItemPriceConImp.TextAlign = HorizontalAlignment.Right;
            txtItemPriceSinImp.TextAlign = HorizontalAlignment.Right;

            txtPrecioCboConTax.MaxLength = 19;
            txtPrecioCboSinTax.MaxLength = 19;

            chkActivo.Checked = false;

            #region Dgv

            dgvDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            SetCabeceraGridDetail();
            DefinirCabeceraGridDetail();
            ControlHelper.DgvReadOnly(dgvDetail);
            ControlHelper.DgvLightStyle(dgvDetail);

            chkIncluyeImpto.Enabled = true;
            cboImpuesto.Enabled = true;
            txtPrecioCboSinTax.Enabled = false;
            txtPrecioCboConTax.Enabled = true;
            #endregion

            #endregion

            SetMaxLengthTxt();
            ControlarEventosABM();
            CargarCombos();
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
                    if (idSelect != lblIdComboVariable.Text && idSelect != "-1")
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


        private void chkIncluyeImpto_CheckedChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
            ControlarCheckImpto();
            isChangedRow = false;
        }

        private void cboImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal? porcentajeAcumulado = null;

            if (int.TryParse(cboImpuesto.SelectedValue?.ToString(), out int id))
            {
                porcentajeAcumulado = new ImpuestoBL().GetPorcentajeAcumulado(id);
            }

            lblPorcentajeAcumuladoImpto.Text = porcentajeAcumulado == null ? "-" : porcentajeAcumulado.RemoveTrailingZeros();

            if (chkIncluyeImpto.Checked)
            {
                ActualizarPreciosSinImpto();
            }

            isChangedRow = false;
        }

        private void txtPrecioCboSinTax_TextChanged(object sender, EventArgs e)
        {
            if (!chkIncluyeImpto.Checked)
            {
                if (decimal.TryParse(txtPrecioCboSinTax.Text, out decimal pvPuSinImpto))
                {
                    txtPrecioCboConTax.Text = txtPrecioCboSinTax.Text;
                }
                else
                {
                    txtPrecioCboConTax.Clear();
                }
            }
            isChangedRow = false;
        }

        private void txtPrecioCboConTax_TextChanged(object sender, EventArgs e)
        {
            if (chkIncluyeImpto.Checked)
            {
                if (decimal.TryParse(txtPrecioCboConTax.Text, out decimal pvPuConImpto))
                {
                    txtPrecioCboSinTax.Text = CalPrecioSinImpuesto(pvPuConImpto);
                }
                else
                {
                    txtPrecioCboSinTax.Clear();
                }
            }
            isChangedRow = false;
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
            if (e.KeyData == Keys.Delete)
            {
                RemoveItem(DeleteDtlAction.Remove);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItem(DeleteDtlAction.Remove);
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
            if (dgvDetail.CurrentCell != null &&
                dgvDetail.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
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
                if (form._itemEdited && form._itemVar != null)
                {
                    if (EditItem(form._itemVar))
                        CargarGridProd(details, chkMostrarInactivos.Checked);
                    else
                        Msg.Ok_Wng("No se pudo editar el item.");
                }
            }
        }

        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDetail.DataSourceChanged -= new EventHandler(OnContentChanged);

                CargarGridProd(details, chkMostrarInactivos.Checked);
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Ocurrió un error al intentar cargar el grid. ERROR:" + ex.Message);
            }
            finally
            {
                dgvDetail.DataSourceChanged += new EventHandler(OnContentChanged);
            }
        }

        private void dgvDetail_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e, Color.LightGray);
        }

        #endregion

        #endregion

    }
}

