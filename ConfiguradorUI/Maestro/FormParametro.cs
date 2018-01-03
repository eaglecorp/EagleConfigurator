using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.General;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormParametro : MetroForm
    {

        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        bool isFijo = false;
        bool changedLogo = false;
        int sn_editSelected = 0;
        string codSelected = "";
        #endregion

        public FormParametro()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void addHandlers()
        {
            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            var txts = new[] { txtNombre, txtCodigo,txtValor, txtDecValor,
                               txtObservacion};
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }

            txtDecValor.KeyPress += ValidarTxtDecimal;

        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            //Eliminar y agregar eventos... etc etc..
            //TipoOperacion = TipoOperacionABM.Cambio;
            //ControlarEventosABM();
            //if (ContentChanged != null)
            //{
            //    ContentChanged(this, new EventArgs());
            //}
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
        private void ValidarTxtDecimal(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = txt.Text.Contains(".") || txt.Text.Equals("") ?
                           true : false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (esValido())
                    {
                        var obj = new GRLt01_parametro();
                        obj = GetObjeto();
                        int id = new ParametroBL().InsertarParametro(obj);
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
        private void Eliminar()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvParametro.RowCount > 0)
                {
                    if (dgvParametro.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdParametro.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new ParametroBL().EliminarParametro(id);
                                    ControlarEventosABM();
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
                    if (esValido())
                    {
                        var obj = new GRLt01_parametro();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdParametro.Text, out id))
                        {
                            obj.id_parametro = id;
                            new ParametroBL().ActualizarParametro(obj);
                            ControlarEventosABM(obj.id_parametro);
                            if (obj.cod_parametro == ParameterCode.LogoImg)
                                changedLogo = true;
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
                    if (esValido())
                    {
                        var obj = new GRLt01_parametro();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdParametro.Text, out id))
                        {
                            obj.id_parametro = id;
                            new ParametroBL().ActualizarParametro(obj);
                            if (obj.cod_parametro == ParameterCode.LogoImg)
                                changedLogo = true;
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

        private GRLt01_parametro GetObjeto()
        {
            var obj = new GRLt01_parametro();
            try
            {

                if (TipoOperacion == TipoOperacionABM.Insertar)
                    obj.sn_edit = Estado.IdActivo;
                else if (TipoOperacion == TipoOperacionABM.Modificar)
                    obj.sn_edit = sn_editSelected;


                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_parametro = txtCodigo.Text.Trim();


                if (txtCodigo.Text == ParameterCode.Password)
                    obj.txt_valor = txtValor.Text;
                else
                    obj.txt_valor = txtValor.Text.Trim();



                if (string.IsNullOrEmpty(txtDecValor.Text.Trim()))
                    obj.dec_valor = null;
                else obj.dec_valor = decimal.Parse(txtDecValor.Text);

                obj.txt_obs = txtObservacion.Text.Trim();

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(GRLt01_parametro obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                lblIdParametro.Text = obj.id_parametro.ToString();

                codSelected = obj.cod_parametro;

                sn_editSelected = obj.sn_edit;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_parametro;

                txtValor.UseSystemPasswordChar = (obj.cod_parametro != ParameterCode.Password) ? false : true;

                txtValor.Text = obj.txt_valor;
                txtDecValor.Text = (obj.dec_valor == null) ? "" : obj.dec_valor.RemoveTrailingZeros();
                txtObservacion.Text = obj.txt_obs;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }
        }

        private bool esValido()
        {
            //Por ver - validar combos.
            bool no_error = true;
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.
            errorProv.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabParametro.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }


            #region cod único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var parametro = new ParametroBL().ParametroXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (parametro != null && parametro.id_parametro > 0)
                        {
                            tabParametro.SelectedTab = tabPagGeneral;
                            MessageBox.Show("Este código ya está registrado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya existe.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && parametro != null && parametro.id_parametro > 0)
                        {
                            tabParametro.SelectedTab = tabPagGeneral;
                            MessageBox.Show("Este código ya está registrado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya existe.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            #endregion

            if (no_error)
            {
                if (txtDecValor.Text.Length > 0)
                {
                    decimal num = 0;
                    if (!decimal.TryParse(txtDecValor.Text, out num))
                    {
                        tabParametro.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtDecValor, "Tiene que ingresar un número.");
                        txtDecValor.Focus();
                        no_error = false;
                    }
                    else if (!(num > 0 && num < 10000000000))
                    {
                        tabParametro.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtDecValor, "El valor dec tiene que ser mayor que 0 y menor que 10000000000.");
                        txtDecValor.Focus();
                        no_error = false;
                    }
                }
            }

            #region validación de parámetros en particular

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                string valorParam = txtValor.Text.Trim();

                if (cod == ParameterCode.EmailFrom)
                {
                    if (!string.IsNullOrEmpty(valorParam) && !Validation.EsEmail(valorParam))
                    {
                        tabParametro.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtValor, "Debe ingresar un correo electrónico válido.");
                        txtValor.Focus();
                        no_error = false;
                    }
                }

                else if (cod == ParameterCode.Port)
                {
                    if (txtDecValor.Text.Length < 1)
                    {
                        tabParametro.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtDecValor, "Debe ingresar un campo numérico.");
                        txtDecValor.Focus();
                        no_error = false;
                    }
                }
                else if (cod == ParameterCode.SplashImg || cod == ParameterCode.LogoImg || cod == ParameterCode.LoginImg)
                {
                    if (valorParam.Length > 0)
                    {
                        if (valorParam.Length <= 260)
                        {

                            if (File.Exists(valorParam))
                            {
                                try
                                {
                                    using (Image newImage = Image.FromFile(valorParam))
                                    { }
                                }
                                catch (OutOfMemoryException)
                                {
                                    tabParametro.SelectedTab = tabPagGeneral;
                                    errorProv.SetError(txtValor, "El formato del archivo debe ser el de una imagen.");
                                    txtValor.Focus();
                                    no_error = false;
                                }
                            }
                            else
                            {
                                tabParametro.SelectedTab = tabPagGeneral;
                                errorProv.SetError(txtValor, "La ruta del archivo que ha colocado es incorrecta o no existe.");
                                txtValor.Focus();
                                no_error = false;
                            }
                        }
                        else
                        {
                            tabParametro.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txtValor, "La ruta del archivo puede tener máximo hasta 260 de longitud.");
                            txtValor.Focus();
                        }
                    }

                }
            }
            #endregion

            //Se podría validar que no tenga hijas al desactivar.

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
                    DataGridViewRow row = dgvParametro.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvParametro.Rows.Count > 0)
                        {
                            dgvParametro.Rows[index].Selected = true;
                            dgvParametro.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvParametro.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvParametro.Rows.Count > 0)
                        {
                            dgvParametro.Rows[index].Selected = true;
                            dgvParametro.FirstDisplayedScrollingRowIndex = index;
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
                DataGridViewRow row = dgvParametro.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_parametro"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvParametro.Rows.Count > 0)
                    {
                        dgvParametro.Rows[index].Selected = true;
                        dgvParametro.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvParametro.RowCount > 0 && dgvParametro.SelectedRows.Count > 0 && dgvParametro.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ParametroBL().ParametroXId(id);
                        if (obj != null)
                        {
                            isSelected = false;
                            ConfigurarTxt(obj.sn_edit);
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
                if (dgvParametro.SelectedRows.Count > 0 && dgvParametro.Rows.Count > 0)
                {
                    id = dgvParametro.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
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
            lblIdParametro.Text = 0 + "";

            sn_editSelected = 0;

            codSelected = "";

            txtNombre.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
            txtDecValor.Clear();
            txtObservacion.Clear();

        }
        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
        {
            btnNuevo.Enabled = eNuevo;

            if (!isFijo)
                btnDelete.Enabled = eDelete;
            else
                btnDelete.Enabled = false;

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
                //tab
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabParametro.SelectedTab = tabPagGeneral;
                    txtNombre.Focus();
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
                        tabParametro.SelectedTab = tabPagGeneral;
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
                            tabParametro.SelectedTab = tabPagGeneral;
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
                                tabParametro.SelectedTab = tabPagGeneral;
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

                                        tabParametro.SelectedTab = tabPagGeneral;

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
        private void CargarGrilla()
        {
            try
            {

                var lista = new ParametroBL().ListaParametro(true);

                var listaView = lista.Select(x => new { x.id_parametro, CODIGO = x.cod_parametro, NOMBRE = x.txt_desc })
                                            .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    dgvParametro.DataSource = listaView;
                    dgvParametro.Columns["id_parametro"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}");
            }
        }
        private void ActualizarGrilla()
        {
            CargarGrilla();
        }
        private void ConfigurarGrilla()
        {
            dgvParametro.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvParametro.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvParametro.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvParametro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvParametro.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvParametro.EnableHeadersVisualStyles = false;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 50;
            txtDecValor.MaxLength = 19;
            txtValor.MaxLength = 500;
            txtObservacion.MaxLength = 350;
        }
        private void ConfigurarTxt(int sn_edit)
        {
            try
            {
                if (sn_edit == Estado.IdInactivo)
                {
                    isFijo = true;
                    ControlarTxt(false);
                }
                else
                {
                    isFijo = false;
                    ControlarTxt(true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción cuando se intentó configurar los txt's. Error: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        #endregion

        #region Eventos de ventana

        private void FormParametro_Load(object sender, EventArgs e)
        {
            lblIdParametro.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            LimpiarForm();
            CargarGrilla();
            CargarComboFiltro();
            panelFiltro.Visible = false;
            addHandlers();
            ConfigurarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Nuevo;
            ControlarTxt(true);
            ControlarEventosABM();
        }

        private void ControlarTxt(bool activado)
        {
            txtCodigo.Enabled = activado;
            txtNombre.Enabled = activado;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Eliminar;
            Eliminar();
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
            if (panelFiltro.Visible)
            {
                panelFiltro.Visible = false;
            }
            else
            {
                panelFiltro.Visible = true;
            }
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

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }

        private void dgvParametro_SelectionChanged(object sender, EventArgs e)
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
                        //al intentar cambiar la fila si no es válido
                        //la actualización, no pasará hasta que sea válido
                        //o se dea rollback.
                        bool isValid = false;
                        string idSelect = GetIdSelected();

                        //Indica que está seleccionado otro registro
                        //que el que se quiere modificar
                        if (idSelect != lblIdParametro.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
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
                    //al intentar cambiar la fila si no es válido
                    //la actualización, no pasará hasta que sea válido
                    //o se dea rollback.
                    bool isValid = false;
                    string idSelect = GetIdSelected();

                    //Indica que está seleccionado otro registro
                    //que el que se quiere modificar
                    if (idSelect != lblIdParametro.Text && idSelect != "-1")
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

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
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
