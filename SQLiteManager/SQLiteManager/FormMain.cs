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

        public List<DatabaseFile> databases;
        public DatabaseFile currentDbFile;

        private string connectionString;

        private DataTable tables;
        private DataTable columns;

        public FormMain()
        {
            listDbPath = new List<string>();
            currentDbFile = new DatabaseFile();
            databases = new List<DatabaseFile>();

            tables = new DataTable();
            columns = new DataTable();

            renderTree();

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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                connectionString = $"Data Source={openFileDialog.FileName}; Version=3";
                try
                {
                    if (openFileDialog.FileName != null) {
                        var dbFile = new DatabaseFile(openFileDialog.FileName);
                        databases.Add(dbFile);
                        currentDbFile = dbFile;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Connection to \"{openFileDialog.FileName}\" is failed.");
                }
            }

            GetSchema();

            renderTree();
            renderToolstrip();
        }

        private void renderTree()
        {
            TreeNode treeNode = new TreeNode("test");

//            treeDatabases.Nodes.Add(treeNode);
        }

        private void renderToolstrip()
        {
            toolStripSelectedDB.Items.Add(currentDbFile.fileName);
            toolStripSelectedDB.SelectedItem = currentDbFile.fileName;
        }

        private void GetSchema()
        {
            using (var connection = new SQLiteConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                tables = connection.GetSchema("Tables");
                columns = connection.GetSchema("Columns");
            }
        }

        private void toolStripSelectedDB_Click(object sender, EventArgs e)
        {

        }
    }
}
