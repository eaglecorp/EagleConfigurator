using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.HelperGeneric
{
    public class UtilString
    {
        public static string Space(int count)
        {
            return string.Empty.PadLeft(count);
        }

        public static string GetRandomName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
        }
    }
}
