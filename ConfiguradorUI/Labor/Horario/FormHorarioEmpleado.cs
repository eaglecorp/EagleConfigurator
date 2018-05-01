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
using ConfigUtilitarios.KeyValues;
using ConfiguradorUI.Buscadores;
using ConfigUtilitarios.HelperGeneric;
using ConfigUtilitarios.Extensions;

namespace ConfiguradorUI.Labor.Horario
{
    public partial class FormHorarioEmpleado : MetroForm
    {
        #region Varibles Globales

        private int _tipoOperacion = TipoOperacionABM.No_Action;

        private PERt04_empleado _empleado;
        private LABt03_horario_emp _horario;

        #endregion

        public FormHorarioEmpleado()
        {
            InitializeComponent();
        }

        #region Métodos

        private void AddHandlers()
        {
            mcaMes.DoubleClick += mcaMes_DoubleClick;
            btnHoy.Click += btnDate_Click;
            btnPrimerDiaTrabajo.Click += btnDate_Click;
            btnUltimoDiaTrabajo.Click += btnDate_Click;
        }

        private void SetEmpleado(PERt04_empleado empleado)
        {
            _empleado = empleado;

            try
            {
                var nombreCompleto = Human.Nombre(_empleado.txt_ape_pat, _empleado.txt_pri_nom, _empleado.txt_ape_mat,
                                                    _empleado.txt_seg_nom, _empleado.txt_rzn_social);

                lblNombreEmpleado.Text = nombreCompleto.ToUpper();

                lblFechaIngreso.Text = _empleado.fecha_ingreso != null ? ((DateTime)_empleado.fecha_ingreso).ToString("dd/MM/yyyy") : "-";
                lblFechaCese.Text = _empleado.fecha_cese != null ? ((DateTime)_empleado.fecha_cese).ToString("dd/MM/yyyy") : "-";
                lblNumDoc.Text = !string.IsNullOrEmpty(_empleado.nro_doc) ? _empleado.nro_doc : "-";
                lblRuc.Text = !string.IsNullOrEmpty(_empleado.nro_ruc) ? _empleado.nro_ruc : "-";

            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo mostrar los datos del empleado correctamente. Excepción: " + e.Message);
            }
        }

        private void SetHorario(LABt03_horario_emp horario)
        {
            _horario = horario;

            try
            {
                var hoy = DateTime.Now.Date;
                if (horario != null &&
                       horario.id_horario_emp > 0)
                {
                    lblMensajeNoTieneHorario.Visible = false;
                    IEnumerable<DateTime> horarioSoloFechas = new List<DateTime>();
                    if (horario.LABt04_horario_emp_dtl != null)
                    {
                        horarioSoloFechas = horario.LABt04_horario_emp_dtl.Select(x => x.fecha_labor);
                    }

                    var fechasDeLaborRestante = horarioSoloFechas.Count(x => x.Date >= DateTime.Now.Date);

                    btnPrimerDiaTrabajo.Text = horario.fecha_inicio_horario.ToString("dd/MM/yyyy");
                    btnUltimoDiaTrabajo.Text = horario.fecha_fin_horario.ToString("dd/MM/yyyy");
                    btnHoy.Text = hoy.ToString("dd/MM/yyyy");

                    lblDiasDeTrabajoRestantes.Text = fechasDeLaborRestante.ToString();

                    ResaltarFechasEnCalendario(horarioSoloFechas);
                }
                else
                {

                    lblMensajeNoTieneHorario.Visible = true;

                    btnPrimerDiaTrabajo.Text = "-";
                    btnUltimoDiaTrabajo.Text = "-";
                    btnHoy.Text = hoy.ToString("dd/MM/yyyy");

                    lblDiasDeTrabajoRestantes.Text = "-";

                    ResaltarFechasEnCalendario(null);
                }
                SeleccionarDiaYVer(hoy,true);
                btnAsignarHorario.Focus();
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo mostrar el horario correctamente. Excepción: " + e.Message);
            }
        }

        private void LimpiarForm()
        {
            LimpiarDatosDeMemoria();
            LimpiarEmpleado();
            LimpiarHorario();
        }

        private void LimpiarDatosDeMemoria()
        {
            _horario = null;
            _empleado = null;
        }

        private void SearchAndSetEmpleado()
        {
            if (!BuscarEmpleado())
            {
                var form = new FormBuscarEmpleado();
                form.ShowDialog();
                if (form._empleado != null && form._empleado.id_empleado > 0)
                {
                    SetHorarioXEmpleado(form._empleado);
                }
            }
        }

        private void SetHorarioXEmpleado(PERt04_empleado emp)
        {
            LimpiarForm();

            SetEmpleado(emp);
            var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
            SetHorario(horario);

            btnAsignarHorario.Enabled = true;
            btnQuitarFechas.Enabled =
            btnEditarHorario.Enabled = TieneHorarioYFechas();
        }

