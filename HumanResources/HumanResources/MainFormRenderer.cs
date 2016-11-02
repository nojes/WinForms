using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataLayer.DbLayer;

namespace HumanResources
{
    public class MainFormRenderer : FormRendererBase
    {
        private MainForm form;

        public MainFormRenderer(MainForm form)
        {
            this.form = form;
        }

        public void RenderEmployeesList()
        {
//            form.bsEmployees.DataSource = form.context.Employees.Local;

            form.listEmployees.Update();
            form.listEmployees.ValueMember = "EmployeeId";
            form.listEmployees.DisplayMember = "FirstName";
            form.listEmployees.DataSource = form.bsEmployees.DataSource;
        }

        public void RenderEmployeesList(IEnumerable<Employee> employees)
        {
            form.listEmployees.ValueMember = "EmployeeId";
            form.listEmployees.DisplayMember = "FirstName";
            form.listEmployees.DataSource = employees.ToList();
        }

        public void RenderEmployeeInfo()
        {
            int employeeId = Convert.ToInt32(form.listEmployees.SelectedValue);
            var currentEmployee = form.context.Employees.Local.FirstOrDefault(eml => eml.EmployeeId == employeeId);

            if (currentEmployee != null)
            {
                form.textBoxFirstName.Text = currentEmployee.FirstName;
                form.textBoxLastName.Text = currentEmployee.LastName;
                form.textBoxINN.Text = currentEmployee.INN;
                form.datePickerBirthDate.Text = currentEmployee.DateBirthday.ToString();
            }
        }
    }
}