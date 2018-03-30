using ConfigBusinessEntity;
using ConfigBusinessLogic.Labor;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Labor.Horario
{
    public partial class FormAsignarHorario : MetroForm
    {


        #region Varibles Globales

        enum TipoControl
        {
            CheckDia,
            CheckDiaTupla,
            ChekedDia,
            DtpLabor,
            DtpInicioLabor,
            DtpFinLabor,
            DtpBreak,
            DtpInicioBreak,
            DtpFinBreak,
            DtpTiempoTolerancia,
            DtpHoraDom,
            DtpHoraLun,
            DtpHoraMar,
            DtpHoraMie,
            DtpHoraJue,
            DtpHoraVie,
            DtpHoraSab
        };

        public bool _seAsigno = false;
        private PERt04_empleado _empleado;
        private LABt03_horario_emp _horario;

        #endregion

        public FormAsignarHorario(PERt04_empleado empleado, LABt03_horario_emp horario)
        {
            InitializeComponent();

            _empleado = empleado;
            _horario = horario;
        }

        #region Métodos


        private void AddHandlers()
        {
            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.CheckedChanged += chk_CheckedChanged;
            }

            foreach (var dtpBreak in (DateTimePicker[])GetControls(TipoControl.DtpBreak))
            {
                dtpBreak.MouseDown += DtpBreak_MouseDown;
                dtpBreak.KeyPress += DtpBreak_KeyPress;
            }

            foreach (var dtpHoraInicioLabor in (DateTimePicker[])GetControls(TipoControl.DtpInicioLabor))
            {
                dtpHoraInicioLabor.ValueChanged += dtpHoraInicioLabor_ValueChanged;
            }

            foreach (var dtpHoraFinLabor in (DateTimePicker[])GetControls(TipoControl.DtpFinLabor))
            {
                dtpHoraFinLabor.ValueChanged += dtpHoraFinLabor_ValueChanged;
            }

            foreach (var dtpHoraInicioBreak in (DateTimePicker[])GetControls(TipoControl.DtpInicioBreak))
            {
                dtpHoraInicioBreak.ValueChanged += dtpHoraInicioBreak_ValueChanged;
            }

            foreach (var dtpHoraFinBreak in (DateTimePicker[])GetControls(TipoControl.DtpFinBreak))
            {
                dtpHoraFinBreak.ValueChanged += dtpHoraFinBreak_ValueChanged;
            }

            foreach (var dtpTiempoTolerancia in (DateTimePicker[])GetControls(TipoControl.DtpTiempoTolerancia))
            {
                dtpTiempoTolerancia.ValueChanged += dtpTiempoTolerancia_ValueChanged;
            }

            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;

            dtpHasta.CloseUp += dtpHasta_CloseUp;
        }

        private dynamic GetControls(TipoControl tipoControl)
        {
            dynamic controls = null;

            switch (tipoControl)
            {
                case TipoControl.CheckDia:
                    controls = new[]
                    {
                        chkDomingo, chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes, chkSabado,
                    };
                    break;
                case TipoControl.CheckDiaTupla:
                    controls = new List<Tuple<CheckBox, DayOfWeek>>
                    {
                        new Tuple<CheckBox,DayOfWeek>(chkDomingo,DayOfWeek.Sunday),
                        new Tuple<CheckBox,DayOfWeek>(chkLunes,DayOfWeek.Monday),
                        new Tuple<CheckBox,DayOfWeek>(chkMartes,DayOfWeek.Tuesday),
                        new Tuple<CheckBox,DayOfWeek>(chkMiercoles,DayOfWeek.Wednesday),
                        new Tuple<CheckBox,DayOfWeek>(chkJueves,DayOfWeek.Thursday),
                        new Tuple<CheckBox,DayOfWeek>(chkViernes,DayOfWeek.Friday),
                        new Tuple<CheckBox,DayOfWeek>(chkSabado,DayOfWeek.Saturday)
                    };
                    break;
                case TipoControl.ChekedDia:
                    {
                        controls = new List<CheckBox>();

                        if (chkDomingo.Checked)
                        {
                            controls.Add(chkDomingo);
                        }
                        if (chkLunes.Checked)
                        {
                            controls.Add(chkLunes);
                        }
                        if (chkMartes.Checked)
                        {
                            controls.Add(chkMartes);
                        }
                        if (chkMiercoles.Checked)
                        {
                            controls.Add(chkMiercoles);
                        }
                        if (chkJueves.Checked)
                        {
                            controls.Add(chkJueves);
                        }
                        if (chkViernes.Checked)
                        {
                            controls.Add(chkViernes);
                        }
                        if (chkSabado.Checked)
                        {
                            controls.Add(chkSabado);
                        }
                    }
                    break;
                case TipoControl.DtpLabor:
                    controls = new[]
                     {
                        dtpIniLabDom, dtpFinLabDom,
                        dtpIniLabLun, dtpFinLabLun,
                        dtpIniLabMar, dtpFinLabMar,
                        dtpIniLabMie, dtpFinLabMie,
                        dtpIniLabJue, dtpFinLabJue,
                        dtpIniLabVie, dtpFinLabVie,
                        dtpIniLabSab, dtpFinLabSab,
                    };
                    break;
                case TipoControl.DtpInicioLabor:
                    controls = new[]
                    {
                        dtpIniLabDom,
                        dtpIniLabLun,
                        dtpIniLabMar,
                        dtpIniLabMie,
                        dtpIniLabJue,
                        dtpIniLabVie,
                        dtpIniLabSab
                    };
                    break;
                case TipoControl.DtpFinLabor:
                    controls = new[]
                    {
                        dtpFinLabDom,
                        dtpFinLabLun,
                        dtpFinLabMar,
                        dtpFinLabMie,
                        dtpFinLabJue,
                        dtpFinLabVie,
                        dtpFinLabSab,
                    };
                    break;
                case TipoControl.DtpBreak:
                    controls = new[]
                    {
                        dtpIniBrkDom, dtpFinBrkDom,
                        dtpIniBrkLun, dtpFinBrkLun,
                        dtpIniBrkMar, dtpFinBrkMar,
                        dtpIniBrkMie, dtpFinBrkMie,
                        dtpIniBrkJue, dtpFinBrkJue,
                        dtpIniBrkVie, dtpFinBrkVie,
                        dtpIniBrkSab, dtpFinBrkSab,
                    };
                    break;
                case TipoControl.DtpInicioBreak:
                    controls = new[]
                    {
                        dtpIniBrkDom,
                        dtpIniBrkLun,
                        dtpIniBrkMar,
                        dtpIniBrkMie,
                        dtpIniBrkJue,
                        dtpIniBrkVie,
                        dtpIniBrkSab
                    };
                    break;
                case TipoControl.DtpFinBreak:
                    controls = new[]
                    {
                        dtpFinBrkDom,
                        dtpFinBrkLun,
                        dtpFinBrkMar,
                        dtpFinBrkMie,
                        dtpFinBrkJue,
                        dtpFinBrkVie,
                        dtpFinBrkSab
                    };
                    break;
                case TipoControl.DtpTiempoTolerancia:
                    controls = new[]
                    {
                        dtpToleranciaDom,
                        dtpToleranciaLun,
                        dtpToleranciaMar,
                        dtpToleranciaMie,
                        dtpToleranciaJue,
                        dtpToleranciaVie,
                        dtpToleranciaSab
                    };
                    break;
                case TipoControl.DtpHoraDom:
                    controls = new[]
                    {
                        dtpIniLabDom,
                        dtpFinLabDom,
                        dtpIniBrkDom,
                        dtpFinBrkDom,
                        dtpToleranciaDom
                    };
                    break;
                case TipoControl.DtpHoraLun:
                    controls = new[]
                    {
                        dtpIniLabLun,
                        dtpFinLabLun,
                        dtpIniBrkLun,
                        dtpFinBrkLun,
                        dtpToleranciaLun
                    };
                    break;
                case TipoControl.DtpHoraMar:
                    controls = new[]
                    {
                        dtpIniLabMar,
                        dtpFinLabMar,
                        dtpIniBrkMar,
                        dtpFinBrkMar,
                        dtpToleranciaMar
                    };
                    break;
                case TipoControl.DtpHoraMie:
                    controls = new[]
                    {
                        dtpIniLabMie,
                        dtpFinLabMie,
                        dtpIniBrkMie,
                        dtpFinBrkMie,
                        dtpToleranciaMie
                    };
                    break;
                case TipoControl.DtpHoraJue:
                    controls = new[]
                    {
                        dtpIniLabJue,
                        dtpFinLabJue,
                        dtpIniBrkJue,
                        dtpFinBrkJue,
                        dtpToleranciaJue
                    };
                    break;
                case TipoControl.DtpHoraVie:
                    controls = new[]
                    {
                        dtpIniLabVie,
                        dtpFinLabVie,
                        dtpIniBrkVie,
                        dtpFinBrkVie,
                        dtpToleranciaVie
                    };
                    break;
                case TipoControl.DtpHoraSab:
                    controls = new[]
                    {
                        dtpIniLabSab,
                        dtpFinLabSab,
                        dtpIniBrkSab,
                        dtpFinBrkSab,
                        dtpToleranciaSab
                    };
                    break;
                default:
                    break;
            }

            return controls;
        }

        private void LimpiarDatosEnMemoria()
        {
            _empleado = null;
            _horario = null;
        }

        private void LimpiarForm()
        {
            var hoy = DateTime.Now.Date;
            var fechaDtp = hoy > KeyDates.MaxDate ? KeyDates.MaxDate : hoy;

            dtpDesde.Value = fechaDtp;
            dtpHasta.Value = fechaDtp;

            ControlHelper.FormatDatePicker(dtpHasta, " ", showUpDown: false);

            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.Checked = false;
                chkDia.Enabled = false;
            }

            var dtpsInicioLabor = (DateTimePicker[])GetControls(TipoControl.DtpInicioLabor);
            var dtpsFinLabor = (DateTimePicker[])GetControls(TipoControl.DtpFinLabor);
            var dtpsInicioBreak = (DateTimePicker[])GetControls(TipoControl.DtpInicioBreak);
            var dtpsFinBreak = (DateTimePicker[])GetControls(TipoControl.DtpFinBreak);
            var dtpsTolerancia = (DateTimePicker[])GetControls(TipoControl.DtpTiempoTolerancia);
            var dtpsBreak = dtpsInicioBreak.Union(dtpsFinBreak);

            foreach (var dtpLaborInicio in dtpsInicioLabor)
            {
                dtpLaborInicio.Value = Convert.ToDateTime(new TimeSpan(8, 0, 0).ToString());
            }

            foreach (var dtpLaborFin in dtpsFinLabor)
            {
                dtpLaborFin.Value = Convert.ToDateTime(new TimeSpan(17, 0, 0).ToString());
            }

            foreach (var dtpTolerancia in dtpsTolerancia)
            {
                dtpTolerancia.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }

            foreach (var dtpInicioBreak in dtpsInicioBreak)
            {
                dtpInicioBreak.Value = Convert.ToDateTime(new TimeSpan(12, 0, 0).ToString());
            }

            foreach (var dtpFinBreak in dtpsFinBreak)
            {
                dtpFinBreak.Value = Convert.ToDateTime(new TimeSpan(13, 0, 0).ToString());
            }

            foreach (var dtpBreak in dtpsBreak)
            {
                ControlHelper.FormatDatePicker(dtpBreak, customFormat: " ");
            }

            foreach (var dtp in dtpsInicioLabor.Union(dtpsFinLabor).Union(dtpsTolerancia).Union(dtpsBreak))
            {
                dtp.Visible = false;
            }
        }

        private TimeSpan GetHoraYMinutos(TimeSpan hora)
        {
            return new TimeSpan(hora.Hours, hora.Minutes, 0);
        }

        private void ValidarHoraInicioLabor(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;
            var dtpTiempoTolerancia = new DateTimePicker();

            TimeSpan horaInicio = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFin = new TimeSpan(0, 0, 0);

            if (nameDtp == dtpIniLabDom.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabDom.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaDom;
            }
            else if (nameDtp == dtpIniLabLun.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabLun.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaLun;
            }
            else if (nameDtp == dtpIniLabMar.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabMar.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaMar;
            }
            else if (nameDtp == dtpIniLabMie.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabMie.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaMie;
            }
            else if (nameDtp == dtpIniLabJue.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabJue.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaJue;
            }
            else if (nameDtp == dtpIniLabVie.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabVie.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaVie;
            }
            else if (nameDtp == dtpIniLabSab.Name)
            {
                horaFin = GetHoraYMinutos(dtpFinLabSab.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaSab;
            }

            if (horaInicio > horaFin)
            {
                Msg.Ok_Wng("La \"Hora inicio\" no puede ser mayor que la \"Hora fin\".", "Validación");

                dtp.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
                dtpTiempoTolerancia.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }
            else
            {
                var tiempoTolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay);
                var maxTiempoTolerancia = horaFin - horaInicio;
                if (tiempoTolerancia > maxTiempoTolerancia)
                {
                    dtpTiempoTolerancia.Value = Convert.ToDateTime(maxTiempoTolerancia.ToString());
                }
            }
        }
        private void ValidarHoraFinLabor(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;
            var dtpTiempoTolerancia = new DateTimePicker();

            TimeSpan horaFin = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicio = new TimeSpan(0, 0, 0);

            if (nameDtp == dtpFinLabDom.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabDom.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaDom;
            }
            else if (nameDtp == dtpFinLabLun.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabLun.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaLun;
            }
            else if (nameDtp == dtpFinLabMar.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabMar.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaMar;
            }
            else if (nameDtp == dtpFinLabMie.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabMie.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaMie;
            }
            else if (nameDtp == dtpFinLabJue.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabJue.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaJue;
            }
            else if (nameDtp == dtpFinLabVie.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabVie.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaVie;
            }
            else if (nameDtp == dtpFinLabSab.Name)
            {
                horaInicio = GetHoraYMinutos(dtpIniLabSab.Value.TimeOfDay);
                dtpTiempoTolerancia = dtpToleranciaSab;
            }

            if (horaFin < horaInicio)
            {
                Msg.Ok_Wng("La \"Hora fin\" no puede ser menor que la \"Hora inicio\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaInicio.ToString());
                dtpTiempoTolerancia.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }
            else
            {
                var tiempoTolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay);
                var maxTiempoTolerancia = horaFin - horaInicio;
                if (tiempoTolerancia > maxTiempoTolerancia)
                {
                    dtpTiempoTolerancia.Value = Convert.ToDateTime(maxTiempoTolerancia.ToString());
                }
            }
        }
        private void ValidarHoraInicioBreak(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;
            TimeSpan horaInicioBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = new TimeSpan(0, 0, 0);
            TimeSpan horaFinBreak = new TimeSpan(0, 0, 0);

            if (nameDtp == dtpIniBrkDom.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabDom.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkDom.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkLun.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabLun.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkLun.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkMar.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabMar.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkMar.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkMie.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabMie.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkMie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkJue.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabJue.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkJue.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkVie.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabVie.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkVie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpIniBrkSab.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabSab.Value.TimeOfDay);
                horaFinBreak = GetHoraYMinutos(dtpFinBrkSab.Value.TimeOfDay);
            }

            if (horaInicioBreak < horaInicioLabor)
            {
                Msg.Ok_Wng("La hora \"Inicio break\" no puede ser menor que la \"Hora inicio\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaInicioLabor.ToString());
            }
            else if (horaInicioBreak > horaFinBreak)
            {
                Msg.Ok_Wng("La hora \"Inicio break\" no puede ser mayor que la hora \"Fin break\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaFinBreak.ToString());
            }
        }
        private void ValidarHoraFinBreak(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;
            TimeSpan horaFinBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFinLabor = new TimeSpan(0, 0, 0);
            TimeSpan horaInicioBreak = new TimeSpan(0, 0, 0);

            if (nameDtp == dtpFinBrkDom.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabDom.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkDom.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkLun.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabLun.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkLun.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkMar.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabMar.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkMar.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkMie.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabMie.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkMie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkJue.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabJue.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkJue.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkVie.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabVie.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkVie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpFinBrkSab.Name)
            {
                horaFinLabor = GetHoraYMinutos(dtpFinLabSab.Value.TimeOfDay);
                horaInicioBreak = GetHoraYMinutos(dtpIniBrkSab.Value.TimeOfDay);
            }

            if (horaFinBreak > horaFinLabor)
            {
                Msg.Ok_Wng("La hora \"Fin break\" no puede ser mayor que la \"Hora Fin\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaFinLabor.ToString());
            }
            else if (horaFinBreak < horaInicioBreak)
            {
                Msg.Ok_Wng("La hora \"Fin break\" no puede ser menor que la hora \"Inicio break\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaInicioBreak.ToString());
            }
        }
        private void ValidarTiempoTolerancia(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;
            TimeSpan tiempoTolerancia = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = new TimeSpan(0, 0, 0);
            TimeSpan horaFinLabor = new TimeSpan(0, 0, 0);
            TimeSpan maxTolerancia = new TimeSpan(0, 0, 0);

            if (nameDtp == dtpToleranciaDom.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabDom.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabDom.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaLun.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabLun.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabLun.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaMar.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabMar.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabMar.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaMie.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabMie.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabMie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaJue.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabJue.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabJue.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaVie.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabVie.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabVie.Value.TimeOfDay);
            }
            else if (nameDtp == dtpToleranciaSab.Name)
            {
                horaInicioLabor = GetHoraYMinutos(dtpIniLabSab.Value.TimeOfDay);
                horaFinLabor = GetHoraYMinutos(dtpFinLabSab.Value.TimeOfDay);
            }

            maxTolerancia = horaFinLabor - horaInicioLabor;
            if (tiempoTolerancia > maxTolerancia)
            {
                Msg.Ok_Wng($"El tiempo de \"Tolerancia\" sobrepasa al rango de horas del día ({maxTolerancia.ToString()} horas).", "Validación");
                dtp.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }
        }

        private List<LABt04_horario_emp_dtl> GetRangoDeFechas()
        {
            var fechas = new List<LABt04_horario_emp_dtl>();

            try
            {
                var desde = dtpDesde.Value.Date;
                var hasta = dtpHasta.Value.Date;
                var diaIterado = desde;

                var diasChecked = (List<CheckBox>)GetControls(TipoControl.ChekedDia);
                var listTuplaDiaYHoras = new List<Tuple<DayOfWeek, LABt04_horario_emp_dtl>>();
                foreach (var chk in diasChecked)
                {
                    listTuplaDiaYHoras.Add(GetDiaYHorasDelDia(chk));
                }

                while (diaIterado <= hasta)
                {
                    if (listTuplaDiaYHoras.Any(x => x.Item1 == diaIterado.DayOfWeek))
                    {
                        var diaYHora = listTuplaDiaYHoras.First(x => x.Item1 == diaIterado.DayOfWeek);

                        fechas.Add(
                            new LABt04_horario_emp_dtl
                            {
                                fecha_labor = diaIterado,
                                hora_inicio = diaYHora.Item2.hora_inicio,
                                hora_fin = diaYHora.Item2.hora_fin,
                                hora_inicio_break = diaYHora.Item2.hora_inicio_break,
                                hora_fin_break = diaYHora.Item2.hora_fin_break,
                                tiempo_tolerancia = diaYHora.Item2.tiempo_tolerancia
                            }
                            );
                    }

                    diaIterado = diaIterado.AddDays(1);
                }
            }
            catch (Exception e)
            {
                fechas = new List<LABt04_horario_emp_dtl>();
                Msg.Ok_Err("No se pudo generar el rango fechas. Excepción: " + e.Message);
            }

            return fechas;
        }

        private Tuple<DayOfWeek, LABt04_horario_emp_dtl> GetDiaYHorasDelDia(CheckBox checkBox)
        {
            DayOfWeek dia = DayOfWeek.Saturday;
            var horasDelDia = new LABt04_horario_emp_dtl();
            DateTimePicker dtpIni = null;
            DateTimePicker dtpFin = null;
            DateTimePicker dtpBrkIni = null;
            DateTimePicker dtpBrkFin = null;
            DateTimePicker dtpTol = null;

            if (checkBox.Name == chkDomingo.Name)
            {
                dia = DayOfWeek.Sunday;
                dtpIni = dtpIniLabDom;
                dtpFin = dtpFinLabDom;
                dtpBrkIni = dtpIniBrkDom;
                dtpBrkFin = dtpFinBrkDom;
                dtpTol = dtpToleranciaDom;
            }
            else if (checkBox.Name == chkLunes.Name)
            {
                dia = DayOfWeek.Monday;
                dtpIni = dtpIniLabLun;
                dtpFin = dtpFinLabLun;
                dtpBrkIni = dtpIniBrkLun;
                dtpBrkFin = dtpFinBrkLun;
                dtpTol = dtpToleranciaLun;
            }
            else if (checkBox.Name == chkMartes.Name)
            {
                dia = DayOfWeek.Tuesday;
                dtpIni = dtpIniLabMar;
                dtpFin = dtpFinLabMar;
                dtpBrkIni = dtpIniBrkMar;
                dtpBrkFin = dtpFinBrkMar;
                dtpTol = dtpToleranciaMar;
            }
            else if (checkBox.Name == chkMiercoles.Name)
            {
                dia = DayOfWeek.Wednesday;
                dtpIni = dtpIniLabMie;
                dtpFin = dtpFinLabMie;
                dtpBrkIni = dtpIniBrkMie;
                dtpBrkFin = dtpFinBrkMie;
                dtpTol = dtpToleranciaMie;
            }
            else if (checkBox.Name == chkJueves.Name)
            {
                dia = DayOfWeek.Thursday;
                dtpIni = dtpIniLabJue;
                dtpFin = dtpFinLabJue;
                dtpBrkIni = dtpIniBrkJue;
                dtpBrkFin = dtpFinBrkJue;
                dtpTol = dtpToleranciaJue;
            }
            else if (checkBox.Name == chkViernes.Name)
            {
                dia = DayOfWeek.Friday;
                dtpIni = dtpIniLabVie;
                dtpFin = dtpFinLabVie;
                dtpBrkIni = dtpIniBrkVie;
                dtpBrkFin = dtpFinBrkVie;
                dtpTol = dtpToleranciaVie;
            }

            else if (checkBox.Name == chkSabado.Name)
            {
                dia = DayOfWeek.Saturday;
                dtpIni = dtpIniLabSab;
                dtpFin = dtpFinLabSab;
                dtpBrkIni = dtpIniBrkSab;
                dtpBrkFin = dtpFinBrkSab;
                dtpTol = dtpToleranciaSab;
            }

            horasDelDia = new LABt04_horario_emp_dtl()
            {
                hora_inicio = dtpIni.Value.TimeOfDay,
                hora_fin = dtpFin.Value.TimeOfDay,
                tiempo_tolerancia = dtpTol.Value.TimeOfDay
            };
            if (dtpBrkIni.CustomFormat != " ")
            {
                horasDelDia.hora_inicio_break = dtpBrkIni.Value.TimeOfDay;
            }
            if (dtpBrkFin.CustomFormat != " ")
            {
                horasDelDia.hora_fin_break = dtpBrkFin.Value.TimeOfDay;
            }

            return new Tuple<DayOfWeek, LABt04_horario_emp_dtl>(dia, horasDelDia);
        }

        private void AsignarHorario()
        {
            var tuplaValidarFechas = ValidarFechas();
            if (tuplaValidarFechas.Item1)
            {
                var fechas = tuplaValidarFechas.Item2;

                //update
                if (_horario != null && _horario.id_horario_emp > 0)
                {

                }
                //insert
                else
                {
                    var horario = new LABt03_horario_emp()
                    {
                        fecha_inicio_horario = fechas.Min(x => x.fecha_labor),
                        fecha_fin_horario = fechas.Max(x => x.fecha_labor),
                        id_empleado = _empleado.id_empleado
                    };

                    horario.LABt04_horario_emp_dtl = fechas;

                    long idNuevoHorario = new HorarioEmpleadoBL().InsertarHorario(horario);
                    if (idNuevoHorario > 0)
                    {
                        _seAsigno = true;
                        Dispose();
                    }
                    else
                    {
                        Msg.Ok_Err("No se pudo asignar el horario.");
                    }
                }
            }
        }

        private void ConfigurarControles()
        {

            #region DateTimePicker

            dtpDesde.MinDate = dtpHasta.MinDate = DateTime.Now.Date;
            dtpDesde.MaxDate = dtpHasta.MaxDate = KeyDates.MaxDate;

            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyyy";

            var dtpsLabor = (DateTimePicker[])GetControls(TipoControl.DtpLabor);

            foreach (var dtpLabor in dtpsLabor)
            {
                ControlHelper.FormatDatePicker(dtpLabor, customFormat: "hh:mm tt");
            }

            foreach (var dtpTol in (DateTimePicker[])GetControls(TipoControl.DtpTiempoTolerancia))
            {
                ControlHelper.FormatDatePicker(dtpTol, customFormat: "HH:mm");
            }

            #endregion
        }

        private void EvaluarDiasDisponibles()
        {
            var fechaDesde = dtpDesde.Value.Date;
            var fechaHasta = dtpHasta.Value.Date;

            if ((fechaHasta - fechaDesde).Days >= 6)
            {
                foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
                {
                    chkDia.Enabled = true;
                }
            }
            else
            {
                var diasHabilitados = new List<DayOfWeek>();
                while (fechaDesde <= fechaHasta)
                {
                    diasHabilitados.Add(fechaDesde.DayOfWeek);
                    fechaDesde = fechaDesde.AddDays(1);
                }

                foreach (var tuplaChkDia in (List<Tuple<CheckBox, DayOfWeek>>)GetControls(TipoControl.CheckDiaTupla))
                {
                    tuplaChkDia.Item1.Enabled = diasHabilitados.Any(x => x == tuplaChkDia.Item2);
                    if (!tuplaChkDia.Item1.Enabled)
                    {
                        tuplaChkDia.Item1.Checked = false;
                    }
                }
            }
        }

        private Tuple<bool, ICollection<LABt04_horario_emp_dtl>> ValidarFechas()
        {
            bool no_error = true;
            var fechas = new List<LABt04_horario_emp_dtl>();

            //validar que existe el empleado
            if (_empleado == null ||
                !(_empleado.id_empleado > 0))
            {
                no_error = false;
                Msg.Ok_Wng("Busque y seleccione un empleado antes de asignar un horario.", "Validación");
            }

            //validar el rango de fechas
            if (no_error && dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                no_error = false;
                Msg.Ok_Wng("La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".", "Validación");
            }

            //validar rango de fechas y fechas de ingreso y cese del empleado
            if (no_error)
            {
                var fechaIngreso = _empleado.fecha_ingreso?.Date;
                var fechaCese = _empleado.fecha_cese?.Date;

                if (fechaIngreso != null && fechaIngreso > dtpDesde.Value.Date)
                {
                    no_error = false;
                    Msg.Ok_Wng("La fecha \"Desde\" no puede ser menor que la fecha de ingreso del empleado.", "Validación");
                }
                else if (fechaCese != null && fechaCese < dtpHasta.Value.Date)
                {
                    no_error = false;
                    Msg.Ok_Wng("La fecha \"Hasta\" no puede ser mayor que la fecha de cese del empleado.", "Validación");
                }
            }

            //Validar las fechas a asignar/editar
            if (no_error)
            {
                fechas = GetRangoDeFechas();
                if (fechas == null || !(fechas.Count > 0))
                {
                    no_error = false;
                    Msg.Ok_Wng("Debe seleccionar los días que desea asignar al empleado.", "Validación");
                }
            }

            return new Tuple<bool, ICollection<LABt04_horario_emp_dtl>>(no_error, fechas);
        }

        private void VisibleOrInvisibleDtps(DateTimePicker[] dtps, bool visible)
        {
            foreach (var dtp in dtps)
            {
                dtp.Visible = visible;
            }
        }

        private void ToggleHorasDelDia(CheckBox checkBox)
        {
            if (checkBox.Name == chkDomingo.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraDom), checkBox.Checked);
            }
            else if (checkBox.Name == chkLunes.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraLun), checkBox.Checked);
            }
            else if (checkBox.Name == chkMartes.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraMar), checkBox.Checked);
            }
            else if (checkBox.Name == chkMiercoles.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraMie), checkBox.Checked);
            }
            else if (checkBox.Name == chkJueves.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraJue), checkBox.Checked);
            }
            else if (checkBox.Name == chkViernes.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraVie), checkBox.Checked);
            }
            else if (checkBox.Name == chkSabado.Name)
            {
                VisibleOrInvisibleDtps((DateTimePicker[])GetControls(TipoControl.DtpHoraSab), checkBox.Checked);
            }

        }

        private void ToggleDtpBreak(DateTimePicker dtp, string customFormat)
        {
            string format = customFormat;
            if (dtp.Name == dtpIniBrkDom.Name || dtp.Name == dtpFinBrkDom.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkDom, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkDom, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkLun.Name || dtp.Name == dtpFinBrkLun.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkLun, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkLun, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkMar.Name || dtp.Name == dtpFinBrkMar.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkMar, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkMar, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkMie.Name || dtp.Name == dtpFinBrkMie.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkMie, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkMie, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkJue.Name || dtp.Name == dtpFinBrkJue.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkJue, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkJue, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkVie.Name || dtp.Name == dtpFinBrkVie.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkVie, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkVie, customFormat: format);
            }
            else if (dtp.Name == dtpIniBrkSab.Name || dtp.Name == dtpFinBrkSab.Name)
            {
                ControlHelper.FormatDatePicker(dtpIniBrkSab, customFormat: format);
                ControlHelper.FormatDatePicker(dtpFinBrkSab, customFormat: format);
            }
        }

        #endregion

        #region Eventos
        private void FormAsignarHorario_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            LimpiarForm();
            AddHandlers();
            dtpHasta.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AsignarHorario();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                Msg.Ok_Wng("La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".");
                dtpDesde.Value = dtpHasta.Value.Date;
            }
            else
            {
                EvaluarDiasDisponibles();
            }

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                Msg.Ok_Wng("La fecha \"Hasta\" no puede ser menor que la fecha \"Desde\".");
                dtpHasta.Value = dtpDesde.Value.Date;
            }
            else
            {
                EvaluarDiasDisponibles();
            }
        }

        private void dtpHasta_CloseUp(object sender, EventArgs e)
        {
            if (dtpHasta.CustomFormat == " ")
            {
                ControlHelper.FormatDatePicker(dtpHasta, customFormat: "dd/MM/yyyy", showUpDown: false);
                EvaluarDiasDisponibles();
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            ToggleHorasDelDia(chk);
        }

        private void DtpBreak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ToggleDtpBreak((DateTimePicker)sender, " ");
            }
        }

        private void DtpBreak_MouseDown(object sender, MouseEventArgs e)
        {
            ToggleDtpBreak((DateTimePicker)sender, "hh:mm tt");
        }

        private void dtpHoraInicioLabor_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraInicioLabor(dtp);
        }

        private void dtpHoraFinLabor_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraFinLabor(dtp);
        }

        private void dtpHoraInicioBreak_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraInicioBreak(dtp);
        }

        private void dtpHoraFinBreak_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraFinBreak(dtp);
        }

        private void dtpTiempoTolerancia_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarTiempoTolerancia(dtp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fechasL = GetRangoDeFechas();
            if (fechasL != null)
            {
                string fechas = "";
                foreach (var fecha in fechasL)
                {
                    fechas += fecha.fecha_labor.ToLongDateString() + "\n";
                }
                Msg.Ok_Info(fechas);
            }
        }

        #endregion
    }
}
