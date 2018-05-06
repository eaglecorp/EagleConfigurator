using ConfigUtilitarios;
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
using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigUtilitarios.HelperDatabase;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormBackupRestore : MetroForm
    {
        public FormBackupRestore()
        {
            InitializeComponent();
        }

        #region Métodos de ventana
        private bool Backup(string path)
        {
            using (new CursorWait())
            {
                string cnString = ConnectionManager.GetConnectionString();
                string dbName = Connection.GetSettingValue(Connection.dbName);
                return BackupRestore.Backup(cnString, dbName, path);
            }
        }

        private bool Restore(string pathFile)
        {
            using (new CursorWait())
            {
                string cnString = ConnectionManager.GetConnectionString();
                string dbName = Connection.GetSettingValue(Connection.dbName);
                return BackupRestore.Restore(cnString, dbName, pathFile);
            }
        }

        private void ConfigurarLoad()
        {
            try
            {
                if(Parameter.EnableRestore != Estado.IdActivo)
                {
                    btnRestore.Enabled = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo configurar el load. "+e.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Eventos de ventana

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();

            if (Directory.Exists(FilePath.BackupPath))
                folderDialog.SelectedPath = FilePath.BackupPath;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocationBackup.Text = folderDialog.SelectedPath;
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtLocationBackup.Text))
            {
                if (Connection.ConnectionTest())
                {
                    try
                    {
                        if (Backup(txtLocationBackup.Text))
                            MessageBox.Show("El Backup se completó exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se pudo realizar el Backup.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Ocurrió una excepción cuando se intentaba procesar el Backup. " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede realizar el Backup.\n.La conexión es incorrecta o no está disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La ruta no existe. Verifique y vuelva a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBrowseBackup.Focus();
            }
        }
        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Backup Files(*.bak)|*.bak";
            openFile.FilterIndex = 0;

            if (Directory.Exists(FilePath.BackupPath))
                openFile.InitialDirectory = FilePath.BackupPath;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtLocationRestore.Text = openFile.FileName;
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtLocationRestore.Text))
            {
                if (Connection.ConnectionTest())
                {
                    try
                    {
                        if (MessageBox.Show("¿Estás seguro de restaurar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (Restore(txtLocationRestore.Text))
                                MessageBox.Show("La restauración se completó exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo realizar la restauración.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Ocurrió una excepción cuando se intentaba resturar. " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede realizar la restauración.\nLa conexión es incorrecta o no está disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La ruta del archivo no existe o es incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBrowseRestore.Focus();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        private void FormBackupRestore_Load(object sender, EventArgs e)
        {
            ConfigurarLoad();
        }
    }
}

