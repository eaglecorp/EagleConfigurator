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
using ConfigUtilitarios;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Utiles;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormCambiarClave : MetroForm
    {
        PERt01_usuario usuarioAnterior = null;

        public FormCambiarClave(PERt01_usuario usuario)
        {
            InitializeComponent();
            usuarioAnterior = usuario;
            
        }

        private void SetMaxLengthTxt()
        {
            txtNuevaClave.UseSystemPasswordChar = true;
            txtNuevaClaveRepeat.UseSystemPasswordChar = true;
            txtNuevaClave.MaxLength = Parameter.LenghtPassMax;
            txtNuevaClaveRepeat.MaxLength = Parameter.LenghtPassMax;
        }

        private void FormCambiarClave_Load(object sender, EventArgs e)
        {
            SetMaxLengthTxt();
            lblIndicadorContraseña.Text = "";
            NombreUsuario();
            txtNuevaClave.Focus();
        }

        public void NombreUsuario()
        {
            lblUsername.Text = usuarioAnterior.txt_usuario;
        }

        private bool EsValido()
        {
            bool esvalido = false;

            string clave = txtNuevaClave.Text;
            string claveRep = txtNuevaClaveRepeat.Text;

            if(clave == claveRep)
            {
                if(clave.Length>=Parameter.LenghtPassMin)
                {
                    string claveAnteriorDesc =new Encription().Decryption(usuarioAnterior.txt_clave);
                    if(clave == claveAnteriorDesc)
                    {
                        MessageBox.Show(" La nueva contraseña tiene que ser diferente a la interior. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        esvalido = true;
                    }
                }
                else
                {
                    MessageBox.Show($"La contraseña debe tener {Parameter.LenghtPassMin} caracteres mínimamente. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Las constraseñas no coinciden. ", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return esvalido;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void CambiarContraseña()
        {
            if (EsValido())
            {
                var usuarioActualizado = usuarioAnterior;
                usuarioActualizado.txt_clave = new Encription().Encryption(txtNuevaClave.Text);
                usuarioActualizado.sn_upd_requered = Estado.IdInactivo;
                usuarioActualizado.fecha_modificacion = UtilBL.GetCurrentDateTime;
                try
                {
                    new ConfigBusinessLogic.Seguridad.UsuarioBL().ActualizarUsuario(usuarioActualizado);
                    MessageBox.Show(" Se cambió su contraseña correctamente", "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Close();

                }
                catch (Exception exe)
                {
                    MessageBox.Show(" Ocurrió una excepción: " + exe.Message, "Aviso Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void txtNuevaClave_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevaClave.Text.Length == 0)
            {
                panelIndicadorClave.BackColor = Color.Transparent;
                lblIndicadorContraseña.Text = "";
            }
            else if (txtNuevaClave.Text.Length > 0 && txtNuevaClave.Text.Length < Parameter.LenghtPassMin)
            {
                panelIndicadorClave.BackColor = Color.Red;
                lblIndicadorContraseña.Text = "Débil";
            }
            else if (txtNuevaClave.Text.Length >= Parameter.LenghtPassMin && txtNuevaClave.Text.Length < Parameter.LenghtPassMed)
            {
                panelIndicadorClave.BackColor = Color.Yellow;
                lblIndicadorContraseña.Text = "Medio";
            }
            else if (txtNuevaClave.Text.Length >= Parameter.LenghtPassMed)
            {
                panelIndicadorClave.BackColor = Color.LimeGreen;
                lblIndicadorContraseña.Text = "Fuerte";
            }
        }

        private void txtNuevaClaveRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                CambiarContraseña();
            }
        }
    }
}
