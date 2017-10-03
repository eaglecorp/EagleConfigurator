using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Producto;
using ConfigUtilitarios;
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
    public partial class FormBuscarComboVariable : MetroForm
    {
        #region Variables
        public PROt15_combo_variable cboVariable = null;
        #endregion

        public FormBuscarComboVariable()
        {
            InitializeComponent();
        }

        #region Métodos

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Hide();
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CargarGrid(IEnumerable<PROt15_combo_variable> list)
        {
            if (list != null)
            {
                dgvComboVariable.DataSource = list.Select(x => new
                {
                    ID = x.id_combo_variable,
                    CODIGO = x.cod_combo_variable,
                    DESCRIPCION = x.txt_desc,
                    PVPU_CON_IGV = x.mto_pvpu_con_tax,
                    PVPU_SIN_IGV = x.mto_pvpu_sin_tax,
                    ESTADO = x.txt_estado
                }).ToList();
            }
            else
            {
                var prodHeader = new List<TNSt05_comp_emitido_dtl>();
                dgvComboVariable.DataSource = prodHeader.Select(x => new
                {
                    ID = "",
                    CODIGO = "",
                    DESCRIPCION = "",
                    PVPU_CON_IGV = "",
                    PVPU_SIN_IGV = "",
                    ESTADO = ""
                }).ToList();
            }
            DefinirCabeceraGrid();
        }

        private void BuscarComboVariable(bool verTodos = false)
        {
            var cod = txtCodigo.Text.Trim();
            var nombre = txtDescripcion.Text.Trim();
            int? estado = chkIncluirInactivos.Checked ? Estado.Ignorar : Estado.IdActivo;

            if (verTodos)
            {
                cod = "";
                nombre = "";
                estado = Estado.Ignorar;
            }
            var list = new ComboVariableBL().BuscarComboVariable(cod, nombre, estado);
            CargarGrid(list);
        }

        private void SetInicio()
        {
            ConfigurarControles();
            BuscarComboVariable();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvComboVariable.Columns["ID"].Visible = false;
                dgvComboVariable.Columns["PVPU_SIN_IGV"].Visible = false;
                dgvComboVariable.Columns["PVPU_CON_IGV"].Visible = false;

                dgvComboVariable.Columns["CODIGO"].HeaderText = "CÓDIGO";
                dgvComboVariable.Columns["CODIGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvComboVariable.Columns["CODIGO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariable.Columns["DESCRIPCION"].HeaderText = "DESCRIPCIÓN";

                dgvComboVariable.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvComboVariable.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariable.Columns["DESCRIPCION"].Width = 245;
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

            #region Checks

            chkIncluirInactivos.Checked = false;

            #endregion

            #region TextBox

            txtCodigo.MaxLength = 10;
            txtDescripcion.MaxLength = 250;

            #endregion

            #region Grilla
            var prodHeader = new List<TNSt05_comp_emitido_dtl>();
            dgvComboVariable.DataSource = prodHeader.Select(x => new
            {
                ID = "",
                CODIGO = "",
                DESCRIPCION = "",
                PVPU_CON_IGV = "",
                PVPU_SIN_IGV = "",
                ESTADO = ""
            }).ToList();
            DefinirCabeceraGrid();
            ControlHelper.DgvReadOnly(dgvComboVariable);
            ControlHelper.DgvStyle(dgvComboVariable);
            #endregion

        }

        private void SeleccionarComboVariable()
        {
            if (dgvComboVariable.CurrentRow != null)
            {
                try
                {
                    cboVariable = new PROt15_combo_variable();

                    var pvpu_con_igv = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["PVPU_CON_IGV"].Value;
                    var pvpu_sin_igv = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["PVPU_SIN_IGV"].Value;

                    cboVariable.id_combo_variable = long.Parse(dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["ID"].Value.ToString());
                    cboVariable.cod_combo_variable = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                    cboVariable.txt_desc = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
                    cboVariable.txt_estado = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                    if (pvpu_con_igv != null) cboVariable.mto_pvpu_con_tax = decimal.Parse(pvpu_con_igv.ToString());
                    if (pvpu_sin_igv != null) cboVariable.mto_pvpu_sin_tax = decimal.Parse(pvpu_sin_igv.ToString());

                    Hide();
                    Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"No se pudo seleccionar el producto. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion

        #region Eventos

        private void FormBuscarComboVariable_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarComboVariable();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            BuscarComboVariable();
        }

        private void dgvComboVariable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarComboVariable();
        }

        private void chkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarComboVariable();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarComboVariable();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BuscarComboVariable(true);
        }

        private void dgvComboVariable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarComboVariable();
            }
        }


        #endregion


    }
}
