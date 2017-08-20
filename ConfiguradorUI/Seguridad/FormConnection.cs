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

namespace ConfiguradorUI.Seguridad
{
    public partial class FormConnection : MetroForm
    {
        #region Variables

        string dataSource = "", dbName = "", dbUser = "", dbPassword = "";
        bool isSuccessfull = false;
        public bool isRight = false;

        #endregion

        public FormConnection()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void ConfigurarControles()
        {
            lblTestResult.Visible = false;

            txtContrasena.UseSystemPasswordChar = true;

            txtDataSource.Text = dataSource;
            txtUsuario.Text = dbUser;
            txtContrasena.Text = dbPassword;
            var list = new List<string>() { dbName };
            cboDatabase.DataSource = list;

            ButtonControl(false, true, true, false, true);
            TextComboControl(false, false, false, false);
            btnCambiar.Focus();
        }

        private void GetAppConnectionData()
        {
            dataSource = Connection.GetSettingValue(Connection.dataSource);
            dbName = Connection.GetSettingValue(Connection.dbName);
            dbUser = Connection.GetSettingValue(Connection.dbUser);
            dbPassword = Connection.GetSettingValue(Connection.dbPassword);
        }

        private void ButtonControl(bool eConectar, bool eCambiar, bool eTestConnection, bool eGuardar, bool eCancelar)
        {
            btnConnect.Enabled = eConectar;
            btnCambiar.Enabled = eCambiar;
            btnTestConnection.Enabled = eTestConnection;
            btnGuardar.Enabled = eGuardar;
            btnCancelar.Enabled = eCancelar;
        }

        private void TextComboControl(bool eDataSource, bool eUser, bool ePassword, bool eDatabase)
        {
            txtDataSource.Enabled = eDataSource;
            txtUsuario.Enabled = eUser;
            txtContrasena.Enabled = ePassword;
            cboDatabase.Enabled = eDatabase;
        }

        private void Conectar(string cnnString)
        {
            using (new CursorWait())
            {
                if (Connection.ConnectionTest(cnnString))
                {

                    ButtonControl(false, true, true, false, true);
                    TextComboControl(false, false, false, true);
                    var databases = new Connection().GetDatabases(cnnString);
                    cboDatabase.DataSource = databases;

                }
                else
                {
                    MessageBox.Show("La autenticación de SQL es incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TestConnection(string cnnString)
        {
            using (new CursorWait())
            {
                isSuccessfull = Connection.ConnectionTest(cnnString);
                if (isSuccessfull)
                {
                    ButtonControl(false, true, true, true, true);
                    lblTestResult.Visible = true;
                    lblTestResult.Text = "La conexión es correcta";
                    lblTestResult.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lblTestResult.Visible = true;
                    lblTestResult.Text = "La conexión es incorrecta";
                    lblTestResult.ForeColor = Color.Red;
                }
            }

        }

        #endregion

        #region Eventos de ventana

        private void FormConnection_Load(object sender, EventArgs e)
        {
            GetAppConnectionData();
            ConfigurarControles();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string _dataSource = txtDataSource.Text;
            string _dbUser = txtUsuario.Text;
            string _dbPassword = txtContrasena.Text;

            string cnnString = Connection.AssembleConnectionString(_dataSource, _dbUser, _dbPassword);

            try
            {
                Conectar(cnnString);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió una excepción cuando se intentó conectar: " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            isSuccessfull = false;
            lblTestResult.Visible = false;

            ButtonControl(true, false, true, false, true);
            TextComboControl(true, true, true, false);
            cboDatabase.DataSource = null;
            txtDataSource.Focus();

        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSuccessfull = false;
            lblTestResult.Visible = false;
            lblTestResult.Text = "";
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (cboDatabase.SelectedItem!=null && !string.IsNullOrEmpty(cboDatabase.SelectedItem.ToString()))
            {
                string _dbName = cboDatabase.SelectedItem.ToString();
                string _dataSource = txtDataSource.Text;
                string _dbUser = txtUsuario.Text;
                string _dbPassword = txtContrasena.Text;

                string cnnString = Connection.AssembleConnectionString(_dataSource, _dbUser, _dbPassword, _dbName);
                try
                {
                    TestConnection(cnnString);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ocurrió una excepción cuando se hacía la validación. " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Autentifíquese y seleccione una base de datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (isSuccessfull)
            {
                string _dataSource = txtDataSource.Text;
                string _dbUser = txtUsuario.Text;
                string _dbPassword = txtContrasena.Text;
                string _dbName = cboDatabase.SelectedItem.ToString();

                if (_dataSource == dataSource)
                    _dataSource = null;

                if (_dbUser == dbUser)
                    _dbUser = null;

                if (_dbPassword == dbPassword)
                    _dbPassword = null;

                if (_dbName == dbName)
                    _dbName = null;

                bool success = new Connection().EditConnectionString(_dataSource, _dbName, _dbUser, _dbPassword);
               
                if(success)
                {
                    ButtonControl(false, true, true, false, true);
                    TextComboControl(false, false, false, false);
                    lblTestResult.Visible = false;
                    lblTestResult.Text = "";
                    isRight = true;
                    MessageBox.Show("Los cambios se han modificado exitosamente. Cierre y vuelva abrir el programa para que los cambios surgan efecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar los datos de conexión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Tiene que pasar el test de conexión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
