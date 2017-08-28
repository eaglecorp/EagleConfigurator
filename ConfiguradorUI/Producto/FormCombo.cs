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

namespace ConfiguradorUI.Producto
{
    public partial class FormCombo : MetroForm
    {
        public FormCombo()
        {
            InitializeComponent();
        }

        private void FormCombo_Load(object sender, EventArgs e)
        {
            //Parent table  
            var dtComboDtl = new DataTable();
            // add column to datatable  
            dtComboDtl.Columns.Add("ComboDtl_ID", typeof(int));
            dtComboDtl.Columns.Add("PRODUCTO", typeof(string));
            dtComboDtl.Columns.Add("CANRIDAD", typeof(decimal));
            dtComboDtl.Columns.Add("PRECIO", typeof(decimal));

            //Child table  
            DataTable dtComboSize = new DataTable();
            dtComboSize.Columns.Add("ComboDtl_ID", typeof(int));
            dtComboSize.Columns.Add("ComboSize_ID", typeof(int));
            dtComboSize.Columns.Add("PRODUCTO", typeof(string));
            dtComboSize.Columns.Add("CANTIDAD", typeof(decimal));
            dtComboSize.Columns.Add("PRECIO", typeof(decimal));

            //Adding Rows  
            dtComboDtl.Rows.Add(111, "CocaCola 3L", 4, 41);
            dtComboDtl.Rows.Add(222, "Postre variable - Size", 2, 20);
            dtComboDtl.Rows.Add(333, "Chaufa variable - Size", 1, 20);
            dtComboDtl.Rows.Add(444, "Snack Torties", 4, 13);

            // data for devesh ID=222
            dtComboSize.Rows.Add(222, 1, "Helado caliente Tornu", 3, 10);
            dtComboSize.Rows.Add(222, 2, "Teceños", 4, 12);
            dtComboSize.Rows.Add(222, 3, "Ensalada de frutas", 2, 10);
            dtComboSize.Rows.Add(222, 4, "Café sin azúcar", 2, 12.5);

            //data for ROLI ID=333
            dtComboSize.Rows.Add(333, 1, "Chaufa con pollo", 1, 40);
            dtComboSize.Rows.Add(333, 2, "Aereopuerto Jorge Chávez", 1, 43);
            dtComboSize.Rows.Add(333, 3, "Chaufa estilo Loreto", 1, 44);
            dtComboSize.Rows.Add(333, 4, "Chaufa vegano", 2, 25);

            DataSet dsDataset = new DataSet();
            //Add two DataTables in Dataset  
            dsDataset.Tables.Add(dtComboDtl);
            dsDataset.Tables.Add(dtComboSize);

            DataRelation Datatablerelation = new DataRelation("DetailsSize", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[0], true);
            dsDataset.Relations.Add(Datatablerelation);
            dataGrid1.DataSource = dsDataset.Tables[0];
        }

    }
}

