//using ConfigBusinessLogic.Persona;
//using MetroFramework.Forms;
//using System;
//using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Linq;
//using ConfigBusinessEntity;
//using ConfigUtilitarios;
//using ConfigBusinessLogic.Labor;

//namespace ConfiguradorUI.Labor
//{
//    public partial class FormHorarioEmpleado : MetroForm
//    {
//        /*
//         1. ver modelo y txt del modelo.
//         2. Reparar los errores locales.
//             */

//        #region Varibles Globales
//        private readonly List<DayOfWeek> _daysOfWeekList;

//        private readonly DateTimePicker[] _dtpsDomingo, _dtpsLunes, _dtpsMartes, _dtpsMiercoles, _dtpsJueves, _dtpsViernes, _dtpsSabado;

//        private PERt04_empleado _empleado;

//        private List<DateTime> _daysHorario;

//        private List<LABt03_horario_emp> _horarioList;

//        private int _tipoOperacion = TipoOperacionABM.No_Action;

//        private bool _isPending = false;
//        #endregion

//        public FormHorarioEmpleado()
//        {
//            InitializeComponent();

//            #region Inicialización de variables
//            var chkDias = new[]
//            {
//                chkDomingo, chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes, chkSabado,
//            };

//            #region DatePickers por día semana
//            _dtpsDomingo = new[]
//            {
//                dtpHI1, dtpHF1, dtpIB1, dtpFB1, dtpT1
//            };
//            _dtpsLunes = new[]
//            {
//                dtpHI2, dtpHF2, dtpIB2, dtpFB2, dtpT2,
//            };
//            _dtpsMartes = new[]
//            {
//                dtpHI3, dtpHF3, dtpIB3, dtpFB3, dtpT3,
//            };
//            _dtpsMiercoles = new[]
//            {
//                dtpHI4, dtpHF4, dtpIB4, dtpFB4, dtpT4,
//            };
//            _dtpsJueves = new[]
//            {
//                dtpHI5, dtpHF5, dtpIB5, dtpFB5, dtpT5,
//            };
//            _dtpsViernes = new[]
//            {
//                dtpHI6, dtpHF6, dtpIB6, dtpFB6, dtpT6,
//            };
//            _dtpsSabado = new[]
//            {
//                dtpHI7, dtpHF7, dtpIB7, dtpFB7, dtpT7,
//            };
//            #endregion

//            var dtpsBreak = new[]
//            {
//                dtpIB1, dtpFB1,
//                dtpIB2, dtpFB2,
//                dtpIB3, dtpFB3,
//                dtpIB4, dtpFB4,
//                dtpIB5, dtpFB5,
//                dtpIB6, dtpFB6,
//                dtpIB7, dtpFB7,
//            };

//            var dtpsTolerancia = new[]
//            {
//                dtpT1, dtpT2, dtpT3, dtpT4, dtpT5, dtpT6, dtpT7,
//            };
//            _daysOfWeekList = new List<DayOfWeek>();
//            #endregion

//            // Unir todos los DatePickers para formatear
//            DateTimePicker[] dtps = _dtpsDomingo
//                                    .Union(_dtpsLunes)
//                                    .Union(_dtpsMartes)
//                                    .Union(_dtpsMiercoles)
//                                    .Union(_dtpsJueves)
//                                    .Union(_dtpsViernes)
//                                    .Union(_dtpsSabado).ToArray();
//            // Formatear Datepickers
//            foreach (var item in dtps)
//            {
//                ControlHelper.FormatDatePicker(item, customFormat: "HH:mm",visible:false);
//            }

//            // Formatear DatePickers para Break
//            foreach (var item in dtpsBreak)
//            {
//                ControlHelper.FormatDatePicker(item, customFormat: " ", visible: false);
//            }

//            // Formatear DatePickers para Tolerancia
//            foreach (var item in dtpsTolerancia)
//            {
//                ControlHelper.FormatDatePicker(item, customFormat: "0", visible: false);
//            }

//            // Asignar a todos los CheckBox el mismo evento
//            foreach (var item in chkDias)
//                item.CheckedChanged += chk_CheckedChanged;
//            foreach (var dtpTolerancia in dtpsTolerancia)
//            {
//                dtpTolerancia.MouseDown += Dtp_MouseDown;
//                dtpTolerancia.KeyPress += dtpToleracia_KeyPress;
//            }
//            foreach (var dtpBreak in dtpsBreak)
//            {
//                dtpBreak.MouseDown += Dtp_MouseDown;
//                dtpBreak.KeyPress += DtpBreak_KeyPress;
//            }
//            _horarioList = new List<LABt03_horario_emp>();
//        }

