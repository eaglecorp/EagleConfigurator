using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Components;
using MetroFramework.Controls;
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

namespace ConfiguradorUI.Maestro
{
    public partial class FormMesa : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        public bool actualizar = false;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";
        MetroToolTip tooltip;
        #endregion

        public FormMesa()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            var txts = new[] { txtNumero, txtCodigo, txtCapacidad };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }
            var cbos = new[] { cboEstadoMesa, cboCanalVenta };
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cbo);
            }
            txtCapacidad.KeyPress += ValidarTxtEntero;
        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            if (isSelected && isChangedRow == false && TipoOperacion != TipoOperacionABM.Cambio)
            {
                TipoOperacion = TipoOperacionABM.Cambio;
                ControlarEventosABM();
            }
        }
        private void CambioEnControl(object sender, EventArgs e)
        {
            //invocado con el IDE (por repetición).
            isChangedRow = false;
        }
        private void ValidarTxtEntero(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt14_mesa();
                        obj = GetObjeto();
                        int id = new MesaBL().InsertarMesa(obj);
                        if (id > 0)
                            actualizar = true;
                        ControlarEventosABM(id);
                    }
                }
                else
                {
                    Actualizar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción en el commit:" + e.Message, "MENSAJE");
            }

        }
        //No está enlazado con el evento click. (Se hará otra gestión con los estados de las mesas)
        //En principio no se llamará eliminar sino algo como 'cambiarEstado'
        private void Eliminar()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvMesa.RowCount > 0)
                {
                    if (dgvMesa.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdMesa.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    //Lógica que prevee si tiene hijos antes de la elimanación del registro

                                    //bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Estado_ComprobanteEmitido);
                                    //if (validDelete)
                                    //{
                                    new MesaBL().CambiarEstadoMesa(id, 0);
                                    actualizar = true;
                                    ControlarEventosABM();
                                    //}
                                    //else
                                    //{
                                    //    TipoOperacion = TipoOperacionABM.No_Action;
                                    //    ControlarEventosABM();
                                    //    MessageBox.Show(this, "Este registro no se puede eliminar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //}
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "El ID es incorrecto.", "MENSAJE");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(this, "Ocurrió una excepción en el intento de eliminación: " + e.Message, "MENSAJE");
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha seleccinado ningún registro.", "MENNSAJE");
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay registros", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private bool Actualizar()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {

                        var obj = new MSTt14_mesa();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdMesa.Text, out id))
                        {
                            obj.id_mesa = id;
                            new MesaBL().ActualizarMesa(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_mesa);
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar el registro: " + e.Message);
            }
            return isValid;
        }
        private bool ActualizarEnCheck()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt14_mesa();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdMesa.Text, out id))
                        {
                            obj.id_mesa = id;
                            new MesaBL().ActualizarMesa(obj);
                            actualizar = true;
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar en Check: " + e.Message);
            }
            return isValid;
        }

        private MSTt14_mesa GetObjeto()
        {
            var obj = new MSTt14_mesa();
            try
            {
                obj.txt_num = txtNumero.Text.Trim();
                obj.cod_mesa = txtCodigo.Text.Trim();
                obj.capacidad = int.Parse(txtCapacidad.Text.Trim());

                obj.id_estado_mesa = int.Parse(cboEstadoMesa.SelectedValue.ToString());

                if (int.TryParse(cboCanalVenta.SelectedValue?.ToString(), out int id))
                    obj.id_can_vta = id;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }
            return obj;
        }
        private void SetObjeto(MSTt14_mesa obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                lblIdMesa.Text = obj.id_mesa.ToString();
                codSelected = obj.cod_mesa;

                txtNumero.Text = obj.txt_num;
                txtCodigo.Text = obj.cod_mesa;
                txtCapacidad.Text = obj.capacidad.ToString();

                cboEstadoMesa.SelectedValue = obj.id_estado_mesa;
                setValueInCbo(cboCanalVenta, obj.id_can_vta);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }

        }

        private bool EsValido()
        {
            //Por ver - validar combos.
            bool no_error = true;
            errorProv.Clear();

            if (string.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                tabMesa.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNumero, "Este campo es requerido.");
                txtNumero.Focus();
                no_error = false;
            }

            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabMesa.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new MesaBL().MesaXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_mesa > 0)
                            {
                                tabMesa.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_mesa > 0)
                            {
                                tabMesa.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }

                    }

                }
            }

            #endregion

            if (no_error)
            {
                if (string.IsNullOrEmpty(txtCapacidad.Text.Trim()))
                {
                    errorProv.SetError(txtCapacidad, "Este campo es requerido.");
                    txtCapacidad.Focus();
                    no_error = false;
                }
                else if (!int.TryParse(txtCapacidad.Text.Trim(), out int capacidad) || capacidad <= 0)
                {
                    errorProv.SetError(txtCapacidad, "Debe ser un número entero positivo.");
                    txtCapacidad.Focus();
                    no_error = false;
                }
            }

            if (no_error && !int.TryParse(cboEstadoMesa.SelectedValue?.ToString(), out int id))
            {
                errorProv.SetError(cboEstadoMesa, "Este campo es requerido.");
                cboEstadoMesa.Focus();
                no_error = false;
            }

            return no_error;
        }
        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvMesa.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvMesa.Rows.Count > 0)
                        {
                            dgvMesa.Rows[index].Selected = true;
                            dgvMesa.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvMesa.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvMesa.Rows.Count > 0)
                        {
                            dgvMesa.Rows[index].Selected = true;
                            dgvMesa.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(int id)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvMesa.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_mesa"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvMesa.Rows.Count > 0)
                    {
                        dgvMesa.Rows[index].Selected = true;
                        dgvMesa.FirstDisplayedScrollingRowIndex = index;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarRegistro()
        {
            isPending = false;
            if (dgvMesa.RowCount > 0 && dgvMesa.SelectedRows.Count > 0 && dgvMesa.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new MesaBL().MesaXId(id);
                        if (obj != null)
                        {
                            isSelected = false;
                            SetObjeto(obj);
                            isChangedRow = true;
                            isSelected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string GetIdSelected()
        {
            string id = "-1";
            try
            {
                if (dgvMesa.SelectedRows.Count > 0 && dgvMesa.Rows.Count > 0)
                {
                    id = dgvMesa.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }


        void setValueInCbo(ComboBox cbo, int? id)
        {
            if (id != null)
                cbo.SelectedValue = id;
            else
                cbo.SelectedIndex = -1;
        }
        private void CargarComboFiltro()
        {
            try
            {
                var listFiltro = new ComboFiltro().ListarFiltros();
                cboFiltro.DisplayMember = "TxtCampo";
                cboFiltro.ValueMember = "IdCampo";
                cboFiltro.DataSource = listFiltro;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de Filtro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LimpiarForm()
        {
            isSelected = false;
            lblIdMesa.Text = 0 + "";
            codSelected = "";

            txtNumero.Clear();
            txtCodigo.Clear();
            txtCapacidad.Clear();

            if (cboEstadoMesa.Items.Count > 0)
                cboEstadoMesa.SelectedIndex = 0;
            cboCanalVenta.SelectedIndex = -1;

        }
        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
        {
            btnNuevo.Enabled = eNuevo;
            btnDelete.Enabled = eDelete;
            btnCommit.Enabled = eCommit;
            btnRollback.Enabled = eRollback;
            btnSearch.Enabled = eSearch;
            btnFilter.Enabled = eFilter;
        }
        private void ControlarEventosABM(int? id = null)
        {

            if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
                errorProv.Clear();
                //tabProducto.SelectedTab = tabPagGeneral;
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabMesa.SelectedTab = tabPagGeneral;
                    txtNumero.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();
                        ActualizarGrilla();
                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        tabMesa.SelectedTab = tabPagGeneral;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        //Después de hacer commit-eliminar
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            ActualizarGrilla();
                            tabMesa.SelectedTab = tabPagGeneral;
                            btnNuevo.Focus();
                        }
                        else
                        {
                            if (TipoOperacion == TipoOperacionABM.Rollback)
                            {
                                ControlarBotones(true, true, false, false, true, true);
                                isPending = false;
                                errorProv.Clear();
                                LimpiarForm();
                                SeleccionarRegistro();
                                tabMesa.SelectedTab = tabPagGeneral;
                                btnNuevo.Focus();
                            }
                            else
                            {
                                if (TipoOperacion == TipoOperacionABM.Cambio)
                                {
                                    ControlarBotones(false, false, true, true, false, false);
                                    isPending = true;
                                }
                                else
                                {
                                    if (TipoOperacion == TipoOperacionABM.Modificar)
                                    {
                                        errorProv.Clear();
                                        LimpiarForm();
                                        ControlarBotones(true, true, false, false, true, true);
                                        isSelected = false;
                                        isPending = false;
                                        isChangedRow = false;

                                        ActualizarGrilla();

                                        tabMesa.SelectedTab = tabPagGeneral;

                                        if (id != null)
                                        {
                                            int idAct = (int)id;
                                            SeleccionarPorId(idAct);
                                        }
                                        btnNuevo.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void MantenerEstadoABM()
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                ControlarBotones(false, false, true, true, false, false);
            }
            else if (TipoOperacion == TipoOperacionABM.Cambio)
            {
                ControlarBotones(false, false, true, true, false, false);
                isPending = true;
            }
            else if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
            else
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
        }
        private void CargarCombos()
        {
            try
            {
                cboEstadoMesa.DataSource = null;
                cboEstadoMesa.DisplayMember = "txt_desc";
                cboEstadoMesa.ValueMember = "id_estado_mesa";
                cboEstadoMesa.DataSource = new EstadoMesaBL().ListaEstadoMesa(Estado.IdActivo, false, true);

                cboCanalVenta.DataSource = null;
                cboCanalVenta.DisplayMember = "txt_desc";
                cboCanalVenta.ValueMember = "id_can_vta";
                cboCanalVenta.DataSource = new CanalVentaBL().ListaCanalVenta(Estado.IdActivo, false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos: " + e.Message, "MENSAJE");
            }
        }
        private void CargarGrilla(int? id_estado_mesa = null)
        {
            try
            {
                var lista = new MesaBL().ListaMesa(id_estado_mesa, true);
                var listaView = lista.Select(x => new { x.id_mesa, CODIGO = x.cod_mesa, NOMBRE = x.txt_num })
               .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    dgvMesa.DataSource = listaView;
                    dgvMesa.Columns["id_mesa"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}");

            }
        }
        private void ActualizarGrilla(int? id_estado_mesa = null)
        {
            CargarGrilla(id_estado_mesa);
        }
        private void ConfigurarGrilla()
        {
            dgvMesa.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvMesa.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvMesa.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvMesa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvMesa.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvMesa.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvMesa.AllowUserToResizeColumns = true;
            dgvMesa.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvMesa.Columns["CODIGO"].Width = 100;
            dgvMesa.Columns["NOMBRE"].Width = 300;

        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNumero.MaxLength = 20;
            txtCapacidad.MaxLength = 9;

        }

        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        #endregion

        #region Eventos de ventana

        private void FormMesa_Load(object sender, EventArgs e)
        {
            #region Set tooltip
            tooltip = new MetroToolTip();
            tooltip.SetToolTip(btnNuevo, "Nuevo");
            tooltip.SetToolTip(btnDelete, "Eliminar");
            tooltip.SetToolTip(btnCommit, "Confirmar");
            tooltip.SetToolTip(btnRollback, "Cancelar");
            tooltip.SetToolTip(btnSearch, "Mostrar/Ocultar búsqueda");
            tooltip.SetToolTip(btnFilter, "Buscar");
            #endregion
            btnDelete.Visible = false;
            lblIdMesa.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            CargarCombos();
            LimpiarForm();
            CargarGrilla();
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            ConfigurarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Nuevo;
            ControlarEventosABM();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TipoOperacion = TipoOperacionABM.Eliminar;
            //Eliminar();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                TipoOperacion = TipoOperacionABM.Insertar;
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Cambio)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                }
            }
            Commit();
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Rollback;
            ControlarEventosABM();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelFiltro.Visible = !panelFiltro.Visible;
            txtFiltro.Focus();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                string criterio = "";
                if (cboFiltro.SelectedValue != null)
                {
                    criterio = cboFiltro.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(criterio) && !filtro.Equals(""))
                    {

                        int idCriterio = int.Parse(criterio);
                        if (idCriterio == Filtro.Nombre)
                        {
                            Filtrar(Filtro.Nombre, filtro);
                        }
                        else if (idCriterio == Filtro.Codigo)
                        {
                            Filtrar(Filtro.Codigo, filtro);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrió una excepción al filtrar: " + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvMesa_SelectionChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        TipoOperacion = TipoOperacionABM.Modificar;
                        bool isValid = false;
                        string idSelect = GetIdSelected();

                        if (idSelect != lblIdMesa.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                SeleccionarPorId(int.Parse(idSelect));
                            }
                        }
                        else
                        {
                            Actualizar();
                        }


                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        SeleccionarRegistro();
                        TipoOperacion = TipoOperacionABM.No_Action;
                        ControlarEventosABM();
                    }
                }
                else if (preguntar == false)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                    bool isValid = false;
                    string idSelect = GetIdSelected();

                    //Indica que está seleccionado otro registro
                    //que el que se quiere modificar
                    if (idSelect != lblIdMesa.Text && idSelect != "-1")
                    {
                        isValid = Actualizar();
                        if (isValid)
                        {
                            SeleccionarPorId(int.Parse(idSelect));
                        }
                    }
                    else
                    {
                        Actualizar();
                    }
                }
            }
            else
            {
                SeleccionarRegistro();
                TipoOperacion = TipoOperacionABM.No_Action;
                ControlarEventosABM();
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }


        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }

        #region Eventos ventana emergente

        private void btnEstadoMesa_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboEstadoMesa.SelectedValue != null)
                    oldValue = int.Parse(cboEstadoMesa.SelectedValue.ToString());

                var frm = new FormEstadoMesa();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboEstadoMesa.DataSource = null;
                    cboEstadoMesa.DisplayMember = "txt_desc";
                    cboEstadoMesa.ValueMember = "id_estado_mesa";
                    cboEstadoMesa.DataSource = new EstadoMesaBL().ListaEstadoMesa(Estado.IdActivo, false, true);
                    cboEstadoMesa.DropDownWidth = ControlHelper.DropDownWidth(cboEstadoMesa);
                    cboEstadoMesa.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCanalVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboCanalVenta.SelectedValue != null)
                    oldValue = int.Parse(cboCanalVenta.SelectedValue.ToString());

                var frm = new FormCanalVenta();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboCanalVenta.DataSource = null;
                    cboCanalVenta.DisplayMember = "txt_desc";
                    cboCanalVenta.ValueMember = "id_can_vta";
                    cboCanalVenta.DataSource = new CanalVentaBL().ListaCanalVenta(Estado.IdActivo, false, true);
                    cboCanalVenta.DropDownWidth = ControlHelper.DropDownWidth(cboCanalVenta);
                    cboCanalVenta.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        preguntar = !checkDialog.check;
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = Actualizar();
                        if (isValid)
                        {
                            isPending = false;
                            CerrarForm();
                        }

                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        CerrarForm();
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = Actualizar();
                    if (isValid)
                    {
                        isPending = false;
                        CerrarForm();
                    }
                }
            }
            else
            {
                CerrarForm();
            }
        }

        #endregion

    }
}
