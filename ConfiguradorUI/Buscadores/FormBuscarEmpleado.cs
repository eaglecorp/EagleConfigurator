using ConfigBusinessEntity;
using ConfigBusinessLogic.Persona;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.HelperGeneric;
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

namespace ConfiguradorUI.Buscadores
{
    public partial class FormBuscarEmpleado : MetroForm
    {
        #region Variables
        public PERt04_empleado _empleado = null;

        #endregion

        public FormBuscarEmpleado()
        {
            InitializeComponent();
        }

        #region Métodos

        void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            txtNumDoc.KeyDown += FocusDgv_KeyDown;
            txtCodigo.KeyDown += FocusDgv_KeyDown;
            txtApellidosYNombres.KeyDown += FocusDgv_KeyDown;
        }

        private void FocusDgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvEmpleado.Focus();
            }
        }

        private void CargarGrid(IEnumerable<PERt04_empleado> list)
        {
            if (list != null)
            {
                dgvEmpleado.DataSource = list.Select(x => new
                {
                    ID = x.id_empleado,
                    COD = x.cod_empleado,
                    NOMBRE = Human.Nombre(x.txt_ape_pat, x.txt_pri_nom, x.txt_ape_mat, x.txt_seg_nom, x.txt_rzn_social).ToUpper(),
                    NUM_DOC = x.nro_doc,
                    RUC = x.nro_ruc
                }).ToList();
            }
            else
            {
                var empHeader = new List<PERt04_empleado>();
                dgvEmpleado.DataSource = empHeader.Select(x => new
                {
                    ID = "",
                    COD = "",
                    NOMBRE = "",
                    NUM_DOC = "",
                    RUC = "",
                }).ToList();
            }
            DefinirCabeceraGrid();
        }

        private void BuscarEmpleado(bool verTodos = false)
        {
            var numDoc = txtNumDoc.Text.Trim();
            var cod = txtCodigo.Text.Trim();
            var nombre = txtApellidosYNombres.Text.Trim();

            if (verTodos)
            {
                numDoc = "";
                cod = "";
                nombre = "";
            }

            var list = new EmpleadoBL().BuscarEmpleados(numDoc, numDoc, cod, nombre, Estado.IdActivo);
            CargarGrid(list);
        }

        private void SetInicio()
        {
            AddHandlers();
            ConfigurarControles();
            BuscarEmpleado();
            txtApellidosYNombres.Focus();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvEmpleado.Columns["ID"].Visible = false;

                dgvEmpleado.Columns["NUM_DOC"].HeaderText = "NRO. DOC";
                dgvEmpleado.Columns["NUM_DOC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleado.Columns["NUM_DOC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvEmpleado.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleado.Columns["RUC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvEmpleado.Columns["COD"].HeaderText = "CÓDIGO";
                dgvEmpleado.Columns["COD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleado.Columns["COD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dgvEmpleado.Columns["NUM_DOC"].Width = 100;
                dgvEmpleado.Columns["RUC"].Width = 100;
                dgvEmpleado.Columns["COD"].Width = 100;
                dgvEmpleado.Columns["NOMBRE"].HeaderText = "APELLIDOS Y NOMBRES | RAZÓN SOCIAL";
                dgvEmpleado.Columns["NOMBRE"].Width = 535;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            #region Form
            MaximizeBox = false;
            Resizable = false;
            #endregion

            #region TextBox

            txtNumDoc.MaxLength = 50;
            txtCodigo.MaxLength = 50;
            txtApellidosYNombres.MaxLength = 350;

            #endregion

            #region Grilla
            var empHeader = new List<PERt04_empleado>();
            dgvEmpleado.DataSource = empHeader.Select(x => new
            {
                ID = "",
                COD = "",
                NOMBRE = "",
                NUM_DOC = "",
                RUC = ""
            }).ToList();
            DefinirCabeceraGrid();
            ControlHelper.DgvReadOnly(dgvEmpleado);
            ControlHelper.DgvStyle(dgvEmpleado);
            #endregion

        }

        private PERt04_empleado GetEmpleado()
        {
            try
            {
                long id_empleado = long.Parse(dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells["ID"].Value.ToString());
                return new EmpleadoBL().EmpleadoXId(id_empleado);
            }
            catch (Exception)
            {
                Msg.Ok_Err("No se pudo obtener el empleado.", "Excepción encontrada");
            }
            return null;
        }

        private void Seleccionar(DataGridViewCellEventArgs e=null)
        {
            if (e != null && e.RowIndex == -1 || !(dgvEmpleado.SelectedRows.Count > 0)) return;
            if (dgvEmpleado.CurrentRow != null)
            {
                try
                {
                    _empleado = GetEmpleado();
                    CerrarForm();
                }
                catch (Exception ex)
                {
                    _empleado = null;
                    MessageBox.Show($"No se pudo seleccionar el empleado. Excepción: {ex.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CerrarForm()
        {
            Hide();
            Close();
        }


        #endregion

        #region Eventos

        private void FormBuscarEmpleado_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void txtApellidosYNombres_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BuscarEmpleado(true);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void dgvEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Seleccionar();
            }
        }

        private void dgvEmpleado_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }

        #endregion
    }
}