//        // Métodos para buscar y luego cargar el horario de un empleado
//        private void BuscarEmpleado()
//        {
//            _tipoOperacion = TipoOperacionABM.Cambio;
//            if (esValido())
//            {
//                _empleado = new EmpleadoBL().EmpleadoXNroDoc(txtNroDocEmp.Text.Trim());
//                if (_empleado != null)
//                {
//                    var nombreCompleto = string.IsNullOrEmpty(_empleado.txt_ape_mat) ?
//                        $"{_empleado.txt_ape_pat}, {_empleado.txt_pri_nom} {_empleado.txt_seg_nom}"
//                        : $"{_empleado.txt_ape_pat} {_empleado.txt_ape_mat}, {_empleado.txt_pri_nom} {_empleado.txt_seg_nom}";

//                    lblNomEmp.Text = nombreCompleto.ToUpper();
//                    txtUsuario.Text = nombreCompleto.ToUpper();
//                    txtInicioContrato.Text = _empleado.fecha_ingreso?.ToString("dd/MM/yyyy");
//                    txtFinContrato.Text = _empleado.fecha_cese?.ToString("dd/MM/yyyy");
//                    var lista = new HorarioEmpleadoBL().ListaHorarioXEmpleado(_empleado.id_empleado);
//                    if (lista.Count() > 0)
//                    {
//                        CargarHorarioEmpleado(lista);
//                    }
//                    else
//                    {
//                        LimpiarPickers();
//                        MessageBox.Show("El empleado no tiene un horario asignado", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                }
//                else
//                {
//                    LimpiarForm();
//                    MessageBox.Show("No se encontró empleado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//        }

//        /// <summary>
//        /// Agrega las horas en los DatePickers.
//        /// </summary>
//        /// <param name="listHorarios">Lista del horario de un empleado.</param>
//        private void CargarHorarioEmpleado(IEnumerable<LABt03_horario_emp> listHorarios)
//        {
//            listHorarios = listHorarios.OrderBy(x => x.fecha_labor);
//            dtpDesde.Value = listHorarios.FirstOrDefault().fecha_labor;
//            dtpHasta.Value = listHorarios.LastOrDefault().fecha_labor;
//            // Por corregir
//            bool _repite = false;
//            var chkDias = new[]
//            {
//                chkDomingo, chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes, chkSabado,
//            };

//            foreach (var item in chkDias)
//            {
//                item.Checked = false;
//            }
//            foreach (var item in listHorarios)
//            {
//                if (item.fecha_labor.DayOfWeek == DayOfWeek.Monday)
//                {
//                    chkLunes.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsLunes, item);
//                    CambiarEstadoDateTimePickers(_dtpsLunes, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Tuesday)
//                {
//                    chkMartes.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsMartes, item);
//                    CambiarEstadoDateTimePickers(_dtpsMartes, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Wednesday)
//                {
//                    chkMiercoles.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsMiercoles, item);
//                    CambiarEstadoDateTimePickers(_dtpsMiercoles, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Thursday)
//                {
//                    chkJueves.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsJueves, item);
//                    CambiarEstadoDateTimePickers(_dtpsJueves, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Friday)
//                {
//                    chkViernes.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsViernes, item);
//                    CambiarEstadoDateTimePickers(_dtpsViernes, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Saturday)
//                {
//                    chkSabado.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsSabado, item);
//                    CambiarEstadoDateTimePickers(_dtpsSabado, visible: true);
//                }
//                else if (item.fecha_labor.DayOfWeek == DayOfWeek.Sunday)
//                {
//                    chkDomingo.Checked = true;
//                    AgregarHorarioADatePicker(_dtpsDomingo, item);
//                    CambiarEstadoDateTimePickers(_dtpsDomingo, visible: true);
//                }
//            }
//        }

