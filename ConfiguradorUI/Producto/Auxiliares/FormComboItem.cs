using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigBusinessEntity;
using ConfigUtilitarios.Extensions;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.KeyValues;
using ConfigUtilitarios.ViewModels;

namespace ConfiguradorUI.Producto.Auxiliares
{
    public partial class FormComboItem : MetroForm
    {
        #region Variables
        public PROt16_combo_variable_dtl _itemVar = null;
        public PROt14_combo_fixed_dtl _itemFix = null;

        public ComboItem _item = null;

        public bool _itemEdited = false;
        #endregion

        public FormComboItem(PROt16_combo_variable_dtl item)
        {
            InitializeComponent();
            _itemVar = item;
            MapItem(item);
            SetItem(_item);
            AddHandlers();
        }

        public FormComboItem(PROt14_combo_fixed_dtl item)
        {
            InitializeComponent();
            _itemFix = item;
            MapItem(item);
            SetItem(_item);
            AddHandlers();
        }

        #region Métodos

        public void MapItem(PROt16_combo_variable_dtl item)
        {
            _item = new ComboItem()
            {
                txt_desc_item = item.PROt09_producto?.txt_desc,
                cod_combo_item = item.cod_combo_variable_dtl,
                cantidad = item.cantidad,
                mto_pvpu_con_tax = item.mto_pvpu_con_tax,
                mto_pvpu_sin_tax = item.mto_pvpu_sin_tax,
                id_estado = item.id_estado
            };
        }

        public void MapItem(PROt14_combo_fixed_dtl item)
        {
            _item = new ComboItem()
            {
                txt_desc_item = item.id_producto != null ? item.PROt09_producto?.txt_desc : item.PROt15_combo_variable?.txt_desc,
                cod_combo_item = item.cod_combo_fixed_dtl,
                cantidad = item.cantidad != null ? (decimal)item.cantidad : 0,
                mto_pvpu_con_tax = item.mto_pvpu_con_tax,
                mto_pvpu_sin_tax = item.mto_pvpu_sin_tax,
                id_estado = item.id_estado
            };
        }

        public void SetItem(ComboItem item)
        {
            lblItemName.Text = item.txt_desc_item;
            txtItemCod.Text = item.cod_combo_item;
            txtItemQuantity.Text = item.cantidad.RemoveTrailingZeros();
            txtItemPriceConImp.Text = item.mto_pvpu_con_tax.RemoveTrailingZeros();
            txtItemPriceSinImp.Text = item.mto_pvpu_sin_tax.RemoveTrailingZeros();
            chkActivo.Checked = item.id_estado == Estado.IdActivo ? true : false;
        }

        public ComboItem GetItem()
        {
            try
            {
                var detailItem = new ComboItem()
                {
                    cod_combo_item = txtItemCod.Text.Trim(),
                    cantidad = decimal.Parse(txtItemQuantity.Text.Trim()),
                    mto_pvpu_sin_tax = decimal.Parse(txtItemPriceSinImp.Text.Trim()),
                    mto_pvpu_con_tax = decimal.Parse(txtItemPriceConImp.Text.Trim()),
                    id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo,
                    //txt_estado     = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo
                };
                return detailItem;
            }
            catch (Exception e)
            {
                Msg.Ok_Err($"No se pudo obtener el item. ERROR: {e.Message}");
                return null;
            }
        }

        public void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            txtItemCod.TextChanged += CheckChange_Changed;
            txtItemPriceConImp.TextChanged += CheckChange_Changed;
            txtItemPriceSinImp.TextChanged += CheckChange_Changed;
            txtItemQuantity.TextChanged += CheckChange_Changed;
            chkActivo.CheckedChanged += CheckChange_Changed;
        }

