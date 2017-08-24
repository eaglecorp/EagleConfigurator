using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.HelperClass
{
    public class ComboItem
    {
        public string Key { get; set; }
        public string Value { get; set; }


        public ComboItem()
        {
        }
        public ComboItem(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public ComboItem(string KeyAndValue)
        {
            Key = KeyAndValue;
            Value = KeyAndValue;
        }

        public ComboItem[] GetHHs()
        {
            return new ComboItem[] {
                    new ComboItem("01"),
                    new ComboItem("02"),
                    new ComboItem("03"),
                    new ComboItem("04"),
                    new ComboItem("05"),
                    new ComboItem("06"),
                    new ComboItem("07"),
                    new ComboItem("08"),
                    new ComboItem("09"),
                    new ComboItem("10"),
                    new ComboItem("11"),
                    new ComboItem("12") };
        }

        public ComboItem[] GetMMs()
        {
            return new ComboItem[] {
                    new ComboItem("00"),
                    new ComboItem("05"),
                    new ComboItem("10"),
                    new ComboItem("15"),
                    new ComboItem("20"),
                    new ComboItem("25"),
                    new ComboItem("30"),
                    new ComboItem("35"),
                    new ComboItem("40"),
                    new ComboItem("45"),
                    new ComboItem("50"),
                    new ComboItem("55") };
        }

        public ComboItem[] GetTTs()
        {
            return new ComboItem[] {
                    new ComboItem("AM"),
                    new ComboItem("PM") };
        }
    }
}
