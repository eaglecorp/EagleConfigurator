using ConfigBusinessLogic;
using ConfigBusinessLogic.General;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.FormUtil
{
    public partial class CheckBoxDialog : Form
    {

        public CheckBoxDialog()
        {
            InitializeComponent();
        }

        private void AsignarImagenCheck()
        {
            bool errorDefault = false;
            try
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.LogoImg);

                if (p != null && p.id_parametro > 0 && !string.IsNullOrEmpty(p.txt_valor) && File.Exists(@p.txt_valor))
                {
                    string fullpath = @p.txt_valor;
                    try
                    {
                        picLogo.Image = new Bitmap(fullpath);
                    }
                    catch
                    {
                        MessageBox.Show($"Excepción al momento de cargar la imagen del logo sugerido. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        try
                        {
                            picLogo.Image = new Bitmap(Path.Combine
                                  (FilePath.FotoDefault, Parameter.LogoImg));
                        }
                        catch
                        {
                            MessageBox.Show($"El logo por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    errorDefault = true;
                    picLogo.Image = new Bitmap(Path.Combine(FilePath.FotoDefault, Parameter.LogoImg));
                }
            }
            catch (Exception e)
            {
                if (errorDefault)
                    MessageBox.Show($"El logo por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Ocurrió un error no identificado. ERROR:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool check
        {
            get { return chkDialog.Checked; }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            //rp = DialogResult.Yes;
            //oCheckBoxDialog.Dispose();
            //oCheckBoxDialog.Close();
            //oCheckBoxDialog.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //rp = DialogResult.No;
            //oCheckBoxDialog.Dispose();
            //oCheckBoxDialog.Close();
            //oCheckBoxDialog.Hide();
        }

        private void CheckBoxDialog_Load(object sender, EventArgs e)
        {
            AsignarImagenCheck();
            CenterToParent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