        public bool ReallyChanged(ComboItem itemChanged)
        {
            if (itemChanged == null)
                return false;

            return !(_item.cod_combo_item == itemChanged.cod_combo_item &&
                    _item.cantidad == itemChanged.cantidad &&
                    _item.mto_pvpu_con_tax == itemChanged.mto_pvpu_con_tax &&
                    _item.mto_pvpu_sin_tax == itemChanged.mto_pvpu_sin_tax &&
                    _item.id_estado == itemChanged.id_estado);
        }

        private void EditItem()
        {
            if (ValidItem())
            {
                var itemChanged = GetItem();
                if (ReallyChanged(itemChanged))
                {
                    if (_itemVar != null)
                    {
                        _itemVar.cod_combo_variable_dtl = itemChanged.cod_combo_item;
                        _itemVar.cantidad = itemChanged.cantidad;
                        _itemVar.mto_pvpu_con_tax = itemChanged.mto_pvpu_con_tax;
                        _itemVar.mto_pvpu_sin_tax = itemChanged.mto_pvpu_sin_tax;
                        _itemVar.id_estado = itemChanged.id_estado;
                        _itemVar.txt_estado = _itemVar.id_estado == Estado.IdActivo ? Estado.TxtActivo : Estado.TxtInactivo;
                    }
                    else if (_itemFix != null)
                    {
                        _itemFix.cod_combo_fixed_dtl = itemChanged.cod_combo_item;
                        _itemFix.cantidad = itemChanged.cantidad;
                        _itemFix.mto_pvpu_con_tax = itemChanged.mto_pvpu_con_tax;
                        _itemFix.mto_pvpu_sin_tax = itemChanged.mto_pvpu_sin_tax;
                        _itemFix.id_estado = itemChanged.id_estado;
                        _itemFix.txt_estado = _itemFix.id_estado == Estado.IdActivo ? Estado.TxtActivo : Estado.TxtInactivo;
                    }

                    _itemEdited = true;
                }
                CloseForm();
            }
        }

        private void CheckChange()
        {
            if (ValidItem())
            {
                var itemChanged = GetItem();
                if (ReallyChanged(itemChanged))
                {
                    btnEditar.Enabled = true;
                }
                else btnEditar.Enabled = false;
            }
            else btnEditar.Enabled = false;
        }

        private bool ValidItem()
        {
            errorProv.Clear();
            var valid = true;

            if (!(_item != null))
            {
                valid = false;
                Msg.Ok_Info("El item está vacío.");
                btnCancelar.Focus();
            }
            else
            {
                if (!Validation.PositiveAmount(txtItemPriceSinImp.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(txtItemPriceSinImp, ValidationMsg.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(txtItemPriceConImp, ValidationMsg.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(txtItemQuantity, ValidationMsg.Amount);
                    txtItemQuantity.Focus();
                }
            }

            return valid;
        }

        public void SetInit()
        {
            txtItemCod.MaxLength = 50;

            txtItemPriceConImp.ReadOnly = true;
            txtItemPriceSinImp.ReadOnly = true;
            txtItemPriceConImp.TextAlign = HorizontalAlignment.Right;
            txtItemPriceSinImp.TextAlign = HorizontalAlignment.Right;
            txtItemQuantity.TextAlign = HorizontalAlignment.Right;


            txtItemPriceConImp.KeyPress += ControlHelper.TxtValidDecimal;
            txtItemPriceSinImp.KeyPress += ControlHelper.TxtValidDecimal;
            txtItemQuantity.KeyPress += ControlHelper.TxtValidInteger;

            btnEditar.Enabled = false;
        }

        private void CloseForm()
        {
            Dispose();
            Hide();
            Close();
        }
        #endregion

        #region Eventos

        private void FormComboVariableDtl_Load(object sender, EventArgs e)
        {
            SetInit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void CheckChange_Changed(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void lblItemName_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(lblItemName, lblItemName.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _itemVar = null;
            _itemFix = null;
            _itemEdited = false;
            CloseForm();
        }

        #endregion
    }
}
