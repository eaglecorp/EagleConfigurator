using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ConfigUtilitarios;
using ConfigBusinessEntity;
using ConfigBusinessLogic.Persona;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Sunat;
using ConfigBusinessLogic.Clinica;
using ConfiguradorUI.FormUtil;
using MetroFramework.Controls;
using ConfigBusinessLogic.Seguridad;

namespace ConfiguradorUI.Persona
{
    public partial class FormEmpleado : MetroForm
    {
        #region Variables

        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        //variable add
        private string emailSelected1 = "";
        private string emailSelected2 = "";

        string codSelected = "";
        string esActivo = "";
        #endregion

        public FormEmpleado()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void addHandlers()
        {
            var txts = new[] { txtApPaterno, txtApMaterno,txtPrimerNom,txtSegundoNom,
                                txtCodigo,txtRazonSocial,txtNomComercial,txtNumDoc,
                                txtNumRuc,txtNomZona,txtNomVia,txtNumVia,
                                txtDireccion01,txtDireccion02,txtReferencia,txtCelular01,
                                txtCelular02,txtCelular03,txtTelfFijo01,txtTelfFijo02,
                                txtTelfFijo03,txtEmail01,txtEmail02,txtPagWeb,
                                txtInfo01,txtInfo02,txtInfo03,txtInfo04,
                                txtInfo05,txtInfo06,txtInfo07,txtInfo08,
                                txtInfo09,txtInfo10,
                                txtNumHorasMes,txtNumCuenta,txtSalMensual, txtSalQuincenal,
                                txtSalHora};

            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);

            }

