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

        #region Métodos

        private void AsignarImagenCheck()
        {
            var parametroImg = new ParametroBL().ParametroXCod(ParameterCode.LogoImg);
            Parameter.CargarParametroImg(parametroImg, picLogo, ParameterCode.LogoImg);
        }

        public bool check
        {
            get { return chkDialog.Checked; }
        }

        #endregion

        #region Eventos

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
        #endregion

    }
}
