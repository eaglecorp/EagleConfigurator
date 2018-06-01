using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.FormUtil
{
    public partial class Transparent : Form
    {
        public Transparent()
        {
            InitializeComponent();
            BackColor = Color.LimeGreen;
            TransparencyKey = Color.LimeGreen;
        }

        private void Transparent_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
    }
}
