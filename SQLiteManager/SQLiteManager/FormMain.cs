using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteManager
{
    public partial class FormMain : Form
    {
        public List<string> listDbPath;

        public FormMain()
        {
            listDbPath = new List<string>();
            InitializeComponent();
        }

        private void EventCreateDb(object sender, EventArgs eventArgs)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            SQLiteConnection.CreateFile(saveFileDialog.FileName);
            MessageBox.Show(@"Database successfuly created!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            menuItemCreate.Click += EventCreateDb;
            toolBtnCreateDB.Click += EventCreateDb;
        }

        private void EventConnection(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {
                Filter = @"SQL Database(*.db)|*.db|All Files(*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var connectionString = $"Data Source={openFileDialog.FileName}; Version=3";
            var connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                if (openFileDialog.FileName == null) return;

                string fileName = Path.GetFileName(openFileDialog.FileName);
                listDbPath.Add(openFileDialog.FileName);

                toolStripSelectedDB.Items.Add(fileName);
                toolStripSelectedDB.SelectedItem = fileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Connection to \"{openFileDialog.FileName}\" is failed.");
            }
            finally
            {
                connection.Close();
            }
        }

        private void toolStripSelectedDB_Click(object sender, EventArgs e)
        {

        }
    }
}
