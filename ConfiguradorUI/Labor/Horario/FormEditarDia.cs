using ConfigBusinessEntity;
using ConfigBusinessLogic.Labor;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
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
    public partial class FormEditarDia : MetroForm
    {
        public bool _seOpero = false;
        LABt04_horario_emp_dtl _horarioDtl;
        int _tipoOperacion;

        public FormEditarDia(LABt04_horario_emp_dtl horarioDtl, int tipoOperacion)
        {
            InitializeComponent();
            _horarioDtl = horarioDtl;
            _tipoOperacion = tipoOperacion;
        }

        private void AddHandlers()
        {
            dtpHoraInicioLabor.ValueChanged += dtpHoraInicioLabor_ValueChanged;
            dtpHoraFinLabor.ValueChanged += dtpHoraFinLabor_ValueChanged;

            dtpHoraInicioBreak.ValueChanged += dtpHoraInicioBreak_ValueChanged;
            dtpHoraFinBreak.ValueChanged += dtpHoraFinBreak_ValueChanged;

            dtpTiempoTolerancia.ValueChanged += dtpTiempoTolerancia_ValueChanged;

            dtpHoraInicioBreak.KeyPress += DtpBreak_KeyPress;
            dtpHoraFinBreak.KeyPress += DtpBreak_KeyPress;

            dtpHoraInicioBreak.MouseDown += DtpBreak_MouseDown;
            dtpHoraFinBreak.MouseDown += DtpBreak_MouseDown;
        }

        private void ConfigurarControles()
        {
            ControlHelper.FormatDatePicker(dtpHoraInicioLabor, customFormat: "hh:mm tt");
            ControlHelper.FormatDatePicker(dtpHoraFinLabor, customFormat: "hh:mm tt");
            ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: " ");
            ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: " ");
            ControlHelper.FormatDatePicker(dtpTiempoTolerancia, customFormat: "HH:mm");

            if (_horarioDtl != null && _horarioDtl.id_horario_emp_dtl > 0)
            {
                dtpHoraInicioBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
                dtpHoraFinBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
            }
            else
            {
                dtpHoraInicioLabor.Value = Convert.ToDateTime(new TimeSpan(8, 0, 0).ToString());
                dtpHoraFinLabor.Value = Convert.ToDateTime(new TimeSpan(17, 0, 0).ToString());

                dtpHoraInicioBreak.Value = Convert.ToDateTime(new TimeSpan(12, 0, 0).ToString());
                dtpHoraFinBreak.Value = Convert.ToDateTime(new TimeSpan(13, 0, 0).ToString());

                dtpTiempoTolerancia.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }
        }

        private DateTimePicker[] GetDtps()
        {
            return new[]
                    {
                        dtpHoraInicioLabor,
                        dtpHoraFinLabor,
                        dtpHoraInicioBreak,
                        dtpHoraFinBreak,
                        dtpTiempoTolerancia
                    };
        }


        private LABt04_horario_emp_dtl GetHorarioDtl()
        {
            var horarioDtl = new LABt04_horario_emp_dtl
            {
                fecha_labor = _horarioDtl.fecha_labor,
                id_horario_emp_dtl = _horarioDtl.id_horario_emp_dtl,
                id_horario_emp = _horarioDtl.id_horario_emp,

                hora_inicio = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay),
                hora_fin = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay),
                tiempo_tolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay)
            };

            if (dtpHoraInicioBreak.CustomFormat != " " && dtpHoraFinBreak.CustomFormat != " ")
            {
                horarioDtl.hora_inicio_break = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                horarioDtl.hora_fin_break = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);
            }

            return horarioDtl;
        }

        private void SetHorarioDtl()
        {
            if (_horarioDtl != null)
            {
                lblNombreForm.Text = "Editar: " + _horarioDtl.fecha_labor.ToLongDateString();

                dtpHoraInicioLabor.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
                dtpHoraFinLabor.Value = Convert.ToDateTime(_horarioDtl.hora_fin.ToString());

                if (_horarioDtl.hora_inicio_break != null)
                {
                    dtpHoraInicioBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio_break.ToString());
                    ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: "hh:mm tt");
                }

                if (_horarioDtl.hora_fin_break != null)
                {
                    dtpHoraFinBreak.Value = Convert.ToDateTime(_horarioDtl.hora_fin_break.ToString());
                    ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: "hh:mm tt");
                }

                dtpTiempoTolerancia.Value = Convert.ToDateTime(_horarioDtl.tiempo_tolerancia.ToString());
                chkModificarEnTodosLosMismosDias.Text = "Guardar las mismas horas para todos los " + _horarioDtl.fecha_labor.ToString("dddd");
            }
        }

        private TimeSpan GetHoraYMinutos(TimeSpan hora)
        {
            return new TimeSpan(hora.Hours, hora.Minutes, 0);
        }

        private void ValidarHoraInicioLabor(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;

            TimeSpan horaInicio = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFin = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);

            if (dtpHoraInicioBreak.CustomFormat != " ")
            {
                var horaInicioBrk = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                if (horaInicio > horaInicioBrk)
                {
                    Msg.Ok_Wng("La \"Hora inicio\" no puede ser mayor que la hora \"Inicio break\".", "Validación");
                    dtp.Value = Convert.ToDateTime(horaInicioBrk.ToString());
                }
            }
            else if (horaInicio > horaFin)
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
            TimeSpan horaFin = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicio = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);

            if (dtpHoraFinBreak.CustomFormat != " ")
            {
                var horaFinBrk = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);
                if (horaFin < horaFinBrk)
                {
                    Msg.Ok_Wng("La \"Hora fin\" no puede ser menor que la hora \"Fin break\".", "Validación");
                    dtp.Value = Convert.ToDateTime(horaFinBrk.ToString());
                }
            }
            else if (horaFin < horaInicio)
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
            TimeSpan horaInicioBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            TimeSpan horaFinBreak = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);

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
            TimeSpan horaFinBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            TimeSpan horaInicioBreak = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);

            if (horaFinBreak > horaFinLabor)
            {
                Msg.Ok_Wng("La hora \"Fin break\" no puede ser mayor que la \"Hora Fin\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaInicioBreak.ToString());
            }
            else if (horaFinBreak < horaInicioBreak)
            {
                Msg.Ok_Wng("La hora \"Fin break\" no puede ser menor que la hora \"Inicio break\".", "Validación");
                dtp.Value = Convert.ToDateTime(horaInicioBreak.ToString());
            }
        }

        private void ValidarTiempoTolerancia(DateTimePicker dtp)
        {
            TimeSpan tiempoTolerancia = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            TimeSpan horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            TimeSpan maxTolerancia = horaFinLabor - horaInicioLabor;

            if (tiempoTolerancia > maxTolerancia)
            {
                Msg.Ok_Wng($"El tiempo de \"Tolerancia\" sobrepasa al rango de horas del día ({maxTolerancia.ToString()} horas).", "Validación");
                dtp.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
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
            if (dtp.CustomFormat != " ")
            {
                ValidarHoraInicioBreak(dtp);
            }
        }

        private void dtpHoraFinBreak_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            if (dtp.CustomFormat != " ")
            {
                ValidarHoraFinBreak(dtp);
            }
        }

        private void dtpTiempoTolerancia_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarTiempoTolerancia(dtp);
        }

        private void DtpBreak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape && ((DateTimePicker)sender).CustomFormat != " ")
            {
                ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: " ");
                ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: " ");
            }
        }

        private void DtpBreak_MouseDown(object sender, MouseEventArgs e)
        {
            if (((DateTimePicker)sender).CustomFormat != "hh:mm tt")
            {
                var fecha = Convert.ToDateTime(dtpHoraInicioLabor.Value.TimeOfDay.ToString());
                dtpHoraInicioBreak.Value = fecha;
                dtpHoraFinBreak.Value = fecha;

                ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: "hh:mm tt");
                ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: "hh:mm tt");
            }
        }

        private void FormEditarDia_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            SetHorarioDtl();
            AddHandlers();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (EsValido())
            {
                var horarioDtl = GetHorarioDtl();
                bool success = false;
                if (chkModificarEnTodosLosMismosDias.Checked)
                {
                    var hoy = DateTime.Now.Date;
                    success = new HorarioEmpleadoBL().ActualizarHorariosDtlXDiaDeSemana(horarioDtl, hoy, horarioDtl.fecha_labor);
                }
                else
                {
                    success = new HorarioEmpleadoBL().ActualizarHorarioDtl(horarioDtl);
                }

                if (success)
                {
                    _seOpero = true;
                    Dispose();
                }
                else
                {
                    Msg.Ok_Err("No se pudo realizar la actualización.");
                }
            }
        }

        private bool EsValido()
        {
            bool no_error = true;
            var hoy = DateTime.Now.Date;
            var horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            var horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            var maxTolerancia = (horaFinLabor - horaInicioLabor);
            var tiempoTolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay);

            if(hoy > _horarioDtl.fecha_labor)
            {
                no_error = false;
                Msg.Ok_Wng("No se puede actualizar una fecha inferior a la fecha actual.", "Validación");
            }
            else if (horaInicioLabor > horaFinLabor)
            {
                no_error = false;
                Msg.Ok_Wng("La \"Hora Inicio\" no puede ser mayor que la \"Hora Fin\".", "Validación");
                dtpHoraInicioLabor.Focus();
            }
            else if (tiempoTolerancia > maxTolerancia)
            {
                no_error = false;
                Msg.Ok_Wng($"El tiempo de \"Tolerancia\" sobrepasa al rango de horas del día ({maxTolerancia.ToString()} horas).", "Validación");
                dtpTiempoTolerancia.Focus();
            }

            if (no_error && dtpHoraInicioBreak.CustomFormat != " " && dtpHoraInicioBreak.CustomFormat != " ")
            {
                var horaInicioBrk = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                var horaFinBrk = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);

                if (horaInicioBrk < horaInicioLabor)
                {
                    no_error = false;
                    Msg.Ok_Wng("La hora \"Inicio break\" no puede ser menor que la \"Hora inicio\".", "Validación");
                    dtpHoraInicioBreak.Focus();
                }
                else if (horaFinBrk > horaFinLabor)
                {
                    no_error = false;
                    Msg.Ok_Wng("La hora \"Fin break\" no puede ser mayor que la \"Hora fin\".", "Validación");
                    dtpHoraFinBreak.Focus();
                }
            }

            return no_error;
        }
    }
}
