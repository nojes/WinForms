using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DbLayer;

namespace HumanResources
{
    public partial class MainForm : Form
    {
        public HumanContext context;

        public BindingSource bsEmployees;
        public BindingSource bsPromotions;
        public BindingSource bsJobs;

        private MainFormRenderer renderer;

        public MainForm()
        {
            context = new HumanContext();

            bsEmployees = new BindingSource();
            bsPromotions = new BindingSource();
            bsJobs = new BindingSource();

            renderer = new MainFormRenderer(this);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            context.Employees.Include(p => p.EmpPromotions).Load();

            bsEmployees.DataSource = context.Employees.Local.ToList();
            renderer.RenderEmployeesList();
        }

        private void tabEmployeeJob_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeInfo_TabIndexChanged(object sender, EventArgs e)
        { }

        private void listEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            renderer.RenderEmployeeInfo();
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(listEmployees.SelectedValue);
            var currentEmployee = context.Employees.Local.FirstOrDefault(eml => eml.EmployeeId == employeeId);

            currentEmployee.FirstName = textBoxFirstName.Text;
            currentEmployee.LastName = textBoxLastName.Text;
            currentEmployee.DateBirthday = Convert.ToDateTime(datePickerBirthDate.Text);

//            DbSet<Employee> employees = context.Employees;
//            var currentEmployee = employees.Find(employeeId);
//            currentEmployee.FirstName = textBoxFirstName.Text;

            context.SaveChanges();

            SearchEmployee();
        }

        private void SearchEmployee()
        {
            string findString = textBoxFind.Text.ToLower();

            var employees = context.Employees.Local
                .Where(em => em.ToString().ToLower().Contains(findString));

            renderer.RenderEmployeesList(employees);
        }
    }
}
