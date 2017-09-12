using MetroFramework.Forms;
using System;
using ConfigBusinessEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Producto
{
    public partial class FormCombo : MetroForm
    {
        public FormCombo()
        {
            InitializeComponent();
            PROt13_combo s = new PROt13_combo();
            PROt14_combo_fixed_dtl a = new PROt14_combo_fixed_dtl();
        }


        private void FormCombo_Load(object sender, EventArgs e)
        {
           
        }

    }
}

