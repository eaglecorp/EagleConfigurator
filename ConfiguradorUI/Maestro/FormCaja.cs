using ConfigBusinessEntity;
using ConfigBusinessLogic.Fiscal;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.ViewModels;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormCaja : MetroForm
    {
        #region Variables
        List<int> _idsParametrosFiscalesCambiados = null;

        bool isSelected      = false,
                isChangedRow = false,
                isPending    = false,
                preguntar    = true,
                postLoad     = false;

        public bool actualizar = false;

        private int TipoOperacion = TipoOperacionABM.No_Action;

        const int colIdConfigCaja            = 0,
                    colIdCaja                = 1,
                    colIdParametroFiscal     = 2,
                    colCodParametroFiscal    = 3,
                    colNombreParametroFiscal = 4,
                    colValorParametroCaja    = 5;

        string codSelected = "";
        #endregion

        public FormCaja()
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
            var txts = new[] { txtNombre, txtCodigo, txtInfo01, txtInfo02, txtIp };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }
            //.TextChanged += new EventHandler(OnContentChanged);
            var cbos = new[] { cboImpresora,cboImpresora02,cboImpresora03,cboImpresora04,
                                cboImpresora05,cboImpresora06};
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cbo);
            }


            var chks = new[] { chkActivo };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            dgvConfigFiscalCaja.CellValueChanged += OnContentChangedDgv;

            dgvConfigFiscalCaja.CellPainting += ControlHelper.DgvRemoveBorderSeletedCell_CellPainting;
        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            if (isSelected && isChangedRow == false && TipoOperacion != TipoOperacionABM.Cambio)
            {
                TipoOperacion = TipoOperacionABM.Cambio;
                ControlarEventosABM();
            }
        }
        protected void OnContentChangedDgv(object sender, DataGridViewCellEventArgs e)
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

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt12_caja();
                        obj = GetObjeto();
                        int id = new CajaBL().InsertarCaja(obj);
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
        private void Eliminar()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvCaja.RowCount > 0)
                {
                    if (dgvCaja.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdCaja.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Caja_ControlNumeracion);
                                    if (validDelete)
                                    {
                                        new CajaBL().EliminarCaja(id);
                                        actualizar = true;
                                        ControlarEventosABM();
                                    }
                                    else
                                    {
                                        TipoOperacion = TipoOperacionABM.No_Action;
                                        ControlarEventosABM();
                                        MessageBox.Show(this, "Este registro no se puede eliminar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
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

                        var obj = new MSTt12_caja();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdCaja.Text, out id))
                        {
                            obj.id_caja = id;
                            new CajaBL().ActualizarCaja(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_caja);
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
                        var obj = new MSTt12_caja();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdCaja.Text, out id))
                        {
                            obj.id_caja = id;
                            new CajaBL().ActualizarCaja(obj);
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

        private MSTt12_caja GetObjeto()
        {
            var obj = new MSTt12_caja();
            try
            {
                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_caja = txtCodigo.Text.Trim();
                obj.txt_ip = txtIp.Text.Trim();
                obj.txt_info01 = txtInfo01.Text.Trim();
                obj.txt_info02 = txtInfo02.Text.Trim();

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                if (int.TryParse(cboImpresora.SelectedValue?.ToString(), out int id))
                    obj.id_impresora = id;

                if (int.TryParse(cboImpresora02.SelectedValue?.ToString(), out id))
                    obj.id_impresora02 = id;

                if (int.TryParse(cboImpresora03.SelectedValue?.ToString(), out id))
                    obj.id_impresora03 = id;

                if (int.TryParse(cboImpresora04.SelectedValue?.ToString(), out id))
                    obj.id_impresora04 = id;

                if (int.TryParse(cboImpresora05.SelectedValue?.ToString(), out id))
                    obj.id_impresora05 = id;

                if (int.TryParse(cboImpresora06.SelectedValue?.ToString(), out id))
                    obj.id_impresora06 = id;

                obj.FISt05_configuracion_fiscal_caja = GetParametrosFiscalesDeCaja();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(MSTt12_caja obj)
        {
            try
            {

                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdCaja.Text = obj.id_caja.ToString();
                codSelected = obj.cod_caja;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_caja;
                txtInfo01.Text = obj.txt_info01;
                txtInfo02.Text = obj.txt_info02;
                txtIp.Text = obj.txt_ip;

                SetValueInCbo(cboImpresora, obj.id_impresora);
                SetValueInCbo(cboImpresora02, obj.id_impresora02);
                SetValueInCbo(cboImpresora03, obj.id_impresora03);
                SetValueInCbo(cboImpresora04, obj.id_impresora04);
                SetValueInCbo(cboImpresora05, obj.id_impresora05);
                SetValueInCbo(cboImpresora06, obj.id_impresora06);

                SetParametrosFiscalesDeCaja(obj.FISt05_configuracion_fiscal_caja);
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Excepción en el Set: " + ex.Message);
            }

        }

        private void SetParametrosFiscalesDeCaja(ICollection<FISt05_configuracion_fiscal_caja> confFiscalCaja)
        {
            try
            {
                if (confFiscalCaja != null && confFiscalCaja.Count > 0)
                {
                    dgvConfigFiscalCaja.DataSource = confFiscalCaja
                        .Select(x => new
                                        ParametroFiscalDeCajaVM
                        {
                            id = x.id_configuracion_fiscal_caja,
                            id_caja = x.id_caja,
                            id_parametro_fiscal = x.id_parametro_fiscal,
                            cod = x.FISt04_parametro_fiscal?.cod_parametro_fiscal,
                            parametro = x.FISt04_parametro_fiscal?.txt_desc,
                            valor = x.valor
                        }).ToList();
                }
                else
                {
                    DefinirCabeceraGridParametros();
                }
                RenombrarCabeceraGridParametros();
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Ocurrió un error cuando se cargaba la configuración de parámetros fiscales. Excepción : " + ex.Message);
            }
        }
        private void SetParametrosFiscalesDefault(List<FISt04_parametro_fiscal> parametrosFiscales)
        {
            try
            {
                if (parametrosFiscales != null && parametrosFiscales.Count > 0)
                {
                    dgvConfigFiscalCaja.DataSource = parametrosFiscales
                        .Select(x => new
                                        ParametroFiscalDeCajaVM
                        {
                            id = 0,
                            id_caja = 0,
                            id_parametro_fiscal = x.id_parametro_fiscal,
                            cod = x.cod_parametro_fiscal,
                            parametro = x.txt_desc,
                            valor = x.valor_default
                        }).ToList();
                }
                else
                {
                    DefinirCabeceraGridParametros();
                }
                RenombrarCabeceraGridParametros();
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Ocurrió un error cuando se cargaba la configuración de parámetros fiscales default. Excepción : " + ex.Message);
            }
        }
        private List<FISt05_configuracion_fiscal_caja> GetParametrosFiscalesDeCaja()
        {
            var parametrosFiscales = new List<FISt05_configuracion_fiscal_caja>();
            try
            {
                if (dgvConfigFiscalCaja.Rows != null && dgvConfigFiscalCaja.Rows.Count > 0)
                {
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        RecorrerYLeerParametros(true);
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (_idsParametrosFiscalesCambiados != null && _idsParametrosFiscalesCambiados.Count > 0)
                        {
                            RecorrerYLeerParametros(false);
                        }
                    }
                }

                void RecorrerYLeerParametros(bool traerTodos)
                {
                    foreach (DataGridViewRow row in dgvConfigFiscalCaja.Rows)
                    {
                        int id_config_fiscal_caja = int.Parse(row.Cells[colIdConfigCaja].Value.ToString());

                        if (traerTodos || _idsParametrosFiscalesCambiados.Any(x => x == id_config_fiscal_caja))
                        {
                            parametrosFiscales.Add(
                            new FISt05_configuracion_fiscal_caja()
                            {
                                id_caja = GetIdActualDeCaja(),
                                id_parametro_fiscal = int.Parse(row.Cells[colIdParametroFiscal].Value.ToString()),
                                id_configuracion_fiscal_caja = id_config_fiscal_caja,
                                valor = row.Cells[colValorParametroCaja].Value.ToString()
                            }
                           );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("No se pudo leer la configuración de los parámetros fiscales de la caja. Excepción: " + ex.Message);
            }
            return parametrosFiscales;
        }
        private void AddIdParametroFiscalCambiado()
        {
            try
            {
                var idTxt = ControlHelper.DgvGetCellValueSelectedFromCell(dgvConfigFiscalCaja, colIdConfigCaja);
                if (int.TryParse(idTxt, out int id))
                {
                    if (_idsParametrosFiscalesCambiados == null)
                    {
                        _idsParametrosFiscalesCambiados = new List<int>();
                    }

                    if (!_idsParametrosFiscalesCambiados.Any(x => x == id))
                    {
                        _idsParametrosFiscalesCambiados.Add(id);
                    }
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo agregar el ID de la configuración fiscal de la caja. Excepción: " + e.Message);
            }
        }
        private int GetIdActualDeCaja()
        {
            int id_caja = 0;
            int.TryParse(lblIdCaja.Text, out id_caja);
            return id_caja;
        }

        private bool EsValido()
        {
            bool no_error = true;
            errorProv.Clear();
            //validando los controles para el tabPageGeneral

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabCaja.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (no_error)
            {
                var cbos = new[] { cboImpresora,cboImpresora02,cboImpresora03,cboImpresora04,cboImpresora05,
                                cboImpresora06};
                for (int i = 0; i < cbos.Length; i++)
                {
                    if (cbos[i].SelectedValue != null && i < cbos.Length - 1)
                    {
                        for (int j = i + 1; j < cbos.Length; j++)
                        {
                            if (cbos[j].SelectedValue != null)
                                if (cbos[i].SelectedValue.ToString() == cbos[j].SelectedValue.ToString())
                                {
                                    errorProv.SetError(cbos[j], "Ya estás usando esta impresora.");
                                    cbos[j].Focus();
                                    no_error = false;
                                }
                        }
                    }
                }
            }
            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var obj = new CajaBL().CajaXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (obj != null && obj.id_caja > 0)
                        {
                            tabCaja.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && obj != null && obj.id_caja > 0)
                        {
                            tabCaja.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            #endregion

            if (no_error && !string.IsNullOrEmpty(txtIp.Text.Trim()))
            {
                if (!IPAddress.TryParse(txtIp.Text.Trim(), out IPAddress ip))
                {
                    errorProv.SetError(txtIp, "La dirección IP es incorrecta.");
                    txtIp.Focus();
                    no_error = false;
                }
            }

            #region validación delete

            if (no_error && !chkActivo.Checked && TipoOperacion == TipoOperacionABM.Modificar)
            {
                if (int.TryParse(lblIdCaja.Text, out int idImp))
                {
                    bool validDelete = false;
                    validDelete = new UtilBL().ValidarDelete(idImp, CodValDelete.Caja_ControlNumeracion);
                    if (!validDelete)
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabCaja.SelectedTab = tabPagGeneral;
                        errorProv.SetError(chkActivo, "No puede desactivarlo, está usándose en otro lado.");
                        chkActivo.Focus();
                        no_error = false;
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo obtener el id para verificar la validación.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    no_error = false;
                }
            }


            #endregion

            return no_error;
        }
        private void SetValueInCbo(ComboBox cbo, int? id)
        {
            if (id != null)
                cbo.SelectedValue = id;
            else
                cbo.SelectedIndex = -1;
        }
        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvCaja.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvCaja.Rows.Count > 0)
                        {
                            dgvCaja.Rows[index].Selected = true;
                            dgvCaja.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvCaja.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvCaja.Rows.Count > 0)
                        {
                            dgvCaja.Rows[index].Selected = true;
                            dgvCaja.FirstDisplayedScrollingRowIndex = index;
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
                DataGridViewRow row = dgvCaja.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_caja"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvCaja.Rows.Count > 0)
                    {
                        dgvCaja.Rows[index].Selected = true;
                        dgvCaja.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvCaja.RowCount > 0 && dgvCaja.SelectedRows.Count > 0 && dgvCaja.CurrentRow.Index != -1)
            {
                if (int.TryParse(GetIdSelected(), out int id))
                {
                    if (id > 0)
                    {
                        var obj = new CajaBL().CajaXId(id);
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
                if (dgvCaja.SelectedRows.Count > 0 && dgvCaja.Rows.Count > 0)
                {
                    id = dgvCaja.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("Excepción al capturar el id seleccionado: " + e.Message);
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
            lblIdCaja.Text = 0 + "";
            codSelected = "";

            txtNombre.Clear();
            txtCodigo.Clear();
            txtIp.Clear();
            txtInfo02.Clear();
            txtInfo01.Clear();

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            _idsParametrosFiscalesCambiados = null;
            DefinirCabeceraGridParametros();
            RenombrarCabeceraGridParametros();

            cboImpresora.SelectedIndex = -1;
            cboImpresora02.SelectedIndex = -1;
            cboImpresora03.SelectedIndex = -1;
            cboImpresora04.SelectedIndex = -1;
            cboImpresora05.SelectedIndex = -1;
            cboImpresora06.SelectedIndex = -1;
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
                    SetParametrosFiscalesDefault(new ParametroFiscalBL().ListaParametroFiscal());
                    tabCaja.SelectedTab = tabPagGeneral;
                    txtNombre.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        tabCaja.SelectedTab = tabPagGeneral;
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
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
                            tabCaja.SelectedTab = tabPagGeneral;
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
                                tabCaja.SelectedTab = tabPagGeneral;
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

                                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                                        tabCaja.SelectedTab = tabPagGeneral;

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
                var impresoras = new ImpresoraBL().ListaImpresora(Estado.IdActivo, false, true);

                var impresoras02 = new List<MSTt10_impresora>();
                impresoras02.AddRange(impresoras ?? new List<MSTt10_impresora>());

                var impresoras03 = new List<MSTt10_impresora>();
                impresoras03.AddRange(impresoras ?? new List<MSTt10_impresora>());

                var impresoras04 = new List<MSTt10_impresora>();
                impresoras04.AddRange(impresoras ?? new List<MSTt10_impresora>());

                var impresoras05 = new List<MSTt10_impresora>();
                impresoras05.AddRange(impresoras ?? new List<MSTt10_impresora>());

                var impresoras06 = new List<MSTt10_impresora>();
                impresoras06.AddRange(impresoras ?? new List<MSTt10_impresora>());

                cboImpresora.DataSource = null;
                cboImpresora.DisplayMember = "txt_desc";
                cboImpresora.ValueMember = "id_impresora";
                cboImpresora.DataSource = impresoras;

                cboImpresora02.DataSource = null;
                cboImpresora02.DisplayMember = "txt_desc";
                cboImpresora02.ValueMember = "id_impresora";
                cboImpresora02.DataSource = impresoras02;

                cboImpresora03.DataSource = null;
                cboImpresora03.DisplayMember = "txt_desc";
                cboImpresora03.ValueMember = "id_impresora";
                cboImpresora03.DataSource = impresoras03;

                cboImpresora04.DataSource = null;
                cboImpresora04.DisplayMember = "txt_desc";
                cboImpresora04.ValueMember = "id_impresora";
                cboImpresora04.DataSource = impresoras04;

                cboImpresora05.DataSource = null;
                cboImpresora05.DisplayMember = "txt_desc";
                cboImpresora05.ValueMember = "id_impresora";
                cboImpresora05.DataSource = impresoras05;

                cboImpresora06.DataSource = null;
                cboImpresora06.DisplayMember = "txt_desc";
                cboImpresora06.ValueMember = "id_impresora";
                cboImpresora06.DataSource = impresoras06;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos: " + e.Message, "MENSAJE");
            }
        }
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new CajaBL().ListaCaja(id_estado);
                var listaView = lista.Select(x => new { x.id_caja, CODIGO = x.cod_caja, NOMBRE = x.txt_desc })
               .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvCaja.DataSource = listaView;
                    dgvCaja.Columns["id_caja"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}");

            }
        }
        private void ActualizarGrilla(int? id_estado = null)
        {
            CargarGrilla(id_estado);
        }
        private void ConfigurarGrilla()
        {
            dgvCaja.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvCaja.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvCaja.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvCaja.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvCaja.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvCaja.EnableHeadersVisualStyles = false;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 100;
            txtIp.MaxLength = 15;
            txtInfo01.MaxLength = 100;
            txtInfo02.MaxLength = 100;

        }
        private void ContarEstados(List<MSTt12_caja> lista)
        {
            try
            {
                int numReg = lista.Count;
                int numAct = lista.Where(x => x.id_estado == Estado.IdActivo).ToList().Count;
                int numInac = lista.Where(x => x.id_estado == Estado.IdInactivo).ToList().Count;

                lblNumReg.Text = "Total: " + numReg;
                lblNumActivo.Text = "Activos: " + numAct;
                lblNumInactivo.Text = "Inactivos: " + numInac;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción el contar los estados: {e.Message}");
            }
        }
        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        private void DefinirCabeceraGridParametros()
        {
            try
            {
                var configHeader = new List<FISt05_configuracion_fiscal_caja>();
                dgvConfigFiscalCaja.DataSource = configHeader.Select(x => new
                ParametroFiscalDeCajaVM()
                {
                    id = 0,
                    id_caja = 0,
                    id_parametro_fiscal = 0,
                    cod = "",
                    parametro = "",
                    valor = ""
                }).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de los parámetros. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RenombrarCabeceraGridParametros()
        {
            try
            {
                dgvConfigFiscalCaja.Columns["cod"].HeaderText = "CÓDIGO";
                dgvConfigFiscalCaja.Columns["parametro"].HeaderText = "PARÁMETRO";
                dgvConfigFiscalCaja.Columns["valor"].HeaderText = "VALOR";
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo renombrar la cabecera de la grilla de los parámetros. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarGridParametros()
        {
            dgvConfigFiscalCaja.Columns["id"].Visible = false;
            dgvConfigFiscalCaja.Columns["id_caja"].Visible = false;
            dgvConfigFiscalCaja.Columns["id_parametro_fiscal"].Visible = false;
            dgvConfigFiscalCaja.ReadOnly = false;
            dgvConfigFiscalCaja.Columns[colIdConfigCaja].ReadOnly = true;
            dgvConfigFiscalCaja.Columns[colIdCaja].ReadOnly = true;
            dgvConfigFiscalCaja.Columns[colIdParametroFiscal].ReadOnly = true;
            dgvConfigFiscalCaja.Columns[colCodParametroFiscal].ReadOnly = true;
            dgvConfigFiscalCaja.Columns[colNombreParametroFiscal].ReadOnly = true;

            dgvConfigFiscalCaja.Columns["cod"].Width = 100;
            dgvConfigFiscalCaja.Columns["parametro"].Width = 300;
            dgvConfigFiscalCaja.Columns["valor"].Width = 110;
        }
        private void InicializarGridParametros()
        {
            DefinirCabeceraGridParametros();
            RenombrarCabeceraGridParametros();
            ConfigurarGridParametros();
            ((DataGridViewTextBoxColumn)dgvConfigFiscalCaja.Columns[colValorParametroCaja]).MaxInputLength = 500;
            ControlHelper.DgvBaseStyle(dgvConfigFiscalCaja);
            ControlHelper.DgvBaseConfig(dgvConfigFiscalCaja);
        }

        private void SetInit()
        {
            lblIdCaja.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            InicializarGridParametros();
            CargarCombos();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
            postLoad = true;
        }


        #endregion

        #region Eventos de ventana

        private void FormCaja_Load(object sender, EventArgs e)
        {
            SetInit();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Nuevo;
            ControlarEventosABM();
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

        private void dgvCaja_SelectionChanged(object sender, EventArgs e)
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

                        if (idSelect != lblIdCaja.Text && idSelect != "-1")
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

                    if (idSelect != lblIdCaja.Text && idSelect != "-1")
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

        private void tglListarInactivos_Click(object sender, EventArgs e)
        {
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();

                    if (rp == DialogResult.Yes)
                    {
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = ActualizarEnCheck();
                        //Ya se validó y actualizó pero aún no recarga la grilla
                        if (isValid)
                        {
                            if (tglListarInactivos.Checked)
                                tglListarInactivos.Checked = false;
                            else
                                tglListarInactivos.Checked = true;
                            ControlarEventosABM();
                        }
                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        LimpiarForm();
                        if (tglListarInactivos.Checked)
                        {
                            tglListarInactivos.Checked = false;
                            ActualizarGrilla(Estado.IdActivo);
                        }
                        else
                        {
                            tglListarInactivos.Checked = true;
                            ActualizarGrilla();
                        }
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = ActualizarEnCheck();
                    //Ya se validó y actualizó pero aún no recarga la grilla
                    if (isValid)
                    {
                        if (tglListarInactivos.Checked)
                            tglListarInactivos.Checked = false;
                        else
                            tglListarInactivos.Checked = true;
                        ControlarEventosABM();
                    }
                }
            }

            else
            {
                LimpiarForm();
                if (tglListarInactivos.Checked)
                {
                    tglListarInactivos.Checked = false;
                    ActualizarGrilla(Estado.IdActivo);
                }
                else
                {
                    tglListarInactivos.Checked = true;
                    ActualizarGrilla();
                }

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }

        private void dgvConfigFiscalCaja_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colValorParametroCaja && postLoad)
            {
                isChangedRow = false;
                AddIdParametroFiscalCambiado();
            }
        }

        #region Eventos ventana emergente

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            try
            {
                int? oldValue = null, oldValue02 = null, oldValue03 = null,
                    oldValue04 = null, oldValue05 = null, oldValue06 = null;
                int op = TipoOperacion;

                if (cboImpresora.SelectedValue != null) oldValue = int.Parse(cboImpresora.SelectedValue.ToString());
                if (cboImpresora02.SelectedValue != null) oldValue02 = int.Parse(cboImpresora02.SelectedValue.ToString());
                if (cboImpresora03.SelectedValue != null) oldValue03 = int.Parse(cboImpresora03.SelectedValue.ToString());
                if (cboImpresora04.SelectedValue != null) oldValue04 = int.Parse(cboImpresora04.SelectedValue.ToString());
                if (cboImpresora05.SelectedValue != null) oldValue05 = int.Parse(cboImpresora05.SelectedValue.ToString());
                if (cboImpresora06.SelectedValue != null) oldValue06 = int.Parse(cboImpresora06.SelectedValue.ToString());

                var frm = new FormImpresora();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    CargarCombos();
                    var width = ControlHelper.DropDownWidth(cboImpresora);
                    cboImpresora.DropDownWidth = width;
                    cboImpresora02.DropDownWidth = width;
                    cboImpresora03.DropDownWidth = width;
                    cboImpresora04.DropDownWidth = width;
                    cboImpresora05.DropDownWidth = width;
                    cboImpresora06.DropDownWidth = width;

                    SetValueInCbo(cboImpresora, oldValue);
                    SetValueInCbo(cboImpresora02, oldValue02);
                    SetValueInCbo(cboImpresora03, oldValue03);
                    SetValueInCbo(cboImpresora04, oldValue04);
                    SetValueInCbo(cboImpresora05, oldValue05);
                    SetValueInCbo(cboImpresora06, oldValue06);
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