            var cbos = new[] { cboEstadoCivil,cboClaseEmp,cboCategoriaEmp, cboTipoDocIdentidad,
                                cboDepartamento,cboProvincia,cboDistrito,cboNacionalidad,cboZona,cboVia,

                                cboPeriodoPago,cboEntidadFinanciera,cboTipoTrabajador,cboOcupacion,
                                cboCondicionLaboral,cboRegPension,cboRegLaboral,cboRegSalud,
                                cboSaludEps,cboSituacionEdu,cboModalidadFormativa,cboTipoEspc,
                                cboEspcMedica,cboSituacion,cboMotivoBaja,cboSuspLaboral};
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cbo);
            }

            var rbts = new[] { rbtMasculino, rbtFemenino };
            foreach (var rbt in rbts)
            {
                rbt.CheckedChanged += new EventHandler(OnContentChanged);
            }

            var dtps = new[] { dtpFechaNacimiento, dtpFechaIngreso, dtpFechaCese };
            foreach (var dtp in dtps)
            {
                dtp.ValueChanged += new EventHandler(OnContentChanged);
                if (dtp.ShowCheckBox == false)
                {
                    dtp.CloseUp += new EventHandler(OnContentChanged);
                }
            }

            var chks = new[] { chkActivo };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }

            txtNumHorasMes.KeyPress += ValidarTxtDecimal;
            txtSalMensual.KeyPress += ValidarTxtDecimal;
            txtSalQuincenal.KeyPress += ValidarTxtDecimal;
            txtSalHora.KeyPress += ValidarTxtDecimal;
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
                        var obj = new PERt04_empleado();
                        obj = GetObjeto();
                        long id = new EmpleadoBL().InsertarEmpleado(obj);
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
                if (dgvEmpleado.RowCount > 0)
                {
                    if (dgvEmpleado.SelectedRows.Count > 0)
                    {
                        try
                        {
                            long id = 0;
                            if (long.TryParse(lblIdEmpleado.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new EmpleadoBL().EliminarEmpleado(id);
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
                        var obj = new PERt04_empleado();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdEmpleado.Text, out id))
                        {
                            obj.id_empleado = id;
                            new EmpleadoBL().ActualizarEmpleado(obj);

                            if (obj.id_estado == Estado.IdInactivo && esActivo != obj.id_estado.ToString())
                            {
                                new UsuarioBL().EliminarUsuarioXEmpleado(id);
                            }
                            else if (obj.id_estado == Estado.IdActivo && esActivo != obj.id_estado.ToString())
                            {
                                new UsuarioBL().ActivarUsuarioXEmpleado(id);
                            }

                            ControlarEventosABM(obj.id_empleado);
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
                        var obj = new PERt04_empleado();
                        obj = GetObjeto();
                        long id = 0;
                        if (long.TryParse(lblIdEmpleado.Text, out id))
                        {
                            obj.id_empleado = id;
                            new EmpleadoBL().ActualizarEmpleado(obj);

                            if (obj.id_estado == Estado.IdInactivo && esActivo != obj.id_estado.ToString())
                            {
                                new UsuarioBL().EliminarUsuarioXEmpleado(id);
                            }
                            else if (obj.id_estado == Estado.IdActivo && esActivo != obj.id_estado.ToString())
                            {
                                new UsuarioBL().ActivarUsuarioXEmpleado(id);
                            }

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

        private PERt04_empleado GetObjeto()
        {
            var obj = new PERt04_empleado();
            try
            {
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                if (dtpFechaNacimiento.Format == DateTimePickerFormat.Short)
                {
                    obj.fec_nac = dtpFechaNacimiento.Value;
                }

                if (dtpFechaIngreso.Format == DateTimePickerFormat.Short)
                {
                    obj.fecha_ingreso = dtpFechaIngreso.Value;
                }
                if (dtpFechaCese.Checked)
                {
                    obj.fecha_cese = dtpFechaCese.Value;
                }

                obj.cod_empleado = txtCodigo.Text.Trim();

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

                obj.nro_cuenta = txtNumCuenta.Text.Trim();


                if (string.IsNullOrEmpty(txtNumHorasMes.Text)
                || string.IsNullOrWhiteSpace(txtNumHorasMes.Text))
                    obj.nro_hora_mes = null;
                else obj.nro_hora_mes = decimal.Parse(txtNumHorasMes.Text);

                if (string.IsNullOrEmpty(txtSalMensual.Text)
                || string.IsNullOrWhiteSpace(txtSalMensual.Text))
                    obj.salario_mensual = null;
                else obj.salario_mensual = decimal.Parse(txtSalMensual.Text);

                if (string.IsNullOrEmpty(txtSalQuincenal.Text)
                || string.IsNullOrWhiteSpace(txtSalQuincenal.Text))
                    obj.salario_quincenal = null;
                else obj.salario_quincenal = decimal.Parse(txtSalQuincenal.Text);

                if (string.IsNullOrEmpty(txtSalHora.Text)
                || string.IsNullOrWhiteSpace(txtSalHora.Text))
                    obj.salario_hora = null;
                else obj.salario_hora = decimal.Parse(txtSalHora.Text);


                if (rbtFemenino.Checked || rbtMasculino.Checked)
                {
                    obj.sexo = (rbtFemenino.Checked) ? "F" : "M";
                }
                else obj.sexo = null;


                if (cboClaseEmp.SelectedValue != null)
                    obj.id_clase_emp = int.Parse(cboClaseEmp.SelectedValue.ToString());

                if (cboCategoriaEmp.SelectedValue != null)
                    obj.id_categoria_emp = int.Parse(cboCategoriaEmp.SelectedValue.ToString());

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

                if (cboPeriodoPago.SelectedValue != null)
                    obj.id_periodo_remuneracion = int.Parse(cboPeriodoPago.SelectedValue.ToString());
                else obj.id_periodo_remuneracion = null;

                if (cboEntidadFinanciera.SelectedValue != null)
                    obj.id_entidad_financiera = int.Parse(cboEntidadFinanciera.SelectedValue.ToString());
                else obj.id_entidad_financiera = null;

                if (cboTipoTrabajador.SelectedValue != null)
                    obj.id_tipo_trabajador = int.Parse(cboTipoTrabajador.SelectedValue.ToString());
                else obj.id_tipo_trabajador = null;

                if (cboOcupacion.SelectedValue != null)
                    obj.id_ocupacion = int.Parse(cboOcupacion.SelectedValue.ToString());
                else obj.id_ocupacion = null;

                if (cboCondicionLaboral.SelectedValue != null)
                    obj.id_condicion_laboral = int.Parse(cboCondicionLaboral.SelectedValue.ToString());
                else obj.id_condicion_laboral = null;

                if (cboRegPension.SelectedValue != null)
                    obj.id_regimen_pensionario = int.Parse(cboRegPension.SelectedValue.ToString());
                else obj.id_regimen_pensionario = null;

                if (cboRegLaboral.SelectedValue != null)
                    obj.id_regimen_laboral = int.Parse(cboRegLaboral.SelectedValue.ToString());
                else obj.id_regimen_laboral = null;

                if (cboRegSalud.SelectedValue != null)
                    obj.id_regimen_salud = int.Parse(cboRegSalud.SelectedValue.ToString());
                else obj.id_regimen_salud = null;

                if (cboSaludEps.SelectedValue != null)
                    obj.id_salud_eps = int.Parse(cboSaludEps.SelectedValue.ToString());
                else obj.id_salud_eps = null;

                if (cboSituacionEdu.SelectedValue != null)
                    obj.id_situacion_educativa = int.Parse(cboSituacionEdu.SelectedValue.ToString());
                else obj.id_situacion_educativa = null;

                if (cboModalidadFormativa.SelectedValue != null)
                    obj.id_modalidad_formativa = int.Parse(cboModalidadFormativa.SelectedValue.ToString());
                else obj.id_modalidad_formativa = null;

                if (cboEspcMedica.SelectedValue != null)
                    obj.id_especialidad_medica = int.Parse(cboEspcMedica.SelectedValue.ToString());
                else obj.id_especialidad_medica = null;

                if (cboSituacion.SelectedValue != null)
                    obj.id_situacion = int.Parse(cboSituacion.SelectedValue.ToString());
                else obj.id_situacion = null;

                if (cboMotivoBaja.SelectedValue != null)
                    obj.id_motivo_baja = int.Parse(cboMotivoBaja.SelectedValue.ToString());
                else obj.id_motivo_baja = null;

                if (cboSuspLaboral.SelectedValue != null)
                    obj.id_suspencion_laboral = int.Parse(cboSuspLaboral.SelectedValue.ToString());
                else obj.id_suspencion_laboral = null;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return obj;
        }
        private void SetObjeto(PERt04_empleado obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdEmpleado.Text = obj.id_empleado.ToString();
                codSelected = obj.cod_empleado;
                esActivo = (obj.id_estado == Estado.IdActivo) ? Estado.IdActivo.ToString() : Estado.IdInactivo.ToString();

                if (obj.fec_nac != null)
                {
                    dtpFechaNacimiento_CloseUp(null, EventArgs.Empty);
                    dtpFechaNacimiento.Value = (DateTime)obj.fec_nac;
                }

                if (obj.fecha_ingreso != null)
                {
                    dtpFechaIngreso_CloseUp(null, EventArgs.Empty);
                    dtpFechaIngreso.Value = (DateTime)obj.fecha_ingreso;
                }

                if (obj.fecha_cese != null)
                {
                    dtpFechaCese.Checked = true;
                    dtpFechaCese.Value = (DateTime)obj.fecha_cese;
                }

                emailSelected1 = obj.txt_email1;
                emailSelected2 = obj.txt_email2;

                txtCodigo.Text = obj.cod_empleado;

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

                txtNumHorasMes.Text = (obj.nro_hora_mes == null) ? "" : obj.nro_hora_mes.RemoveTrailingZeros();
                txtNumCuenta.Text = obj.nro_cuenta;
                txtSalMensual.Text = (obj.salario_mensual == null) ? "" : obj.salario_mensual.RemoveTrailingZeros();
                txtSalQuincenal.Text = (obj.salario_quincenal == null) ? "" : obj.salario_quincenal.RemoveTrailingZeros();
                txtSalHora.Text = (obj.salario_hora == null) ? "" : obj.salario_hora.RemoveTrailingZeros();

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


                if (obj.id_categoria_emp != null)
                    cboCategoriaEmp.SelectedValue = obj.id_categoria_emp;
                else cboCategoriaEmp.SelectedIndex = -1;

                if (obj.id_clase_emp != null)
                    cboClaseEmp.SelectedValue = obj.id_clase_emp;
                else cboClaseEmp.SelectedIndex = -1;

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

                if (obj.id_periodo_remuneracion != null)
                    cboPeriodoPago.SelectedValue = obj.id_periodo_remuneracion;
                else cboPeriodoPago.SelectedIndex = -1;

                if (obj.id_entidad_financiera != null)
                    cboEntidadFinanciera.SelectedValue = obj.id_entidad_financiera;
                else cboEntidadFinanciera.SelectedIndex = -1;

                if (obj.id_tipo_trabajador != null)
                    cboTipoTrabajador.SelectedValue = obj.id_tipo_trabajador;
                else cboTipoTrabajador.SelectedIndex = -1;

                if (obj.id_ocupacion != null)
                    cboOcupacion.SelectedValue = obj.id_ocupacion;
                else cboOcupacion.SelectedIndex = -1;

                if (obj.id_condicion_laboral != null)
                    cboCondicionLaboral.SelectedValue = obj.id_condicion_laboral;
                else cboCondicionLaboral.SelectedIndex = -1;

                if (obj.id_regimen_pensionario != null)
                    cboRegPension.SelectedValue = obj.id_regimen_pensionario;
                else cboRegPension.SelectedIndex = -1;

                if (obj.id_regimen_laboral != null)
                    cboRegLaboral.SelectedValue = obj.id_regimen_laboral;
                else cboRegLaboral.SelectedIndex = -1;

                if (obj.id_regimen_salud != null)
                    cboRegSalud.SelectedValue = obj.id_regimen_salud;
                else cboRegSalud.SelectedIndex = -1;

                if (obj.id_salud_eps != null)
                    cboSaludEps.SelectedValue = obj.id_salud_eps;
                else cboSaludEps.SelectedIndex = -1;

                if (obj.id_situacion_educativa != null)
                    cboSituacionEdu.SelectedValue = obj.id_situacion_educativa;
                else cboSituacionEdu.SelectedIndex = -1;

                if (obj.id_modalidad_formativa != null)
                    cboModalidadFormativa.SelectedValue = obj.id_modalidad_formativa;
                else cboModalidadFormativa.SelectedIndex = -1;

                if (obj.CLIt07_especialidad_medica != null && obj.CLIt07_especialidad_medica.id_tipo_especialidad != null)
                    cboTipoEspc.SelectedValue = obj.CLIt07_especialidad_medica.id_tipo_especialidad;
                else
                    cboTipoEspc.SelectedIndex = -1;

                if (obj.id_especialidad_medica != null)
                    cboEspcMedica.SelectedValue = obj.id_especialidad_medica;
                else cboEspcMedica.SelectedIndex = -1;

                if (obj.id_situacion != null)
                    cboSituacion.SelectedValue = obj.id_situacion;
                else cboSituacion.SelectedIndex = -1;

                if (obj.id_motivo_baja != null)
                    cboMotivoBaja.SelectedValue = obj.id_motivo_baja;
                else cboMotivoBaja.SelectedIndex = -1;

                if (obj.id_suspencion_laboral != null)
                    cboSuspLaboral.SelectedValue = obj.id_suspencion_laboral;
                else cboSuspLaboral.SelectedIndex = -1;

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
            //Para limpiar lo que dejó la validación anterior.
            errorProv.Clear();

            #region validación de nombres y apellidos (requeridos)
            var txtRequeridos = new[] { txtApPaterno, txtPrimerNom };
            foreach (var txtReq in txtRequeridos)
            {
                if (txtReq.Text.Trim().Length == 0)
                {
                    tabEmpleado.SelectedTab = tabPagGeneral;
                    errorProv.SetError(txtReq, "Este campo es requerido.");
                    txtReq.Focus();
                    no_error = false;

                }
            }
            #endregion

            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var obj = new EmpleadoBL().EmpleadoXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (obj != null && obj.id_empleado > 0)
                        {
                            tabEmpleado.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && obj != null && obj.id_empleado > 0)
                        {
                            tabEmpleado.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            #endregion

            #region validación salarios y demás numéricos
            //validar los txt's numéricos. Si ya pasó la 
            if (no_error == true)
            {
                if (no_error)
                {
                    //El num de horas al mes, aparte.... 
                    if (txtNumHorasMes.Text.Length > 0)
                    {
                        decimal num = 0;
                        //verificamos que un sea número. si no lo es... entonces...
                        if (!decimal.TryParse(txtNumHorasMes.Text, out num))
                        {
                            tabEmpleado.SelectedTab = tabPagDetalles;
                            errorProv.SetError(txtNumHorasMes, "Tiene que ingresar un número.");
                            txtNumHorasMes.Focus();
                            no_error = false;
                        }
                        else
                        {
                            if (num <= 0 || num > 744)
                            {
                                tabEmpleado.SelectedTab = tabPagDetalles;
                                errorProv.SetError(txtNumHorasMes, "El número de horas al mes tiene que ser mayor a 0 y menor o igual que 744.");
                                txtNumHorasMes.Focus();
                                no_error = false;
                            }
                        }
                    }
                }

                var txtsNumericos = new[] { txtSalMensual, txtSalQuincenal, txtSalHora };
                foreach (var txtNum in txtsNumericos)
                {
                    //si hay algo dentro de esos txt's 
                    if (txtNum.Text.Length > 0)
                    {
                        decimal salario = 0;
                        //verificamos que un sea número. si no lo es... entonces...
                        if (!decimal.TryParse(txtNum.Text, out salario))
                        {
                            tabEmpleado.SelectedTab = tabPagDetalles;
                            errorProv.SetError(txtNum, "Tiene que ingresar un número.");
                            txtNum.Focus();
                            no_error = false;
                            break;
                        }
                        else
                        {
                            if (!(salario > 0 && salario < 10000000000))
                            {
                                tabEmpleado.SelectedTab = tabPagDetalles;
                                errorProv.SetError(txtNum, "El salario tiene que ser mayor que 0 y menor que 10000000000.");
                                txtNum.Focus();
                                no_error = false;
                                break;
                            }

                        }
                    }
                }

                if (no_error)
                {
                    decimal salMen = 0, salQuin = 0, salHora = 0;
                    //Si llego aquí ya se comprobó que si .length > 0 entonces se trata de un número que cumplió las validaciones
                    if (txtSalMensual.Text.Length > 0) salMen = decimal.Parse(txtSalMensual.Text);
                    if (txtSalQuincenal.Text.Length > 0) salQuin = decimal.Parse(txtSalQuincenal.Text);
                    if (txtSalHora.Text.Length > 0) salHora = decimal.Parse(txtSalHora.Text);
                    //Si los salarios son 0 significa que no colocaron nada
                    if (salMen != 0 && salQuin != 0 && salQuin >= salMen)
                    {
                        tabEmpleado.SelectedTab = tabPagDetalles;
                        MessageBox.Show("El salario quincenal no puede ser mayor o igual al mensual.", "Validación Eagle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        errorProv.SetError(txtSalQuincenal, "El salario quincenal no puede ser mayor al mensual.");
                        txtSalQuincenal.Focus();
                        no_error = false;
                    }
                    else
                    {
                        if (salMen != 0 && salHora != 0 && salHora >= salMen)
                        {
                            tabEmpleado.SelectedTab = tabPagDetalles;
                            MessageBox.Show("El salario hora no puede ser mayor o igual al mensual.", "Validación Eagle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            errorProv.SetError(txtSalHora, "El salario hora no puede ser mayor al mensual.");
                            txtSalHora.Focus();
                            no_error = false;
                        }
                        else if (salQuin != 0 && salHora != 0 && salHora >= salQuin)
                        {
                            tabEmpleado.SelectedTab = tabPagDetalles;
                            MessageBox.Show("El salario hora no puede ser mayor o igual al quincenal.", "Validación Eagle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            errorProv.SetError(txtSalHora, "El salario hora no puede ser mayor al quincenal.");
                            txtSalHora.Focus();
                            no_error = false;
                        }

                    }
                }
            }
            #endregion

            #region validación email
            if (no_error == true)
            {
                var txtsEmail = new[] { txtEmail01, txtEmail02 };
                foreach (var txtEm in txtsEmail)
                {
                    string email = txtEm.Text.Trim();
                    //si hay algo dentro de esos txt's 
                    if (email.Length > 0)
                    {
                        //verificamos que un sea un email
                        if (Validation.EsEmail(email))
                        {
                            var empleado = new EmpleadoBL().EmpleadoXEmail(email);
                            if (TipoOperacion == TipoOperacionABM.Insertar)
                            {
                                if (empleado != null && empleado.id_empleado > 0)
                                {
                                    tabEmpleado.SelectedTab = tabPagContacto;
                                    MessageBox.Show("Esta dirección de correo electrónico ya está registrado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    errorProv.SetError(txtEm, "Este email ya está registrado.");
                                    txtEm.Focus();
                                    no_error = false;
                                    break;
                                }
                            }
                            //validamos que el usuario este disponible.
                            else if (TipoOperacion == TipoOperacionABM.Modificar)
                            {
                                //dos casos
                                //1. Cambio el email
                                //2. No cambió el email
                                //Con email's que ha ingreaso existe un empleado
                                if (empleado != null && empleado.id_empleado > 0)
                                {
                                    if (email != emailSelected1 && email != emailSelected2)
                                    {
                                        tabEmpleado.SelectedTab = tabPagContacto;
                                        MessageBox.Show("Esta dirección de correo electrónico ya está registrado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        errorProv.SetError(txtEm, "Este email ya está registrado.");
                                        txtEm.Focus();
                                        no_error = false;
                                        break;
                                    }

                                }
                            }

                        }
                        else
                        {
                            tabEmpleado.SelectedTab = tabPagContacto;
                            errorProv.SetError(txtEm, "Formato de email incorrecto.");
                            txtEm.Focus();
                            no_error = false;
                            break;
                        }

                    }
                }
            }
            #endregion

            #region Validación fechas
            if (no_error)
            {
                if (dtpFechaIngreso.Format != DateTimePickerFormat.Short && dtpFechaCese.Checked)
                {
                    tabEmpleado.SelectedTab = tabPagDetalles;
                    errorProv.SetError(dtpFechaIngreso, "La fecha de ingreso es requerida cuando ha asignado una fecha de cese.");
                    dtpFechaIngreso.Focus();
                    no_error = false;
                }

                else if (dtpFechaIngreso.Format == DateTimePickerFormat.Short && dtpFechaCese.Checked)
                {
                    if (!(new DateFormat().Validar_FechaIni_FechaFin(dtpFechaIngreso.Value, dtpFechaCese.Value)))
                    {
                        tabEmpleado.SelectedTab = tabPagDetalles;
                        MessageBox.Show("La fecha de ingreso tiene que ser anterior y/o inferior a la fecha de cese.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(dtpFechaIngreso, "La fecha ingreso tiene que ser inferior a la fecha de cese.");
                        errorProv.SetError(dtpFechaCese, "La fecha cese tiene que ser superior a la fecha de ingreso.");
                        dtpFechaIngreso.Focus();
                        no_error = false;
                    }
                }
            }
            #endregion

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
                    DataGridViewRow row = dgvEmpleado.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvEmpleado.Rows.Count > 0)
                        {
                            dgvEmpleado.Rows[index].Selected = true;
                            dgvEmpleado.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvEmpleado.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvEmpleado.Rows.Count > 0)
                        {
                            dgvEmpleado.Rows[index].Selected = true;
                            dgvEmpleado.FirstDisplayedScrollingRowIndex = index;
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
            {   //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvEmpleado.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_empleado"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvEmpleado.Rows.Count > 0)
                    {

                        dgvEmpleado.Rows[index].Selected = true;
                        dgvEmpleado.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvEmpleado.RowCount > 0 && dgvEmpleado.SelectedRows.Count > 0 && dgvEmpleado.CurrentRow.Index != -1)
            {
                long id = 0;
                if (long.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new EmpleadoBL().EmpleadoXIdMM(id);
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
                if (dgvEmpleado.SelectedRows.Count > 0 && dgvEmpleado.Rows.Count > 0)
                {
                    id = dgvEmpleado.SelectedRows[0].Cells[0].Value.ToString();
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

            lblIdEmpleado.Text = 0 + "";
            codSelected = "";
            esActivo = "";

            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = " ";

            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaIngreso.Format = DateTimePickerFormat.Custom;
            dtpFechaIngreso.CustomFormat = " ";

            dtpFechaCese.Value = DateTime.Now;
            dtpFechaCese.Checked = false;

            emailSelected1 = "";
            emailSelected2 = "";

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

            txtNumHorasMes.Clear();
            txtNumCuenta.Clear();
            txtSalMensual.Clear();
            txtSalQuincenal.Clear();
            txtSalHora.Clear();

            cboClaseEmp.SelectedIndex = -1;
            cboCategoriaEmp.SelectedIndex = -1;

            cboTipoDocIdentidad.SelectedIndex = (cboTipoDocIdentidad.Items.Count > 0) ? 0 : -1;
            cboEstadoCivil.SelectedIndex = (cboEstadoCivil.Items.Count > 0) ? 0 : -1;
            cboVia.SelectedIndex = (cboVia.Items.Count > 0) ? 0 : -1;
            cboZona.SelectedIndex = (cboZona.Items.Count > 0) ? 0 : -1;
            cboNacionalidad.SelectedIndex = (cboNacionalidad.Items.Count > 0) ? 0 : -1;

            cboDepartamento.SelectedIndex = (cboDepartamento.Items.Count > 0) ? 0 : -1;
            cboProvincia.SelectedIndex = (cboProvincia.Items.Count > 0) ? 0 : -1;
            cboDistrito.SelectedIndex = (cboDistrito.Items.Count > 0) ? 0 : -1;

            cboPeriodoPago.SelectedIndex = (cboPeriodoPago.Items.Count > 0) ? 0 : -1;
            cboEntidadFinanciera.SelectedIndex = (cboEntidadFinanciera.Items.Count > 0) ? 0 : -1;
            cboTipoTrabajador.SelectedIndex = (cboTipoTrabajador.Items.Count > 0) ? 0 : -1;
            cboOcupacion.SelectedIndex = (cboOcupacion.Items.Count > 0) ? 0 : -1;
            cboCondicionLaboral.SelectedIndex = (cboCondicionLaboral.Items.Count > 0) ? 0 : -1;
            cboRegPension.SelectedIndex = (cboRegPension.Items.Count > 0) ? 0 : -1;
            cboRegLaboral.SelectedIndex = (cboRegLaboral.Items.Count > 0) ? 0 : -1;
            cboRegSalud.SelectedIndex = (cboRegSalud.Items.Count > 0) ? 0 : -1;
            cboSaludEps.SelectedIndex = (cboSaludEps.Items.Count > 0) ? 0 : -1;
            cboSituacionEdu.SelectedIndex = (cboSituacionEdu.Items.Count > 0) ? 0 : -1;
            cboModalidadFormativa.SelectedIndex = (cboModalidadFormativa.Items.Count > 0) ? 0 : -1;

            cboTipoEspc.SelectedIndex = (cboTipoEspc.Items.Count > 0) ? 0 : -1;
            cboEspcMedica.SelectedIndex = (cboEspcMedica.Items.Count > 0) ? 0 : -1;

            cboSituacion.SelectedIndex = (cboSituacion.Items.Count > 0) ? 0 : -1;
            cboMotivoBaja.SelectedIndex = (cboMotivoBaja.Items.Count > 0) ? 0 : -1;
            cboSuspLaboral.SelectedIndex = (cboSuspLaboral.Items.Count > 0) ? 0 : -1;
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
        private void ControlarEventosABM(long? id = null)
        {

            if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
                errorProv.Clear();
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabEmpleado.SelectedTab = tabPagGeneral;
                    txtPrimerNom.Focus();
                }
                else
                {
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        long idInsertado = (long)id;
                        SeleccionarPorId(idInsertado);
                        tabEmpleado.SelectedTab = tabPagGeneral;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
                            tabEmpleado.SelectedTab = tabPagGeneral;
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
                                tabEmpleado.SelectedTab = tabPagGeneral;
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

                                        tabEmpleado.SelectedTab = tabPagGeneral;

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
                cboClaseEmp.DataSource = null;
                cboClaseEmp.DisplayMember = "txt_nombre";
                cboClaseEmp.ValueMember = "id_clase_emp";
                cboClaseEmp.DataSource = new ClaseEmpBL().ListaClaseEmp(Estado.IdActivo, false, true);

                cboCategoriaEmp.DataSource = null;
                cboCategoriaEmp.DisplayMember = "txt_nombre";
                cboCategoriaEmp.ValueMember = "id_categoria_emp";
                cboCategoriaEmp.DataSource = new CategoriaEmpBL().ListaCategoriaEmp(Estado.IdActivo, false, true);


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


                cboPeriodoPago.DataSource = null;
                cboPeriodoPago.DisplayMember = "txt_desc";
                cboPeriodoPago.ValueMember = "id_periodo_remuneracion";
                cboPeriodoPago.DataSource = new PeriodoRemuneracionBL().ListaPeriodoRemuneracion(Estado.IdActivo, true);

                cboEntidadFinanciera.DataSource = null;
                cboEntidadFinanciera.DisplayMember = "txt_desc";
                cboEntidadFinanciera.ValueMember = "id_entidad_financiera";
                cboEntidadFinanciera.DataSource = new EntidadFinancieraBL().ListaEntidadFinanciera(Estado.IdActivo, true);

                cboTipoTrabajador.DataSource = null;
                cboTipoTrabajador.DisplayMember = "txt_abrv";
                cboTipoTrabajador.ValueMember = "id_tipo_trabajador";
                cboTipoTrabajador.DataSource = new TipoTrabajadorBL().ListaTipoTrabajador(Estado.IdActivo, true);

                cboOcupacion.DataSource = null;
                cboOcupacion.DisplayMember = "txt_desc";
                cboOcupacion.ValueMember = "id_ocupacion";
                cboOcupacion.DataSource = new OcupacionBL().ListaOcupacion(Estado.IdActivo, true);

                cboCondicionLaboral.DataSource = null;
                cboCondicionLaboral.DisplayMember = "txt_abrv";
                cboCondicionLaboral.ValueMember = "id_condicion_laboral";
                cboCondicionLaboral.DataSource = new CondicionLaboralBL().ListaCondicionLaboral(Estado.IdActivo, true);

                cboRegPension.DataSource = null;
                cboRegPension.DisplayMember = "txt_abrv";
                cboRegPension.ValueMember = "id_regimen_pensionario";
                cboRegPension.DataSource = new RegimenPensionarioBL().ListaRegimenPensionario(Estado.IdActivo, true);

                cboRegLaboral.DataSource = null;
                cboRegLaboral.DisplayMember = "txt_abrv";
                cboRegLaboral.ValueMember = "id_regimen_laboral";
                cboRegLaboral.DataSource = new RegimenLaboralBL().ListaRegimenLaboral(Estado.IdActivo, true);

                cboRegSalud.DataSource = null;
                cboRegSalud.DisplayMember = "txt_abrv";
                cboRegSalud.ValueMember = "id_regimen_salud";
                cboRegSalud.DataSource = new RegimenSaludBL().ListaRegimenSalud(Estado.IdActivo, true);

                cboSaludEps.DataSource = null;
                cboSaludEps.DisplayMember = "txt_desc";
                cboSaludEps.ValueMember = "id_salud_eps";
                cboSaludEps.DataSource = new SaludEpsBL().ListaSaludEps(Estado.IdActivo, true);

                cboSituacionEdu.DataSource = null;
                cboSituacionEdu.DisplayMember = "txt_abrv";
                cboSituacionEdu.ValueMember = "id_situacion_educativa";
                cboSituacionEdu.DataSource = new SituacionEducativaBL().ListaSituacionEducativa(Estado.IdActivo, true);

                cboModalidadFormativa.DataSource = null;
                cboModalidadFormativa.DisplayMember = "txt_abrv";
                cboModalidadFormativa.ValueMember = "id_modalidad_formativa";
                cboModalidadFormativa.DataSource = new ModalidadFormativaBL().ListaModalidadFormativa(Estado.IdActivo, true);

                cboTipoEspc.DataSource = null;
                cboTipoEspc.DisplayMember = "txt_desc";
                cboTipoEspc.ValueMember = "id_tipo_especialidad";
                cboTipoEspc.DataSource = new TipoEspecialidadBL().ListaTipoEspecialidad(Estado.IdActivo, true);

                cboEspcMedica.DataSource = null;
                cboEspcMedica.DisplayMember = "txt_desc";
                cboEspcMedica.ValueMember = "id_especialidad_medica";
                cboEspcMedica.DataSource = (cboTipoEspc.SelectedValue != null) ?
                    new EspecialidadMedicaBL().ListaEspcMedicaXTipo(int.Parse(cboTipoEspc.SelectedValue.ToString()), Estado.IdActivo) : null;

                cboSituacion.DataSource = null;
                cboSituacion.DisplayMember = "txt_abrv";
                cboSituacion.ValueMember = "id_situacion";
                cboSituacion.DataSource = new SituacionBL().ListaSituacion(Estado.IdActivo, true);

                cboMotivoBaja.DataSource = null;
                cboMotivoBaja.DisplayMember = "txt_abrv";
                cboMotivoBaja.ValueMember = "id_motivo_baja";
                cboMotivoBaja.DataSource = new MotivoBajaBL().ListaMotivoBaja(Estado.IdActivo, true);

                cboSuspLaboral.DataSource = null;
                cboSuspLaboral.DisplayMember = "txt_abrv";
                cboSuspLaboral.ValueMember = "id_suspencion_laboral";
                cboSuspLaboral.DataSource = new SuspensionLaboralBL().ListaSuspencionLaboral(Estado.IdActivo, true);

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos: " + e.Message, "MENSAJE");
            }
        }
        private string Nombre(string apPaterno, string primerNom, string rznSocial)
        {
            string nombre = "";
            if (apPaterno != null && apPaterno.Trim() != "")
            {
                nombre = apPaterno + " ";
            }
            if (primerNom != null && primerNom.Trim() != "")
            {
                nombre += primerNom + " ";
            }
            if (rznSocial != null && rznSocial.Trim() != "")
            {
                if (nombre.Length > 0)
                {
                    nombre += "| " + rznSocial;
                }
                else
                {
                    nombre = rznSocial;
                }
            }
            return nombre;
        }
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new EmpleadoBL().ListaEmpleado(id_estado, true);
                var listaView = lista.Select(x => new { x.id_empleado, CODIGO = x.cod_empleado, NOMBRE = Nombre(x.txt_ape_pat, x.txt_pri_nom, x.txt_rzn_social) })
                                    .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvEmpleado.DataSource = listaView;
                    dgvEmpleado.Columns["id_empleado"].Visible = false;
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
            dgvEmpleado.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvEmpleado.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvEmpleado.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvEmpleado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvEmpleado.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvEmpleado.EnableHeadersVisualStyles = false;

            //
            //dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //dgvEmpleado.GridColor = Color.LightGray;
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

            txtSalMensual.MaxLength = 19;
            txtSalQuincenal.MaxLength = 19;
            txtSalHora.MaxLength = 19;
            txtNumHorasMes.MaxLength = 9;
            txtNumCuenta.MaxLength = 50;
        }
        private void ContarEstados(List<PERt04_empleado> lista)
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

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            lblIdEmpleado.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            CargarCombos();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            addHandlers();
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

        private void btnClaseEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboClaseEmp.SelectedValue != null)
                    oldValue = int.Parse(cboClaseEmp.SelectedValue.ToString());

                var frm = new FormClaseEmp();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboClaseEmp.DataSource = null;
                    cboClaseEmp.DisplayMember = "txt_nombre";
                    cboClaseEmp.ValueMember = "id_clase_emp";
                    cboClaseEmp.DataSource = new ClaseEmpBL().ListaClaseEmp(Estado.IdActivo, false, true);
                    cboClaseEmp.DropDownWidth = ControlHelper.DropDownWidth(cboClaseEmp);
                    cboClaseEmp.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategoriaEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboCategoriaEmp.SelectedValue != null)
                    oldValue = int.Parse(cboCategoriaEmp.SelectedValue.ToString());

                var frm = new FormCategoriaEmp();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboCategoriaEmp.DataSource = null;
                    cboCategoriaEmp.DisplayMember = "txt_nombre";
                    cboCategoriaEmp.ValueMember = "id_categoria_emp";
                    cboCategoriaEmp.DataSource = new CategoriaEmpBL().ListaCategoriaEmp(Estado.IdActivo, false, true);
                    cboCategoriaEmp.DropDownWidth = ControlHelper.DropDownWidth(cboCategoriaEmp);

                    cboCategoriaEmp.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipoEspc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoEspc.SelectedValue != null)
            {
                cboEspcMedica.DataSource = null;
                cboEspcMedica.DisplayMember = "txt_desc";
                cboEspcMedica.ValueMember = "id_especialidad_medica";
                cboEspcMedica.DataSource = new EspecialidadMedicaBL().ListaEspcMedicaXTipo(int.Parse(cboTipoEspc.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboEspcMedica.DataSource = null;

            cboEspcMedica.DropDownWidth = ControlHelper.DropDownWidth(cboEspcMedica);

            isChangedRow = false;
        }

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdEmpleado.Text && idSelect != "-1")
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
                    if (idSelect != lblIdEmpleado.Text && idSelect != "-1")
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

        private void dtpFechaNacimiento_CloseUp(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Format != DateTimePickerFormat.Short)
            {
                dtpFechaNacimiento.CustomFormat = null;
                dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
                isChangedRow = false;
            }
        }

        private void dtpFechaIngreso_CloseUp(object sender, EventArgs e)
        {
            if (dtpFechaIngreso.Format != DateTimePickerFormat.Short)
            {
                dtpFechaIngreso.CustomFormat = null;
                dtpFechaIngreso.Format = DateTimePickerFormat.Short;
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
