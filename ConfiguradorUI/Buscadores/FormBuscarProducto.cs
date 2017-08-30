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
using ConfigBusinessLogic.Producto;
using ConfigBusinessEntity;
using ConfigUtilitarios;
using ConfigBusinessLogic;

namespace ConfiguradorUI.Buscadores
{
    public partial class FormBuscarProducto : MetroForm
    {
        #region Variables
        public PROt09_producto producto = null;
        #endregion

        public FormBuscarProducto()
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

        private void CargarGrid(IEnumerable<PROt09_producto> list)
        {
            if (list != null)
            {
                dgvProd.DataSource = list.Select(x => new
                {
                    ID = x.id_producto,
                    CODIGO = x.cod_producto,
                    CODIGO02 = x.cod_producto2,
                    DESCRIPCION = x.txt_desc,
                    ESTADO = x.txt_estado,
                    PVPU_CON_IGV = x.mto_pvpu_con_igv,
                    PVPU_SIN_IGV = x.mto_pvpu_sin_igv,
                    POR_IMPTO = x.por_impto,
                    PESO = x.peso_prod,
                    UM = x.id_um

                }).ToList();
            }
            else
            {
                var prodHeader = new List<TNSt05_comp_emitido_dtl>();
                dgvProd.DataSource = prodHeader.Select(x => new
                {
                    ID = "",
                    CODIGO = "",
                    CODIGO02 = "",
                    DESCRIPCION = "",
                    ESTADO = "",
                    PVPU_CON_IGV = "",
                    PVPU_SIN_IGV = "",
                    POR_IMPTO = "",
                    PESO = "",
                    UM = ""

                }).ToList();
            }
            DefinirCabeceraGrid();
        }

        private void BuscarProducto(bool verTodos = false)
        {
            var cod = txtCodigo.Text.Trim();
            var cod02 = txtCodigo02.Text.Trim();
            var nombre = txtDescripcionProd.Text.Trim();
            int? estado = chkIncluirInactivos.Checked ? Estado.Ignorar : Estado.IdActivo;
            int? snVenta = chkProdVenta.Checked ? Estado.IdActivo : Estado.Ignorar;
            int? snCompra = chkProdCompra.Checked ? Estado.IdActivo : Estado.Ignorar;

            if (verTodos)
            {
                cod = "";
                cod02 = "";
                nombre = "";
                estado = Estado.Ignorar;
                snVenta = Estado.Ignorar;
                snCompra = Estado.Ignorar;
            }

            var list = new ProductoBL().BuscarProducto(cod, cod02, nombre, snVenta, snCompra, estado);
            CargarGrid(list);
        }

        private void SetInicio()
        {
            ConfigurarControles();
            BuscarProducto();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvProd.Columns["ID"].Visible = false;
                dgvProd.Columns["PVPU_CON_IGV"].Visible = false;
                dgvProd.Columns["PVPU_SIN_IGV"].Visible = false;
                dgvProd.Columns["POR_IMPTO"].Visible = false;
                dgvProd.Columns["PESO"].Visible = false;
                dgvProd.Columns["UM"].Visible = false;

                dgvProd.Columns["CODIGO"].HeaderText = "CÓDIGO";
                dgvProd.Columns["CODIGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["CODIGO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["CODIGO02"].HeaderText = "CÓDIGO 02";
                dgvProd.Columns["CODIGO02"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["CODIGO02"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["DESCRIPCION"].HeaderText = "DESCRIPCIÓN";

                dgvProd.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProd.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProd.Columns["DESCRIPCION"].Width = 405;
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
            chkProdVenta.Checked = true;
            chkProdCompra.Checked = false;

            #endregion

            #region TextBox

            txtCodigo.MaxLength = 50;
            txtCodigo02.MaxLength = 50;
            txtDescripcionProd.MaxLength = 350;

            #endregion

            #region Grilla
            var prodHeader = new List<TNSt05_comp_emitido_dtl>();
            dgvProd.DataSource = prodHeader.Select(x => new
            {
                ID = "",
                CODIGO = "",
                CODIGO02 = "",
                DESCRIPCION = "",
                ESTADO = "",
                PVPU_CON_IGV = "",
                PVPU_SIN_IGV = "",
                POR_IMPTO = "",
                PESO = "",
                UM = ""

            }).ToList();
            DefinirCabeceraGrid();
            ControlHelper.DgvReadOnly(dgvProd);
            ControlHelper.DgvStyle(dgvProd);
            #endregion

        }

        private void SeleccionarProducto()
        {
            if (dgvProd.CurrentRow != null)
            {
                try
                {
                    producto = new PROt09_producto();

                    var pvpu_con_igv = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PVPU_CON_IGV"].Value;
                    var pvpu_sin_igv = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PVPU_SIN_IGV"].Value;
                    var por_impto = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["POR_IMPTO"].Value;
                    var id_um = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["UM"].Value;

                    producto.id_producto = long.Parse(dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ID"].Value.ToString());
                    producto.cod_producto = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                    producto.cod_producto2 = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["CODIGO02"].Value.ToString();
                    producto.txt_desc = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["DESCRIPCION"].Value.ToString();
                    producto.txt_estado = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
                    if (pvpu_con_igv == null) producto.mto_pvpu_con_igv = null; else producto.mto_pvpu_con_igv = decimal.Parse(pvpu_con_igv.ToString());
                    if (pvpu_sin_igv == null) producto.mto_pvpu_sin_igv = null; else producto.mto_pvpu_sin_igv = decimal.Parse(pvpu_sin_igv.ToString());
                    if (por_impto == null) producto.por_impto = null; else producto.por_impto = decimal.Parse(por_impto.ToString());
                    producto.peso_prod = dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["PESO"].Value.ToString();
                    if (id_um == null) producto.id_um = null; else producto.id_um = int.Parse(id_um.ToString());

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

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void txtCodigo02_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void txtDescripcionProd_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto();
        }

        private void chkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void chkProdVenta_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void chkProdCompra_CheckedChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BuscarProducto(true);
        }

        private void dgvProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProducto();
            }
        }


        #endregion

    }
}
