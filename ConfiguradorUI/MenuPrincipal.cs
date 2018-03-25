using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.General;
using ConfiguradorUI.Labor;
using ConfiguradorUI.Maestro;
using ConfiguradorUI.Persona;
using ConfiguradorUI.Producto;
using ConfiguradorUI.Reporte;
using ConfiguradorUI.Seguridad;
using ConfigUtilitarios;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace ConfiguradorUI
{
    public partial class MenuPrincipal : MetroForm
    {

        #region Variables

        long idEmpleado = 0;
        string username = "";
        string strCodLocation = "";
        bool closeWindows = false;
        PERt04_empleado oEmpleado = new PERt04_empleado();
        #endregion

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        #region Métodos Menú principal

        private void RunTimer()
        {
            dtpFechaCronologia.Visible = false;
            string txtFecha = dtpFechaCronologia.Value.ToLongDateString();
            toolStripFechaCronologica.Text = txtFecha;
            timerHora.Enabled = true;
        }

        private void ConfigurarControles()
        {
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            NombreUsuario();
            RunTimer();
            btnPrecio.Enabled = false;
            btnReceta.Enabled = false;
            btnParametro.Visible = false;
        }

        private void NombreUsuario()
        {
            toolStripUsername.Text = $"Usuario: {username}";
        }

        private void AsignarImagenHeader()
        {

            var parametroImg = new ParametroBL().ParametroXCod(ParameterCode.LogoImg);
            Parameter.CargarParametroImg(parametroImg, picLogo, ParameterCode.LogoImg);
        }


        #endregion

        #region Eventos Menú Principal

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                var oFormLogin = new FormLogin();
                //Al cerrar el form de conexión(no existoso) error 
                //No se puede acceder a un elemento desechado
                oFormLogin.ShowDialog();

                if (oFormLogin.result)
                {
                    AsignarImagenHeader();
                    idEmpleado = oFormLogin.usuarioLogin.id_empleado;
                    username = oFormLogin.usuarioLogin.txt_usuario;
                    ConfigurarControles();

                    #region log bienvenida

                    var oLog = new Log();
                    oLog.ArchiveLog("Abrir Aplicativo", "Se abrió el aplicativo. Usuario: " + username);

                    #endregion

                    closeWindows = false;
                }
                else
                {
                    closeWindows = true;
                    Application.Exit();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Excepción en load del Menú Principal. " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            toolStripHora.Text = $"{ DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (closeWindows)
                {
                    var oLog = new Log();
                    oLog.ArchiveLog("Cerrar Login", "Cerró desde el login. No ingresó al aplicativo.");
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro de salir del aplicativo?", "Información SysCorp Eagle ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        var oLog = new Log();
                        oLog.ArchiveLog("Cerrar Aplicativo", "Se cerró el aplicativo. Usuario: " + username);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Excepción en el evento FormClosing. " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void lnkConnection_Click(object sender, EventArgs e)
        {
            var frm = new FormConnection();
            frm.ShowDialog();
        }

        private void lnkBackup_Click(object sender, EventArgs e)
        {
            var frm = new FormBackupRestore();
            frm.ShowDialog();
        }

        private void lnkConfiguracion_Click(object sender, EventArgs e)
        {
            var frm = new FormConfiguracion();
            frm.ShowDialog();
            if (frm.changedLogo)
            {
                AsignarImagenHeader();
            }
        }
        #endregion

        #region Eventos tab

        #region Eventos TabPag Producto

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto oFrmProducto = new FormProducto();
            oFrmProducto.ShowDialog();
        }

        private void btnSubFamilia_Click(object sender, EventArgs e)
        {
            FormSubFamilia oForm = new FormSubFamilia();
            oForm.ShowDialog();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            FormFamilia oForm = new FormFamilia();
            oForm.ShowDialog();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            FormModelo oForm = new FormModelo();
            oForm.ShowDialog();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FormMarca oForm = new FormMarca();
            oForm.ShowDialog();
        }

        private void btnClaseProducto_Click(object sender, EventArgs e)
        {
            FormClase oForm = new FormClase();
            oForm.ShowDialog();
        }

        private void btnGrupoProducto_Click(object sender, EventArgs e)
        {
            FormGrupo oForm = new FormGrupo();
            oForm.ShowDialog();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            FormTipoProd oForm = new FormTipoProd();
            oForm.ShowDialog();
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {

        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            var form = new FormCombo();
            form.ShowDialog();
        }

        private void btnComboVariable_Click(object sender, EventArgs e)
        {
            var form = new FormComboVariable();
            form.ShowDialog();
        }

        private void btnComboGrupo_Click(object sender, EventArgs e)
        {
            var form = new FormComboGrupo();
            form.ShowDialog();
        }

        #endregion

        #region Eventos TabPag Persona

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FormEmpleado oForm = new FormEmpleado();
            oForm.ShowDialog();
        }

        private void btnCategoriaEmp_Click(object sender, EventArgs e)
        {
            var form = new FormCategoriaEmp();
            form.ShowDialog();
        }

        private void btnClaseEmp_Click(object sender, EventArgs e)
        {
            var form = new FormClaseEmp();
            form.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor oForm = new FormProveedor();
            oForm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente oForm = new FormCliente();
            oForm.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario oForm = new FormUsuario();
            oForm.ShowDialog();
        }
        #endregion

        #region Eventos TabPag Maestro

        private void btnMedioPago_Click(object sender, EventArgs e)
        {
            FormMedioPago oForm = new FormMedioPago();
            oForm.ShowDialog();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            FormDescuento oForm = new FormDescuento();
            oForm.ShowDialog();
        }

        private void btnTipoOrden_Click(object sender, EventArgs e)
        {
            FormTipoOrden oForm = new FormTipoOrden();
            oForm.ShowDialog();
        }

        private void btnCanalVenta_Click(object sender, EventArgs e)
        {
            FormCanalVenta oForm = new FormCanalVenta();
            oForm.ShowDialog();
        }

        private void btnRazon_Click(object sender, EventArgs e)
        {
            FormRazon oForm = new FormRazon();
            oForm.ShowDialog();
        }

        private void btnImpuesto_Click(object sender, EventArgs e)
        {
            FormImpuesto oForm = new FormImpuesto();
            oForm.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FormLocation oForm = new FormLocation();
            oForm.ShowDialog();
        }

        private void btnTipoLocation_Click(object sender, EventArgs e)
        {
            FormTipoLocation oForm = new FormTipoLocation();
            oForm.ShowDialog();
        }

        private void btnTipoImpresora_Click(object sender, EventArgs e)
        {
            FormTipoImpresora oForm = new FormTipoImpresora();
            oForm.ShowDialog();
        }
        private void btnImpresora_Click(object sender, EventArgs e)
        {
            FormImpresora oForm = new FormImpresora();
            oForm.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            FormCaja oForm = new FormCaja();
            oForm.ShowDialog();
        }
        private void btnMesa_Click(object sender, EventArgs e)
        {
            var form = new FormMesa();
            form.ShowDialog();
        }

        private void btnEstadoMesa_Click(object sender, EventArgs e)
        {
            var form = new FormEstadoMesa();
            form.ShowDialog();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            var form = new FormTurno();
            form.ShowDialog();
        }


        private void btnTipoRazon_Click(object sender, EventArgs e)
        {
            var form = new FormTipoRazon();
            form.ShowDialog();
        }

        private void btnParametro_Click(object sender, EventArgs e)
        {
            FormParametro oForm = new FormParametro();
            oForm.ShowDialog();

            if (true)
                AsignarImagenHeader();
        }

        #endregion

        #region Eventos TabPag Reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte oForm = new FormReporte();
            oForm.ShowDialog();
        }

        private void btnCategoriaReporte_Click(object sender, EventArgs e)
        {

            FormCategoriaReporte oForm = new FormCategoriaReporte();
            oForm.ShowDialog();
        }

        #endregion

        #region TabPag Labor

        private void btnHorario_Click(object sender, EventArgs e)
        {
            var form = new FormHorarioEmpleado();
            form.ShowDialog();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            FormTrabajo oForm = new FormTrabajo();
            oForm.ShowDialog();
        }

        #endregion

        #endregion
    }
}
