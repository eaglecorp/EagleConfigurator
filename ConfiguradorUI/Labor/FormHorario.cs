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

namespace ConfiguradorUI.Labor
{
    public partial class FormHorario : MetroForm
    {
        public FormHorario()
        {
            InitializeComponent();
        }

        private void ConfigurarControles()
        {
            #region dgv

            CargarSemana();

            ControlHelper.DgvBaseConfig(dgvSemana);
            ControlHelper.DgvBaseConfig(dgvMes);

            ControlHelper.DgvBaseStyle(dgvMes);
            ControlHelper.DgvBaseStyle(dgvSemana, 25, 90, true,29);

            dgvSemana.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSemana.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);



            #endregion

            #region list view

            lstTrabajo.View = View.List;

            #endregion

            #region picture

            picFotoEmp.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            #region grb

            grbDatosEmpleado.Enabled = false;
            #endregion
        }

        private void CargarSemana()
        {
            DataTable dtSemana = new DataTable();
            dtSemana.Columns.Add(new DataColumn("horaInicio", typeof(string)));
            dtSemana.Columns.Add(new DataColumn("horaFin", typeof(string)));
            dtSemana.Columns.Add(new DataColumn("activar", typeof(bool)));

            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);
            dtSemana.Rows.Add(string.Empty, string.Empty, false);

            dgvSemana.DataSource = dtSemana;

            dgvSemana.Columns["horaInicio"].HeaderText = "Hora inicio";
            dgvSemana.Columns["horaFin"].HeaderText = "Hora fin";
            dgvSemana.Columns["activar"].HeaderText = "Activar";

            dgvSemana.Columns["horaInicio"].Width = 85;
            dgvSemana.Columns["horaFin"].Width = 85;
            dgvSemana.Columns["activar"].Width = 50;

            dgvSemana.Rows[0].HeaderCell.Value = "Lunes";
            dgvSemana.Rows[1].HeaderCell.Value = "Martes";
            dgvSemana.Rows[2].HeaderCell.Value = "Miércoles";
            dgvSemana.Rows[3].HeaderCell.Value = "Jueves";
            dgvSemana.Rows[4].HeaderCell.Value = "Viernes";
            dgvSemana.Rows[5].HeaderCell.Value = "Sábado";
            dgvSemana.Rows[6].HeaderCell.Value = "Domingo";

        }

        private void CargarMes()
        {

        }

        private void FormHorario_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvSemana.Rows[0].HeaderCell.Value = "Lunes";
            dgvSemana.Rows[1].HeaderCell.Value = "Martes";
            dgvSemana.Rows[2].HeaderCell.Value = "Miércoles";
            dgvSemana.Rows[3].HeaderCell.Value = "Jueves";
            dgvSemana.Rows[4].HeaderCell.Value = "Viernes";
            dgvSemana.Rows[5].HeaderCell.Value = "Sábado";
            dgvSemana.Rows[6].HeaderCell.Value = "Domingo";
        }
    }
}
