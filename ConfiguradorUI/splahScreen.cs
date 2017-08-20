using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using ConfigBusinessLogic.General;
using ConfigBusinessLogic.Utiles;
using ConfigBusinessLogic;
using ConfigUtilitarios;
using ConfigBusinessEntity;

namespace ConfiguradorUI
{
    public partial class splahScreen : Form
    {
        public splahScreen(int segundos)
        {
            InitializeComponent();
            AsignarImagenSplash();

            timSplah.Interval = segundos * 1000;
            if (!timSplah.Enabled)
                timSplah.Enabled = true;

        }

        private void AsignarImagenSplash()
        {
            bool errorDefault = false;
            try
            {
                var p = new GRLt01_parametro();
                if (Connection.ConnectionTest())
                    p = new ParametroBL().ParametroXCod(ParameterCode.SplashImg);
                else
                    p = null;

                if (p != null && p.id_parametro > 0 && !string.IsNullOrEmpty(p.txt_valor) && File.Exists(@p.txt_valor))
                {
                    string fullpath = @p.txt_valor;
                    try
                    {
                        picSplash.Image = new Bitmap(fullpath);
                    }
                    catch
                    {
                        MessageBox.Show($"Excepción al momento de cargar la imagen del Splash sugerido. Parámetro: {ParameterCode.SplashImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        try
                        {
                            picSplash.Image = new Bitmap(Path.Combine
                                  (FilePath.FotoDefault,  Parameter.SplashImg));
                        }
                        catch
                        {
                            MessageBox.Show($"El splash por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.SplashImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    errorDefault = true;
                    picSplash.Image = new Bitmap(Path.Combine(FilePath.FotoDefault, Parameter.SplashImg));
                }
            }
            catch (Exception e)
            {
                if (errorDefault)
                    MessageBox.Show($"El splash por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.SplashImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Ocurrió un error no identificado. ERROR:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timSplah_Tick(object sender, EventArgs e)
        {
            timSplah.Stop();
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.005;
                this.Refresh();
            }

            this.Close();
        }

        private void splahScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
