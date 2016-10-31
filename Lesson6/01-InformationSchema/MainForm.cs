using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_InformationSchema
{
    public partial class MainForm : Form
    {
        private string dbPath;
        private string dbName;
        private string dbExtension;

        private string connectionString;

        private DataTable tables;
        private DataTable columns;
        private DataTable data;

        private BindingSource bsTables;
        private BindingSource bsColumns;
        private BindingSource bsData;

        private SqlDataAdapter dataAdapter;

        public MainForm()
        {
            tables = new DataTable();
            columns = new DataTable();
            data = new DataTable();

            bsTables = new BindingSource();
            bsColumns = new BindingSource();
            bsData = new BindingSource();

            dbPath = "../../db";
            dbName = "book";
            dbExtension = "db";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = $"Data Source={dbPath}/{dbName}.{dbExtension}";
            try
            {
                GetSchema();

                bsTables.DataSource = tables;
                bsColumns.DataSource = columns;

                dgvTables.DataSource = bsTables.DataSource;
                dgvColumns.DataSource = bsColumns.DataSource;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void GetSchema()
        {
            //DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                tables = connection.GetSchema("Tables");
                columns = connection.GetSchema("Columns");
            }
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
//            DataRowView dataRowTable = bsTables.Current as DataRowView;
//            string filter = dataRowTable["TABLE_NAME"].ToString();
        }

        private void tabControlTables_SelectedIndexChanged(object sender, EventArgs e)
        {

//            dgvTables.Update();
//            bsTables.DataSource = dgvTables.DataSource;

            DataRowView dataRowTable = dgvTables.SelectedRows[0] as DataRowView;

            if (tabControlData.SelectedTab.Name == tabPageColumns.Name)
            {
                string filter = dataRowTable["TABLE_NAME"].ToString();
                bsColumns.Filter = $"TABLE_NAME='{filter}'";
            }

            if (tabControlData.SelectedTab.Name == tabPageDDL.Name)
            {
                string definition = dataRowTable["TABLE_DEFINITION"].ToString();

                textDDL.Clear();
                textDDL.Text = definition;
            }

            if (tabControlData.SelectedTab.Name == tabPageData.Name)
            {
                string table = dataRowTable["TABLE_NAME"].ToString();

                using (SQLiteConnection connection = new SQLiteConnection())
                {
                    string query = $"SELECT * FROM {table}";

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);

                    SQLiteCommandBuilder command = new SQLiteCommandBuilder(dataAdapter);
                    dataAdapter.InsertCommand = command.GetInsertCommand(true);
                    dataAdapter.UpdateCommand = command.GetUpdateCommand(true);
                    dataAdapter.DeleteCommand = command.GetDeleteCommand(true);

                    data.Clear();
                    dataAdapter.Fill(data);
                    bsData.DataSource = data;
                    dgvData.DataSource = bsData.DataSource;
                }
            }
        }
    }
}
