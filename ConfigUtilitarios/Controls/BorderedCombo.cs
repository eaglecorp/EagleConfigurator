using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtilitarios.Controls
{
    public class BorderedCombo : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(ColorTranslator.FromHtml("#999999")))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                        //Dibuja una linea entre el botón de despligue del combo y el texto del combo
                        //g.DrawLine(p, Width - buttonWidth, 0, Width - buttonWidth, Height);
                    }
                }
            }
        }
    }
}
