using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtilitarios
{
    public class ControlHelper
    {
        #region TextBox

        public static void TxtValidDecimal(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (e.KeyChar == '.')
                    e.Handled = txt.Text.Contains(".") || txt.Text.Equals("") ? true : false;
                else
                    e.Handled = true;
            }
        }

        public static void TxtValidInteger(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region DropDown

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

        #endregion

        #region DataGridView

        public static void DgvReadOnly(DataGridView dgv)
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

            #endregion
        }

        public static void DgvStyle(DataGridView dgv, float fontSize = 9.75F, FontStyle fontStyle = FontStyle.Regular, Color? colorLetter = null)
        {
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;//Para que no sobeescriba la cabecera

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

        public static void DgvLightStyle(DataGridView dgv)
        {
            dgv.ColumnHeadersHeight = 25;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;//Para que no sobeescriba la cabecera

            #region Estilo grilla

            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#BDF1F6");
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            #endregion
        }

        #endregion

    }
}
