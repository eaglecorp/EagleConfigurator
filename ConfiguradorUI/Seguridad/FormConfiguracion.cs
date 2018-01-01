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
using ConfigUtilitarios;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormConfiguracion : MetroForm
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            ControlHelper.SetTextArea(txtAddMsjRegister);
            ControlHelper.SetTextArea(txtAddMsjCredentials);
        }

        private void txtAddMsjRegister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
