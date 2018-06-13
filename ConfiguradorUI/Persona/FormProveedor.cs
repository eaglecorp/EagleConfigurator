using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Persona;
using ConfigBusinessLogic.Sunat;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperGeneric;
using ConfigUtilitarios.KeyValues;
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

namespace ConfiguradorUI.Persona
{
    public partial class FormProveedor : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";
        #endregion

        public FormProveedor()
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
            var txts = new[] { txtApPaterno, txtApMaterno,txtPrimerNom,txtSegundoNom,
                                txtCodigo,txtRazonSocial,txtNomComercial,txtNumDoc,
                                txtNumRuc,txtNomZona,txtNomVia,txtNumVia,
                                txtDireccion01,txtDireccion02,txtReferencia,txtCelular01,
                                txtCelular02,txtCelular03,txtTelfFijo01,txtTelfFijo02,
                                txtTelfFijo03,txtEmail01,txtEmail02,txtPagWeb,
                                txtInfo01,txtInfo02,txtInfo03,txtInfo04,
                                txtInfo05,txtInfo06,txtInfo07,txtInfo08,
                                txtInfo09,txtInfo10 };

            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }

            //cambio en combos
            var cbos = new[] { cboEstadoCivil,cboTipoDocIdentidad,cboDepartamento,cboProvincia,
                                cboDistrito,cboNacionalidad,cboZona,cboVia};
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cbo);
            }

            //cambio en radio button's
            var rbts = new[] { rbtMasculino, rbtFemenino };
            foreach (var rbt in rbts)
            {
                rbt.CheckedChanged += new EventHandler(OnContentChanged);
            }

            dtpFechaNacimiento.CloseUp += dtpVer_CloseUp;
            dtpFechaNacimiento.MouseDown += DtpVer_MouseDown;
            dtpFechaNacimiento.KeyPress += DtpLimpiar_KeyPress;

            dtpFechaNacimiento.ValueChanged += new EventHandler(OnContentChanged);
            dtpFechaNacimiento.CloseUp += new EventHandler(OnContentChanged);
            dtpFechaNacimiento.MouseDown += OnContentChanged;
            dtpFechaNacimiento.KeyPress += OnContentChanged;


            chkActivo.CheckedChanged += new EventHandler(OnContentChanged);

            cboTipoDocIdentidad.DropDownWidth = ControlHelper.DropDownWidth(cboTipoDocIdentidad);
            cboNacionalidad.DropDownWidth = ControlHelper.DropDownWidth(cboNacionalidad);

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

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        var obj = new PERt03_proveedor();
                        obj = GetObjeto();
                        long id = new ProveedorBL().InsertarProveedor(obj);
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
                if (dgvProveedor.RowCount > 0)
                {
                    if (dgvProveedor.SelectedRows.Count > 0)
                    {
                        try
                        {
                            long id = 0;
                            if (long.TryParse(lblIdProveedor.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new ProveedorBL().EliminarProveedor(id);
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
            //Esta variable booleana se usa en algunos para controlar la validez
            // del producto, por ejemplo, cuando el usuario quiere salir
            //y tiene una modificación pendiente(pero si no es válida no sale)
            //en esa caso usaremos esta variables, en otras no.
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {

                        var obj = new PERt03_proveedor();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdProveedor.Text, out id))
                        {
                            obj.id_proveedor = id;
                            new ProveedorBL().ActualizarProveedor(obj);
                            ControlarEventosABM(obj.id_proveedor);
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
                        var obj = new PERt03_proveedor();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdProveedor.Text, out id))
                        {
                            obj.id_proveedor = id;
                            new ProveedorBL().ActualizarProveedor(obj);
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

        private PERt03_proveedor GetObjeto()
        {
            var obj = new PERt03_proveedor();
            try
            {
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                if (dtpFechaNacimiento.CustomFormat == DateFormat.DateOnly)
                {
                    obj.fec_nac = dtpFechaNacimiento.Value.Date;
                }

                obj.cod_proveedor = txtCodigo.Text.Trim();

                obj.cod_tipo_per = (string.IsNullOrEmpty(txtNumRuc.Text.Trim())) ? "N" : "J";

                obj.nro_doc = txtNumDoc.Text.Trim();
                obj.nro_ruc = txtNumRuc.Text.Trim();
                obj.txt_ape_pat = txtApPaterno.Text.Trim();
                obj.txt_ape_mat = txtApMaterno.Text.Trim();
                obj.txt_pri_nom = txtPrimerNom.Text.Trim();
                obj.txt_seg_nom = txtSegundoNom.Text.Trim();
                obj.txt_rzn_social = txtRazonSocial.Text.Trim();
                obj.txt_nom_comercial = txtNomComercial.Text.Trim();
                obj.nom_via = txtNomVia.Text.Trim();
                obj.nro_via = txtNumVia.Text.Trim();
                obj.nom_zona = txtNomZona.Text.Trim();
                obj.txt_direccion1 = txtDireccion01.Text.Trim();
                obj.txt_direccion2 = txtDireccion02.Text.Trim();
                obj.txt_referencia = txtReferencia.Text.Trim();
                obj.txt_email1 = txtEmail01.Text.Trim();
                obj.txt_email2 = txtEmail02.Text.Trim();
                obj.txt_web = txtPagWeb.Text.Trim();
                obj.telef_fijo1 = txtTelfFijo01.Text.Trim();
                obj.telef_fijo2 = txtTelfFijo02.Text.Trim();
                obj.telef_fijo3 = txtTelfFijo03.Text.Trim();
                obj.celular1 = txtCelular01.Text.Trim();
                obj.celular2 = txtCelular02.Text.Trim();
                obj.celular3 = txtCelular03.Text.Trim();
                obj.info01 = txtInfo01.Text.Trim();
                obj.info02 = txtInfo02.Text.Trim();
                obj.info03 = txtInfo03.Text.Trim();
                obj.info04 = txtInfo04.Text.Trim();
                obj.info05 = txtInfo05.Text.Trim();
                obj.info06 = txtInfo06.Text.Trim();
                obj.info07 = txtInfo07.Text.Trim();
                obj.info08 = txtInfo08.Text.Trim();
                obj.info09 = txtInfo09.Text.Trim();
                obj.info10 = txtInfo10.Text.Trim();



                if (rbtFemenino.Checked || rbtMasculino.Checked)
                {
                    obj.sexo = (rbtFemenino.Checked) ? "F" : "M";
                }
                else obj.sexo = null;

                if (cboTipoDocIdentidad.SelectedValue != null)
                    obj.id_tipo_doc_identidad = int.Parse(cboTipoDocIdentidad.SelectedValue.ToString());
                else obj.id_tipo_doc_identidad = null;

                if (cboEstadoCivil.SelectedValue != null)
                    obj.id_estado_civil = int.Parse(cboEstadoCivil.SelectedValue.ToString());
                else obj.id_estado_civil = null;

                if (cboVia.SelectedValue != null)
                    obj.id_via = int.Parse(cboVia.SelectedValue.ToString());
                else obj.id_via = null;

                if (cboZona.SelectedValue != null)
                    obj.id_zona = int.Parse(cboZona.SelectedValue.ToString());
                else obj.id_zona = null;

                if (cboDistrito.SelectedValue != null)
                    obj.id_dist = int.Parse(cboDistrito.SelectedValue.ToString());
                else obj.id_dist = null;

                if (cboNacionalidad.SelectedValue != null)
                    obj.id_nacionalidad = int.Parse(cboNacionalidad.SelectedValue.ToString());
                else obj.id_nacionalidad = null;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(PERt03_proveedor obj)
        {
            try
            {

                isChangedRow = true;
                LimpiarForm();
                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;
                lblIdProveedor.Text = obj.id_proveedor.ToString();
                codSelected = obj.cod_proveedor;

                if (obj.fec_nac != null)
                {
                    DateFormat.SetFormat(dtpFechaNacimiento, DateFormat.DateOnly);
                    dtpFechaNacimiento.Value = (DateTime)obj.fec_nac;
                }

                txtCodigo.Text = obj.cod_proveedor;
                txtNumDoc.Text = obj.nro_doc;
                txtNumRuc.Text = obj.nro_ruc;
                txtApPaterno.Text = obj.txt_ape_pat;
                txtApMaterno.Text = obj.txt_ape_mat;
                txtPrimerNom.Text = obj.txt_pri_nom;
                txtSegundoNom.Text = obj.txt_seg_nom;
                txtRazonSocial.Text = obj.txt_rzn_social;
                txtNomComercial.Text = obj.txt_nom_comercial;
                txtNomVia.Text = obj.nom_via;
                txtNumVia.Text = obj.nro_via;
                txtNomZona.Text = obj.nom_zona;
                txtDireccion01.Text = obj.txt_direccion1;
                txtDireccion02.Text = obj.txt_direccion2;
                txtReferencia.Text = obj.txt_referencia;
                txtEmail01.Text = obj.txt_email1;
                txtEmail02.Text = obj.txt_email2;
                txtPagWeb.Text = obj.txt_web;
                txtTelfFijo01.Text = obj.telef_fijo1;
                txtTelfFijo02.Text = obj.telef_fijo2;
                txtTelfFijo03.Text = obj.telef_fijo3;
                txtCelular01.Text = obj.celular1;
                txtCelular02.Text = obj.celular2;
                txtCelular03.Text = obj.celular3;
                txtInfo01.Text = obj.info01;
                txtInfo02.Text = obj.info02;
                txtInfo03.Text = obj.info03;
                txtInfo04.Text = obj.info04;
                txtInfo05.Text = obj.info05;
                txtInfo06.Text = obj.info06;
                txtInfo07.Text = obj.info07;
                txtInfo08.Text = obj.info08;
                txtInfo09.Text = obj.info09;
                txtInfo10.Text = obj.info10;


                if (obj.sexo != null)
                {
                    if (obj.sexo.Equals("M") || obj.sexo.Equals("F"))
                    {
                        if (obj.sexo.Equals("M"))
                        { rbtFemenino.Checked = false; rbtMasculino.Checked = true; }
                        else
                        { rbtFemenino.Checked = true; rbtMasculino.Checked = false; }
                    }
                }
                else { rbtFemenino.Checked = false; rbtMasculino.Checked = false; }


                if (obj.id_tipo_doc_identidad != null)
                    cboTipoDocIdentidad.SelectedValue = obj.id_tipo_doc_identidad;
                else cboTipoDocIdentidad.SelectedIndex = -1;

                if (obj.id_estado_civil != null)
                    cboEstadoCivil.SelectedValue = obj.id_estado_civil;
                else cboEstadoCivil.SelectedIndex = -1;

                if (obj.id_via != null)
                    cboVia.SelectedValue = obj.id_via;
                else cboVia.SelectedIndex = -1;

                if (obj.id_zona != null)
                    cboZona.SelectedValue = obj.id_zona;
                else cboZona.SelectedIndex = -1;

                if (obj.id_nacionalidad != null)
                    cboNacionalidad.SelectedValue = obj.id_nacionalidad;
                else cboNacionalidad.SelectedIndex = -1;

                if (obj.id_dist != null)
                {
                    cboDepartamento.SelectedValue = obj.SNTt33_distrito.SNTt32_provincia.id_dpto;
                    cboProvincia.SelectedValue = obj.SNTt33_distrito.id_prov;
                    cboDistrito.SelectedValue = obj.id_dist;
                }
                else
                {
                    cboDepartamento.SelectedIndex = -1;
                    cboProvincia.SelectedIndex = -1;
                    cboDistrito.SelectedIndex = -1;
                }

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
            //Para limpiar lo que dejó la validación anterior.
            errorProv.Clear();
            if (string.IsNullOrEmpty(txtApPaterno.Text.Trim()) || string.IsNullOrEmpty(txtPrimerNom.Text.Trim()))
            {
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) && string.IsNullOrEmpty(txtNumRuc.Text.Trim()))
                {
                    if (string.IsNullOrEmpty(txtApPaterno.Text.Trim()) && string.IsNullOrEmpty(txtPrimerNom.Text.Trim()))
                    {
                        tabProveedor.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtApPaterno, "Este campo es requerido.");
                        txtApPaterno.Focus();
                        no_error = false;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) && string.IsNullOrEmpty(txtNumRuc.Text.Trim()))
                    {
                        tabProveedor.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtNumRuc, "Este campo es requerido.");
                        txtNumRuc.Focus();
                        no_error = false;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) && !string.IsNullOrEmpty(txtNumRuc.Text.Trim()))
                        {
                            tabProveedor.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txtRazonSocial, "Este campo es requerido.");
                            txtRazonSocial.Focus();
                            no_error = false;
                        }
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) && string.IsNullOrEmpty(txtNumRuc.Text.Trim()))
                {
                    tabProveedor.SelectedTab = tabPagGeneral;
                    errorProv.SetError(txtNumRuc, "Este campo es requerido.");
                    txtNumRuc.Focus();
                    no_error = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) && !string.IsNullOrEmpty(txtNumRuc.Text.Trim()))
                    {
                        tabProveedor.SelectedTab = tabPagGeneral;
                        errorProv.SetError(txtRazonSocial, "Este campo es requerido.");
                        txtRazonSocial.Focus();
                        no_error = false;
                    }
                }
            }

            #region Fechas

            if (no_error)
            {
                if (dtpFechaNacimiento.CustomFormat == DateFormat.DateOnly)
                {
                    var hoy = UtilBL.GetCurrentDateTime.Date;
                    var edad = Human.CalcularEdad(dtpFechaNacimiento.Value, hoy);

                    if (edad < KeyHuman.EdadMinimaParaRegistro)
                    {
                        tabProveedor.SelectedTab = tabPagGeneral;
                        errorProv.SetError(dtpFechaNacimiento, $"La edad mínima de registro es {KeyHuman.EdadMinimaParaRegistro} años.");
                        dtpFechaNacimiento.Focus();
                        no_error = false;
                    }
                }
            }
            #endregion

            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {

                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabProveedor.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ProveedorBL().ProveedorXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_proveedor > 0)
                            {
                                tabProveedor.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_proveedor > 0)
                            {
                                tabProveedor.SelectedTab = tabPagGeneral;
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
                var txtsEmail = new[] { txtEmail01, txtEmail02 };
                foreach (var txtEm in txtsEmail)
                {
                    string email = txtEm.Text.Trim();
                    //si hay algo dentro de esos txt's 
                    if (email.Length > 0)
                    {
                        //verificamos que un sea un email
                        if (!Validation.EsEmail(email))
                        {
                            tabProveedor.SelectedTab = tabPagContacto;
                            errorProv.SetError(txtEm, "Formato de email incorrecto.");
                            txtEm.Focus();
                            no_error = false;
                            break;
                        }

                    }
                }
            }

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
                    DataGridViewRow row = dgvProveedor.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvProveedor.Rows.Count > 0)
                        {
                            dgvProveedor.Rows[index].Selected = true;
                            dgvProveedor.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvProveedor.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvProveedor.Rows.Count > 0)
                        {
                            dgvProveedor.Rows[index].Selected = true;
                            dgvProveedor.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(long id)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvProveedor.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_proveedor"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvProveedor.Rows.Count > 0)
                    {
                        dgvProveedor.Rows[index].Selected = true;
                        dgvProveedor.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvProveedor.RowCount > 0 && dgvProveedor.SelectedRows.Count > 0 && dgvProveedor.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ProveedorBL().ProveedorXIdMM(id);
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
                if (dgvProveedor.SelectedRows.Count > 0 && dgvProveedor.Rows.Count > 0)
                {
                    id = dgvProveedor.SelectedRows[0].Cells[0].Value.ToString();
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

            lblIdProveedor.Text = 0 + "";
            codSelected = "";

            var hoy = UtilBL.GetCurrentDateTime.Date;
            dtpFechaNacimiento.Value = hoy;

            DateFormat.SetFormat(dtpFechaNacimiento, DateFormat.Blank);

            txtCodigo.Clear();

            txtNumDoc.Clear();
            txtNumRuc.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtPrimerNom.Clear();
            txtSegundoNom.Clear();

            txtRazonSocial.Clear();
            txtNomComercial.Clear();
            txtNomVia.Clear();
            txtNumVia.Clear();
            txtNomZona.Clear();
            txtDireccion01.Clear();
            txtDireccion02.Clear();
            txtReferencia.Clear();
            txtEmail01.Clear();
            txtEmail02.Clear();
            txtPagWeb.Clear();
            txtTelfFijo01.Clear();
            txtTelfFijo02.Clear();
            txtTelfFijo03.Clear();
            txtCelular01.Clear();
            txtCelular02.Clear();
            txtCelular03.Clear();
            txtInfo01.Clear();
            txtInfo02.Clear();
            txtInfo03.Clear();
            txtInfo04.Clear();
            txtInfo05.Clear();
            txtInfo06.Clear();
            txtInfo07.Clear();
            txtInfo08.Clear();
            txtInfo09.Clear();
            txtInfo10.Clear();

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;

            cboTipoDocIdentidad.SelectedIndex = (cboTipoDocIdentidad.Items.Count > 0) ? 0 : -1;
            cboEstadoCivil.SelectedIndex = (cboEstadoCivil.Items.Count > 0) ? 0 : -1;
            cboVia.SelectedIndex = (cboVia.Items.Count > 0) ? 0 : -1;
            cboZona.SelectedIndex = (cboZona.Items.Count > 0) ? 0 : -1;
            cboNacionalidad.SelectedIndex = (cboNacionalidad.Items.Count > 0) ? 0 : -1;

            cboDepartamento.SelectedIndex = (cboDepartamento.Items.Count > 0) ? 0 : -1;
            cboProvincia.SelectedIndex = (cboProvincia.Items.Count > 0) ? 0 : -1;
            cboDistrito.SelectedIndex = (cboDistrito.Items.Count > 0) ? 0 : -1;

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
        private void ControlarEventosABM(long? id = null)
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
                    tabProveedor.SelectedTab = tabPagGeneral;
                    txtApPaterno.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        long idInsertado = (long)id;
                        SeleccionarPorId(idInsertado);
                        tabProveedor.SelectedTab = tabPagGeneral;
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
                            tabProveedor.SelectedTab = tabPagGeneral;
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
                                tabProveedor.SelectedTab = tabPagGeneral;
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

                                        tabProveedor.SelectedTab = tabPagGeneral;

                                        if (id != null)
                                        {
                                            long idAct = (long)id;
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
        private void CargarCombos()
        {
            try
            {
                cboEstadoCivil.DataSource = null;
                cboEstadoCivil.DisplayMember = "txt_desc";
                cboEstadoCivil.ValueMember = "id_estado_civil";
                cboEstadoCivil.DataSource = new EstadoCivilBL().ListaEstadoCivil(Estado.IdActivo, false, true);

                cboTipoDocIdentidad.DataSource = null;
                cboTipoDocIdentidad.DisplayMember = "txt_abrv";
                cboTipoDocIdentidad.ValueMember = "id_tipo_doc_identidad";
                cboTipoDocIdentidad.DataSource = new TipoDocIdentidadBL().ListaTipoDocIdentidad(Estado.IdActivo, true);

                cboDepartamento.DataSource = null;
                cboDepartamento.DisplayMember = "txt_desc";
                cboDepartamento.ValueMember = "id_dpto";
                cboDepartamento.DataSource = new DepartamentoBL().ListaDepartamento(Estado.IdActivo, true);

                cboProvincia.DataSource = null;
                cboProvincia.DisplayMember = "txt_desc";
                cboProvincia.ValueMember = "id_prov";
                cboProvincia.DataSource = (cboDepartamento.SelectedValue != null) ?
                    new ProvinciaBL().ListaProvinciaXDep(int.Parse(cboDepartamento.SelectedValue.ToString()), Estado.IdActivo) : null;

                cboDistrito.DataSource = null;
                cboDistrito.DisplayMember = "txt_desc";
                cboDistrito.ValueMember = "id_dist";
                cboDistrito.DataSource = (cboProvincia.SelectedValue != null) ?
                    new DistritoBL().ListaDistritoXProv(int.Parse(cboProvincia.SelectedValue.ToString()), Estado.IdActivo) : null;


                cboNacionalidad.DataSource = null;
                cboNacionalidad.DisplayMember = "txt_desc";
                cboNacionalidad.ValueMember = "id_nacionalidad";
                cboNacionalidad.DataSource = new NacionalidadBL().ListaNacionalidad(Estado.IdActivo, true);

                cboZona.DataSource = null;
                cboZona.DisplayMember = "txt_desc";
                cboZona.ValueMember = "id_zona";
                cboZona.DataSource = new ZonaBL().ListaZona(Estado.IdActivo, true);

                cboVia.DataSource = null;
                cboVia.DisplayMember = "txt_desc";
                cboVia.ValueMember = "id_via";
                cboVia.DataSource = new ViaBL().ListaVia(Estado.IdActivo, true);

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
                var lista = new ProveedorBL().ListaProveedor(id_estado, true);
                var listaView = lista.Select(x => new
                {
                    x.id_proveedor,
                    CODIGO = x.cod_proveedor,
                    NOMBRE = Human.Nombre(x.txt_ape_pat, x.txt_pri_nom, rznSocial: x.txt_rzn_social)
                })
                                        .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();
                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvProveedor.DataSource = listaView;
                    dgvProveedor.Columns["id_proveedor"].Visible = false;
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
            dgvProveedor.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvProveedor.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvProveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvProveedor.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvProveedor.AllowUserToResizeColumns = true;
            dgvProveedor.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvProveedor.Columns["CODIGO"].Width = 100;
            dgvProveedor.Columns["NOMBRE"].Width = 300;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 20;
            txtNumDoc.MaxLength = 15;
            txtNumRuc.MaxLength = 15;
            txtApPaterno.MaxLength = 200;
            txtApMaterno.MaxLength = 150;
            txtPrimerNom.MaxLength = 120;
            txtSegundoNom.MaxLength = 100;
            txtRazonSocial.MaxLength = 350;
            txtNomComercial.MaxLength = 350;
            txtNomVia.MaxLength = 250;
            txtNumVia.MaxLength = 20;
            txtNomZona.MaxLength = 250;
            txtDireccion01.MaxLength = 350;
            txtDireccion02.MaxLength = 350;
            txtReferencia.MaxLength = 350;
            txtEmail01.MaxLength = 50;
            txtEmail02.MaxLength = 50;
            txtPagWeb.MaxLength = 50;
            txtTelfFijo01.MaxLength = 100;
            txtTelfFijo02.MaxLength = 100;
            txtTelfFijo03.MaxLength = 100;
            txtCelular01.MaxLength = 100;
            txtCelular02.MaxLength = 100;
            txtCelular03.MaxLength = 100;
            txtInfo01.MaxLength = 300;
            txtInfo02.MaxLength = 300;
            txtInfo03.MaxLength = 300;
            txtInfo04.MaxLength = 300;
            txtInfo05.MaxLength = 300;
            txtInfo06.MaxLength = 300;
            txtInfo07.MaxLength = 300;
            txtInfo08.MaxLength = 300;
            txtInfo09.MaxLength = 300;
            txtInfo10.MaxLength = 300;
        }
        private void ContarEstados(List<PERt03_proveedor> lista)
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

        #endregion

        #region Eventos de ventana

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            lblIdProveedor.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            CargarCombos();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
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

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue != null)
            {
                cboProvincia.DataSource = null;
                cboProvincia.DisplayMember = "txt_desc";
                cboProvincia.ValueMember = "id_prov";
                cboProvincia.DataSource = new ProvinciaBL().ListaProvinciaXDep(int.Parse(cboDepartamento.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboProvincia.DataSource = null;

            cboProvincia.DropDownWidth = ControlHelper.DropDownWidth(cboProvincia);

            isChangedRow = false;
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue != null)
            {
                cboDistrito.DataSource = null;
                cboDistrito.DisplayMember = "txt_desc";
                cboDistrito.ValueMember = "id_dist";
                cboDistrito.DataSource = new DistritoBL().ListaDistritoXProv(int.Parse(cboProvincia.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboDistrito.DataSource = null;

            cboDistrito.DropDownWidth = ControlHelper.DropDownWidth(cboDistrito);

            isChangedRow = false;
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdProveedor.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
                                SeleccionarPorId(long.Parse(idSelect));
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
                    if (idSelect != lblIdProveedor.Text && idSelect != "-1")
                    {
                        isValid = Actualizar();
                        if (isValid)
                        {
                            SeleccionarPorId(long.Parse(idSelect));
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

        private void DtpLimpiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (e.KeyChar == (char)Keys.Escape && dtp.CustomFormat != DateFormat.Blank)
            {
                DateFormat.SetFormat(dtp, DateFormat.Blank);
                isChangedRow = false;
            }
        }

        private void DtpVer_MouseDown(object sender, MouseEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                isChangedRow = false;
            }
        }

        private void dtpVer_CloseUp(object sender, EventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                isChangedRow = false;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }
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