        private bool BuscarEmpleado()
        {
            string numDoc = txtNroDocEmp.Text.Trim();
            if (numDoc == "")
                return false;

            var list = new EmpleadoBL().BuscarEmpleados(numDoc, numDoc, "", "", Estado.IdActivo);
            if (list != null && list.Count() == 1)
            {
                foreach (var emp in list)
                {
                    if (_empleado == null || emp.id_empleado != _empleado.id_empleado)
                    {
                        if (emp != null && emp.id_empleado > 0)
                        {
                            SetHorarioXEmpleado(emp);
                        }

                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        private void LimpiarHorario()
        {
            btnPrimerDiaTrabajo.Text = "-";
            btnUltimoDiaTrabajo.Text = "-";
            btnHoy.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            ResaltarFechasEnCalendario(null);
        }

        private void ResaltarFechasEnCalendario(IEnumerable<DateTime> fechas)
        {
            mcaMes.BoldedDates = fechas?.ToList();
            //boldasdate coolection y category
            mcaMes.Refresh();
        }

        private void LimpiarEmpleado()
        {
            lblNombreEmpleado.Text = "EMPLEADO: NINGUNO";
            lblNumDoc.Text =
            lblRuc.Text =
            lblFechaIngreso.Text =
            lblFechaCese.Text = "-";

            txtNroDocEmp.Clear();
        }

        private void ConfigurarControles()
        {
            #region MonthCalendar

            mcaMes.MaxDate = KeyDates.MaxDate;

            #endregion

            #region Labels

            lblMensajeNoTieneHorario.Visible = false;


            #endregion

            #region botones

            btnAsignarHorario.Enabled =
            btnQuitarFechas.Enabled =
            btnEditarHorario.Enabled = false;

            #endregion

            #region Month Calendar
            mcaMes.SelectionStart = DateTime.Now;
            mcaMes.SelectionEnd = DateTime.Now;
            mcaMes.ContextMenuStrip = ctxMenuDate;

            #endregion
        }

        private void SeleccionarDiaYVer(DateTime fecha, bool setFechaComoPrimerMes = false)
        {
            var colorPrevio = mcaMes.ColorTable.DaySelectedGradientBegin;
            mcaMes.ColorTable.DaySelectedGradientBegin = Color.Transparent;
            mcaMes.ColorTable.DaySelectedGradientEnd = Color.Transparent;

            mcaMes.SelectionStart =
            mcaMes.SelectionEnd = fecha;

            FijarMes();

            mcaMes.ColorTable.DaySelectedGradientBegin = colorPrevio;
            mcaMes.ColorTable.DaySelectedGradientEnd = colorPrevio;
            mcaMes.Refresh();

            void FijarMes()
            {
                if(setFechaComoPrimerMes)
                {
                    mcaMes.ViewStart = fecha;
                }
                else
                {
                    var fechaInicialDelCalendario = mcaMes.ViewStart;
                    var fechaFinalDelCalendario = mcaMes.ViewEnd;

                    if (!(fecha >= fechaInicialDelCalendario && fecha <= fechaFinalDelCalendario))
                    {
                        mcaMes.ViewStart = fecha;
                    }
                }
            }
        }

        private void RefrescarHorario()
        {
            LimpiarHorario();
            var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
            SetHorario(horario);

            btnAsignarHorario.Enabled = true;
            btnQuitarFechas.Enabled =
            btnEditarHorario.Enabled = TieneHorarioYFechas();
        }

        private bool TieneHorarioYFechas()
        {
            return (_horario != null &&
                _horario.id_horario_emp > 0 &&
                _horario.LABt04_horario_emp_dtl != null &&
                _horario.LABt04_horario_emp_dtl.Count > 0);
        }

        private bool EsFechaValida(DateTime fecha)
        {
            var hoy = DateTime.Now.Date;
            var isValid = (fecha >= hoy && fecha <= KeyDates.MaxDate);

            if (isValid && _empleado != null && _empleado.id_empleado > 0)
            {
                var fechaIngreso = _empleado.fecha_ingreso?.Date;
                var fechaCese = _empleado.fecha_cese?.Date;

                if (fechaIngreso != null && fecha < fechaIngreso)
                {
                    isValid = false;
                    Msg.Ok_Info($"La fecha no puede ser menor que la fecha de ingreso ({((DateTime)fechaIngreso).ToString("dd/MM/yyyy")}) del empleado.");
                }
                else if (fechaCese != null && fecha > fechaCese)
                {
                    isValid = false;
                    Msg.Ok_Info($"La fecha no puede ser mayor que la fecha de cese ({((DateTime)fechaCese).ToString("dd/MM/yyyy")}) del empleado.");
                }
            }

            return isValid;
        }

        private int GetNumeroFechasPasadas()
        {
            var hoy = DateTime.Now.Date;
            try
            {
                return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor < hoy).Count();
            }
            catch
            {
                return 0;
            }
        }

        private int GetNumeroFechasRestantes()
        {
            var hoy = DateTime.Now.Date;

            try
            {
                return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= hoy).Count();
            }
            catch
            {
                return 0;
            }
        }

        private IEnumerable<long> GetIdsDeFechasValidasSeleccionadas()
        {
            var hoy = DateTime.Now.Date;
            IEnumerable<long> lista = new List<long>();

            if (_horario != null && _horario.id_horario_emp > 0 && _horario.LABt04_horario_emp_dtl != null)
            {
                try
                {
                    lista = _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= hoy && mcaMes.SelectionRanges.Any(r => x.fecha_labor >= r.Start.Date && x.fecha_labor <= r.End.Date))
                                                                    .Select(x => x.id_horario_emp_dtl);
                }
                catch (Exception e)
                {
                    lista = new List<long>();
                    Msg.Ok_Err("No se pudo determinar las fechas seleccionadas.");
                }
            }
            return lista;
        }

        private void EliminarDiaDeHorario()
        {
            if (_empleado != null && _empleado.id_empleado > 0 && _horario != null && _horario.LABt04_horario_emp_dtl != null)
            {
                var listaIds = GetIdsDeFechasValidasSeleccionadas();
                var numeroFechasSeleccionadas = listaIds.Count();
                if (numeroFechasSeleccionadas > 0)
                {
                    var mensajeSegunNumero = numeroFechasSeleccionadas == 1 ? "la fecha seleccionada" : "las fechas seleccionadas";
                    bool success = false;

                    if (GetNumeroFechasPasadas() > 0 || numeroFechasSeleccionadas < GetNumeroFechasRestantes())
                    {
                        if (Msg.YesNo_Ques($"¿Está seguro de eliminar {mensajeSegunNumero} del horario?") == DialogResult.Yes)
                        {
                            success = new HorarioEmpleadoBL().EliminarHorariosDtl(listaIds);
                            SalidaDeOperacion();
                        }
                    }
                    else if (Msg.YesNo_Wng("Está eliminando todas las fechas del horario del empleado. ¿Está seguro de continuar?") == DialogResult.Yes)
                    {
                        success = new HorarioEmpleadoBL().EliminarHorario(_horario.id_horario_emp);
                        SalidaDeOperacion(false);
                    }

                    void SalidaDeOperacion(bool actualizarRangoDeHorario = true)
                    {
                        if (success)
                        {
                            if (actualizarRangoDeHorario && !(new HorarioEmpleadoBL().ActualizarRangoDeHorario(_horario.id_horario_emp)))
                            {
                                Msg.Ok_Err("No se pudo actualizar la cabecera del horario (primera fecha, útlima fecha).");
                            }
                            RefrescarHorario();
                        }
                        else
                        {
                            Msg.Ok_Err($"No se pudo eliminar {mensajeSegunNumero} del horario.");
                        }
                    }
                }
            }
        }

        private void AsignarOEditarDiaDeHorario()
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                var fecha = mcaMes.SelectionRange.Start.Date;

                if (EsFechaValida(fecha))
                {
                    bool seOpero = false;
                    if (_horario != null && _horario.id_horario_emp > 0)
                    {
                        int tipoOperacion = TipoOperacionABM.No_Action;
                        var horarioDtl = new HorarioEmpleadoBL().GetHorarioDtlXFecha(fecha, _horario.id_horario_emp);

                        if (horarioDtl != null && horarioDtl.id_horario_emp_dtl > 0)
                        {
                            //Editar horario Dtl
                            var frm = new FormAsignarOEditarDia(horarioDtl);
                            frm.ShowDialog();
                            seOpero = frm._seOpero;
                        }
                        else
                        {
                            //Asignar horario Dtl
                            var frm = new FormAsignarOEditarDia(_horario.id_horario_emp, fecha);
                            frm.ShowDialog();
                            seOpero = frm._seOpero;
                        }

                    }
                    else
                    {
                        //crear nuevo horario y agregar horario Dtl
                        var frm = new FormAsignarOEditarDia(fecha, _empleado.id_empleado);
                        frm.ShowDialog();
                        seOpero = frm._seOpero;
                    }

                    if (seOpero)
                    {
                        RefrescarHorario();
                    }
                }
                //no está en el horario (add) (no tiene horario/tiene horario)
            }
        }

