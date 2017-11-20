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
using ConfigUtilitarios.ViewModels;
using ConfiguradorUI.Maestro;

namespace ConfiguradorUI.Producto
{
    public partial class FormCombo : MetroForm
    {

        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        int maxNumItems = 10;
        public bool actualizar = false;
        string codSelected = "";

        private int TipoOperacion = TipoOperacionABM.No_Action;

        enum DeleteDtlAction { Remove, ActiveDesactive };
        enum Detail { Producto, ComboVariable }
        Detail DetailView = Detail.Producto;


        PROt09_producto product = null;
        PROt15_combo_variable cboVar = null;
        List<PROt14_combo_fixed_dtl> details = null;

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
                txtItemPriceConImp.Text = producto.mto_pvpu_con_igv?.RemoveTrailingZeros();
                txtItemPriceSinImp.Text = producto.mto_pvpu_sin_igv?.RemoveTrailingZeros();
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
                txtItemPriceConImp.Text = obj.mto_pvpu_con_tax.RemoveTrailingZeros();
                txtItemPriceSinImp.Text = obj.mto_pvpu_sin_tax.RemoveTrailingZeros();
                txtItemQuantity.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar el combo variable. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PROt14_combo_fixed_dtl GetItem()
        {
            var ventana = "producto";
            try
            {
                var detailItem = new PROt14_combo_fixed_dtl();

                detailItem.cod_combo_fixed_dtl = txtItemCod.Text.Trim();
                detailItem.cantidad = decimal.Parse(txtItemQuantity.Text.Trim());
                detailItem.mto_pvpu_sin_tax = decimal.Parse(txtItemPriceSinImp.Text.Trim());
                detailItem.mto_pvpu_con_tax = decimal.Parse(txtItemPriceConImp.Text.Trim());
                detailItem.id_estado = Estado.IdActivo;
                detailItem.txt_estado = Estado.TxtActivo;

                if (DetailView == Detail.Producto)
                {
                    detailItem.id_producto = product.id_producto;
                    detailItem.PROt09_producto = new PROt09_producto()
                    {
                        txt_desc = txtItemDesc.Text.Trim()
                    };
                }
                else if (DetailView == Detail.ComboVariable)
                {
                    ventana = "combo variable";
                    detailItem.id_combo_variable = cboVar.id_combo_variable;
                    detailItem.PROt15_combo_variable = new PROt15_combo_variable()
                    {
                        txt_desc = txtItemDesc.Text.Trim()
                    };
                }
                else return null;

                return detailItem;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo obtener el {ventana}. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            SetCabeceraGridProductOfCboVarDetail();
            DefinirCabeceraProductOfCboVarDetail();

            if (includeDetails) details = null;
        }

        private bool EditItem(PROt14_combo_fixed_dtl item, bool accumulateQuantity = false)
        {
            try
            {
                var index = -1;
                if (DetailView == Detail.Producto)
                    index = details.FindIndex(x => x.id_producto == item.id_producto);
                else if (DetailView == Detail.ComboVariable)
                    index = details.FindIndex(x => x.id_combo_variable == item.id_combo_variable);
                else return false;

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
                        //Intenta editar
                        if (EditItem(itemObtained, true))
                        {
                            CargarGridDetail(details, false, chkMostrarInactivos.Checked);
                        }
                        //Si no edita singfica que no está -> agrega
                        else if (details.Count < maxNumItems)
                        {
                            long idMaster = 0;
                            if (TipoOperacion != TipoOperacionABM.Nuevo)
                            {
                                long.TryParse(lblIdCombo.Text, out idMaster);
                            }
                            itemObtained.id_combo = idMaster;
                            details.Add(itemObtained);
                            CargarGridDetail(details, false, chkMostrarInactivos.Checked);
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
                    var itemDesc = string.Empty;


                    if (DetailView == Detail.Producto)
                    {
                        itemDesc = oldItem.PROt09_producto?.txt_desc;
                    }
                    else if (DetailView == Detail.ComboVariable)
                    {
                        itemDesc = oldItem.PROt15_combo_variable?.txt_desc;
                    }

                    if (actionDeleteDtl == DeleteDtlAction.Remove)
                    {
                        if (oldItem.id_combo_fixed_dtl <= 0)
                        {
                            if (Msg.YesNo_Ques($"¿Está seguro de QUITAR el item '{itemDesc}'?") == DialogResult.Yes)
                            {
                                details.RemoveAt(itemSelected_index.Item2);
                                isChangedRow = false;
                                if (details.Count == 0) details = null;
                                CargarGridDetail(details, false, chkMostrarInactivos.Checked);
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
                                CargarGridDetail(details, false, chkMostrarInactivos.Checked);
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
                                CargarGridDetail(details, false, chkMostrarInactivos.Checked);
                            }
                        }
                    }
                }
                else
                    Msg.Ok_Info($"No hay ningún item.");
            }
            catch (Exception e)
            {
                Msg.Ok_Err($"No se pudo eliminar el item correctamente. Excepción: {e.Message}", "Excepción encontrada");
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
        private void VerItemDetail()
        {
            var itemSelected = GetItemSelected();
            if (itemSelected.Item1 != null)
            {
                var form = new FormComboItem(itemSelected.Item1);
                form.ShowDialog();
                if (form._itemEdited && form._itemFix != null)
                {
                    if (EditItem(form._itemFix))
                        CargarGridDetail(details, false, chkMostrarInactivos.Checked);
                    else
                        Msg.Ok_Wng("No se pudo editar el item.");
                }
            }
        }
        private Tuple<PROt14_combo_fixed_dtl, int> GetItemSelected()
        {
            if (DetailView == Detail.Producto && long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvProductDetail, 0), out long id))
            {
                int index = details.FindIndex(x => x.id_producto == id);
                if (index != -1 && details[index] != null)
                {
                    return new Tuple<PROt14_combo_fixed_dtl, int>(details[index], index);
                }
            }
            else if (DetailView == Detail.ComboVariable && long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvCboVariableDetail, 0), out long idCboVar))
            {
                int index = details.FindIndex(x => x.id_combo_variable == idCboVar);
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


            if (DetailView == Detail.Producto)
            {
                if (!(product != null && product.id_producto > 0))
                {
                    valid = false;
                    Msg.Ok_Info("No se ha seleccionado a ningún producto. Presione Enter y seleccione.");
                    txtItemCod.Focus();
                }
            }
            else if (DetailView == Detail.ComboVariable)
            {
                if (!(cboVar != null && cboVar.id_combo_variable > 0))
                {
                    valid = false;
                    Msg.Ok_Info("No se ha seleccionado a ningún cbo. electivo. Presione Enter y seleccione.");
                    txtItemCod.Focus();
                }
            }
            else
                valid = false;


            if (valid)
            {
                if (!Validation.PositiveAmount(txtItemPriceSinImp.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblPrecioSinImp, ValidationMsg.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblPrecioConImp, ValidationMsg.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProvDtl.SetError(lblCantidad, ValidationMsg.Amount);
                    txtItemQuantity.Focus();
                }
                if (txtItemDesc.Text.Trim() == "")
                {
                    valid = false;
                    errorProvDtl.SetError(lblItemDesc, ValidationMsg.Required);
                    txtItemDesc.Focus();
                }
            }

            return valid;
        }
        private void VerDetalleDeCboVariable()
        {
            if (dgvCboVariableDetail.RowCount > 0 && dgvCboVariableDetail.SelectedRows.Count > 0 && dgvCboVariableDetail.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdCboVarSelected(), out id) && id > 0)
                {
                    var details = new ComboVariableDetalleBL().ListaDetalleXCboVar(id);
                    CargarGridProductOfCboVarDetail(details);
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string GetIdCboVarSelected()
        {
            string id = "-1";
            try
            {
                if (dgvCboVariableDetail.SelectedRows.Count > 0 && dgvCboVariableDetail.Rows.Count > 0)
                {
                    id = dgvCboVariableDetail.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }

        private void CargarGridDetail(IEnumerable<PROt14_combo_fixed_dtl> list, bool refreshAllGrids = false, bool showInactive = false)
        {
            if (list != null)
            {
                if (DetailView == Detail.Producto || refreshAllGrids)
                {
                    var listProduct = list.Where(x => x.id_producto != null).ToList();

                    if (listProduct != null)
                    {
                        var products = showInactive ? listProduct : listProduct.Where(x => x.id_estado == Estado.IdActivo);


                        dgvProductDetail.DataSource = products.Select(x => new
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
                        SetCabeceraGridDetailProduct();
                    DefinirCabeceraGridDetailProduct();
                }

                if (DetailView == Detail.ComboVariable || refreshAllGrids)
                {
                    var limpiarGridProductOfCboVar = false;
                    var listCboVar = list.Where(x => x.id_combo_variable != null).ToList();
                    if (listCboVar != null && listCboVar.Count() > 0)
                    {
                        var cboVars = showInactive ? listCboVar : listCboVar.Where(x => x.id_estado == Estado.IdActivo);

                        if (cboVars != null && cboVars.Count() > 0)
                        {
                            dgvCboVariableDetail.DataSource = cboVars.Select(x => new
                            {
                                ID_CBO_VAR = x.id_combo_variable,
                                DESC = x.PROt15_combo_variable != null ? x.PROt15_combo_variable.txt_desc : "NO SE PUEDE MOSTRAR",
                                CANTIDAD = x.cantidad.RemoveTrailingZeros(),
                                P_UNIT_C_TAX = x.mto_pvpu_con_tax.RemoveTrailingZeros(),
                                P_UNIT_S_TAX = x.mto_pvpu_sin_tax.RemoveTrailingZeros(),
                                ACTIVO = x.id_estado == Estado.IdActivo ? true : false
                            }).OrderBy(x => x.DESC).ThenByDescending(x => x.P_UNIT_C_TAX).ToList();
                        }
                        else
                        {
                            limpiarGridProductOfCboVar = true;
                        }
                    }
                    else
                    {
                        limpiarGridProductOfCboVar = true;
                    }

                    if (limpiarGridProductOfCboVar)
                    {
                        SetCabeceraGridDetailCboVariable();

                        SetCabeceraGridProductOfCboVarDetail();
                        DefinirCabeceraProductOfCboVarDetail();
                    }
                    DefinirCabeceraGridDetailCboVariable();
                }
            }
            else
            {
                SetCabeceraGridDetailProduct();
                DefinirCabeceraGridDetailProduct();

                SetCabeceraGridDetailCboVariable();
                DefinirCabeceraGridDetailCboVariable();
            }
        }
        private void CargarGridProductOfCboVarDetail(IEnumerable<ComboItem> list)
        {
            if (list != null)
            {
                dgvProductOfCboVarDetail.DataSource = list.Select(x => new
                {
                    CANTIDAD = x.cantidad.RemoveTrailingZeros(),
                    DESC = x.txt_desc_item,
                    ACTIVO = x.id_estado == Estado.IdActivo ? "SÍ" : "NO"
                }).OrderByDescending(x => x.ACTIVO).ThenBy(x => x.DESC).ToList();

            }
            else
            {
                SetCabeceraGridProductOfCboVarDetail();
            }
            DefinirCabeceraProductOfCboVarDetail();
        }

        private void SetCabeceraGridDetailCboVariable()
        {
            var detailHeader = new List<PROt14_combo_fixed_dtl>();
            dgvCboVariableDetail.DataSource = detailHeader.Select(x => new
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

                dgvCboVariableDetail.Columns["ID_CBO_VAR"].Visible = false;

                dgvCboVariableDetail.Columns["DESC"].HeaderText = "CBO. ELEC";
                dgvCboVariableDetail.Columns["CANTIDAD"].HeaderText = "CANT";

                dgvCboVariableDetail.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCboVariableDetail.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCboVariableDetail.Columns["P_UNIT_C_TAX"].HeaderText = "P.UNIT. C/I";
                dgvCboVariableDetail.Columns["P_UNIT_C_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCboVariableDetail.Columns["P_UNIT_C_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCboVariableDetail.Columns["P_UNIT_S_TAX"].HeaderText = "P.UNIT. S/I";
                dgvCboVariableDetail.Columns["P_UNIT_S_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCboVariableDetail.Columns["P_UNIT_S_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCboVariableDetail.Columns["DESC"].Width = 110;
                dgvCboVariableDetail.Columns["ACTIVO"].Width = 50;
                dgvCboVariableDetail.Columns["CANTIDAD"].Width = 38;
                dgvCboVariableDetail.Columns["P_UNIT_C_TAX"].Width = 67;
                dgvCboVariableDetail.Columns["P_UNIT_S_TAX"].Width = 67;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetCabeceraGridDetailProduct()
        {
            var detailHeader = new List<PROt14_combo_fixed_dtl>();
            dgvProductDetail.DataSource = detailHeader.Select(x => new
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
                dgvProductDetail.Columns["ID_PROD"].Visible = false;

                dgvProductDetail.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductDetail.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductDetail.Columns["P_UNIT_C_TAX"].HeaderText = "P. UNIT. C/I";
                dgvProductDetail.Columns["P_UNIT_C_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductDetail.Columns["P_UNIT_C_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductDetail.Columns["P_UNIT_S_TAX"].HeaderText = "P. UNIT. S/I";
                dgvProductDetail.Columns["P_UNIT_S_TAX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductDetail.Columns["P_UNIT_S_TAX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductDetail.Columns["PRODUCTO"].Width = 218;
                dgvProductDetail.Columns["CANTIDAD"].Width = 80;
                dgvProductDetail.Columns["P_UNIT_C_TAX"].Width = 97;
                dgvProductDetail.Columns["P_UNIT_S_TAX"].Width = 97;
                dgvProductDetail.Columns["ACTIVO"].Width = 54;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetCabeceraGridProductOfCboVarDetail()
        {
            var detailHeader = new List<ComboItem>();
            dgvProductOfCboVarDetail.DataSource = detailHeader.Select(x => new
            {
                CANTIDAD = "",
                DESC = "",
                ACTIVO = ""
            }).ToList();
        }
        private void DefinirCabeceraProductOfCboVarDetail()
        {
            try
            {
                dgvProductOfCboVarDetail.Columns["DESC"].HeaderText = "PROD";
                dgvProductOfCboVarDetail.Columns["CANTIDAD"].HeaderText = "CANT";
                dgvProductOfCboVarDetail.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductOfCboVarDetail.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductOfCboVarDetail.Columns["ACTIVO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductOfCboVarDetail.Columns["ACTIVO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductOfCboVarDetail.Columns["DESC"].Width = 100;
                dgvProductOfCboVarDetail.Columns["CANTIDAD"].Width = 37;
                dgvProductOfCboVarDetail.Columns["ACTIVO"].Width = 44;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de los productos del cbo. electivo. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            var chks = new[] { chkActivo, chkIncluyeImpto, chkPrecioAcumulado };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            cboComboGrupo.SelectedIndexChanged += new EventHandler(OnContentChanged);
            cboImpuesto.SelectedIndexChanged += new EventHandler(OnContentChanged);

            dgvProductDetail.DataSourceChanged += new EventHandler(OnContentChanged);
            dgvCboVariableDetail.DataSourceChanged += new EventHandler(OnContentChanged);

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
                                    new ComboBL().EliminarCombo(id);
                                    actualizar = true;
                                    ControlarEventosABM();
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

                obj.sn_incluye_impto = chkIncluyeImpto.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.sn_precio_acumulado = chkPrecioAcumulado.Checked ? Estado.IdActivo : Estado.IdInactivo;

                obj.id_combo_grupo = int.Parse(cboComboGrupo.SelectedValue.ToString());
                //IMPORTANTE
                /*
                 Colocar null al producto y cbo variable de cada detalle. De los contrario EF al
                 momento de grabar insertería también estos.
                 */
                if (details != null)
                {
                    details.ForEach(x => x.PROt09_producto = null);
                    details.ForEach(x => x.PROt15_combo_variable = null);
                }
                obj.PROt14_combo_fixed_dtl = details;

                if (cboImpuesto.SelectedValue != null)
                    obj.id_impuesto = int.Parse(cboImpuesto.SelectedValue.ToString());
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

                cboComboGrupo.SelectedValue = obj.id_combo_grupo;

                if (obj.sn_incluye_impto == Estado.IdActivo)
                {
                    chkPrecioAcumulado.Checked = false;
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

                    if (obj.sn_precio_acumulado == Estado.IdActivo)
                    {
                        chkPrecioAcumulado.Checked = true;
                    }
                }

                if (obj.id_impuesto != null)
                    cboImpuesto.SelectedValue = obj.id_impuesto;
                else
                    cboImpuesto.SelectedIndex = -1;

                txtPrecioCboConTax.Text = obj.mto_pvpu_con_tax.RemoveTrailingZeros();
                txtPrecioCboSinTax.Text = obj.mto_pvpu_sin_tax.RemoveTrailingZeros();

                details = obj.PROt14_combo_fixed_dtl?.ToList();

                CargarGridDetail(obj.PROt14_combo_fixed_dtl, true, chkMostrarInactivos.Checked);

                dgvCombo.Focus();
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

            if (!int.TryParse(cboComboGrupo.SelectedValue?.ToString(), out int idCboGrupo))
            {
                errorProv.SetError(cboComboGrupo, "Este campo es requerido.");
                cboComboGrupo.Focus();
                no_error = false;
            }

            if ((!chkIncluyeImpto.Checked || chkPrecioAcumulado.Checked) && !Validation.PositiveAmount(txtPrecioCboSinTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboSinTax, ValidationMsg.Amount);
                txtPrecioCboSinTax.Focus();
                no_error = false;
            }

            if ((chkIncluyeImpto.Checked  || chkPrecioAcumulado.Checked) && !Validation.PositiveAmount(txtPrecioCboConTax.Text.Trim()))
            {
                errorProv.SetError(txtPrecioCboConTax, ValidationMsg.Amount);
                txtPrecioCboConTax.Focus();
                no_error = false;
            }

            #region Validación Details
            if (details == null || details.Count == 0)
            {
                errorProvDtl.SetError(tabDetails, "Se requiere al menos de un item.");
                txtItemCod.Focus();
                no_error = false;
            }
            else
            {
                var msjValid = "";
                var numActivos = 0;
                foreach (var item in details)
                {
                    var desc = item.id_producto != null ? item.PROt09_producto.txt_desc : (item.id_combo_variable != null) ? item.PROt15_combo_variable.txt_desc : "";


                    if (!Validation.PositiveAmount(item.cantidad))
                    {
                        no_error = false;
                        msjValid += $"- La cantidad de:'{desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }
                    if (!Validation.PositiveAmount(item.mto_pvpu_con_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta con impuesto de:'{desc}' " +
                            $"debe ser un número positivo menor a {KeyAmounts.MaxAmount}.\n";
                    }

                    if (!Validation.PositiveAmount(item.mto_pvpu_sin_tax))
                    {
                        no_error = false;
                        msjValid += $"- El precio de venta sin impuesto de:'{desc}' " +
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
                    msjValid = "- El combo debe tener al menos un producto o cbo. electivo activado.\n" + msjValid;
                }
                if (msjValid != "")
                {
                    Msg.Ok_Info(msjValid, "VALIDACIÓN DEL COMBO");
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
                            SelectTabDetail();
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

        private void SelectTabDetail()
        {
            if (details != null && !details.Any(x => x.id_producto != null && x.id_estado == Estado.IdActivo))
            {
                tabDetails.SelectedTab = tabPagCboElectivo;
            }
            else
            {
                tabDetails.SelectedTab = tabPagProductos;
            }
            dgvCombo.Focus();
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
                cboImpuesto.SelectedIndex = cboImpuesto.Items.Count > 0 ? 0 : -1;

                if (chkIncluyeImpto.Enabled && !chkIncluyeImpto.Checked)
                {
                    txtPrecioCboConTax.Text = txtPrecioCboSinTax.Text;

                    txtPrecioCboConTax.Enabled = false;
                    txtPrecioCboSinTax.Enabled = true;

                    cboImpuesto.Enabled = false;

                    txtPrecioCboSinTax.Focus();
                }
                else if (chkIncluyeImpto.Enabled)
                {
                    txtPrecioCboConTax.Enabled = true;
                    txtPrecioCboSinTax.Enabled = false;

                    cboImpuesto.Enabled = true;

                    ActualizarPreciosConImpto();

                    txtPrecioCboConTax.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió un error reseteando el check. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcularPrecioAcumulado()
        {
            decimal precioConTaxAcumulado = 0,
                    precioSinTaxAcumulado = 0;

            if (details != null)
            {
                foreach (var item in details)
                {
                    if (item.id_estado == Estado.IdActivo)
                    {
                        precioConTaxAcumulado += (item.cantidad * item.mto_pvpu_con_tax);
                        precioSinTaxAcumulado += (item.cantidad * item.mto_pvpu_sin_tax);
                    }
                }
            }

            txtPrecioCboSinTax.Text = precioSinTaxAcumulado == 0 ? "" : precioSinTaxAcumulado.RemoveTrailingZeros();
            txtPrecioCboConTax.Text = precioConTaxAcumulado == 0 ? "" : precioConTaxAcumulado.RemoveTrailingZeros();
        }
        private void EstadoAreaImpuesto(bool esActivo)
        {
            chkIncluyeImpto.Enabled = esActivo;
            chkIncluyeImpto.Checked = esActivo;
            cboImpuesto.Enabled = esActivo;
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

            chkActivo.Checked = true;
            chkIncluyeImpto.Checked = true;
            chkPrecioAcumulado.Checked = false;
            lblIdCombo.Text = 0 + "";
            codSelected = "";
            txtNombre.Clear();
            txtCodigo.Clear();

            if (cboComboGrupo.Items.Count > 0)
                cboComboGrupo.SelectedIndex = 0;

            errorProvDtl.Clear();
            CleanItem(true);
            CleanDetail(true);

            cboImpuesto.SelectedIndex = (cboImpuesto.Items.Count > 0) ? 0 : -1;

            txtPrecioCboConTax.Clear();
            txtPrecioCboSinTax.Clear();

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
                    tabCombo.SelectedTab = tabPagGeneral;
                    tabDetails.SelectedTab = tabPagProductos;
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
                cboComboGrupo.DataSource = null;
                cboComboGrupo.DisplayMember = "txt_desc";
                cboComboGrupo.ValueMember = "id_combo_grupo";
                cboComboGrupo.DataSource = new ComboGrupoBL().ListaComboGrupo(Estado.IdActivo, false, true);

                cboImpuesto.DataSource = null;
                cboImpuesto.DisplayMember = "txt_abrv";
                cboImpuesto.ValueMember = "id_impuesto";
                cboImpuesto.DataSource = new ImpuestoBL().ListaImpuesto(Estado.IdActivo, false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos: " + e.Message, "MENSAJE");
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

            txtPrecioCboConTax.MaxLength = 19;
            txtPrecioCboSinTax.MaxLength = 19;
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
                lblItemDesc.Text = "Descrip. Producto";
                btnItem.Location = new Point(187, 104);
            }
            else if (tabDetails.SelectedTab == tabDetails.TabPages["tabPagCboElectivo"])
            {
                DetailView = Detail.ComboVariable;
                lblItemDesc.Text = "Descrip. Cbo. Electivo";
                btnItem.Location = new Point(207, 104);
            }
            CleanItem(true);

            errorProvDtl.Clear();
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

            chkMostrarInactivos.Checked = false;

            #region Dgv

            dgvCboVariableDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvProductOfCboVarDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvProductDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCboVariableDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductOfCboVarDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            SetCabeceraGridProductOfCboVarDetail();
            DefinirCabeceraProductOfCboVarDetail();
            ControlHelper.DgvReadOnly(dgvProductOfCboVarDetail);
            ControlHelper.DgvLightStyle(dgvProductOfCboVarDetail, 8F, 8F);

            SetCabeceraGridDetailProduct();
            DefinirCabeceraGridDetailProduct();
            ControlHelper.DgvReadOnly(dgvProductDetail);
            ControlHelper.DgvLightStyle(dgvProductDetail);

            SetCabeceraGridDetailCboVariable();
            DefinirCabeceraGridDetailCboVariable();
            ControlHelper.DgvReadOnly(dgvCboVariableDetail);
            ControlHelper.DgvLightStyle(dgvCboVariableDetail, 8F, 8F);

            chkIncluyeImpto.Enabled = true;
            chkPrecioAcumulado.Checked = false;
            cboImpuesto.Enabled = true;
            txtPrecioCboSinTax.Enabled = false;
            txtPrecioCboConTax.Enabled = true;

            #endregion

            #endregion

            SetMaxLengthTxt();
            CheckChangeTab();
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
            if (chkIncluyeImpto.Enabled && !chkIncluyeImpto.Checked)
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
            if (chkIncluyeImpto.Enabled && chkIncluyeImpto.Checked)
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

        private void chkPrecioAcumulado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrecioAcumulado.Checked)
            {
                txtPrecioCboConTax.Enabled = false;
                txtPrecioCboSinTax.Enabled = false;
                EstadoAreaImpuesto(false);
                CalcularPrecioAcumulado();
            }
            else
            {
                EstadoAreaImpuesto(true);
                txtPrecioCboConTax.Text = "";
                txtPrecioCboConTax.Focus();
            }
            isChangedRow = false;
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

            tabDetails.SelectedTab = tabPagCboElectivo;
            //RemoveItem(DeleteDtlAction.Remove);
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
                        CargarGridDetail(details, false, chkMostrarInactivos.Checked);
                    else
                        Msg.Ok_Wng("No se pudo editar el item.");
                }
            }
        }

        private void btnComboGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboComboGrupo.SelectedValue != null)
                    oldValue = int.Parse(cboComboGrupo.SelectedValue.ToString());

                var frm = new FormComboGrupo();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboComboGrupo.DataSource = null;
                    cboComboGrupo.DisplayMember = "txt_desc";
                    cboComboGrupo.ValueMember = "id_combo_grupo";
                    cboComboGrupo.DataSource = new ComboGrupoBL().ListaComboGrupo(Estado.IdActivo, false, true);

                    cboComboGrupo.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChangeTab();
            txtItemCod.Focus();
        }

        private void dgvCboVariableDetail_SelectionChanged(object sender, EventArgs e)
        {
            VerDetalleDeCboVariable();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            SearchAndSetItem();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (DetailView == Detail.Producto)
            {
                var form = new FormProducto();
                form.ShowDialog();
            }
            else if (DetailView == Detail.ComboVariable)
            {
                var form = new FormComboVariable();
                form.ShowDialog();
            }
        }

        private void dgvProductDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerItemDetail();
        }

        private void dgvCboVariableDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerItemDetail();
        }

        private void dgvProductDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductDetail.CurrentCell != null &&
               dgvProductDetail.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                RemoveItem(DeleteDtlAction.ActiveDesactive);
            }
        }

        private void dgvCboVariableDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCboVariableDetail.CurrentCell != null &&
                dgvCboVariableDetail.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                RemoveItem(DeleteDtlAction.ActiveDesactive);
            }
        }

        private void dgvProductDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveItem(DeleteDtlAction.Remove);
            }
        }

        private void dgvCboVariableDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveItem(DeleteDtlAction.Remove);
            }
        }

        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProductDetail.DataSourceChanged -= new EventHandler(OnContentChanged);
                dgvCboVariableDetail.DataSourceChanged -= new EventHandler(OnContentChanged);

                CargarGridDetail(details, true, chkMostrarInactivos.Checked);
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Ocurrió un error al intentar cargar los grid. ERROR:" + ex.Message);
            }
            finally
            {
                dgvProductDetail.DataSourceChanged += new EventHandler(OnContentChanged);
                dgvCboVariableDetail.DataSourceChanged += new EventHandler(OnContentChanged);
            }
        }

        private void dgvProductDetail_DataSourceChanged(object sender, EventArgs e)
        {
            isChangedRow = false;
            if (chkPrecioAcumulado.Checked)
                CalcularPrecioAcumulado();
        }

        private void dgvCboVariableDetail_DataSourceChanged(object sender, EventArgs e)
        {
            isChangedRow = false;
            if (chkPrecioAcumulado.Checked)
                CalcularPrecioAcumulado();
        }


        #endregion

        #endregion

    }
}

