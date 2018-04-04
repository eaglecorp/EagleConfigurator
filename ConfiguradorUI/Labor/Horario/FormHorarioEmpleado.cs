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
        private void SetHorario(LABt03_horario_emp horario)
        {
            try
            {
                _horario = horario;

                if (horario != null &&
                       horario.id_horario_emp > 0)
                {

                    IEnumerable<DateTime> horarioSoloFechas = new List<DateTime>();
                    if (horario.LABt04_horario_emp_dtl != null)
                    {
                        horarioSoloFechas = horario.LABt04_horario_emp_dtl.Select(x => x.fecha_labor);
                    }

                    var fechasDeLaborRestante = horarioSoloFechas.Count(x => x.Date >= DateTime.Now.Date);

                    lblRangoHorario.ForeColor = Color.Navy;
                    lblRangoHorario.Text = $"Horario desde {horario.fecha_inicio_horario.ToShortDateString()} " +
                                            $"hasta {horario.fecha_fin_horario.ToShortDateString()} - {fechasDeLaborRestante} días restantes";

                    ResaltarFechasEnCalendario(horarioSoloFechas);
                }
                else
                {
                    lblRangoHorario.Text = "HORARIO: NINGUNO";
                    lblRangoHorario.ForeColor = Color.Red;
                    ResaltarFechasEnCalendario(null);
                    btnAsignarHorario.Focus();
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo mostrar el horario correctamente. Error: " + e.Message);
            }
        }

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

                    SetEmpleado(empleado);
                    var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
                    SetHorario(horario);

                    btnAsignarHorario.Enabled = true;
                    btnDesasignarFechas.Enabled = (horario != null && horario.id_horario_emp > 0);
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

        private void LimpiarHorario()
        {
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
            lblRangoHorario.Text = "HORARIO: NINGUNO";

            txtNombreEmpleado.Clear();
            txtInicioContrato.Clear();
            txtFinContrato.Clear();
            txtNroDocEmp.Clear();
        }

        private void ConfigurarControles()
        {
            #region MonthCalendar

            mcaMes.MaxDate = KeyDates.MaxDate;

            #endregion

            #region labels

            lblRangoHorario.UseCustomForeColor = true;
            lblRangoHorario.ForeColor = Color.Red;

            #endregion


            #region botones

            btnAsignarHorario.Enabled = false;
            btnDesasignarFechas.Enabled = false;

            #endregion

            #region Month Calendar

            mcaMes.SelectionRange = new SelectionRange();
            mcaMes.ContextMenuStrip = ctxMenuDate;

            #endregion
        }

        private void RefrescarHorario()
        {
            LimpiarHorario();
            var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
            SetHorario(horario);

            btnAsignarHorario.Enabled = true;
            btnDesasignarFechas.Enabled =
            btnEditarFechas.Enabled = TieneHorarioYFechas();
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
            return (fecha >= hoy && fecha <= KeyDates.MaxDate);
        }

        private int GetNumeroFechasPasadas()
        {
            var hoy = DateTime.Now.Date;
            return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor < hoy).Count();
        }

        private int GetNumeroFechasRestantes()
        {
            var hoy = DateTime.Now.Date;
            return _horario.LABt04_horario_emp_dtl.Where(x => x.fecha_labor >= hoy).Count();
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
                    Msg.Ok_Err("No se pudo determinar los IDs de las fechas seleccionadas.");
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
                        if (Msg.YesNo_Wng($"¿Está seguro de eliminar {mensajeSegunNumero}?") == DialogResult.Yes)
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
                                Msg.Ok_Err("No se actualizó el rango de fechas del horario.");
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

        private void EditarDiaDeHorario()
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                var fecha = mcaMes.SelectionRange.Start.Date;
                if (_horario != null && _horario.id_horario_emp > 0)
                {
                    //Cuando ya tiene un horario
                    if (EsFechaValida(fecha))
                    {
                        var horarioDtl = new HorarioEmpleadoBL().GetHorarioDtlXFecha(fecha, _horario.id_horario_emp);
                        if (horarioDtl != null && horarioDtl.id_horario_emp_dtl > 0)
                        {
                            //Actualizar fecha
                            var frm = new FormEditarDia(horarioDtl, TipoOperacionABM.Modificar);
                            frm.ShowDialog();

                            if (frm._seOpero)
                            {
                                RefrescarHorario();
                            }
                        }
                        else
                        {
                            //Agregar fecha

                        }
                    }
                }
                else
                {
                    //crear nuevo horario y agregar fecha
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
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btnAsignarHorario_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                var frm = new FormAsignarHorario(_empleado, _horario, TipoOperacionABM.Insertar);
                frm.ShowDialog();

                if (frm._seAsigno)
                {
                    RefrescarHorario();
                }
            }
            else
            {
                Msg.Ok_Wng("Debe buscar un empleado antes de asignar el horario.");
            }
        }

        private void btnDesasignarFechas_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                if (TieneHorarioYFechas())
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
                    Msg.Ok_Wng("Este empleado no tiene horario o no tiene ninguna fecha asignada.");
                }
            }
            else
            {
                Msg.Ok_Wng("Debe buscar un empleado antes de eliminar fechas del horario.");
            }
        }

        private void btnEditarFechas_Click(object sender, EventArgs e)
        {
            if (_empleado != null && _empleado.id_empleado > 0)
            {
                if (TieneHorarioYFechas())
                {
                    var hoy = DateTime.Now.Date;
                    if (_horario.fecha_fin_horario >= hoy)
                    {
                        var frm = new FormAsignarHorario(_empleado, _horario, TipoOperacionABM.Modificar);
                        frm.ShowDialog();

                        if (frm._seAsigno)
                        {
                            RefrescarHorario();
                        }
                    }
                    else
                    {
                        Msg.Ok_Wng("Las fechas asignadas al empleado han concluido.");
                    }
                }
                else
                {
                    Msg.Ok_Wng("Este empleado no tiene horario o no tiene ninguna fecha asignada.");
                }
            }
            else
            {
                Msg.Ok_Wng("Debe buscar un empleado antes de eliminar fechas del horario.");
            }
        }

        private void txtNroDocEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BuscarEmpleado();
        }

        private void mcaMes_DoubleClick(object sender, EventArgs e)
        {
            EditarDiaDeHorario();
        }

        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            EliminarDiaDeHorario();
        }

        private void toolStripMenuItemAgregarOEditar_Click(object sender, EventArgs e)
        {
            EditarDiaDeHorario();
        }

        private void ctxMenuDate_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ControlarMenuDeCalendario();
        }

        private void ControlarMenuDeCalendario()
        {
            ctxMenuDate.Enabled =
            ctxMenuDate.Items[0].Enabled =
            ctxMenuDate.Items[1].Enabled = true;

            ctxMenuDate.Items[0].Text = "Asignar día";

            if (_empleado != null && _empleado.id_empleado > 0)
            {
                //Items[0]: agregar o editar e Items[1]: eliminar
                var hoy = DateTime.Now.Date;

                bool soloUnaFechaSeleccionada = mcaMes.SelectionRanges.Count == 1 && (mcaMes.SelectionRanges[0].Start.Date == mcaMes.SelectionRanges[0].End.Date);
                bool tieneHorario = _horario != null && _horario.id_horario_emp > 0 && _horario.LABt04_horario_emp_dtl != null;
                bool fechaDeHorarioExisteDentroDelRangoSeleccionado = _horario.LABt04_horario_emp_dtl.Any(x => x.fecha_labor >= hoy && mcaMes.SelectionRanges.Any(r => x.fecha_labor >= r.Start.Date && x.fecha_labor <= r.End.Date));

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_horario != null && _horario.LABt04_horario_emp_dtl != null)
            {
                string fechas = "";
                foreach (var fecha in _horario.LABt04_horario_emp_dtl)
                {
                    fechas += fecha.fecha_labor.ToLongDateString() + "\n";
                }
                Msg.Ok_Info(fechas);
            }
        }
        #endregion

    }
}
