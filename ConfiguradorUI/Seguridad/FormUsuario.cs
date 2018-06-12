using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Persona;
using ConfigBusinessLogic.Seguridad;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.HelperGeneric;
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

namespace ConfiguradorUI.Seguridad
{
    public partial class FormUsuario : MetroForm
    {

        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        //para que al actualizar no se pierda la clave
        private PERt01_usuario usuarioSelected = null;

        #endregion

        public FormUsuario()
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
            var txts = new[] {
                txtCodigo,
                txtIdPassword
            };

            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }

            chkActivo.CheckedChanged += new EventHandler(OnContentChanged);

            txtIdPassword.KeyPress += ControlHelper.TxtValidInteger;

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
                if (dgvUsuario.RowCount > 0)
                {
                    if (dgvUsuario.SelectedRows.Count > 0)
                    {
                        try
                        {
                            long id = 0;
                            if (long.TryParse(lblIdUsuario.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {

                                    new UsuarioBL().EliminarUsuario(id);
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
                        var obj = new PERt01_usuario();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdUsuario.Text, out id))
                        {
                            obj.id_usuario = id;
                            obj.fecha_modificacion = UtilBL.GetCurrentDateTime;
                            new UsuarioBL().ActualizarUsuario(obj);

                            ControlarEventosABM(obj.id_usuario);
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
                        var obj = new PERt01_usuario();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdUsuario.Text, out id))
                        {
                            obj.id_usuario = id;
                            obj.fecha_modificacion = DateTime.Now;
                            new UsuarioBL().ActualizarUsuario(obj);
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
        private void EnviarCredenciales()
        {
            string emailFrom = Parameter.EmailFrom;
            string password = Parameter.Password;
            if (!string.IsNullOrEmpty(emailFrom) && !string.IsNullOrEmpty(password))
            {
                var empleado = new EmpleadoBL().EmpleadoXId(usuarioSelected.id_empleado);
                if (empleado != null && empleado.id_empleado > 0)
                {
                    if (empleado.txt_email1.Length > 0 || empleado.txt_email2.Length > 0)
                    {
                        bool enviado = false;
                        string body = new UsuarioBL().ArmarMsjCredenciales(usuarioSelected, empleado, ParameterCode.SubjectCredentials);
                        if (empleado.txt_email1.Length > 0)
                        {
                            enviado = new Email().SendEmail(emailFrom, password, Parameter.DisplayNameEmail, empleado.txt_email1, Parameter.SubjectCredentials, body, Parameter.MailServer, Parameter.Port);
                            if (enviado)
                                MessageBox.Show($"Las credenciales han sido enviadas al email: {empleado.txt_email1}.", "AVISO EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (empleado.txt_email2.Length > 0)
                        {
                            enviado = new Email().SendEmail(emailFrom, password, Parameter.DisplayNameEmail, empleado.txt_email2, Parameter.SubjectCredentials, body, Parameter.MailServer, Parameter.Port);
                            if (enviado)
                                MessageBox.Show($"Las credenciales han sido enviadas al email: {empleado.txt_email2}.", "AVISO EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (!enviado)
                            MessageBox.Show($"No se pudo enviar las credenciales a su email.", "AVISO EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("El empleado no tiene ningún email registrado.", "AVISO EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El empleado no tiene ningún email registrado.", "AVISO EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"No se envío el correo electronico. Deberá asignar valores a los parámetros {ParameterCode.EmailFrom} y {ParameterCode.Password}.", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private PERt01_usuario GetObjeto()
        {
            var obj = new PERt01_usuario();
            try
            {
                obj.txt_usuario = txtUsuario.Text.Trim();
                obj.cod_usuario = txtCodigo.Text.Trim();


                obj.txt_clave = usuarioSelected.txt_clave;
                obj.sn_upd_requered = usuarioSelected.sn_upd_requered;

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                if (usuarioSelected.id_empleado != 0)
                    obj.id_empleado = usuarioSelected.id_empleado;


                if (long.TryParse(txtIdPassword.Text.Trim(), out long idPasswordPosible) && idPasswordPosible >= 0)
                {
                    obj.id_password = idPasswordPosible;
                }
                else
                {
                    obj.id_password = null;
                }
                //De cumplir la condición lo guardaría con 0 generaría un error.
                //Puede en estos casos guardar con el id del registro vacío u otros(opción).
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(PERt01_usuario obj)
        {
            try
            {
                // Variable de la lógica de cambio.
                // Indica que la asignación de los datos de un reg se está dando
                // porque se cambió de fila.
                isChangedRow = true;
                LimpiarForm();

                usuarioSelected = obj;

                chkActivo.Checked = obj.id_estado == Estado.IdActivo ? true : false;

                lblIdUsuario.Text = obj.id_usuario.ToString();

                txtUsuario.Text = obj.txt_usuario;
                txtCodigo.Text = obj.cod_usuario;

                if (usuarioSelected.id_empleado != 0)
                {
                    long idEmp = usuarioSelected.id_empleado;
                    var emp = new EmpleadoBL().EmpleadoXIdMM(idEmp);
                    if (emp != null && emp.id_empleado > 0)
                    {
                        string nombreCompleto = Human.Nombre(emp.txt_ape_pat, emp.txt_pri_nom, emp.txt_ape_mat, emp.txt_seg_nom, emp.txt_rzn_social);
                        txtNombreEmpleado.Text = nombreCompleto.ToUpper();
                    }
                }

                txtIdPassword.Text = obj.id_password?.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }
        }

        private bool EsValido()
        {
            //Por ver - validar combos.
            errorProv.Clear();
            bool no_error = true;
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                tabUsuario.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtUsuario, "Este campo es requerido.");
                txtUsuario.Focus();
                no_error = false;
            }

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var usuario = new UsuarioBL().UsuarioXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (usuario != null && usuario.id_usuario > 0)
                        {
                            tabUsuario.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != usuarioSelected.cod_usuario && usuario != null && usuario.id_usuario > 0)
                        {
                            tabUsuario.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            if (no_error == true)
            {
                //validamos el que no tenga espacios en blanco
                if (txtUsuario.Text.Trim().Contains(" "))
                {
                    tabUsuario.SelectedTab = tabPagGeneral;
                    errorProv.SetError(txtUsuario, "El nombre de usuario no debe tener espacios en blanco.");
                    txtUsuario.Focus();
                    MessageBox.Show("El nombre de usuario no debe tener espacios en blanco.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    no_error = false;
                }
            }

            #region lógica de validación cuando se habilite la opción de agregar
            //if (no_error == true)
            //{
            //    //validamos el largo min
            //    if (txtUsuario.Text.Trim().Length < 6)
            //    {
            //        tabUsuario.SelectedTab = tabPagGeneral;
            //        errorProv.SetError(txtUsuario, "El usuario debe tener mínimamente 6 carácteres.");
            //        txtUsuario.Focus();
            //        MessageBox.Show("El nombre de usuario debe tener mínimimamente 6 carácteres.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        no_error = false;
            //    }
            //}

            //if (no_error == true)
            //{
            //    var usuario = new UsuarioBL().UsuarioXUsername(txtUsuario.Text.Trim());
            //    //validamos que el usuario este disponible.

            //    if (TipoOperacion == TipoOperacionABM.Insertar)
            //    {

            //        if (usuario != null)
            //        {
            //            tabUsuario.SelectedTab = tabPagGeneral;
            //            errorProv.SetError(txtUsuario, "El usuario ya existe");
            //            txtUsuario.Focus();
            //            MessageBox.Show("El nombre de usuario ya existe.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            no_error = false;

            //        }
            //    }
            //    else if(TipoOperacion == TipoOperacionABM.Modificar)
            //    {
            //        //dos casos
            //        //1. Cambio el username
            //        //2. No cambió el username

            //        if (usuario != null)
            //        {
            //            if (lblUsername.Text!=txtUsuario.Text.Trim())
            //            {
            //                tabUsuario.SelectedTab = tabPagGeneral;
            //                errorProv.SetError(txtUsuario, "El usuario ya existe");
            //                txtUsuario.Focus();
            //                MessageBox.Show("El nombre de usuario ya existe.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                no_error = false;
            //            }

            //        }
            //    }
            //}

            #endregion


            #region Valid ID password único
            if (no_error)
            {
                var txtValorIdPassword = txtIdPassword.Text.Trim();
                if (txtValorIdPassword != "")
                {
                    if (long.TryParse(txtValorIdPassword, out long idPassword))
                    {
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (!new UsuarioBL().EsValidoIDPassword(null, idPassword))
                            {
                                Msg.Ok_Wng("El ID Password ya existe.");
                                tabUsuario.SelectedTab = tabPagGeneral;
                                errorProv.SetError(txtIdPassword, "El ID Password ya existe.");
                                txtIdPassword.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (long.TryParse(lblIdUsuario.Text, out long idUsuarioActual) && idUsuarioActual > 0)
                            {
                                if (!new UsuarioBL().EsValidoIDPassword(idUsuarioActual, idPassword))
                                {
                                    Msg.Ok_Wng("El ID Password ya existe.");
                                    tabUsuario.SelectedTab = tabPagGeneral;
                                    errorProv.SetError(txtIdPassword, "El ID Password ya existe.");
                                    txtIdPassword.Focus();
                                    no_error = false;
                                }
                            }
                            else
                            {
                                Msg.Ok_Wng("No se pudo obtener el ID del usuario para validar su ID Password.");
                                tabUsuario.SelectedTab = tabPagGeneral;
                                errorProv.SetError(txtIdPassword, "No se puede validar el ID password.");
                                txtIdPassword.Focus();
                                no_error = false;
                            }
                        }
                    }
                    else
                    {
                        tabUsuario.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtIdPassword, "Debe ser un número entero.");
                        txtIdPassword.Focus();
                        no_error = false;
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
                    DataGridViewRow row = dgvUsuario.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvUsuario.Rows.Count > 0)
                        {
                            dgvUsuario.Rows[index].Selected = true;
                            dgvUsuario.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvUsuario.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvUsuario.Rows.Count > 0)
                        {
                            dgvUsuario.Rows[index].Selected = true;
                            dgvUsuario.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(long id)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvUsuario.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_usuario"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvUsuario.Rows.Count > 0)
                    {
                        dgvUsuario.Rows[index].Selected = true;
                        dgvUsuario.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvUsuario.RowCount > 0 && dgvUsuario.SelectedRows.Count > 0 && dgvUsuario.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new UsuarioBL().UsuarioXId(id);
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
                if (dgvUsuario.SelectedRows.Count > 0 && dgvUsuario.Rows.Count > 0)
                {
                    id = dgvUsuario.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }
        private void CambiarContrasena()
        {
            if (long.TryParse(lblIdUsuario.Text, out long idUsuario) && idUsuario > 0)
            {
                var usuario = new UsuarioBL().UsuarioXId(idUsuario);
                if (usuario != null && usuario.id_usuario > 0)
                {
                    var frm = new FormCambiarClave(usuario);
                    frm.ShowDialog();
                }
                else
                {
                    Msg.Ok_Wng("No se ha encontrado al usuario seleccionado.");
                }
            }
            else
            {
                Msg.Ok_Wng("No ha seleccionado a ningún usuario.");
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
            usuarioSelected = null;
            lblIdUsuario.Text = 0 + "";
            txtUsuario.Clear();
            txtCodigo.Clear();
            txtIdPassword.Clear();
            txtNombreEmpleado.Clear();


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
                ControlarBotones(false, true, false, false, true, true);
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
                    tabUsuario.SelectedTab = tabPagGeneral;
                    txtUsuario.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(false, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        tabUsuario.SelectedTab = tabPagGeneral;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        //Después de hacer commit-eliminar
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(false, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
                            tabUsuario.SelectedTab = tabPagGeneral;
                            btnNuevo.Focus();
                        }
                        else
                        {
                            if (TipoOperacion == TipoOperacionABM.Rollback)
                            {
                                ControlarBotones(false, true, false, false, true, true);
                                isPending = false;
                                errorProv.Clear();
                                LimpiarForm();
                                SeleccionarRegistro();
                                tabUsuario.SelectedTab = tabPagGeneral;
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
                                        ControlarBotones(false, true, false, false, true, true);
                                        isSelected = false;
                                        isPending = false;
                                        isChangedRow = false;

                                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                                        tabUsuario.SelectedTab = tabPagGeneral;

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
                var lista = new UsuarioBL().ListaUsuario(id_estado, true);
                var listaView = lista.Select(x => new { x.id_usuario, CODIGO = x.cod_usuario, NOMBRE = x.txt_usuario })
                .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvUsuario.DataSource = listaView;
                    dgvUsuario.Columns["id_usuario"].Visible = false;
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
            dgvUsuario.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvUsuario.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvUsuario.AllowUserToResizeColumns = true;
            dgvUsuario.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvUsuario.Columns["CODIGO"].Width = 100;
            dgvUsuario.Columns["NOMBRE"].Width = 300;
        }
        private void SetMaxLengthTxt()
        {
            txtUsuario.Enabled = false;
            txtNombreEmpleado.Enabled = false;
            txtCodigo.MaxLength = 10;
            txtIdPassword.MaxLength = 10;
            //este es por siacaso porque en realidad 
            //el txt usuario es solo de lectura.
            txtUsuario.MaxLength = 20;

        }
        private void ContarEstados(List<PERt01_usuario> lista)
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

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            lblIdUsuario.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
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

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdUsuario.Text && idSelect != "-1")
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
                    if (idSelect != lblIdUsuario.Text && idSelect != "-1")
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

        private void btnEnviarCredenciales_Click(object sender, EventArgs e)
        {

            if (usuarioSelected != null && usuarioSelected.id_usuario > 0)
            {
                try
                {
                    using (new CursorWait())
                    {
                        EnviarCredenciales();
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Ocurrió una excepción al enviar las credenciales: " + exe.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario a quién desea enviar las credenciles.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            CambiarContrasena();
        }
        #endregion

    }
}
