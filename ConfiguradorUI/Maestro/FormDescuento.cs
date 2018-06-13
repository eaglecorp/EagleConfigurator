using ConfigBusinessEntity;
using ConfigBusinessLogic.General;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormDescuento : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";
        #endregion

        public FormDescuento()
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
            var txts = new[] { txtNombre, txtCodigo,txtPorcentaje,txtMonto,
                                txtMontoMin,txtMontoMax};
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }

            var cbos = new[] {  cboP1Hi, cboP1Hf,
                                cboP2Hi, cboP2Hf,
                                cboP3Hi, cboP3Hf,
                                cboP4Hi, cboP4Hf,
                                cboP5Hi, cboP5Hf,
                                cboP6Hi, cboP6Hf,
                                cboP7Hi, cboP7Hf,
                                cboDomHi,cboDomHf,
                                cboLunHi,cboLunHf,
                                cboMarHi,cboMarHf,
                                cboMieHi,cboMieHf,
                                cboJueHi,cboJueHf,
                                cboVieHi,cboVieHf,
                                cboSabHi,cboSabHf,

            };
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
            }

            var dtps = GetDtpPeriodos();

            foreach (var dtp in dtps)
            {
                dtp.CloseUp += dtpVer_CloseUp;
                dtp.MouseDown += DtpVer_MouseDown;
                dtp.KeyPress += DtpLimpiar_KeyPress;

                dtp.ValueChanged += OnContentChanged;
                dtp.CloseUp += OnContentChanged;
                dtp.MouseDown += OnContentChanged;
                dtp.KeyPress += OnContentChanged;
            }

            var chks = new[] { chkActivo, chkDomingo, chkLunes,
                                chkMartes, chkMiercoles,chkJueves,
                                chkViernes,chkSabado
                                 };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            var rbts = new[] { rbtMonto, rbtMontoAbierto, rbtPorcentaje,
                                rbtPorcentajeAbierto };

            foreach (var rbt in rbts)
            {
                rbt.CheckedChanged += new EventHandler(OnContentChanged);
            }

            txtPorcentaje.KeyPress += ValidarTxtDecimal;
            txtMonto.KeyPress += ValidarTxtDecimal;
            txtMontoMin.KeyPress += ValidarTxtDecimal;
            txtMontoMax.KeyPress += ValidarTxtDecimal;
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
        private void EnableTxtMtoAndPorc(bool enableMto = true, bool enablePorc = true)
        {
            txtMonto.Enabled = enableMto;
            txtPorcentaje.Enabled = enablePorc;
        }
        private void CleanTxtMtoAndPorc(bool cleanMto = true, bool cleanPorc = true)
        {
            if (cleanMto)
                txtMonto.Clear();
            if (cleanPorc)
                txtPorcentaje.Clear();
        }

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt02_descuento();
                        obj = GetObjeto();
                        int id = new DescuentoBL().InsertarDescuento(obj);
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
                if (dgvDescuento.RowCount > 0)
                {
                    if (dgvDescuento.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdDescuento.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new DescuentoBL().EliminarDescuento(id);
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
            //Esta variable booleana se usa en algunos para controlar la validez
            // del reg, por ejemplo, cuando el usuario quiere salir
            //y tiene una modificación pendiente(pero si no es válida no sale)
            //en esa caso usaremos esta variables, en otras no.
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt02_descuento();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdDescuento.Text, out id))
                        {
                            obj.id_descuento = id;
                            new DescuentoBL().ActualizarDescuento(obj);
                            ControlarEventosABM(obj.id_descuento);
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar el registro: " + e.Message);
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
                    if (EsValido())
                    {
                        var obj = new MSTt02_descuento();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdDescuento.Text, out id))
                        {
                            obj.id_descuento = id;
                            new DescuentoBL().ActualizarDescuento(obj);
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

        private MSTt02_descuento GetObjeto()
        {
            var obj = new MSTt02_descuento();
            try
            {

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_descuento = txtCodigo.Text.Trim();

                if (rbtPorcentaje.Checked)
                {
                    if (string.IsNullOrEmpty(txtPorcentaje.Text.Trim()))
                        obj.porcentaje = null;
                    else obj.porcentaje = decimal.Parse(txtPorcentaje.Text);
                }
                else if (rbtMonto.Checked)
                {
                    if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
                        obj.monto = null;
                    else obj.monto = decimal.Parse(txtMonto.Text);
                }

                obj.sn_dscto_mto = rbtMonto.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.sn_dscto_mto_abierto = rbtMontoAbierto.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.sn_dscto_porc = rbtPorcentaje.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.sn_dscto_porc_abierto = rbtPorcentajeAbierto.Checked ? Estado.IdActivo : Estado.IdInactivo;

                if (string.IsNullOrEmpty(txtMontoMin.Text.Trim()))
                    obj.monto_min = null;
                else obj.monto_min = decimal.Parse(txtMontoMin.Text);

                if (string.IsNullOrEmpty(txtMontoMax.Text.Trim()))
                    obj.monto_max = null;
                else obj.monto_max = decimal.Parse(txtMontoMax.Text);

                if (rbtDia.Checked || rbtPeriodo.Checked)
                {
                    if (rbtPeriodo.Checked)
                    {
                        obj.sn_descuen_periodo = Estado.IdActivo;
                        obj.sn_descuen_dia = Estado.IdInactivo;

                        if (dtpP1Ini.CustomFormat == DateFormat.DateOnly || dtpP1Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP1Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p1_fecha_ini = dtpP1Ini.Value.Date;

                            if (dtpP1Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p1_fecha_fin = dtpP1Fin.Value.Date;

                            obj.p1_hora_ini = TimeSpan.Parse(cboP1Hi.Text);
                            obj.p1_hora_fin = TimeSpan.Parse(cboP1Hf.Text);
                        }

                        if (dtpP2Ini.CustomFormat == DateFormat.DateOnly || dtpP2Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP2Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p2_fecha_ini = dtpP2Ini.Value.Date;

                            if (dtpP2Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p2_fecha_fin = dtpP2Fin.Value.Date;

                            obj.p2_hora_ini = TimeSpan.Parse(cboP2Hi.Text);
                            obj.p2_hora_fin = TimeSpan.Parse(cboP2Hf.Text);
                        }

                        if (dtpP3Ini.CustomFormat == DateFormat.DateOnly || dtpP3Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP3Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p3_fecha_ini = dtpP3Ini.Value.Date;

                            if (dtpP3Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p3_fecha_fin = dtpP3Fin.Value.Date;

                            obj.p3_hora_ini = TimeSpan.Parse(cboP3Hi.Text);
                            obj.p3_hora_fin = TimeSpan.Parse(cboP3Hf.Text);
                        }

                        if (dtpP4Ini.CustomFormat == DateFormat.DateOnly || dtpP4Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP4Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p4_fecha_ini = dtpP4Ini.Value.Date;

                            if (dtpP4Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p4_fecha_fin = dtpP4Fin.Value.Date;

                            obj.p4_hora_ini = TimeSpan.Parse(cboP4Hi.Text);
                            obj.p4_hora_fin = TimeSpan.Parse(cboP4Hf.Text);
                        }

                        if (dtpP5Ini.CustomFormat == DateFormat.DateOnly || dtpP5Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP5Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p5_fecha_ini = dtpP5Ini.Value.Date;

                            if (dtpP5Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p5_fecha_fin = dtpP5Fin.Value.Date;

                            obj.p5_hora_ini = TimeSpan.Parse(cboP5Hi.Text);
                            obj.p5_hora_fin = TimeSpan.Parse(cboP5Hf.Text);
                        }

                        if (dtpP6Ini.CustomFormat == DateFormat.DateOnly || dtpP6Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP6Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p6_fecha_ini = dtpP6Ini.Value.Date;

                            if (dtpP6Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p6_fecha_fin = dtpP6Fin.Value.Date;

                            obj.p6_hora_ini = TimeSpan.Parse(cboP6Hi.Text);
                            obj.p6_hora_fin = TimeSpan.Parse(cboP6Hf.Text);
                        }

                        if (dtpP7Ini.CustomFormat == DateFormat.DateOnly || dtpP7Fin.CustomFormat == DateFormat.DateOnly)
                        {
                            if (dtpP7Ini.CustomFormat == DateFormat.DateOnly)
                                obj.p7_fecha_ini = dtpP7Ini.Value.Date;

                            if (dtpP7Fin.CustomFormat == DateFormat.DateOnly)
                                obj.p7_fecha_fin = dtpP7Fin.Value.Date;

                            obj.p7_hora_ini = TimeSpan.Parse(cboP7Hi.Text);
                            obj.p7_hora_fin = TimeSpan.Parse(cboP7Hf.Text);
                        }
                    }
                    else
                    {
                        obj.sn_descuen_periodo = Estado.IdInactivo;
                        obj.sn_descuen_dia = Estado.IdActivo;

                        if (chkDomingo.Checked)
                        {
                            obj.sn_domingo = Estado.IdActivo;
                            obj.dom_hora_ini = TimeSpan.Parse(cboDomHi.Text);
                            obj.dom_hora_fin = TimeSpan.Parse(cboDomHf.Text);
                        }
                        else obj.sn_domingo = Estado.IdInactivo;

                        if (chkLunes.Checked)
                        {
                            obj.sn_lunes = Estado.IdActivo;
                            obj.lun_hora_ini = TimeSpan.Parse(cboLunHi.Text);
                            obj.lun_hora_fin = TimeSpan.Parse(cboLunHf.Text);
                        }
                        else obj.sn_lunes = Estado.IdInactivo;

                        if (chkMartes.Checked)
                        {
                            obj.sn_martes = Estado.IdActivo;
                            obj.mar_hora_ini = TimeSpan.Parse(cboMarHi.Text);
                            obj.mar_hora_fin = TimeSpan.Parse(cboMarHf.Text);
                        }
                        else obj.sn_martes = Estado.IdInactivo;

                        if (chkMiercoles.Checked)
                        {
                            obj.sn_miercoles = Estado.IdActivo;
                            obj.mie_hora_ini = TimeSpan.Parse(cboMieHi.Text);
                            obj.mie_hora_fin = TimeSpan.Parse(cboMieHf.Text);
                        }
                        else obj.sn_miercoles = Estado.IdInactivo;

                        if (chkJueves.Checked)
                        {
                            obj.sn_jueves = Estado.IdActivo;
                            obj.jue_hora_ini = TimeSpan.Parse(cboJueHi.Text);
                            obj.jue_hora_fin = TimeSpan.Parse(cboJueHf.Text);
                        }
                        else obj.sn_jueves = Estado.IdInactivo;

                        if (chkViernes.Checked)
                        {
                            obj.sn_viernes = Estado.IdActivo;
                            obj.vie_hora_ini = TimeSpan.Parse(cboVieHi.Text);
                            obj.vie_hora_fin = TimeSpan.Parse(cboVieHf.Text);
                        }
                        else obj.sn_viernes = Estado.IdInactivo;

                        if (chkSabado.Checked)
                        {
                            obj.sn_sabado = Estado.IdActivo;
                            obj.sab_hora_ini = TimeSpan.Parse(cboSabHi.Text);
                            obj.sab_hora_fin = TimeSpan.Parse(cboSabHf.Text);
                        }
                        else obj.sn_sabado = Estado.IdInactivo;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }

        private void SetObjeto(MSTt02_descuento obj)
        {
            try
            {
                isChangedRow = true;

                LimpiarForm();

                chkActivo.Checked = obj.id_estado == Estado.IdActivo ? true : false;

                lblIdDescuento.Text = obj.id_descuento.ToString();
                codSelected = obj.cod_descuento;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_descuento;

                txtPorcentaje.Text = (obj.porcentaje == null) ? "" : obj.porcentaje.RemoveTrailingZeros();
                txtMonto.Text = (obj.monto == null) ? "" : obj.monto.RemoveTrailingZeros();
                txtMontoMin.Text = (obj.monto_min == null) ? "" : obj.monto_min.RemoveTrailingZeros();
                txtMontoMax.Text = (obj.monto_max == null) ? "" : obj.monto_max.RemoveTrailingZeros();

                rbtMonto.Checked = obj.sn_dscto_mto == Estado.IdActivo;
                rbtMontoAbierto.Checked = obj.sn_dscto_mto_abierto == Estado.IdActivo;
                rbtPorcentaje.Checked = obj.sn_dscto_porc == Estado.IdActivo;
                rbtPorcentajeAbierto.Checked = obj.sn_dscto_porc_abierto == Estado.IdActivo;

                if (obj.sn_descuen_dia == Estado.IdActivo || obj.sn_descuen_periodo == Estado.IdActivo)
                {
                    if (obj.sn_descuen_periodo == Estado.IdActivo)
                    {
                        rbtPeriodo.Checked = true;

                        if (obj.p1_fecha_ini != null || obj.p1_fecha_fin != null)
                        {

                            if (obj.p1_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP1Ini, DateFormat.DateOnly);
                                dtpP1Ini.Value = (DateTime)obj.p1_fecha_ini;
                            }
                            if (obj.p1_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP1Fin, DateFormat.DateOnly);
                                dtpP1Fin.Value = (DateTime)obj.p1_fecha_fin;
                            }
                            cboP1Hi.Enabled = true;
                            cboP1Hf.Enabled = true;
                            cboP1Hi.Text = obj.p1_hora_ini.ToString().Substring(0, 5);
                            cboP1Hf.Text = obj.p1_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p2_fecha_ini != null || obj.p2_fecha_fin != null)
                        {
                            if (obj.p2_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP2Ini, DateFormat.DateOnly);
                                dtpP2Ini.Value = (DateTime)obj.p2_fecha_ini;
                            }
                            if (obj.p2_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP2Fin, DateFormat.DateOnly);
                                dtpP2Fin.Value = (DateTime)obj.p2_fecha_fin;
                            }

                            cboP2Hi.Enabled = true;
                            cboP2Hf.Enabled = true;
                            cboP2Hi.Text = obj.p2_hora_ini.ToString().Substring(0, 5);
                            cboP2Hf.Text = obj.p2_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p3_fecha_ini != null || obj.p3_fecha_fin != null)
                        {
                            if (obj.p3_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP3Ini, DateFormat.DateOnly);
                                dtpP3Ini.Value = (DateTime)obj.p3_fecha_ini;
                            }
                            if (obj.p3_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP3Fin, DateFormat.DateOnly);
                                dtpP3Fin.Value = (DateTime)obj.p3_fecha_fin;
                            }

                            cboP3Hi.Enabled = true;
                            cboP3Hf.Enabled = true;
                            cboP3Hi.Text = obj.p3_hora_ini.ToString().Substring(0, 5);
                            cboP3Hf.Text = obj.p3_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p4_fecha_ini != null || obj.p4_fecha_fin != null)
                        {
                            if (obj.p4_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP4Ini, DateFormat.DateOnly);
                                dtpP4Ini.Value = (DateTime)obj.p4_fecha_ini;
                            }
                            if (obj.p4_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP4Fin, DateFormat.DateOnly);
                                dtpP4Fin.Value = (DateTime)obj.p4_fecha_fin;
                            }

                            cboP4Hi.Enabled = true;
                            cboP4Hf.Enabled = true;
                            cboP4Hi.Text = obj.p4_hora_ini.ToString().Substring(0, 5);
                            cboP4Hf.Text = obj.p4_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p5_fecha_ini != null || obj.p5_fecha_fin != null)
                        {
                            if (obj.p5_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP5Ini, DateFormat.DateOnly);
                                dtpP5Ini.Value = (DateTime)obj.p5_fecha_ini;
                            }
                            if (obj.p5_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP5Fin, DateFormat.DateOnly);
                                dtpP5Fin.Value = (DateTime)obj.p5_fecha_fin;
                            }

                            cboP5Hi.Enabled = true;
                            cboP5Hf.Enabled = true;
                            cboP5Hi.Text = obj.p5_hora_ini.ToString().Substring(0, 5);
                            cboP5Hf.Text = obj.p5_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p6_fecha_ini != null || obj.p6_fecha_fin != null)
                        {
                            if (obj.p6_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP6Ini, DateFormat.DateOnly);
                                dtpP6Ini.Value = (DateTime)obj.p6_fecha_ini;
                            }
                            if (obj.p6_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP6Fin, DateFormat.DateOnly);
                                dtpP6Fin.Value = (DateTime)obj.p6_fecha_fin;
                            }

                            cboP6Hi.Enabled = true;
                            cboP6Hf.Enabled = true;
                            cboP6Hi.Text = obj.p6_hora_ini.ToString().Substring(0, 5);
                            cboP6Hf.Text = obj.p6_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.p7_fecha_ini != null || obj.p7_fecha_fin != null)
                        {
                            if (obj.p7_fecha_ini != null)
                            {
                                DateFormat.SetFormat(dtpP7Ini, DateFormat.DateOnly);
                                dtpP7Ini.Value = (DateTime)obj.p7_fecha_ini;
                            }
                            if (obj.p7_fecha_fin != null)
                            {
                                DateFormat.SetFormat(dtpP7Fin, DateFormat.DateOnly);
                                dtpP7Fin.Value = (DateTime)obj.p7_fecha_fin;
                            }

                            cboP7Hi.Enabled = true;
                            cboP7Hf.Enabled = true;
                            cboP7Hi.Text = obj.p7_hora_ini.ToString().Substring(0, 5);
                            cboP7Hf.Text = obj.p7_hora_fin.ToString().Substring(0, 5);
                        }
                    }
                    else
                    {
                        rbtDia.Checked = true;

                        if (obj.sn_domingo == Estado.IdActivo)
                        {
                            chkDomingo.Checked = true;
                            cboDomHi.Text = obj.dom_hora_ini.ToString().Substring(0, 5);
                            cboDomHf.Text = obj.dom_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_lunes == Estado.IdActivo)
                        {
                            chkLunes.Checked = true;
                            cboLunHi.Text = obj.lun_hora_ini.ToString().Substring(0, 5);
                            cboLunHf.Text = obj.lun_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_martes == Estado.IdActivo)
                        {
                            chkMartes.Checked = true;
                            cboMarHi.Text = obj.mar_hora_ini.ToString().Substring(0, 5);
                            cboMarHf.Text = obj.mar_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_miercoles == Estado.IdActivo)
                        {
                            chkMiercoles.Checked = true;
                            cboMieHi.Text = obj.mie_hora_ini.ToString().Substring(0, 5);
                            cboMieHf.Text = obj.mie_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_jueves == Estado.IdActivo)
                        {
                            chkJueves.Checked = true;
                            cboJueHi.Text = obj.jue_hora_ini.ToString().Substring(0, 5);
                            cboJueHf.Text = obj.jue_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_viernes == Estado.IdActivo)
                        {
                            chkViernes.Checked = true;
                            cboVieHi.Text = obj.vie_hora_ini.ToString().Substring(0, 5);
                            cboVieHf.Text = obj.vie_hora_fin.ToString().Substring(0, 5);
                        }

                        if (obj.sn_sabado == Estado.IdActivo)
                        {
                            chkSabado.Checked = true;
                            cboSabHi.Text = obj.sab_hora_ini.ToString().Substring(0, 5);
                            cboSabHf.Text = obj.sab_hora_fin.ToString().Substring(0, 5);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }
        }

        DateTimePicker[] GetDtpPeriodos()
        {
            return new[] {  dtpP1Ini, dtpP1Fin,
                                dtpP2Ini, dtpP2Fin,
                                dtpP3Ini, dtpP3Fin,
                                dtpP4Ini, dtpP4Fin,
                                dtpP5Ini, dtpP5Fin,
                                dtpP6Ini, dtpP6Fin,
                                dtpP7Ini, dtpP7Fin };
        }

        private bool EsValido()
        {
            //Por ver - validar combos.
            bool no_error = true;
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.
            errorProv.Clear();

            #region validación de nombre (requerido)

            if (txtNombre.Text.Trim().Length == 0)
            {
                tabDescuento.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            #endregion

            #region 


            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabDescuento.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new DescuentoBL().DescuentoXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_descuento > 0)
                            {
                                tabDescuento.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_descuento > 0)
                            {
                                tabDescuento.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }

                    }
                }
            }

            #endregion

            #region validación de porcetanje y monto
            if (no_error)
            {
            //si tiene algo dentro
            if (rbtPorcentaje.Checked)
            {
                if (txtPorcentaje.Text.Trim().Length > 0)
                {
                    decimal num = 0;
                    //Es número.
                    if (!decimal.TryParse(txtPorcentaje.Text, out num))
                    {
                        tabDescuento.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtPorcentaje, "Tiene que ingresar un número.");
                        txtPorcentaje.Focus();
                        no_error = false;
                    }
                    else
                    {
                        if (!(num > 0 && num <= KeyAmounts.MaxAmount))
                        {
                            tabDescuento.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txtPorcentaje, "El porcentaje tiene que ser mayor que 0 y menor que 10000000000.");
                            txtPorcentaje.Focus();
                            no_error = false;
                        }
                    }
                }
                else
                {
                    tabDescuento.SelectedTab = tabPagGeneral;
                    errorProv.SetError(txtPorcentaje, "El porcentaje es requerido.");
                    txtPorcentaje.Focus();
                    no_error = false;
                }
            }
            else if (rbtMonto.Checked)
            {
                if (txtMonto.Text.Trim().Length > 0)
                {
                    decimal num2 = 0;
                    //Es número.
                    if (!decimal.TryParse(txtMonto.Text, out num2))
                    {
                        tabDescuento.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtMonto, "Tiene que ingresar un número.");
                        txtMonto.Focus();
                        no_error = false;
                    }
                    else
                    {
                        if (!(num2 > 0 && num2 <= KeyAmounts.MaxAmount))
                        {
                            tabDescuento.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txtMonto, "El monto tiene que ser mayor que 0 y menor que 10000000000.");
                            txtMonto.Focus();
                            no_error = false;
                        }

                    }
                }
                else
                {
                    tabDescuento.SelectedTab = tabPagGeneral;
                    errorProv.SetError(txtMonto, "El monto es requerido.");
                    txtMonto.Focus();
                    no_error = false;
                }
            }

            }

            if (no_error)
            {
                var txtsNumericos = new[] { txtMontoMin, txtMontoMax };
                foreach (var txt in txtsNumericos)
                {
                    if (txt.Text.Trim().Length > 0)
                    {
                        decimal num = 0;
                        //verificamos que un sea número. si no lo es... entonces...
                        if (!decimal.TryParse(txt.Text, out num))
                        {
                            tabDescuento.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txt, "Tiene que ingresar un número.");
                            txt.Focus();
                            no_error = false;
                            break;
                        }
                        else
                        {
                            if (!(num > 0 && num <= KeyAmounts.MaxAmount))
                            {
                                tabDescuento.SelectedTab = tabPagGeneral;
                                errorProv.SetError(txt, "El monto tiene que ser mayor que 0 y menor que 10000000000.");
                                txt.Focus();
                                no_error = false;
                                break;
                            }
                        }

                    }
                }

                if (no_error)
                {
                    decimal mtoMin = 0, mtoMax = 0;
                    //Si llego aquí ya se comprobó que si .length > 0 entonces se trata de un número que cumplió las validaciones
                    if (txtMontoMin.Text.Length > 0) mtoMin = decimal.Parse(txtMontoMin.Text);
                    if (txtMontoMax.Text.Length > 0) mtoMax = decimal.Parse(txtMontoMax.Text);
                    //Si los salarios son 0 significa que no colocaron nada
                    if (mtoMin != 0 && mtoMax != 0 && mtoMin >= mtoMax)
                    {
                        tabDescuento.SelectedTab = tabPagGeneral;
                        MessageBox.Show("El monto mínimo no puede ser mayor o igual al máximo.", "Validación Eagle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        errorProv.SetError(txtMontoMin, "El monto mínimo no puede ser mayor o igual al máximo.");
                        txtMontoMin.Focus();
                        no_error = false;
                    }
                }
            }

            #endregion

            #region validación de fechas
            //validando rango de fechas
            if (no_error)
            {
                var dtps = GetDtpPeriodos();

                var hoy = UtilBL.GetCurrentDateTime.Date;

                foreach (var dtp in dtps)
                {
                    if (dtp.CustomFormat == DateFormat.DateOnly && dtp.Value.Date < hoy)
                    {
                        tabDescuento.SelectedTab = tabPagPeriodoDia;
                        errorProv.SetError(dtp, $"La fecha tiene que ser mayor o igual a fecha actual ({hoy.ToString(DateFormat.DateOnly)}).");
                        dtp.Focus();
                        no_error = false;
                    }
                }

                if (no_error)
                {

                    if (dtpP1Ini.CustomFormat == DateFormat.DateOnly && dtpP1Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP1Ini.Value, dtpP1Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;
                            errorProv.SetError(dtpP1Ini, "La fecha inicio tiene que ser inferior a la fecha fin.");
                            errorProv.SetError(dtpP1Fin, "La fecha fin tiene que ser superior a la fecha inicio.");
                            dtpP1Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP2Ini.CustomFormat == DateFormat.DateOnly && dtpP2Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP2Ini.Value, dtpP2Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;

                            errorProv.SetError(dtpP2Ini, "La fecha inicio tiene que ser inferior a la fecha fin.");
                            errorProv.SetError(dtpP2Fin, "La fecha fin tiene que ser superior a la fecha inicio.");
                            dtpP2Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP3Ini.CustomFormat == DateFormat.DateOnly && dtpP3Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP3Ini.Value, dtpP3Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;

                            errorProv.SetError(dtpP3Ini, "La fecha inicio tiene que ser inferior a la fecha fin.");
                            errorProv.SetError(dtpP3Fin, "La fecha fin tiene que ser superior a la fecha inicio.");
                            dtpP3Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP4Ini.CustomFormat == DateFormat.DateOnly && dtpP4Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP4Ini.Value, dtpP4Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;

                            errorProv.SetError(dtpP4Ini, "La fecha inicio tiene que ser inferior a la fecha inicio.");
                            errorProv.SetError(dtpP4Fin, "La fecha fin tiene que ser superior a la fecha fin.");
                            dtpP4Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP5Ini.CustomFormat == DateFormat.DateOnly && dtpP5Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP5Ini.Value, dtpP5Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;

                            errorProv.SetError(dtpP5Ini, "La fecha inicio tiene que ser inferior a la fecha inicio.");
                            errorProv.SetError(dtpP5Fin, "La fecha fin tiene que ser superior a la fecha fin.");
                            dtpP5Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP6Ini.CustomFormat == DateFormat.DateOnly && dtpP6Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP6Ini.Value, dtpP6Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;
                            errorProv.SetError(dtpP6Ini, "La fecha inicio tiene que ser inferior a la fecha inicio.");
                            errorProv.SetError(dtpP6Fin, "La fecha fin tiene que ser superior a la fecha fin.");
                            dtpP6Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (dtpP7Ini.CustomFormat == DateFormat.DateOnly && dtpP7Fin.CustomFormat == DateFormat.DateOnly)
                    {
                        if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpP7Ini.Value, dtpP7Fin.Value)))
                        {
                            tabDescuento.SelectedTab = tabPagPeriodoDia;

                            errorProv.SetError(dtpP7Ini, "La fecha inicio tiene que ser inferior a la fecha inicio.");
                            errorProv.SetError(dtpP7Fin, "La fecha fin tiene que ser superior a la fecha fin.");
                            dtpP7Ini.Focus();
                            no_error = false;
                        }
                    }
                    if (no_error == false)
                        MessageBox.Show("La fecha inicial tiene que ser anterior y/o inferior a la fecha final.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }


            #endregion

            //Se podría validar que no tenga hijas al desactivar.

            return no_error;
        }
        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvDescuento.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvDescuento.Rows.Count > 0)
                        {
                            dgvDescuento.Rows[index].Selected = true;
                            dgvDescuento.FirstDisplayedScrollingRowIndex = index;
                        }

                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvDescuento.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvDescuento.Rows.Count > 0)
                        {
                            dgvDescuento.Rows[index].Selected = true;
                            dgvDescuento.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(int id)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvDescuento.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_descuento"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvDescuento.Rows.Count > 0)
                    {
                        dgvDescuento.Rows[index].Selected = true;
                        dgvDescuento.FirstDisplayedScrollingRowIndex = index;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarRegistro()
        {
            isPending = false;
            if (dgvDescuento.RowCount > 0 && dgvDescuento.SelectedRows.Count > 0 && dgvDescuento.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new DescuentoBL().DescuentoXId(id);
                        if (obj != null)
                        {
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
                if (dgvDescuento.SelectedRows.Count > 0 && dgvDescuento.Rows.Count > 0)
                {
                    id = dgvDescuento.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
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
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de Filtro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LimpiarForm()
        {
            isSelected = false;
            lblIdDescuento.Text = 0 + "";
            codSelected = "";

            txtNombre.Clear();
            txtCodigo.Clear();
            txtPorcentaje.Clear();
            txtMonto.Clear();
            txtMontoMin.Clear();
            txtMontoMax.Clear();

            rbtPorcentaje.Checked = true;

            rbtDia.Checked = false;
            rbtPeriodo.Checked = false;

            panelDia.Visible = false;
            panelPeriodo.Visible = false;

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            var hoy = UtilBL.GetCurrentDateTime.Date;

            DateFormat.SetFormat(new DateTimePicker[] {
                dtpP1Ini,
                dtpP1Fin,
                dtpP2Ini,
                dtpP2Fin,
                dtpP3Ini,
                dtpP3Fin,
                dtpP4Ini,
                dtpP4Fin,
                dtpP5Ini,
                dtpP5Fin,
                dtpP6Ini,
                dtpP6Fin,
                dtpP7Ini,
                dtpP7Fin
            }, DateFormat.Blank);

            dtpP1Ini.Value = hoy;
            dtpP1Fin.Value = hoy;
            dtpP2Ini.Value = hoy;
            dtpP2Fin.Value = hoy;
            dtpP3Ini.Value = hoy;
            dtpP3Fin.Value = hoy;
            dtpP4Ini.Value = hoy;
            dtpP4Fin.Value = hoy;
            dtpP5Ini.Value = hoy;
            dtpP5Fin.Value = hoy;
            dtpP6Ini.Value = hoy;
            dtpP6Fin.Value = hoy;
            dtpP7Ini.Value = hoy;
            dtpP7Fin.Value = hoy;

            if (cboP1Hi.Items.Count > 0)
                cboP1Hi.SelectedIndex = 0;
            if (cboP1Hf.Items.Count > 0)
                cboP1Hf.SelectedIndex = 0;

            if (cboP2Hi.Items.Count > 0)
                cboP2Hi.SelectedIndex = 0;
            if (cboP2Hf.Items.Count > 0)
                cboP2Hf.SelectedIndex = 0;

            if (cboP3Hi.Items.Count > 0)
                cboP3Hi.SelectedIndex = 0;
            if (cboP3Hf.Items.Count > 0)
                cboP3Hf.SelectedIndex = 0;

            if (cboP4Hi.Items.Count > 0)
                cboP4Hi.SelectedIndex = 0;
            if (cboP4Hf.Items.Count > 0)
                cboP4Hf.SelectedIndex = 0;

            if (cboP5Hi.Items.Count > 0)
                cboP5Hi.SelectedIndex = 0;
            if (cboP5Hf.Items.Count > 0)
                cboP5Hf.SelectedIndex = 0;

            if (cboP6Hi.Items.Count > 0)
                cboP6Hi.SelectedIndex = 0;
            if (cboP6Hf.Items.Count > 0)
                cboP6Hf.SelectedIndex = 0;

            if (cboP7Hi.Items.Count > 0)
                cboP7Hi.SelectedIndex = 0;
            if (cboP7Hf.Items.Count > 0)
                cboP7Hf.SelectedIndex = 0;


            cboP1Hi.Enabled = false;
            cboP1Hf.Enabled = false;

            cboP2Hi.Enabled = false;
            cboP2Hf.Enabled = false;

            cboP3Hi.Enabled = false;
            cboP3Hf.Enabled = false;

            cboP4Hi.Enabled = false;
            cboP4Hf.Enabled = false;

            cboP5Hi.Enabled = false;
            cboP5Hf.Enabled = false;

            cboP6Hi.Enabled = false;
            cboP6Hf.Enabled = false;

            cboP7Hi.Enabled = false;
            cboP7Hf.Enabled = false;

            chkDomingo.Checked = false;
            cboDomHi.Enabled = false;
            cboDomHf.Enabled = false;

            chkLunes.Checked = false;
            cboLunHi.Enabled = false;
            cboLunHf.Enabled = false;

            chkMartes.Checked = false;
            cboMarHi.Enabled = false;
            cboMarHf.Enabled = false;

            chkMiercoles.Checked = false;
            cboMieHi.Enabled = false;
            cboMieHf.Enabled = false;

            chkJueves.Checked = false;
            cboJueHi.Enabled = false;
            cboJueHf.Enabled = false;

            chkViernes.Checked = false;
            cboVieHi.Enabled = false;
            cboVieHf.Enabled = false;

            chkSabado.Checked = false;
            cboSabHi.Enabled = false;
            cboSabHf.Enabled = false;


            if (cboDomHi.Items.Count > 0)
                cboDomHi.SelectedIndex = 0;
            if (cboDomHf.Items.Count > 0)
                cboDomHf.SelectedIndex = 0;

            if (cboLunHi.Items.Count > 0)
                cboLunHi.SelectedIndex = 0;
            if (cboLunHf.Items.Count > 0)
                cboLunHf.SelectedIndex = 0;

            if (cboMarHi.Items.Count > 0)
                cboMarHi.SelectedIndex = 0;
            if (cboMarHf.Items.Count > 0)
                cboMarHf.SelectedIndex = 0;

            if (cboMieHi.Items.Count > 0)
                cboMieHi.SelectedIndex = 0;
            if (cboMieHf.Items.Count > 0)
                cboMieHf.SelectedIndex = 0;

            if (cboJueHi.Items.Count > 0)
                cboJueHi.SelectedIndex = 0;
            if (cboJueHf.Items.Count > 0)
                cboJueHf.SelectedIndex = 0;

            if (cboVieHi.Items.Count > 0)
                cboVieHi.SelectedIndex = 0;
            if (cboVieHf.Items.Count > 0)
                cboVieHf.SelectedIndex = 0;

            if (cboSabHi.Items.Count > 0)
                cboSabHi.SelectedIndex = 0;
            if (cboSabHf.Items.Count > 0)
                cboSabHf.SelectedIndex = 0;
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
                //tab
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabDescuento.SelectedTab = tabPagGeneral;
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
                        tabDescuento.SelectedTab = tabPagGeneral;
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
                            tabDescuento.SelectedTab = tabPagGeneral;
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
                                tabDescuento.SelectedTab = tabPagGeneral;
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

                                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                                        tabDescuento.SelectedTab = tabPagGeneral;

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
        private void CargarCombos()
        {
            try
            {
                //Sin lista general, dado que cambia los index para los otros combos.
                //var listaHora = new HorarioBL().ListaHorario();
                cboDomHi.DataSource = null;
                cboDomHi.DisplayMember = "hora";
                cboDomHi.ValueMember = "id_horario";
                cboDomHi.DataSource = new HorarioBL().ListaHorario();

                cboDomHf.DataSource = null;
                cboDomHf.DisplayMember = "hora";
                cboDomHf.ValueMember = "id_horario";
                cboDomHf.DataSource = new HorarioBL().ListaHorario();

                cboLunHi.DataSource = null;
                cboLunHi.DisplayMember = "hora";
                cboLunHi.ValueMember = "id_horario";
                cboLunHi.DataSource = new HorarioBL().ListaHorario();

                cboLunHf.DataSource = null;
                cboLunHf.DisplayMember = "hora";
                cboLunHf.ValueMember = "id_horario";
                cboLunHf.DataSource = new HorarioBL().ListaHorario();

                cboMarHi.DataSource = null;
                cboMarHi.DisplayMember = "hora";
                cboMarHi.ValueMember = "id_horario";
                cboMarHi.DataSource = new HorarioBL().ListaHorario();

                cboMarHf.DataSource = null;
                cboMarHf.DisplayMember = "hora";
                cboMarHf.ValueMember = "id_horario";
                cboMarHf.DataSource = new HorarioBL().ListaHorario();

                cboMieHi.DataSource = null;
                cboMieHi.DisplayMember = "hora";
                cboMieHi.ValueMember = "id_horario";
                cboMieHi.DataSource = new HorarioBL().ListaHorario();

                cboMieHf.DataSource = null;
                cboMieHf.DisplayMember = "hora";
                cboMieHf.ValueMember = "id_horario";
                cboMieHf.DataSource = new HorarioBL().ListaHorario();

                cboJueHi.DataSource = null;
                cboJueHi.DisplayMember = "hora";
                cboJueHi.ValueMember = "id_horario";
                cboJueHi.DataSource = new HorarioBL().ListaHorario();

                cboJueHf.DataSource = null;
                cboJueHf.DisplayMember = "hora";
                cboJueHf.ValueMember = "id_horario";
                cboJueHf.DataSource = new HorarioBL().ListaHorario();

                cboVieHi.DataSource = null;
                cboVieHi.DisplayMember = "hora";
                cboVieHi.ValueMember = "id_horario";
                cboVieHi.DataSource = new HorarioBL().ListaHorario();

                cboVieHf.DataSource = null;
                cboVieHf.DisplayMember = "hora";
                cboVieHf.ValueMember = "id_horario";
                cboVieHf.DataSource = new HorarioBL().ListaHorario();

                cboSabHi.DataSource = null;
                cboSabHi.DisplayMember = "hora";
                cboSabHi.ValueMember = "id_horario";
                cboSabHi.DataSource = new HorarioBL().ListaHorario();

                cboSabHf.DataSource = null;
                cboSabHf.DisplayMember = "hora";
                cboSabHf.ValueMember = "id_horario";
                cboSabHf.DataSource = new HorarioBL().ListaHorario();

                cboP1Hi.DataSource = null;
                cboP1Hi.DisplayMember = "hora";
                cboP1Hi.ValueMember = "id_horario";
                cboP1Hi.DataSource = new HorarioBL().ListaHorario();

                cboP1Hf.DataSource = null;
                cboP1Hf.DisplayMember = "hora";
                cboP1Hf.ValueMember = "id_horario";
                cboP1Hf.DataSource = new HorarioBL().ListaHorario();

                cboP2Hi.DataSource = null;
                cboP2Hi.DisplayMember = "hora";
                cboP2Hi.ValueMember = "id_horario";
                cboP2Hi.DataSource = new HorarioBL().ListaHorario();

                cboP2Hf.DataSource = null;
                cboP2Hf.DisplayMember = "hora";
                cboP2Hf.ValueMember = "id_horario";
                cboP2Hf.DataSource = new HorarioBL().ListaHorario();

                cboP3Hi.DataSource = null;
                cboP3Hi.DisplayMember = "hora";
                cboP3Hi.ValueMember = "id_horario";
                cboP3Hi.DataSource = new HorarioBL().ListaHorario();

                cboP3Hf.DataSource = null;
                cboP3Hf.DisplayMember = "hora";
                cboP3Hf.ValueMember = "id_horario";
                cboP3Hf.DataSource = new HorarioBL().ListaHorario();

                cboP4Hi.DataSource = null;
                cboP4Hi.DisplayMember = "hora";
                cboP4Hi.ValueMember = "id_horario";
                cboP4Hi.DataSource = new HorarioBL().ListaHorario();

                cboP4Hf.DataSource = null;
                cboP4Hf.DisplayMember = "hora";
                cboP4Hf.ValueMember = "id_horario";
                cboP4Hf.DataSource = new HorarioBL().ListaHorario();

                cboP5Hi.DataSource = null;
                cboP5Hi.DisplayMember = "hora";
                cboP5Hi.ValueMember = "id_horario";
                cboP5Hi.DataSource = new HorarioBL().ListaHorario();

                cboP5Hf.DataSource = null;
                cboP5Hf.DisplayMember = "hora";
                cboP5Hf.ValueMember = "id_horario";
                cboP5Hf.DataSource = new HorarioBL().ListaHorario();

                cboP6Hi.DataSource = null;
                cboP6Hi.DisplayMember = "hora";
                cboP6Hi.ValueMember = "id_horario";
                cboP6Hi.DataSource = new HorarioBL().ListaHorario();

                cboP6Hf.DataSource = null;
                cboP6Hf.DisplayMember = "hora";
                cboP6Hf.ValueMember = "id_horario";
                cboP6Hf.DataSource = new HorarioBL().ListaHorario();

                cboP7Hi.DataSource = null;
                cboP7Hi.DisplayMember = "hora";
                cboP7Hi.ValueMember = "id_horario";
                cboP7Hi.DataSource = new HorarioBL().ListaHorario();

                cboP7Hf.DataSource = null;
                cboP7Hf.DisplayMember = "hora";
                cboP7Hf.ValueMember = "id_horario";
                cboP7Hf.DataSource = new HorarioBL().ListaHorario();
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
                var lista = new DescuentoBL().ListaDescuento(id_estado);

                var listaView = lista.Select(x => new { x.id_descuento, CODIGO = x.cod_descuento, NOMBRE = x.txt_desc })
                    .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvDescuento.DataSource = listaView;
                    dgvDescuento.Columns["id_descuento"].Visible = false;
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
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }
        private void ConfigurarGrilla()
        {
            dgvDescuento.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvDescuento.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvDescuento.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvDescuento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvDescuento.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvDescuento.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvDescuento.AllowUserToResizeColumns = true;
            dgvDescuento.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvDescuento.Columns["CODIGO"].Width = 100;
            dgvDescuento.Columns["NOMBRE"].Width = 300;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 100;
            txtPorcentaje.MaxLength = 19;
            txtMonto.MaxLength = 19;
            txtMontoMin.MaxLength = 19;
            txtMontoMax.MaxLength = 19;
        }
        private void ContarEstados(List<MSTt02_descuento> lista)
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
        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        #endregion

        #region Eventos de ventana

        private void FormDescuento_Load(object sender, EventArgs e)
        {
            lblIdDescuento.Visible = false;
            SetMaxLengthTxt();
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

        private void rbtPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPeriodo.Checked)
            { panelPeriodo.Visible = true; panelDia.Visible = false; }
            else if (rbtDia.Checked)
            { panelDia.Visible = true; panelPeriodo.Visible = false; }

        }

        private void rbtDia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDia.Checked)
            { panelDia.Visible = true; panelPeriodo.Visible = false; }
            else if (rbtDia.Checked)
            { panelPeriodo.Visible = true; panelDia.Visible = false; }
        }

        private void chkDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDomingo.Checked)
            {
                cboDomHi.Enabled = true;
                cboDomHf.Enabled = true;
            }
            else
            {
                cboDomHi.Enabled = false;
                cboDomHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLunes.Checked)
            {
                cboLunHi.Enabled = true;
                cboLunHf.Enabled = true;
            }
            else
            {
                cboLunHi.Enabled = false;
                cboLunHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMartes.Checked)
            {
                cboMarHi.Enabled = true;
                cboMarHf.Enabled = true;
            }
            else
            {
                cboMarHi.Enabled = false;
                cboMarHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiercoles.Checked)
            {
                cboMieHi.Enabled = true;
                cboMieHf.Enabled = true;
            }
            else
            {
                cboMieHi.Enabled = false;
                cboMieHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJueves.Checked)
            {
                cboJueHi.Enabled = true;
                cboJueHf.Enabled = true;
            }
            else
            {
                cboJueHi.Enabled = false;
                cboJueHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViernes.Checked)
            {
                cboVieHi.Enabled = true;
                cboVieHf.Enabled = true;
            }
            else
            {
                cboVieHi.Enabled = false;
                cboVieHf.Enabled = false;
            }
            isChangedRow = false;
        }

        private void chkSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSabado.Checked)
            {
                cboSabHi.Enabled = true;
                cboSabHf.Enabled = true;
            }
            else
            {
                cboSabHi.Enabled = false;
                cboSabHf.Enabled = false;
            }
            isChangedRow = false;
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

        private void dgvDescuento_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdDescuento.Text && idSelect != "-1")
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
                    if (idSelect != lblIdDescuento.Text && idSelect != "-1")
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

        private void ToggleHoraInicioFin(DateTimePicker dtp, bool enabled)
        {
            var name = dtp.Name;
            var cboHi = new ComboBox();
            var cboHf = new ComboBox();
            var dtpIni = new DateTimePicker();
            var dtpFin = new DateTimePicker();

            if (dtpP1Ini.Name == name || dtpP1Fin.Name == name)
            {
                cboHi = cboP1Hi;
                cboHf = cboP1Hf;
                dtpIni = dtpP1Ini;
                dtpFin = dtpP1Fin;
            }
            else if (dtpP2Ini.Name == name || dtpP2Fin.Name == name)
            {
                cboHi = cboP2Hi;
                cboHf = cboP2Hf;
                dtpIni = dtpP2Ini;
                dtpFin = dtpP2Fin;
            }
            else if (dtpP3Ini.Name == name || dtpP3Fin.Name == name)
            {
                cboHi = cboP3Hi;
                cboHf = cboP3Hf;
                dtpIni = dtpP3Ini;
                dtpFin = dtpP3Fin;
            }
            else if (dtpP4Ini.Name == name || dtpP4Fin.Name == name)
            {
                cboHi = cboP4Hi;
                cboHf = cboP4Hf;
                dtpIni = dtpP4Ini;
                dtpFin = dtpP4Fin;
            }
            else if (dtpP5Ini.Name == name || dtpP5Fin.Name == name)
            {
                cboHi = cboP5Hi;
                cboHf = cboP5Hf;
                dtpIni = dtpP5Ini;
                dtpFin = dtpP5Fin;
            }
            else if (dtpP6Ini.Name == name || dtpP6Fin.Name == name)
            {
                cboHi = cboP6Hi;
                cboHf = cboP6Hf;
                dtpIni = dtpP6Ini;
                dtpFin = dtpP6Fin;
            }
            else if (dtpP7Ini.Name == name || dtpP7Fin.Name == name)
            {
                cboHi = cboP7Hi;
                cboHf = cboP7Hf;
                dtpIni = dtpP7Ini;
                dtpFin = dtpP7Fin;
            }

            if (enabled)
            {
                cboHi.Enabled = enabled;
                cboHf.Enabled = enabled;
            }
            else if (dtpIni.CustomFormat != DateFormat.DateOnly && dtpFin.CustomFormat != DateFormat.DateOnly)
            {
                cboHi.Enabled = false;
                cboHf.Enabled = false;

                if (cboHi.Items.Count > 0)
                    cboHi.SelectedIndex = 0;
                if (cboHf.Items.Count > 0)
                    cboHf.SelectedIndex = 0;
            }
        }

        #region Close Up


        private void DtpLimpiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (e.KeyChar == (char)Keys.Escape && dtp.CustomFormat != DateFormat.Blank)
            {
                DateFormat.SetFormat(dtp, DateFormat.Blank);
                ToggleHoraInicioFin(dtp, false);
                isChangedRow = false;
            }
        }

        private void DtpVer_MouseDown(object sender, MouseEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                ToggleHoraInicioFin(dtp, true);
                isChangedRow = false;
            }
        }

        private void dtpVer_CloseUp(object sender, EventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                ToggleHoraInicioFin(dtp, true);
                isChangedRow = false;
            }
        }

        #endregion

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

        private void rbtMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMonto.Checked)
            {
                EnableTxtMtoAndPorc(true, false);
                CleanTxtMtoAndPorc(false);
            }
            isChangedRow = false;
        }

        private void rbtMontoAbierto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMontoAbierto.Checked)
            {
                EnableTxtMtoAndPorc(false, false);
                CleanTxtMtoAndPorc();
            }
            isChangedRow = false;
        }

        private void rbtPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPorcentaje.Checked)
            {
                EnableTxtMtoAndPorc(false);
                CleanTxtMtoAndPorc(true, false);
            }
            isChangedRow = false;
        }

        private void rbtPorcentajeAbierto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPorcentajeAbierto.Checked)
            {
                EnableTxtMtoAndPorc(false, false);
                CleanTxtMtoAndPorc();
            }
            isChangedRow = false;
        }

        private void rbtPorcentaje_Click(object sender, EventArgs e)
        {
            txtPorcentaje.Focus();
            errorProv.SetError(txtMonto, string.Empty);
        }

        private void rbtPorcentajeAbierto_Click(object sender, EventArgs e)
        {
            txtMontoMin.Focus();
            errorProv.SetError(txtMonto, string.Empty);
            errorProv.SetError(txtPorcentaje, string.Empty);
        }

        private void rbtMonto_Click(object sender, EventArgs e)
        {
            txtMonto.Focus();
            errorProv.SetError(txtPorcentaje, string.Empty);
        }

        private void rbtMontoAbierto_Click(object sender, EventArgs e)
        {
            txtMontoMin.Focus();
            errorProv.SetError(txtMonto, string.Empty);
            errorProv.SetError(txtPorcentaje, string.Empty);
        }

        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }



        #endregion
    }
}
