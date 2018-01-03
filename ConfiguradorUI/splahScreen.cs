using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.General;
using ConfigUtilitarios;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        #region Métodos

        private void AsignarImagenSplash()
        {
            var parametroImg = new GRLt01_parametro();
            if (Connection.ConnectionTest())
                parametroImg = new ParametroBL().ParametroXCod(ParameterCode.SplashImg);
            else
                parametroImg = null;

            Parameter.CargarParametroImg(parametroImg, picSplash, ParameterCode.SplashImg);

        }

        #endregion

        #region Eventos
        private void timSplah_Tick(object sender, EventArgs e)
        {
            timSplah.Stop();
            while (Opacity > 0)
            {
                Opacity -= 0.005;
                Refresh();
            }

            Close();
        }

        private void splahScreen_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
