using ConfigBusinessLogic.Persona;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ConfigBusinessEntity;
using ConfigUtilitarios;
using ConfigBusinessLogic.Labor;
using ConfigUtilitarios.HelperControl;
using System.Drawing;
using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Labor
{
    public partial class FormHorarioEmpleado : MetroForm
    {
        #region Varibles Globales

        private int _tipoOperacion = TipoOperacionABM.No_Action;
        enum TipoControl
        {
            CheckDia,
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

        private PERt04_empleado _empleado;
        private LABt03_horario_emp _horario;
        IEnumerable<DateTime> _horarioSoloFechas;
        private List<LABt04_horario_emp_dtl> _fechasSeleccionadas;

        #endregion

        public FormHorarioEmpleado()
        {
            InitializeComponent();
        }

        private void AddHandlers()
        {
            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.CheckedChanged += chk_CheckedChanged;
            }

            foreach (var dtpBreak in (DateTimePicker[])GetControls(TipoControl.DtpBreak))
            {
                dtpBreak.MouseDown += Dtp_MouseDown;
                dtpBreak.KeyPress += DtpBreak_KeyPress;
            }

            foreach (var dtpHoraInicioLabor in (DateTimePicker[])GetControls(TipoControl.DtpInicioLabor))
            {
                dtpHoraInicioLabor.ValueChanged += dtpHoraInicioLabor_ValueChanged;
            }
            //--
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
            //--

            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
        }

        private void RemoveHandlers()
        {
            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.CheckedChanged -= chk_CheckedChanged;
            }

            foreach (var dtpBreak in (DateTimePicker[])GetControls(TipoControl.DtpBreak))
            {
                dtpBreak.MouseDown -= Dtp_MouseDown;
                dtpBreak.KeyPress -= DtpBreak_KeyPress;
            }

            foreach (var dtpHoraInicio in (DateTimePicker[])GetControls(TipoControl.DtpInicioLabor))
            {
                dtpHoraInicio.ValueChanged -= dtpHoraInicioLabor_ValueChanged;
            }

            foreach (var dtpHoraFinLabor in (DateTimePicker[])GetControls(TipoControl.DtpFinLabor))
            {
                dtpHoraFinLabor.ValueChanged -= dtpHoraFinLabor_ValueChanged;
            }

            foreach (var dtpHoraInicioBreak in (DateTimePicker[])GetControls(TipoControl.DtpInicioBreak))
            {
                dtpHoraInicioBreak.ValueChanged -= dtpHoraInicioBreak_ValueChanged;
            }

            foreach (var dtpHoraFinBreak in (DateTimePicker[])GetControls(TipoControl.DtpFinBreak))
            {
                dtpHoraFinBreak.ValueChanged -= dtpHoraFinBreak_ValueChanged;
            }

            foreach (var dtpTiempoTolerancia in (DateTimePicker[])GetControls(TipoControl.DtpTiempoTolerancia))
            {
                dtpTiempoTolerancia.ValueChanged -= dtpTiempoTolerancia_ValueChanged;
            }

            dtpDesde.ValueChanged -= dtpDesde_ValueChanged;
            dtpHasta.ValueChanged -= dtpHasta_ValueChanged;
        }

        private dynamic[] GetControls(TipoControl tipoControl)
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

        private void SetEmpleado(PERt04_empleado empleado)
        {
            _empleado = empleado;

            var nombreCompleto = GetNombreCompletoDeEmpleado();

            lblNombreEmpleado.Text = nombreCompleto.ToUpper();
            txtNombreEmpleado.Text = nombreCompleto.ToUpper();
            txtInicioContrato.Text = _empleado.fecha_ingreso?.ToShortDateString();
            txtFinContrato.Text = _empleado.fecha_cese?.ToShortDateString();

            string GetNombreCompletoDeEmpleado()
            {
                return string.IsNullOrEmpty(_empleado.txt_ape_mat) ?
                        $"{_empleado.txt_ape_pat}, {_empleado.txt_pri_nom} {_empleado.txt_seg_nom}"
                        : $"{_empleado.txt_ape_pat} {_empleado.txt_ape_mat}, {_empleado.txt_pri_nom} {_empleado.txt_seg_nom}";
            }

        }

        // Métodos para buscar y luego cargar el horario de un empleado
        private void BuscarEmpleado()
        {
            string nroDoc = txtNroDocEmp.Text.Trim();
            if (nroDoc != string.Empty)
            {
                var empleado = new EmpleadoBL().EmpleadoXNroDoc(nroDoc);

                if (empleado != null &&
                    empleado.id_empleado > 0)
                {
                    LimpiarForm();
                    SetHorarioYEmpleado(empleado);
                    AddHandlers();
                }
                else
                {
                    //abrir emergente
                }
            }
            else
            {
                //abrir emergente
            }
        }

        private void LimpiarDatosMemoria()
        {
            _fechasSeleccionadas = null;
        }

        private void LimpiarForm()
        {

            _tipoOperacion = TipoOperacionABM.No_Action;

            LimpiarEmpleado();
            LimpiarHorario();
            LimpiarDatosMemoria();
            btnNuevo.Enabled = btnDesasignarFechas.Enabled = false;
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
                if(tiempoTolerancia > maxTiempoTolerancia)
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
            else if(horaInicioBreak > horaFinBreak)
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
                dtp.Value = Convert.ToDateTime(new TimeSpan(0,0,0).ToString());
            }
        }

        private void SetHorarioYEmpleado(PERt04_empleado empleado)
        {
            SetEmpleado(empleado);
            var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
            SetHorario(horario);

            btnNuevo.Enabled = true;
            btnDesasignarFechas.Enabled = (horario != null && horario.id_horario_emp > 0);
        }

        private void LimpiarHorario()
        {
            LimpiarChecksYDtps();

            ControlarAction();

            mcaMes.RemoveAllBoldedDates();
            mcaMes.UpdateBoldedDates();
        }

        private void SetHorario(LABt03_horario_emp horario)
        {
            try
            {
                _horario = horario;

                if (_horario != null &&
                       _horario.id_horario_emp > 0)
                {
                    if (_horario.LABt04_horario_emp_dtl != null)
                    {
                        _horarioSoloFechas = _horario.LABt04_horario_emp_dtl.Select(x => x.fecha_labor);
                    }

                    var fechasDeLaborRestante = _horarioSoloFechas.Count(x => x.Date >= DateTime.Now.Date);

                    lblRangoHorario.ForeColor = Color.Navy;
                    lblRangoHorario.Text = $"Horario desde {_horario.fecha_inicio_horario.ToShortDateString()} " +
                                            $"hasta {_horario.fecha_fin_horario.ToShortDateString()} - {fechasDeLaborRestante} días restantes";

                    MarcarODesmarcarFechas(_horarioSoloFechas);
                }
                else
                {
                    lblRangoHorario.ForeColor = Color.Red;
                    lblRangoHorario.Text = "NO TIENE HORARIO ASIGNADO";
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo mostrar el horario correctamente. Error: " + e.Message);
            }
        }

        private void MarcarODesmarcarFechas(IEnumerable<DateTime> fechas)
        {
            if (_horarioSoloFechas == null)
            {
                _horarioSoloFechas = new List<DateTime>();
            }

            if (fechas != null)
            {
                if (_tipoOperacion == TipoOperacionABM.Insertar)
                {
                    mcaMes.BoldedDates = fechas.Union(_horarioSoloFechas)
                                                .ToArray();
                }
                else if (_tipoOperacion == TipoOperacionABM.Eliminar)
                {

                }
                else if (_tipoOperacion == TipoOperacionABM.No_Action)
                {
                    mcaMes.BoldedDates = fechas.ToArray();
                }
            }
            else
            {
                mcaMes.RemoveAllBoldedDates();
            }

            mcaMes.UpdateBoldedDates();
        }

        private IEnumerable<DateTime> GetSoloFechas(IEnumerable<LABt04_horario_emp_dtl> horarioDtl)
        {
            return horarioDtl.Select(x => x.fecha_labor);
        }

        private void AgregarOQuitarFechas(CheckBox checkBox)
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            if (_fechasSeleccionadas == null)
            {
                _fechasSeleccionadas = new List<LABt04_horario_emp_dtl>();
            }

            var diaYHorasDelDia = GetDiaYHorasDelDia(checkBox);

            _fechasSeleccionadas.RemoveAll(x => x.fecha_labor.DayOfWeek == diaYHorasDelDia.Item1);

            if (checkBox.Checked)
            {
                var fechasSeleccionadas = GetRangoDeFechas(desde, hasta, diaYHorasDelDia.Item1, diaYHorasDelDia.Item2);
                _fechasSeleccionadas.AddRange(fechasSeleccionadas);
            }
            MarcarODesmarcarFechas(GetSoloFechas(_fechasSeleccionadas));

        }

        private void AgregarOQuitarFechas()
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            if (_fechasSeleccionadas == null)
            {
                _fechasSeleccionadas = new List<LABt04_horario_emp_dtl>();
            }

            var diasChecked = new List<CheckBox>();

            #region Add días marcados
            if (chkDomingo.Checked)
            {
                diasChecked.Add(chkDomingo);
            }
            if (chkLunes.Checked)
            {
                diasChecked.Add(chkLunes);
            }
            if (chkMartes.Checked)
            {
                diasChecked.Add(chkMartes);
            }
            if (chkMiercoles.Checked)
            {
                diasChecked.Add(chkMiercoles);
            }
            if (chkJueves.Checked)
            {
                diasChecked.Add(chkJueves);
            }
            if (chkViernes.Checked)
            {
                diasChecked.Add(chkViernes);
            }
            if (chkSabado.Checked)
            {
                diasChecked.Add(chkSabado);
            }
            #endregion

            foreach (var chk in diasChecked)
            {
                var diaYHorasDelDia = GetDiaYHorasDelDia(chk);

                _fechasSeleccionadas.RemoveAll(x => x.fecha_labor.DayOfWeek == diaYHorasDelDia.Item1);

                var fechasSeleccionadas = GetRangoDeFechas(desde, hasta, diaYHorasDelDia.Item1, diaYHorasDelDia.Item2);
                _fechasSeleccionadas.AddRange(fechasSeleccionadas);
            }

            MarcarODesmarcarFechas(GetSoloFechas(_fechasSeleccionadas));
        }

        private List<LABt04_horario_emp_dtl> GetRangoDeFechas(DateTime desde, DateTime hasta, DayOfWeek dia, LABt04_horario_emp_dtl horas)
        {
            var fechas = new List<LABt04_horario_emp_dtl>();
            var diaIterado = desde;

            while (diaIterado <= hasta)
            {
                if (diaIterado.DayOfWeek == dia)
                {
                    fechas.Add(
                        new LABt04_horario_emp_dtl
                        {
                            fecha_labor = diaIterado,
                            hora_inicio = horas.hora_inicio,
                            hora_fin = horas.hora_fin,
                            hora_inicio_break = horas.hora_inicio_break,
                            hora_fin_break = horas.hora_fin_break,
                            tiempo_tolerancia = horas.tiempo_tolerancia
                        }
                        );
                }

                diaIterado = diaIterado.AddDays(1);
            }

            return fechas;

        }

        private Tuple<DayOfWeek, LABt04_horario_emp_dtl> GetDiaYHorasDelDia(CheckBox checkBox)
        {
            DayOfWeek dia = DayOfWeek.Saturday;
            var horasDelDia = new LABt04_horario_emp_dtl();

            if (checkBox.Name == chkDomingo.Name)
            {
                dia = DayOfWeek.Sunday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabDom.Value.TimeOfDay,
                    hora_fin = dtpFinLabDom.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkDom.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkDom.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaDom.Value.TimeOfDay
                };

            }
            else if (checkBox.Name == chkLunes.Name)
            {
                dia = DayOfWeek.Monday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabLun.Value.TimeOfDay,
                    hora_fin = dtpFinLabLun.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkLun.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkLun.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaLun.Value.TimeOfDay
                };
            }
            else if (checkBox.Name == chkMartes.Name)
            {
                dia = DayOfWeek.Tuesday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabMar.Value.TimeOfDay,
                    hora_fin = dtpFinLabMar.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkMar.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkMar.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaMar.Value.TimeOfDay
                };
            }
            else if (checkBox.Name == chkMiercoles.Name)
            {
                dia = DayOfWeek.Wednesday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabMie.Value.TimeOfDay,
                    hora_fin = dtpFinLabMie.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkMie.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkMie.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaMie.Value.TimeOfDay
                };
            }
            else if (checkBox.Name == chkJueves.Name)
            {
                dia = DayOfWeek.Thursday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabJue.Value.TimeOfDay,
                    hora_fin = dtpFinLabJue.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkJue.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkJue.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaJue.Value.TimeOfDay
                };
            }
            else if (checkBox.Name == chkViernes.Name)
            {
                dia = DayOfWeek.Friday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabVie.Value.TimeOfDay,
                    hora_fin = dtpFinLabVie.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkVie.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkVie.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaVie.Value.TimeOfDay
                };
            }

            else if (checkBox.Name == chkSabado.Name)
            {
                dia = DayOfWeek.Saturday;
                horasDelDia = new LABt04_horario_emp_dtl()
                {
                    hora_inicio = dtpIniLabSab.Value.TimeOfDay,
                    hora_fin = dtpFinLabSab.Value.TimeOfDay,
                    hora_inicio_break = dtpIniBrkSab.Value.TimeOfDay,
                    hora_fin_break = dtpFinBrkSab.Value.TimeOfDay,
                    tiempo_tolerancia = dtpToleranciaSab.Value.TimeOfDay
                };
            }

            return new Tuple<DayOfWeek, LABt04_horario_emp_dtl>(dia, horasDelDia);
        }

        private void AsignarHorario()
        {

            if (EsValido())
            {
                //update
                if (_horario != null && _horario.id_horario_emp > 0)
                {

                }
                //insert
                else
                {
                    var horario = new LABt03_horario_emp()
                    {
                        fecha_inicio_horario = dtpDesde.Value.Date,
                        fecha_fin_horario = dtpHasta.Value.Date,
                        id_empleado = _empleado.id_empleado
                    };

                    horario.LABt04_horario_emp_dtl = _fechasSeleccionadas;

                    long idNuevoHorario = new HorarioEmpleadoBL().InsertarHorario(horario);
                    if (idNuevoHorario > 0)
                    {
                        Msg.Ok_Info("Se asignó el horario correctamente.");
                        LimpiarForm();
                        SetHorarioYEmpleado(_empleado);
                    }
                }
            }
        }

        private List<LABt04_horario_emp_dtl> GetObjetoDtl()
        {
            var obj = new List<LABt04_horario_emp_dtl>();
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(this, $@"Excepción en el Get: {e.Message}");
            }
            return obj;
        }

        private void LimpiarEmpleado()
        {
            lblNombreEmpleado.Text = "EMPLEADO: NINGUNO";
            lblRangoHorario.Text = "HORARIO: NINGUNO";

            txtNombreEmpleado.Clear();
            txtInicioContrato.Clear();
            txtFinContrato.Clear();
            txtNroDocEmp.Clear();
        }

        private void LimpiarChecksYDtps()
        {
            dtpDesde.Value = DateTime.Now.Date;
            dtpHasta.Value = DateTime.Now.Date.AddMonths(1);

            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.Checked = false;
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

        private void ConfigurarControles()
        {
            #region labels

            lblRangoHorario.UseCustomForeColor = true;

            #endregion

            #region paneles
            ControlarAction();

            #endregion

            #region botones

            btnNuevo.Enabled = false;
            btnDesasignarFechas.Enabled = false;

            #endregion

            #region DateTimePicker

            dtpDesde.MinDate = DateTime.Now.Date;
            dtpDesde.MaxDate = new DateTime(2050, 12, 31).Date;
            dtpHasta.MaxDate = new DateTime(2050, 12, 31).Date;

            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyyy";

            var dtpsTolerancia = (DateTimePicker[])GetControls(TipoControl.DtpTiempoTolerancia);
            var dtpsLabor = (DateTimePicker[])GetControls(TipoControl.DtpLabor);

            foreach (var dtpLabor in dtpsLabor.Union(dtpsTolerancia))
            {
                ControlHelper.FormatDatePicker(dtpLabor, customFormat: "HH:mm");
            }

            #endregion
        }

        private void ControlarAction()
        {
            if (_tipoOperacion == TipoOperacionABM.No_Action)
            {
                pnlControlesGenerales.Visible = false;
            }
            else if (_tipoOperacion == TipoOperacionABM.Insertar)
            {
                LimpiarChecksYDtps();


                lblOperacionActual.Text = "Asignar horario. Seleccione los días a asignar y comfirme.";
                pnlHoras.Visible = true;
                pnlControlesGenerales.Visible = true;


            }
            else if (_tipoOperacion == TipoOperacionABM.Eliminar)
            {
                LimpiarChecksYDtps();
            
                lblOperacionActual.Text = "Quitar fechas. Seleccione los días a desasignar y confirme.";
                pnlControlesGenerales.Visible = true;
                pnlHoras.Visible = false;
            }
        }

        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
        {
            btnNuevo.Enabled = eNuevo;
            //btnDelete.Enabled = eDelete;
            //btnCommit.Enabled = eCommit;
            //btnRollback.Enabled = eRollback;
            //btnSearch.Enabled = eSearch;
            //btnFilter.Enabled = eFilter;
        }

        private bool EsValido()
        {
            bool no_error = true;

            //validar que existe el empleado
            if (_empleado == null ||
                !(_empleado.id_empleado > 0))
            {
                no_error = false;
                tabHorario.SelectedTab = tabPagGeneral;
                Msg.Ok_Wng("Busque y seleccione un empleado antes de asignar un horario.", "Validación");
                txtNroDocEmp.Focus();
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

            if (_fechasSeleccionadas == null || !(_fechasSeleccionadas.Count > 0))
            {
                no_error = false;
            }

            return no_error;
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void FormHorarioEmpleado_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            LimpiarForm();
        }

        private void btnDesasignarFechas_Click(object sender, EventArgs e)
        {
            _tipoOperacion = TipoOperacionABM.Eliminar;
            ControlarAction();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (_tipoOperacion == TipoOperacionABM.Insertar)
            {
                AsignarHorario();
            }
            else if (_tipoOperacion == TipoOperacionABM.Eliminar)
            {
                QuitarFechas();
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
        private void VisibleOrInvisibleDtps(DateTimePicker[] dtps, bool visible)
        {
            foreach (var dtp in dtps)
            {
                dtp.Visible = visible;
            }
        }

        private void QuitarFechas()
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (_tipoOperacion != TipoOperacionABM.Insertar)
            {
                _tipoOperacion = TipoOperacionABM.Insertar;
                RemoveHandlers();
                ControlarAction();
                AddHandlers();
            }
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
                AgregarOQuitarFechas();
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                Msg.Ok_Wng("El fecha \"Hasta\" no puede ser menor que la fecha \"Desde\".");
                dtpHasta.Value = dtpDesde.Value.Date;
            }
            else
            {
                AgregarOQuitarFechas();
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            ToggleHorasDelDia(chk);
            AgregarOQuitarFechas(chk);
        }

        private void ToggleDtpBreak(DateTimePicker dtp, string customFormat)
        {
            string format = customFormat;
            if(dtp.Name == dtpIniBrkDom.Name || dtp.Name == dtpFinBrkDom.Name)
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

        private void txtNroDocEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BuscarEmpleado();
        }
        private void DtpBreak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ToggleDtpBreak((DateTimePicker)sender, " ");
            }
        }

        private void Dtp_MouseDown(object sender, MouseEventArgs e)
        {
            ToggleDtpBreak((DateTimePicker)sender, "HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_fechasSeleccionadas != null)
            {
                string fechas = "";
                foreach (var fecha in _fechasSeleccionadas)
                {
                    fechas += fecha.fecha_labor.ToLongDateString() + "\n";
                }
                Msg.Ok_Info(fechas);
            }
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
    }
}
