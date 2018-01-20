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

        public static int maxWidthComboBox { get; } = 400;
        public static int maxHeightComboBox { get; } = 300;
        public static int maxDropDownItems { get; } = 15;

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

        private static void TxtSetTextArea(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectionStart = txt.Text.Length;
            txt.ScrollToCaret();
        }

        public static void SetTextArea(TextBox txt)
        {
            txt.Multiline = true;
            txt.ScrollBars = ScrollBars.Both;
            txt.TextChanged += TxtSetTextArea;
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
                    if (temp >= maxWidthComboBox)
                    {
                        maxWidth = maxWidthComboBox;
                        break;
                    }
                    else if (temp > maxWidth)
                    {
                        maxWidth = temp;
                    }
                }
            }
            catch (Exception)
            {
                return 250;
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
            dgv.ReadOnly = false;

            #endregion
        }

        public static void DgvSetColorBorder(object sender, PaintEventArgs e, Color color)
        {
            e.Graphics.DrawRectangle(new Pen(color), new Rectangle(0, 0, ((DataGridView)sender).Width - 1, ((DataGridView)sender).Height - 1));
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

        public static void DgvLightStyle(DataGridView dgv, float recordFontSize = 9F, float headerFontSize = 9.5F)
        {
            dgv.ColumnHeadersHeight = 25;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;//Para que no sobeescriba la cabecera

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
            dgv.Font = new Font("Segoe UI", recordFontSize, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", headerFontSize, FontStyle.Regular);
        }

        public static void DgvBaseStyle(DataGridView dgv)
        {
            dgv.ColumnHeadersHeight = 25;
            dgv.EnableHeadersVisualStyles = false;

            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.ForeColor = Color.Black;

            dgv.BorderStyle = BorderStyle.None;

            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dgv.RowHeadersWidth = 25;

            dgv.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

        }

        public static void DgvBaseConfig(DataGridView dgv)
        {
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeRows = false;

        }

        public static string DgvGetCellValueSelected(DataGridView dgv, int indexColumn)
        {
            try
            {
                if (dgv.CurrentRow != null &&
                       dgv.SelectedRows.Count > 0 &&
                       dgv.SelectedRows[0].Cells[indexColumn].Value != null)
                {
                    return dgv.SelectedRows[0].Cells[indexColumn].Value.ToString();
                }
                else return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string DgvGetCellValueSelectedFromCell(DataGridView dgv, int indexColumn)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    return dgv.CurrentRow.Cells[indexColumn].Value.ToString();
                }
                else return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

    }
}
