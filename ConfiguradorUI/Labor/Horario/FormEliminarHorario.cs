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
            var hoy = DateTime.Now.Date;

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

        private List<LABt04_horario_emp_dtl> GetRangoDeFechas()
        {
            var fechas = new List<LABt04_horario_emp_dtl>();
            try
            {
                var desde = dtpDesde.Value.Date;
                var hasta = dtpHasta.Value.Date;

                var listTuplaDiaYHoras = (List<Tuple<CheckBox, DayOfWeek>>)GetControls(TipoControl.ChekedDiaTupla);
                var diasEnRango = _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= desde && x.fecha_labor <= hasta);

                foreach (var fechaAsignada in diasEnRango)
                {
                    if (listTuplaDiaYHoras.Any(x => x.Item2 == fechaAsignada.fecha_labor.DayOfWeek))
                    {
                        fechas.Add(fechaAsignada);
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

            #region Label

            lblNoPuedeEliminar.Visible = false;
            #endregion

            #region DateTimePicker

            var hoy = DateTime.Now.Date;
            dtpDesde.MinDate = dtpHasta.MinDate = hoy > _horario.fecha_inicio_horario ? hoy : _horario.fecha_inicio_horario;
            dtpDesde.MaxDate = dtpHasta.MaxDate = _horario.fecha_fin_horario;

            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyyy";

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

            //validar que existe el empleado
            if (_empleado == null ||
                !(_empleado.id_empleado > 0))
            {
                no_error = false;
                Msg.Ok_Wng("Busque y seleccione un empleado antes de asignar un horario.", "Validación");
            }

            //validando que se inferior a la fecha actual
            if (no_error)
            {
                var hoy = DateTime.Now.Date;
                if (dtpDesde.Value.Date < hoy)
                {
                    no_error = false;
                    Msg.Ok_Wng($"La fecha \"Desde\" no puede ser menor que la fecha actual ({hoy.ToShortDateString()}).", "Validación");
                }
                else if (dtpHasta.Value.Date < hoy)
                {
                    no_error = false;
                    Msg.Ok_Wng($"La fecha \"Hasta\" no puede ser menor que la fecha actual ({hoy.ToShortDateString()}).", "Validación");
                }
            }

            //validar el rango de fechas
            if (no_error && dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                no_error = false;
                Msg.Ok_Wng("La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".", "Validación");
            }


            //Validar las fechas a asignar/editar
            if (no_error)
            {
                fechas = GetRangoDeFechas();
                if (fechas == null || !(fechas.Count > 0))
                {
                    no_error = false;
                    Msg.Ok_Wng("No ha seleccionado ningún día para eliminación.", "Validación");
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

                if (GetNumeroFechasPasadas() > 0 || fechasParaEliminar.Count < GetNumeroFechasRestantes())
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
                            Msg.Ok_Err("No se actualizó el rango de fechas del horario.");
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

        private int GetNumeroFechasRestantes()
        {
            var hoy = DateTime.Now.Date;
            return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= hoy).Count();
        }

        private int GetNumeroFechasPasadas()
        {
            var hoy = DateTime.Now.Date;
            return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor < hoy).Count();
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

            var hoy = DateTime.Now.Date;
            if (_horario.fecha_fin_horario >= hoy)
            {
                ConfigurarControles();
                LimpiarForm();
                AddHandlers();
                dtpHasta.Focus();
            }
            else
            {
                //cambuar msj cuando  no selecciojna nada 
                // ki


                btnEliminar.Enabled =
                dtpDesde.Enabled =
                dtpHasta.Enabled = false;

                EstadoDias(false);

                lblNoPuedeEliminar.Text = "NO PUEDE ELIMINAR. LAS FECHAS ASIGNADAS CONCLUYERON.";
                btnCancelar.Focus();
            }
        }

        private void SetFechasHorario()
        {
            lblPrimerDiaHorario.Text = _horario.fecha_inicio_horario.ToString("dd/MM/yyyy");
            lblUltimoDiaHorario.Text = _horario.fecha_fin_horario.ToString("dd/MM/yyyy");
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
                Msg.Ok_Info(fechas + "\n" + fechasL.Count + " días.");
            }
        }

        #endregion
    }
}
