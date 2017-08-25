using System;
using System.Collections.Generic;
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

    }
}
