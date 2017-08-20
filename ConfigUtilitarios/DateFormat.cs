using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigUtilitarios
{
    public class DateFormat
    {
        public string DateFormatYYYYMMDD(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = DateYYYY(Fecha) + DateMM(Fecha) + DateDD(Fecha);

            return _result;
        }

        public string DateFormatYYMMDD(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = DateYY(Fecha) + DateMM(Fecha) + DateDD(Fecha);

            return _result;
        }

        public string DateFormatYYYY_MM_DD(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = DateYYYY(Fecha) + "-" + DateMM(Fecha) + "-" + DateDD(Fecha);

            return _result;
        }

        public string DateFormatYY_MM_DD(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = DateYY(Fecha) + "-" + DateMM(Fecha) + "-" + DateDD(Fecha);

            return _result;
        }

        public string DateYYYY(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = Fecha.Year.ToString();

            return _result;
        }

        public string DateYY(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = Fecha.Year.ToString().Substring(2);

            return _result;
        }

        public string DateMM(DateTime Fecha)
        {
            string _result = string.Empty;
            char _cero = '0';

            _result = Fecha.Month.ToString().PadLeft(2,_cero);

            return _result;
        }

        public string DateDD(DateTime Fecha)
        {
            string _result = string.Empty;
            char _cero = '0';

            _result = Fecha.Day.ToString().PadLeft(2, _cero);

            return _result;
        }
        
        public string DateFormatHHMMSS(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = HourHH(Fecha) + HourMM(Fecha) + HourSS(Fecha);

            return _result;
        }
        
        public string HourHH(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = Fecha.Hour.ToString().PadLeft(2, '0');

            return _result;
        }

        public string HourMM(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = Fecha.Minute.ToString().PadLeft(2, '0');

            return _result;
        }

        public string HourSS(DateTime Fecha)
        {
            string _result = string.Empty;

            _result = Fecha.Second.ToString().PadLeft(2, '0');

            return _result;
        }

        public bool Validar_FechaIni_FechaFin(DateTime FechaInicial, DateTime FechaFinal)
        {
            bool result_ = false;

            if (FechaFinal.Date >= FechaInicial.Date)
            {
                result_ = true;
            }

            return result_;
        }
    }
}
