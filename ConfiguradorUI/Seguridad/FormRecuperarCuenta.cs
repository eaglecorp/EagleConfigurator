using ConfigBusinessLogic.Persona;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ConfigBusinessEntity;
using ConfigBusinessLogic.Seguridad;
using ConfigBusinessLogic.General;
using ConfigBusinessLogic;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormRecuperarCuenta : MetroForm
    {


        public FormRecuperarCuenta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private string Nombre(string apPaterno, string apMaterno, string primerNom, string segundoNom, string rznSocial)
        {
            string nombre = "";
            if (apPaterno != null && apPaterno.Trim() != "")
            {
                nombre = apPaterno + " ";
            }
            if (apMaterno != null && apMaterno.Trim() != "")
            {
                nombre += apMaterno + " ";
            }
            if (primerNom != null && primerNom.Trim() != "")
            {
                nombre += primerNom + " ";
            }
            if (segundoNom != null && segundoNom.Trim() != "")
            {
                nombre += segundoNom + " ";
            }
            if (rznSocial != null && rznSocial.Trim() != "")
            {
                if (nombre.Length > 0)
                {
                    nombre += "| " + rznSocial;
                }
                else
                {
                    nombre = rznSocial;
                }
            }
            return nombre.ToUpper();
        }

        private void EnviarEmail()
        {
            string email = txtEmail.Text.Trim();
            try
            {
                if (Validation.EsEmail(email))
                {
                    string emailFrom = Parameter.EmailFrom;
                    string password = Parameter.Password;
                    if (!string.IsNullOrEmpty(emailFrom) && !string.IsNullOrEmpty(password))
                    {
                        var empleado = new EmpleadoBL().EmpleadoXEmail(email);
                        if (empleado != null && empleado.id_empleado > 0)
                        {
                            var usuario = new UsuarioBL().UsuarioXEmpleado(empleado.id_empleado);
                            if (usuario != null && usuario.id_usuario > 0)
                            {
                                if (usuario.id_estado == Estado.IdActivo)
                                {
                                    bool enviado = false;
                                    string body = new UsuarioBL().ArmarMsjCredenciales(usuario, empleado, ParameterCode.SubjectCredentials);
                                    enviado = new Email().SendEmail(emailFrom, password, Parameter.DisplayNameEmail, email, Parameter.SubjectCredentials, body, Parameter.MailServer, Parameter.Port);

                                    if (enviado)
                                        MessageBox.Show("Se ha enviado las credenciales a su email.", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else
                                        MessageBox.Show("No se pudo enviar las credenciales a su email.", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    if (enviado)
                                    { Hide(); Close(); }
                                }
                                else
                                {
                                    MessageBox.Show("No se le puede enviar el correo electrónico porque el usuario está deshabilitado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show(" No existe un usuario registrado con esta dirección de correo electrónico. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtEmail.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(" La dirección de correo electrónico no está registrada. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmail.Focus();
                        }

                        #region Lógica

                        //dado que pueden proveer mismo email para diferentes empleados
                        //así preguntamos, qué datos de usuario envío y a cuál de los dos?

                        //validar si existe el email en la bd

                        //extraer la info de usuario

                        //enviar los datos a la dirección de correo electrónico

                        //message de éxito o fracaso en el envío.

                        #endregion
                    }
                    else
                    {
                        MessageBox.Show($"No se envío el correo electronico. Deberá asignar valores a los parámetros {ParameterCode.EmailFrom} y {ParameterCode.Password}.", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(" El formato del correo electrónico no es válido. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }

            }
            catch (Exception excep)
            {
                MessageBox.Show("Ocurrió una excepción al enviar sus credenciales: " + excep.Message, "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                EnviarEmail();
            }
        }

        private void SetMaxLengthTxt()
        {
            txtEmail.MaxLength = 50;
        }

        private void FormRecuperarCuenta_Load(object sender, EventArgs e)
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            SetMaxLengthTxt();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Dispose();
        }
    }
}