//        /// <summary>
//        /// Almacena las horas en un array de datepickers.
//        /// </summary>
//        /// <param name="dtpDia">Array de datepickers en los que se almacenarán las horas (break, tolerancia, etc).</param>
//        /// <param name="horario">Objeto del cual se obtendrán las horas.</param>
//        private void AgregarHorarioADatePicker(DateTimePicker[] dtpDia, LABt03_horario_emp horario)
//        {
//            if (dtpDia.Count() == 5)
//            {
//                dtpDia[0].Value = horario.fecha_labor + horario.hora_inicio;
//                dtpDia[1].Value = horario.fecha_labor + horario.hora_fin;

//                DateTime? HIB = horario.fecha_labor + horario.hora_inicio_break;
//                if (HIB != null)
//                {
//                    ControlHelper.FormatDatePicker(dtpDia[2], "HH:mm");
//                    dtpDia[2].Value = (DateTime)HIB;
//                }

//                DateTime? HFB = horario.fecha_labor + horario.hora_fin_break;
//                if (HFB != null)
//                {
//                    ControlHelper.FormatDatePicker(dtpDia[3], "HH:mm");
//                    dtpDia[3].Value = (DateTime)HFB;
//                }

//                ControlHelper.FormatDatePicker(dtpDia[4], "HH:mm");
//                dtpDia[4].Value = horario.fecha_labor + horario.tiempo_tolerancia;
//            }
//        }

//        /// <summary>
//        /// Cambia el estado de visibilidad de un array de datepickers.
//        /// </summary>
//        /// <param name="dateTimePickers">Array de datepickers que cambiarán su propiedad de visibilidad.</param>
//        /// <param name="visible">Invierte la propiedad visible de los datepickers o las establece en true.</param>
//        private void CambiarEstadoDateTimePickers(DateTimePicker[] dateTimePickers, bool visible = false)
//        {
//            if (dateTimePickers != null)
//            {
//                foreach (var item in dateTimePickers)
//                {
//                    if (!visible)
//                    {
//                        item.Visible = !item.Visible;
//                    }
//                    else
//                    {
//                        item.Visible = true;
//                    }
//                }
//            }
//        }

//        /// <summary>
//        /// Resalta días en el MonthCalendar.
//        /// </summary>
//        /// <param name="daysOfWeek">Lista de días de la semana que se resaltarán en el MonthCalendar.</param>
//        private void ResaltarDias(List<DayOfWeek> daysOfWeek)
//        {
//            if (daysOfWeek != null)
//            {
//                var desde = dtpDesde.Value;
//                var hasta = dtpHasta.Value;
//                _daysHorario = new List<DateTime>();
//                foreach (var day in daysOfWeek)
//                {
//                    var i = desde;
//                    for (; i.Date <= hasta; i = i.AddDays(1))
//                    {
//                        if (i.DayOfWeek == day)
//                        {
//                            _daysHorario.Add(i);
//                        }
//                    }
//                }
//            }
//            var days = _daysHorario.ToArray();
//            mcaMes.BoldedDates = days;
//            mcaMes.UpdateBoldedDates();
//        }


//        // Métodos para controlar el cambio de los checks
//        /// <summary>
//        /// Cambia el estado de los datepicker.
//        /// </summary>
//        /// <param name="checkBox">.</param>
//        private void CambiarEstadoXDia(CheckBox checkBox)
//        {
//            if (checkBox.Name == chkDomingo.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsDomingo);
//                ControlListaDias(chkDomingo, DayOfWeek.Sunday);
//            }
//            else if (checkBox.Name == chkLunes.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsLunes);
//                ControlListaDias(chkLunes, DayOfWeek.Monday);
//            }
//            else if (checkBox.Name == chkMartes.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsMartes);
//                ControlListaDias(chkMartes, DayOfWeek.Tuesday);
//            }
//            else if (checkBox.Name == chkMiercoles.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsMiercoles);
//                ControlListaDias(chkMiercoles, DayOfWeek.Wednesday);
//            }
//            else if (checkBox.Name == chkJueves.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsJueves);
//                ControlListaDias(chkJueves, DayOfWeek.Thursday);
//            }
//            else if (checkBox.Name == chkViernes.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsViernes);
//                ControlListaDias(chkViernes, DayOfWeek.Friday);
//            }
//            else if (checkBox.Name == chkSabado.Name)
//            {
//                CambiarEstadoDateTimePickers(_dtpsSabado);
//                ControlListaDias(chkSabado, DayOfWeek.Saturday);
//            }
//        }
        
