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

namespace ConfiguradorUI.Producto.Auxiliares
{
    public partial class FormComboVariableDtl : MetroForm
    {
        #region Variables
        public PROt16_combo_variable_dtl _item = null;
        public bool _itemEdited = false;
        #endregion

        public FormComboVariableDtl(PROt16_combo_variable_dtl item)
        {
            InitializeComponent();
            _item = item;
            SetItem(_item);
            AddEventListener();
        }

        #region Métodos
        public void SetItem(PROt16_combo_variable_dtl item)
        {
            lblItemName.Text = item.PROt09_producto?.txt_desc;
            txtItemCod.Text = item.cod_combo_variable_dtl;
            txtItemQuantity.Text = item.cantidad.RemoveTrailingZeros();
            txtItemPriceConImp.Text = item.mto_pvpu_con_tax.RemoveTrailingZeros();
            txtItemPriceSinImp.Text = item.mto_pvpu_sin_tax.RemoveTrailingZeros();
            chkActivo.Checked = item.id_estado == Estado.IdActivo ? true : false;
        }

        public PROt16_combo_variable_dtl GetItem()
        {
            try
            {
                //Lo que podrá editar
                var detailItem = new PROt16_combo_variable_dtl()
                {
                    cod_combo_variable_dtl = txtItemCod.Text.Trim(),
                    cantidad = decimal.Parse(txtItemQuantity.Text.Trim()),
                    mto_pvpu_sin_tax = decimal.Parse(txtItemPriceSinImp.Text.Trim()),
                    mto_pvpu_con_tax = decimal.Parse(txtItemPriceConImp.Text.Trim()),
                    id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo,
                    txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo
                };
                return detailItem;
            }
            catch (Exception e)
            {
                Msg.Ok_Err($"No se pudo obtener el item. ERROR: {e.Message}");
                return null;
            }
        }


        public PROt16_combo_variable_dtl GetItemNow()
        {
            try
            {
                //Lo que podrá editar
                var detailItem = new PROt16_combo_variable_dtl()
                {
                    cod_combo_variable_dtl = txtItemCod.Text.Trim(),
                    cantidad = decimal.Parse(txtItemQuantity.Text.Trim()),
                    mto_pvpu_sin_tax = decimal.Parse(txtItemPriceSinImp.Text.Trim()),
                    mto_pvpu_con_tax = decimal.Parse(txtItemPriceConImp.Text.Trim()),
                    id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo,
                    txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo
                };
                return detailItem;
            }
            catch (Exception e)
            {
                Msg.Ok_Err($"No se pudo obtener el item. ERROR: {e.Message}");
                return null;
            }
        }

        public void AddEventListener()
        {
            txtItemCod.TextChanged += CheckChange_Changed;
            txtItemPriceConImp.TextChanged += CheckChange_Changed;
            txtItemPriceSinImp.TextChanged += CheckChange_Changed;
            txtItemQuantity.TextChanged += CheckChange_Changed;
            chkActivo.CheckedChanged += CheckChange_Changed;
        }

        public bool ReallyChanged(PROt16_combo_variable_dtl itemChanged)
        {
            if (itemChanged == null)
                return false;

            return !(_item.cod_combo_variable_dtl == itemChanged.cod_combo_variable_dtl &&
                    _item.cantidad == itemChanged.cantidad &&
                    _item.mto_pvpu_con_tax == itemChanged.mto_pvpu_con_tax &&
                    _item.mto_pvpu_sin_tax == itemChanged.mto_pvpu_sin_tax &&
                    _item.id_estado == itemChanged.id_estado &&
                    _item.txt_estado == itemChanged.txt_estado);
        }

        private void EditItem()
        {
            if (ValidItem())
            {
                var itemChanged = GetItem();
                if (ReallyChanged(itemChanged))
                {
                    _item.cod_combo_variable_dtl = itemChanged.cod_combo_variable_dtl;
                    _item.cantidad = itemChanged.cantidad;
                    _item.mto_pvpu_con_tax = itemChanged.mto_pvpu_con_tax;
                    _item.mto_pvpu_sin_tax = itemChanged.mto_pvpu_sin_tax;
                    _item.id_estado = itemChanged.id_estado;
                    _item.txt_estado = itemChanged.txt_estado;
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

            if (!(_item != null && _item.id_producto > 0))
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
                    errorProv.SetError(txtItemPriceSinImp, ValidationMsj.Amount);
                    txtItemPriceSinImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemPriceConImp.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(txtItemPriceConImp, ValidationMsj.Amount);
                    txtItemPriceConImp.Focus();
                }
                if (!Validation.PositiveAmount(txtItemQuantity.Text.Trim()))
                {
                    valid = false;
                    errorProv.SetError(txtItemQuantity, ValidationMsj.Amount);
                    txtItemQuantity.Focus();
                }
            }

            return valid;
        }

        public void SetInit()
        {
            txtItemCod.MaxLength = 10;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _item = null;
            _itemEdited = false;
            CloseForm();
        }

        private void lblItemName_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(lblItemName, lblItemName.Text);
        }

        #endregion
        private void CheckChange_Changed(object sender, EventArgs e)
        {
            CheckChange();
        }
    }
}
