using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiguradorUI.FormUtil
{
    public partial class CustomDialog : Form
    {

        public CustomDialog(string mensaje, int ampliado, string titulo = null)
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
            if (titulo != null)
                lblTitulo.Text = titulo;

            if(ampliado!=0)
            {
             
                panelCustomDialog.Size = new Size(panelCustomDialog.Size.Width, (panelCustomDialog.Size.Height + ampliado));
                panelButton.Size = new Size(panelButton.Size.Width,59);
                Size = new Size(Size.Width, (Height + ampliado));
                btnOk.Location = new Point(btnOk.Location.X, (btnOk.Location.Y + ampliado));
            }

            
        }

        public static void ShowCustom(string mensaje, string titulo = null)
        {
            int ampliado = 0;

            if (mensaje.Length > 120)
            {
                int rows = mensaje.Length / 40;
                decimal resto = mensaje.Length % 40;

                int numAmpliado = rows - 3;
                if (resto != 0)
                    numAmpliado += 1;

                if (numAmpliado > 19) numAmpliado = 19;

                 ampliado = numAmpliado * 18;
               
            }
            CustomDialog o = new CustomDialog(mensaje, ampliado, titulo );
            o.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Dispose();
        }

    
    }
}
