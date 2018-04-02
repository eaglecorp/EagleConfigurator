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
            #endregion
        }


        private void RefrescarHorario()
        {
            LimpiarHorario();
            var horario = new HorarioEmpleadoBL().HorarioXEmpleado(_empleado.id_empleado);
            SetHorario(horario);

            btnAsignarHorario.Enabled = true;
            btnDesasignarFechas.Enabled = (horario != null && horario.id_horario_emp > 0);
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
                var frm = new FormAsignarHorario(_empleado, _horario);
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
                if (_horario != null && _horario.LABt04_horario_emp_dtl != null && _horario.LABt04_horario_emp_dtl.Count > 0)
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

        private void txtNroDocEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BuscarEmpleado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_horario !=null && _horario.LABt04_horario_emp_dtl != null)
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

        private void mcaMes_DoubleClick(object sender, EventArgs e)
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

                            if(frm._seOpero)
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

        //dentro de rango
        private bool EsFechaValida(DateTime fecha)
        {
            var hoy = DateTime.Now.Date;
            return (fecha >= hoy && fecha <= KeyDates.MaxDate);
        }

    }
}
