using ConfigUtilitarios.KeyValues;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public static class StringExt
    {
        public static string RemoveDiacritics(this string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        public static string RemoveTrailingZeros(this decimal? dec)
        {
            decimal num = (decimal)dec;
            return num.ToString("0.########");
        }

        public static string RemoveTrailingZeros(this decimal dec)
        {
            return dec.ToString("0.########");
        }

        public static string RoundOut(this decimal? dec, int numDec = KeyAmounts.numDecDefault)
        {
            string ceros = "0.";
            Enumerable.Range(1, numDec > 0 ? numDec : 1).ToList().ForEach(x => { ceros += "#"; });
            return Math.Round((decimal)dec, numDec).ToString(ceros);
        }

        public static string RoundOut(this decimal dec, int numDec = KeyAmounts.numDecDefault)
        {
            string ceros = "0.";
            Enumerable.Range(1, numDec > 0 ? numDec : 1).ToList().ForEach(x => { ceros += "#"; });
            return Math.Round(dec, numDec).ToString(ceros);
        }
    }
}