        #endregion

        #region Eventos

        private void FormHorarioEmpleado_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            LimpiarForm();
            AddHandlers();
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            SearchAndSetEmpleado();
        }

        private void btnAsignarHorario_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                var frm = new FormAsignarOEditarHorario(_empleado, _horario, TipoOperacionABM.Insertar);
                frm.ShowDialog();

                if (frm._seAsigno)
                {
                    RefrescarHorario();
                }
            }
            else
            {
                Msg.Ok_Info("Debe buscar un empleado antes de asignar el horario.");
            }
        }

        private void btnEliminarFechas_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                if (TieneHorarioYFechas())
                {
                    var hoy = DateTime.Now.Date;
                    if (_horario.fecha_fin_horario >= hoy)
                    {

                        var frm = new FormEliminarHorario(_empleado, _horario);
                        frm.ShowDialog();

                        if (frm._seElimino)
                        {
                            RefrescarHorario();
                        }
                    }
                    else
                    {
                        Msg.Ok_Info("No puede eliminar las fechas asignadas al empleado porque han concluido.");
                    }
                }
                else
                {
                    Msg.Ok_Info("Este empleado no tiene horario o no tiene ninguna fecha asignada.");
                }
            }
            else
            {
                Msg.Ok_Info("Debe buscar un empleado antes de eliminar fechas del horario.");
            }
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                if (TieneHorarioYFechas())
                {
                    var hoy = DateTime.Now.Date;
                    if (_horario.fecha_fin_horario >= hoy)
                    {
                        var frm = new FormAsignarOEditarHorario(_empleado, _horario, TipoOperacionABM.Modificar);
                        frm.ShowDialog();

                        if (frm._seAsigno)
                        {
                            RefrescarHorario();
                        }
                    }
                    else
                    {
                        Msg.Ok_Info("No puede editar el horario porque todas las fechas asignadas al empleado han concluido.");
                    }
                }
                else
                {
                    Msg.Ok_Info("Este empleado no tiene horario o no tiene ninguna fecha asignada.");
                }
            }
            else
            {
                Msg.Ok_Info("Debe buscar un empleado antes de eliminar fechas del horario.");
            }
        }

        private void txtNroDocEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SearchAndSetEmpleado();
            }
        }

        private void mcaMes_DoubleClick(object sender, EventArgs e)
        {
            AsignarOEditarDiaDeHorario();
        }

        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            EliminarDiaDeHorario();
        }

        private void toolStripMenuItemAgregarOEditar_Click(object sender, EventArgs e)
        {
            AsignarOEditarDiaDeHorario();
        }

        private void ctxMenuDate_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ControlarMenuDeCalendario();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn != null && DateTime.TryParse(btn.Text, out DateTime fecha))
            {
                SeleccionarDiaYVer(fecha);
            }
        }

        private void ControlarMenuDeCalendario()
        {
            ctxMenuDate.Enabled =
            ctxMenuDate.Items[0].Enabled =
            ctxMenuDate.Items[1].Enabled = true;

            ctxMenuDate.Items[0].Text = "Asignar día";
            try
            {

                if (_empleado != null && _empleado.id_empleado > 0)
                {
                    //Items[0]: agregar o editar e Items[1]: eliminar
                    var hoy = DateTime.Now.Date;

                    bool soloUnaFechaSeleccionada = mcaMes.SelectionRanges.Count == 1 && (mcaMes.SelectionRanges[0].Start.Date == mcaMes.SelectionRanges[0].End.Date);
                    bool tieneHorario = _horario != null && _horario.id_horario_emp > 0 && _horario.LABt04_horario_emp_dtl != null;
                    bool fechaDeHorarioExisteDentroDelRangoSeleccionado = _horario != null && _horario.LABt04_horario_emp_dtl.Any(x => x.fecha_labor >= hoy && mcaMes.SelectionRanges.Any(r => x.fecha_labor >= r.Start.Date && x.fecha_labor <= r.End.Date));

                    //Para agregar o editar. 
                    if (!soloUnaFechaSeleccionada ||
                        (mcaMes.SelectionRanges[0].Start.Date) < hoy)
                    {
                        ctxMenuDate.Items[0].Enabled = false;
                    }
                    else
                    {
                        ctxMenuDate.Items[0].Enabled = true;

                        ctxMenuDate.Items[0].Text = (tieneHorario && _horario.LABt04_horario_emp_dtl.Any(x => x.fecha_labor == mcaMes.SelectionRanges[0].Start.Date)) ? "Editar día" : "Asignar día";
                    }

                    //Para eliminar
                    ctxMenuDate.Items[1].Enabled = tieneHorario && fechaDeHorarioExisteDentroDelRangoSeleccionado;
                }
                else
                {
                    ctxMenuDate.Enabled = false;
                }
            }
            catch
            {
                ctxMenuDate.Enabled = false;
            }
        }

        #endregion

    }
}