//        /// <summary>
//        /// Agrega o remueve un día de la semana en base a la propiedad checked de un control.
//        /// </summary>
//        /// <param name="checkBox">CheckBox que controlará si se debe agregar o remover el día.</param>
//        /// <param name="dayOfWeek">Día de la semana a agregar o remover.</param>
//        private void ControlListaDias(CheckBox checkBox, DayOfWeek dayOfWeek)
//        {
//            if (checkBox.Checked)
//                _daysOfWeekList.Add(dayOfWeek);
//            else
//                _daysOfWeekList.Remove(dayOfWeek);
//        }
        

//        private void CommitHorarios()
//        {
//            try
//            {
//                if (_tipoOperacion == TipoOperacionABM.Insertar)
//                {
//                    _horarioList = GetObjeto();
//                    if (esValido())
//                    {
//                        if (new HorarioEmpleadoBL().ListaHorarioXEmpleado(_empleado.id_empleado).Count() > 0)
//                        {
//                            DialogResult rp = MessageBox.Show("El empleado ya tiene un horario asignado ¿Desea sobreescribirlo?.", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
//                            if (rp == DialogResult.Yes)
//                            {
//                                if (_horarioList != null)
//                                {
//                                    new HorarioEmpleadoBL().EliminarHorarioXEmpleado(_empleado.id_empleado);
//                                    foreach (var horario in _horarioList)
//                                        new HorarioEmpleadoBL().InsertarHorario(horario);
//                                    MessageBox.Show("Se reasignó el horario correctamente", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                    ControlarEventosABM();
//                                }
//                            }
//                        }
//                        else
//                        {
//                            if (_horarioList != null)
//                            {
//                                foreach (var horario in _horarioList)
//                                    new HorarioEmpleadoBL().InsertarHorario(horario);
//                                MessageBox.Show("Se asignó en horario correctamente", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                ControlarEventosABM();
//                            }

