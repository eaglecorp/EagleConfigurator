using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtilitarios
{
    public class ControlExt
    {
        public static int DropDownWidth(ComboBox myCombo)
        {

            int maxWidth = 0, temp = 0;
            try
            {
                foreach (var obj in myCombo.Items)
                {
                    temp = TextRenderer.MeasureText(myCombo.GetItemText(obj), myCombo.Font).Width;
                    if (temp > maxWidth)
                    {
                        maxWidth = temp;
                    }
                }
            }
            catch (Exception)
            {

                return 200;
            }
            return maxWidth + SystemInformation.VerticalScrollBarWidth;
        }

        public static void ConfigurarGrilla(DataGridView dgv, float fontSize = 9.75F, FontStyle fontStyle = FontStyle.Regular, Color? colorLetter = null)
        {

            #region Configuración grilla

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ReadOnly = true;

            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;//Para que no sobeescriba la cabecera

            #endregion

            #region Estilo grilla
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.ForeColor = colorLetter ?? Color.Black;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#446CB3");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#03C9A9");
            dgv.Font = new Font("Segoe UI", fontSize, fontStyle);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            #endregion

        }

    }
}
