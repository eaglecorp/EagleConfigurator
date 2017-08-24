using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtilitarios.HelperControl
{
    public class Msj
    {
        public static DialogResult Ok_Info(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Ok_Wng(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Ok_Err(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult YesNo_Ques(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DialogResult OkCancel_Ques(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult OkCancel_Wng(string msj, string title = "Mensaje")
        {
            return MessageBox.Show(msj, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
