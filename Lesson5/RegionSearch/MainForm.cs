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

namespace RegionSearch
{
    public partial class MainForm : Form
    {
        RegionContext context;

        BindingSource bsRegions;
        BindingSource bsCities;

        public MainForm(string connectString)
        {
            context = new RegionContext(connectString);
            bsRegions = new BindingSource();
            bsCities = new BindingSource();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Regions.Include(c => c.Cities).Load();

            RenderRegions();
            RenderCities();
        }

        private void RenderRegions()
        {
            bsRegions.DataSource = context.Regions.Local;
            cbRegions.DisplayMember = "RegionName";
            cbRegions.ValueMember = "RegionId";
            cbRegions.DataSource = bsRegions;
        }

        private void RenderCities()
        {
            int regionId = cbRegions.SelectedIndex;
            string cityName = inputCity.Text;

            if (cityName.Length == 0) {
                bsCities.DataSource = context.Cities
                    .Where(c => c.RegionId == regionId)
                    .ToList();
            }
            else {
                bsCities.DataSource = context.Cities
                    .Where(c => c.RegionId == regionId && c.CityName.Contains(cityName))
                    .ToList();
            }

            dgvCities.DataSource = bsCities.DataSource;
            dgvCities.Columns["CityId"].Width = 50;
            dgvCities.Columns["CityName"].Width = 250;

            if (dgvCities.Columns["RegionId"] != null) dgvCities.Columns["RegionId"].Visible = false;
            if (dgvCities.Columns["Region"] != null) dgvCities.Columns["Region"].Visible = false;
        }

        private void cbRegions_SelectedValueChanged(object sender, EventArgs e)
        {
            RenderCities();
        }

        private void inputCity_TextChanged(object sender, EventArgs e)
        {
            RenderCities();
        }
    }
}
