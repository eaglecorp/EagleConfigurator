using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Producto;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.ViewModels;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            dgvComboVariable.Select();
        }

        #region Métodos

        void AddHandled()
        {
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            txtCodigo.KeyDown += FocusDgv_KeyDown;
            txtDescripcion.KeyDown += FocusDgv_KeyDown;
        }

        private void FocusDgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvComboVariable.Focus();
            }
        }

        private string GetIdSelected()
        {
            string id = "-1";
            try
            {
                if (dgvComboVariable.SelectedRows.Count > 0 && dgvComboVariable.Rows.Count > 0)
                {
                    id = dgvComboVariable.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }

        private void SetCabeceraGridDetail()
        {
            var detailHeader = new List<ComboItem>();
            dgvComboVariableDtl.DataSource = detailHeader.Select(x => new
            {
                CANTIDAD = "",
                DESC = "",
                ESTADO = ""
            }).ToList();
        }
        private void DefinirCabeceraGridDetail()
        {
            try
            {
                dgvComboVariableDtl.Columns["ESTADO"].Visible = false;

                dgvComboVariableDtl.Columns["DESC"].HeaderText = "PRODUCTO";
                dgvComboVariableDtl.Columns["CANTIDAD"].HeaderText = "CANT.";
                dgvComboVariableDtl.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvComboVariableDtl.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariableDtl.Columns["DESC"].Width = 400;
                dgvComboVariableDtl.Columns["CANTIDAD"].Width = 70;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de los productos del cbo. electivo. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridDetail(IEnumerable<ComboItem> list)
        {
            if (list != null)
            {
                list = list.Where(x => x.id_estado == Estado.IdActivo);
                dgvComboVariableDtl.DataSource = list.Select(x => new
                {
                    CANTIDAD = x.cantidad.RemoveTrailingZeros(),
                    DESC = x.txt_desc_item?.ToUpper(),
                    ESTADO = Estado.TxtActivo
                }).ToList();

            }
            else
            {
                SetCabeceraGridDetail();
            }
            DefinirCabeceraGridDetail();
        }

        private void VerDetalleRegistro()
        {
            if (dgvComboVariable.RowCount > 0 && dgvComboVariable.SelectedRows.Count > 0 && dgvComboVariable.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id) && id > 0)
                {
                    var details = new ComboVariableDetalleBL().ListaDetalleXCboVar(id);
                    CargarGridDetail(details);
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void CargarGrid(IEnumerable<PROt15_combo_variable> list)
        {
            if (list != null && list.Count() > 0)
            {
                dgvComboVariable.DataSource = list.Select(x => new
                {
                    ID = x.id_combo_variable,
                    CODIGO = x.cod_combo_variable,
                    DESCRIPCION = x.txt_desc?.ToUpper(),
                    PVPU_CON_IGV = x.mto_pvpu_con_tax.RemoveTrailingZeros(),
                    PVPU_SIN_IGV = x.mto_pvpu_sin_tax,
                    ESTADO = x.txt_estado?.ToUpper()
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

                //Limpia los productos del cbo variable seleccionado
                SetCabeceraGridDetail();
                DefinirCabeceraGridDetail();
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
            AddHandled();
            ConfigurarControles();
            BuscarComboVariable();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvComboVariable.Columns["ID"].Visible = false;
                dgvComboVariable.Columns["PVPU_SIN_IGV"].Visible = false;

                dgvComboVariable.Columns["CODIGO"].HeaderText = "CÓDIGO";
                dgvComboVariable.Columns["CODIGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvComboVariable.Columns["CODIGO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariable.Columns["PVPU_CON_IGV"].HeaderText = "PREC. UNIT";
                dgvComboVariable.Columns["PVPU_CON_IGV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvComboVariable.Columns["PVPU_CON_IGV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariable.Columns["DESCRIPCION"].HeaderText = "COMBO ELECTIVO";

                dgvComboVariable.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvComboVariable.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvComboVariable.Columns["CODIGO"].Width = 100;
                dgvComboVariable.Columns["DESCRIPCION"].Width = 260;
                dgvComboVariable.Columns["PVPU_CON_IGV"].Width = 100;
                dgvComboVariable.Columns["ESTADO"].Width = 90;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla del combo electivo. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SetCabeceraGridDetail();
            DefinirCabeceraGridDetail();

            ControlHelper.DgvReadOnly(dgvComboVariableDtl);
            ControlHelper.DgvStyle(dgvComboVariableDtl, 9);

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

        private PROt15_combo_variable GetComboVariable()
        {
            try
            {
                var cboVar = new PROt15_combo_variable()
                {
                    id_combo_variable = long.Parse(dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["ID"].Value.ToString()),
                    cod_combo_variable = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["CODIGO"].Value.ToString(),
                    txt_desc = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString(),
                    txt_estado = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["ESTADO"].Value.ToString()
                };
                var pvpu_con_igv = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["PVPU_CON_IGV"].Value;
                var pvpu_sin_igv = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["PVPU_SIN_IGV"].Value;
                if (pvpu_con_igv != null) cboVar.mto_pvpu_con_tax = decimal.Parse(pvpu_con_igv.ToString());
                if (pvpu_sin_igv != null) cboVar.mto_pvpu_sin_tax = decimal.Parse(pvpu_sin_igv.ToString());

                return cboVar;
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo obtener el combo variable.", "Excepción encontrada");
            }
            return null;
        }

        private void SeleccionarComboVariable()
        {
            if (dgvComboVariable.CurrentRow != null)
            {
                try
                {
                    var estado = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                    var desc = dgvComboVariable.Rows[dgvComboVariable.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();

                    if (estado == Estado.TxtActivo)
                    {
                        cboVariable = GetComboVariable();
                        CerrarForm();
                    }
                    else
                    {
                        if (DialogResult.OK == Msg.OkCancel_Info($@"No puede seleccionar el combo '{desc}' porque NO ESTÁ ACTIVADO. ¿Desea activarlo y seleccionarlo?."))
                        {
                            if (long.TryParse(ControlHelper.DgvGetCellValueSelected(dgvComboVariable, 0), out long id))
                            {
                                if (new ComboVariableBL().ActivarComboVariable(id))
                                {
                                    cboVariable = GetComboVariable();
                                    if (cboVariable != null)
                                    {
                                        cboVariable.id_estado = Estado.IdActivo;
                                        cboVariable.txt_estado = Estado.TxtActivo;
                                    }
                                    CerrarForm();
                                }
                                else
                                    Msg.Ok_Err($"No se pudo activar el combo '{desc}'.");
                            }
                            else
                                Msg.Ok_Err($"No se pudo activar el combo '{desc}'.");
                        }
                    }
                }
                catch (Exception e)
                {
                    cboVariable = null;
                    MessageBox.Show($"No se pudo seleccionar el combo. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvComboVariable_SelectionChanged(object sender, EventArgs e)
        {
            VerDetalleRegistro();
        }

        private void dgvComboVariable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarComboVariable();
            }
        }

        private void dgvComboVariable_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e, Color.LightGray);
        }

        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e, Color.LightGray);
        }
        #endregion

    }
}