//                        }
//                    }
//                }
//                else
//                {
//                    //ActualizarProducto();
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(this, "Ocurrió un error en commit. " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//        }

//        private List<LABt03_horario_emp> GetObjeto()
//        {
//            var obj = new List<LABt03_horario_emp>();
//            try
//            {
                
//                if (_daysHorario != null)
//                    foreach (var day in _daysHorario)
//                    {
//                        var horario = new LABt03_horario_emp
//                        {
//                            fecha_labor = day
//                        };
//                        if (_empleado != null)
//                        {
//                            horario.id_empleado = _empleado.id_empleado;
//                        }
//                        if (chkDomingo.Checked && day.DayOfWeek == DayOfWeek.Sunday)
//                            AgregarHorarioALista(horario, obj, dtpHI1, dtpHF1, dtpIB1, dtpFB1, dtpT1);
//                        else if (chkLunes.Checked && day.DayOfWeek == DayOfWeek.Monday)
//                            AgregarHorarioALista(horario, obj, dtpHI2, dtpHF2, dtpIB2, dtpFB2, dtpT2);
//                        else if (chkMartes.Checked && day.DayOfWeek == DayOfWeek.Tuesday)
//                            AgregarHorarioALista(horario, obj, dtpHI3, dtpHF3, dtpIB3, dtpFB3, dtpT3);
//                        else if (chkMiercoles.Checked && day.DayOfWeek == DayOfWeek.Wednesday)
//                            AgregarHorarioALista(horario, obj, dtpHI4, dtpHF4, dtpIB4, dtpFB4, dtpT4);
//                        else if (chkJueves.Checked && day.DayOfWeek == DayOfWeek.Thursday)
//                            AgregarHorarioALista(horario, obj, dtpHI5, dtpHF5, dtpIB5, dtpFB5, dtpT5);
//                        else if (chkViernes.Checked && day.DayOfWeek == DayOfWeek.Friday)
//                            AgregarHorarioALista(horario, obj, dtpHI6, dtpHF6, dtpIB6, dtpFB6, dtpT6);
//                        else if (chkSabado.Checked && day.DayOfWeek == DayOfWeek.Saturday)
//                            AgregarHorarioALista(horario, obj, dtpHI7, dtpHF7, dtpIB7, dtpFB7, dtpT7);
//                    }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(this, $@"Excepción en el Get: {e.Message}");
//            }
//            return obj;
//        }

//        /// <summary>
//        /// Agrega en una lista las horas de los datepickers.
//        /// </summary>
//        /// <param name="horario">Almacena todas las horas para luego ser añadido en la lista.</param>
//        /// <param name="lista">Lista que almacena el horario.</param>
//        /// <param name="hi">CheckBox hora de inicio.</param>
//        /// <param name="hf">CheckBox hora final.</param>
//        /// <param name="ib">CheckBox inicio break.</param>
//        /// <param name="fb">CheckBox fin break.</param>
//        /// <param name="t">CheckBox tolerancia.</param>
//        private void AgregarHorarioALista(LABt03_horario_emp horario, List<LABt03_horario_emp> lista,
//            Control hi, Control hf, Control ib, Control fb, Control t)
//        {
//            horario.hora_inicio = TimeSpan.Parse(hi.Text);
//            horario.hora_fin = TimeSpan.Parse(hf.Text);
//            TimeSpan HIB;
//            if (TimeSpan.TryParse(ib.Text, out HIB))
//                horario.hora_inicio_break = HIB;

//            TimeSpan FB;
//            if (TimeSpan.TryParse(fb.Text, out FB))
//                horario.hora_fin_break = FB;

//            horario.tiempo_tolerancia = TimeSpan.Parse(t.Text);
//            lista.Add(horario);
//        }


//        private void ControlarEventosABM(long? id = null)
//        {

//            if (_tipoOperacion == TipoOperacionABM.No_Action)
//            {
//                _isPending = false;
//                ControlarBotones(true, true, false, false, true, true);
//                errorProv.Clear();
//            }
//            else
//            {
//                if (_tipoOperacion == TipoOperacionABM.Nuevo)
//                {
//                    ControlarBotones(false, false, true, true, false, false);
//                    errorProv.Clear();
//                    LimpiarForm();
//                    tabHorario.SelectedTab = tabPagGeneral;
//                    txtNroDocEmp.Focus();
//                }
//                else
//                {
//                    //Después de hacer el commit-insertar
//                    if (_tipoOperacion == TipoOperacionABM.Insertar)
//                    {
//                        ControlarBotones(true, true, false, false, true, true);
//                        LimpiarForm();
//                        tabHorario.SelectedTab = tabPagGeneral;
//                        btnNuevo.Focus();
//                    }
//                    else
//                    {
//                        if (_tipoOperacion == TipoOperacionABM.Eliminar)
//                        {
//                            errorProv.Clear();
//                            ControlarBotones(true, true, false, false, true, true);
//                            LimpiarForm();
//                            //if (tglListarInactivos.Checked)
//                            //{ ActualizarGrilla(); }
//                            //else { ActualizarGrilla(Estado.IdActivo); }
//                            tabHorario.SelectedTab = tabPagGeneral;
//                            btnNuevo.Focus();
//                        }
//                        else
//                        {
//                            if (_tipoOperacion == TipoOperacionABM.Rollback)
//                            {
//                                ControlarBotones(true, true, false, false, true, true);
//                                _isPending = false;
//                                errorProv.Clear();
//                                LimpiarForm();
//                                //SeleccionarRegistro();
//                                tabHorario.SelectedTab = tabPagGeneral;
//                                btnNuevo.Focus();
//                            }
//                            else
//                            {
//                                if (_tipoOperacion == TipoOperacionABM.Cambio)
//                                {
//                                    ControlarBotones(false, false, true, true, false, false);
//                                    _isPending = true;
//                                }
//                                else
//                                {
//                                    if (_tipoOperacion == TipoOperacionABM.Modificar)
//                                    {
//                                        errorProv.Clear();
//                                        LimpiarForm();
//                                        ControlarBotones(true, true, false, false, true, true);
//                                        _isPending = false;
//                                        //if (tglListarInactivos.Checked)
//                                        //{ ActualizarGrilla(); }
//                                        //else { ActualizarGrilla(Estado.IdActivo); }
//                                        tabHorario.SelectedTab = tabPagGeneral;
//                                        btnNuevo.Focus();
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        private void LimpiarForm()
//        {
//            lblNomEmp.Text = null;

//            txtUsuario.Clear();
//            LimpiarPickers();
//            txtInicioContrato.Clear();
//            txtFinContrato.Clear();
//            txtNroDocEmp.Clear();
//            _empleado = null;
//        }

//        private void LimpiarPickers()
//        {
//            var chkDias = new[]
//            {
//                chkDomingo, chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes, chkSabado,
//            };
//            foreach (var item in chkDias)
//            {
//                item.Checked = false;
//            }
//        }
            
//        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
//        {
//            btnNuevo.Enabled = eNuevo;
//            //btnDelete.Enabled = eDelete;
//            //btnCommit.Enabled = eCommit;
//            //btnRollback.Enabled = eRollback;
//            //btnSearch.Enabled = eSearch;
//            //btnFilter.Enabled = eFilter;
//        }

//        private bool esValido()
//        {
//            errorProv.Clear();

//            bool no_error = true;

//            if (_tipoOperacion == TipoOperacionABM.Insertar)
//            {
//                if (_empleado == null)
//                {
//                    tabHorario.SelectedTab = tabPagGeneral;
//                    //errorProv.SetError(txtNroDocEmp, "Debe asignar un empleado al horario.");
//                    txtNroDocEmp.Focus();
//                    MessageBox.Show("No hay empleado al cual asignar el horario.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    no_error = false;
//                }
//                if (no_error && _horarioList.Count < 1)
//                {
//                    MessageBox.Show("No seleccionó ninguna fecha para el horario.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    no_error = false;
//                }
//            }
//            else if (_tipoOperacion == TipoOperacionABM.Cambio)
//            {
//                var criterio = txtNroDocEmp.Text.Trim();
//                if (string.IsNullOrEmpty(criterio))
//                {
//                    errorProv.SetError(txtNroDocEmp, "Este campo es requerido.");
//                    no_error = false;
//                }
//            }

//            if (no_error)
//            {
//            }
//            return no_error;
//        }   

//        #region Eventos Click
//        private void btnBuscarEmp_Click(object sender, EventArgs e)
//        {
//            BuscarEmpleado();
//        }

//        private void btnNuevo_Click(object sender, EventArgs e)
//        {
//            _tipoOperacion = TipoOperacionABM.Nuevo;
//            if (_tipoOperacion == TipoOperacionABM.Nuevo)
//            {
//                _tipoOperacion = TipoOperacionABM.Insertar;
//            }
//            else
//            {
//                if (_tipoOperacion == TipoOperacionABM.Cambio)
//                {
//                    _tipoOperacion = TipoOperacionABM.Modificar;
//                }
//            }
//            CommitHorarios();
//        }
//        #endregion
//        #region Eventos Changed
//        private void dtpDesde_ValueChanged(object sender, EventArgs e)
//        {
//            if (dtpDesde.Value > dtpHasta.Value)
//            {
//                //MessageBox.Show("El campo \"desde\" debe ser mayor a campo \"Hasta\"");
//            }
//            ResaltarDias(_daysOfWeekList);
//        }

//        private void FormHorarioEmpleado_Load(object sender, EventArgs e)
//        {

//        }

//        private void dtpHasta_ValueChanged(object sender, EventArgs e)
//        {
//            if (dtpDesde.Value > dtpHasta.Value)
//            {
//                //MessageBox.Show("El campo \"desde\" debe ser mayor a campo \"Hasta\"");
//            }
//            ResaltarDias(_daysOfWeekList);
//        }

//        private void chk_CheckedChanged(object sender, EventArgs e)
//        {
//            var chk = (CheckBox)sender;

//            CambiarEstadoXDia(chk);
//            ResaltarDias(_daysOfWeekList);
//        }
//        #endregion
//        #region Eventos Key Press
//        private void txtNroDocEmp_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == '\r')
//                BuscarEmpleado();
//        }

//        private void DtpBreak_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)Keys.Escape)
//            {
//                var dateTimePicker = (DateTimePicker)sender;
//                ControlHelper.FormatDatePicker(dateTimePicker,customFormat:" ");
//            }
//        }
//        private void dtpToleracia_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)Keys.Escape)
//            {
//                var dateTimePicker = (DateTimePicker)sender;
//                ControlHelper.FormatDatePicker(dateTimePicker, customFormat: "0");
//            }
//        }
//        #endregion
//        #region Eventos Mouse Down
//        private void Dtp_MouseDown(object sender, MouseEventArgs e)
//        {
//            var dateTimePicker = (DateTimePicker)sender;
//            ControlHelper.FormatDatePicker(dateTimePicker, customFormat: "HH:mm");
//        }
//        #endregion        
//    }
//}
