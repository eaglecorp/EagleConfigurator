using ConfigBusinessEntity;
using ConfigBusinessLogic.Labor;
using ConfigBusinessLogic.Utiles;
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
    public partial class FormEliminarHorario : MetroForm
    {
        #region Varibles Globales

        enum TipoControl
        {
            CheckDia,
            CheckDiaTupla,
            ChekedDia,
            ChekedDiaTupla
        };

        public bool _seElimino = false;
        private PERt04_empleado _empleado;
        private LABt03_horario_emp _horario;

        #endregion

        public FormEliminarHorario(PERt04_empleado empleado, LABt03_horario_emp horario)
        {
            InitializeComponent();

            _empleado = empleado;
            _horario = horario;
        }

        #region Métodos


        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;

            dtpHasta.MouseDown += dtpHasta_MouseDown;
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
                case TipoControl.ChekedDiaTupla:
                    {
                        controls = new List<Tuple<CheckBox, DayOfWeek>>();

                        if (chkDomingo.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkDomingo, DayOfWeek.Sunday));
                        }
                        if (chkLunes.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkLunes, DayOfWeek.Monday));
                        }
                        if (chkMartes.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkMartes, DayOfWeek.Tuesday));
                        }
                        if (chkMiercoles.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkMiercoles, DayOfWeek.Wednesday));
                        }
                        if (chkJueves.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkJueves, DayOfWeek.Thursday));
                        }
                        if (chkViernes.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkViernes, DayOfWeek.Friday));
                        }
                        if (chkSabado.Checked)
                        {
                            controls.Add(new Tuple<CheckBox, DayOfWeek>(chkSabado, DayOfWeek.Saturday));
                        }
                    }
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
            errorProv.Clear();

            var hoy = UtilBL.GetCurrentDateTime.Date;

            var fechaDtp = hoy > _horario.fecha_inicio_horario ? hoy : _horario.fecha_inicio_horario;

            dtpDesde.Value = fechaDtp;
            dtpHasta.Value = fechaDtp;

            ControlHelper.FormatDatePicker(dtpHasta, " ", showUpDown: false);

            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.Checked = false;
                chkDia.Enabled = false;
            }
        }

        private TimeSpan GetHoraYMinutos(TimeSpan hora)
        {
            return new TimeSpan(hora.Hours, hora.Minutes, 0);
        }

        private List<LABt04_horario_emp_dtl> GetFechasEnRango()
        {
            var fechas = new List<LABt04_horario_emp_dtl>();
            try
            {
                var desde = dtpDesde.Value.Date;
                var hasta = dtpHasta.Value.Date;

                var diasEnRango = _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= desde && x.fecha_labor <= hasta);

                if (diasEnRango != null && diasEnRango.Count() > 0)
                {
                    var listTuplaDiaYHoras = (List<Tuple<CheckBox, DayOfWeek>>)GetControls(TipoControl.ChekedDiaTupla);

                    foreach (var fechaAsignada in diasEnRango)
                    {
                        if (listTuplaDiaYHoras.Any(x => x.Item2 == fechaAsignada.fecha_labor.DayOfWeek))
                        {
                            fechas.Add(fechaAsignada);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                fechas = new List<LABt04_horario_emp_dtl>();
                Msg.Ok_Err("No se pudo generar el rango fechas. Excepción: " + e.Message);
            }

            return fechas;
        }

        private void ConfigurarControles()
        {
            #region DateTimePicker

            var hoy = UtilBL.GetCurrentDateTime.Date;
            dtpDesde.MinDate = dtpHasta.MinDate = hoy > _horario.fecha_inicio_horario ? hoy : _horario.fecha_inicio_horario;
            dtpDesde.MaxDate = dtpHasta.MaxDate = _horario.fecha_fin_horario;

            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = DateFormat.DateOnly;

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = DateFormat.DateOnly;

            #endregion
        }

        private void EvaluarDiasDisponibles()
        {
            var fechaDesde = dtpDesde.Value.Date;
            var fechaHasta = dtpHasta.Value.Date;

            if ((fechaHasta - fechaDesde).Days >= 6)
            {
                EstadoDias(true);
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

        private void EstadoDias(bool estado)
        {
            foreach (var chkDia in (CheckBox[])GetControls(TipoControl.CheckDia))
            {
                chkDia.Enabled = estado;
            }
        }

        private Tuple<bool, ICollection<LABt04_horario_emp_dtl>> ValidarFechas()
        {
            bool no_error = true;
            var fechas = new List<LABt04_horario_emp_dtl>();

            errorProv.Clear();

            //validar que existe el empleado
            if (_empleado == null ||
                !(_empleado.id_empleado > 0))
            {
                no_error = false;
                Msg.Ok_Info("Busque y seleccione un empleado antes de asignar un horario.", "Validación");
            }

            //validando que se inferior a la fecha actual
            if (no_error)
            {
                var hoy = UtilBL.GetCurrentDateTime.Date;
                if (dtpDesde.Value.Date < hoy)
                {
                    no_error = false;
                    errorProv.SetError(dtpDesde, $"La fecha \"Desde\" no puede ser menor que la fecha actual ({hoy.ToString(DateFormat.DateOnly)}).");
                }
                else if (dtpHasta.Value.Date < hoy)
                {
                    no_error = false;
                    errorProv.SetError(dtpHasta, $"La fecha \"Hasta\" no puede ser menor que la fecha actual ({hoy.ToString(DateFormat.DateOnly)}).");
                }
            }

            //validar el rango de fechas
            if (no_error && dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                no_error = false;
                errorProv.SetError(dtpDesde, "La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".");
            }

            //Validar las fechas a asignar/editar
            if (no_error)
            {
                fechas = GetFechasEnRango();
                if (fechas == null || !(fechas.Count > 0))
                {
                    no_error = false;
                    Msg.Ok_Info("No ha seleccionado ningún día que eliminar.", "Validación");
                }
            }

            return new Tuple<bool, ICollection<LABt04_horario_emp_dtl>>(no_error, fechas);
        }

        private void EliminarHorario()
        {
            var tuplaValidarFechas = ValidarFechas();
            if (tuplaValidarFechas.Item1)
            {
                var fechasParaEliminar = tuplaValidarFechas.Item2;
                bool success = false;
                DateTime hoy = UtilBL.GetCurrentDateTime.Date;

                if (GetNumeroFechasPasadas(hoy) > 0 || fechasParaEliminar.Count < GetNumeroFechasRestantes(hoy))
                {
                    var IdsAEliminar = fechasParaEliminar.Select(x => x.id_horario_emp_dtl);
                    success = new HorarioEmpleadoBL().EliminarHorariosDtl(IdsAEliminar);
                    SalidaDeOperacion();
                }
                else if (Msg.YesNo_Wng("Está eliminando todas las fechas del horario del empleado. ¿Está seguro de continuar?") == DialogResult.Yes)
                {
                    success = new HorarioEmpleadoBL().EliminarHorario(_horario.id_horario_emp);
                    SalidaDeOperacion(false);
                }

                void SalidaDeOperacion(bool actualizarRango = true)
                {
                    if (success)
                    {
                        _seElimino = true;

                        if (actualizarRango && !(new HorarioEmpleadoBL().ActualizarRangoDeHorario(_horario.id_horario_emp)))
                        {
                            Msg.Ok_Err("No se pudo actualizar la cabecera del horario (primera fecha, útlima fecha).");
                        }
                        Dispose();
                    }
                    else
                    {
                        Msg.Ok_Err("No se pudo eliminar las fechas del horario.");
                    }
                }
            }
        }

        private int GetNumeroFechasRestantes(DateTime hoy)
        {
            try
            {
                return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= hoy).Count();
            }
            catch
            {
                return 0;
            }
        }

        private void SetFechasHorario()
        {
            lblPrimerDiaHorario.Text = _horario.fecha_inicio_horario.ToString(DateFormat.DateOnly);
            lblUltimoDiaHorario.Text = _horario.fecha_fin_horario.ToString(DateFormat.DateOnly);
        }

        private int GetNumeroFechasPasadas(DateTime hoy)
        {
            try
            {
                return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor < hoy).Count();
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Eventos

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarHorario();
        }

        private void FormEliminarHorario_Load(object sender, EventArgs e)
        {
            SetFechasHorario();
            ConfigurarControles();
            LimpiarForm();
            AddHandlers();
            dtpHasta.Focus();
        }


        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.CustomFormat == " ")
            {
                dtpHasta.Value = dtpDesde.Value.Date;
                return;
            }

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                errorProv.SetError(dtpHasta, null);
                errorProv.SetError(dtpDesde, "La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".");
            }
            else
            {
                EvaluarDiasDisponibles();
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.CustomFormat == " ")
            {
                return;
            }

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                errorProv.SetError(dtpDesde, null);
                errorProv.SetError(dtpHasta, "La fecha \"Hasta\" no puede ser menor que la fecha \"Desde\".");
            }
            else
            {
                EvaluarDiasDisponibles();
            }
        }

        private void dtpHasta_MouseDown(object sender, MouseEventArgs e)
        {
            if (dtpHasta.CustomFormat == " ")
            {
                ControlHelper.FormatDatePicker(dtpHasta, customFormat: DateFormat.DateOnly, showUpDown: false);
                EvaluarDiasDisponibles();
            }
        }

        #endregion
    }
}
