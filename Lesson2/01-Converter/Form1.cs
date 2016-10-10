using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputF_TextChanged(object sender, EventArgs e)
        {
            if (inputF.Text.Length == 0) {
                btnCalc.Enabled = false;
                btnReset.Enabled = true;
            }
            else
            {
                btnCalc.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void inputC_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioChecked()
        {
            if (inputF.Text.Length == 0)
            {
                btnCalc.Enabled = false;
                btnReset.Enabled = true;
            }
            else
            {
                btnCalc.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void ValidateNumberTextBox(TextBox input, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                if (input.Text.IndexOf(',') != -1 ||
                    input.Text.Length == 0)
                {
                    e.Handled = true;
                }
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (input.Text.IndexOf(',') != -1 ||
                    input.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }

            e.Handled = true;
        }

        private void inputF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumberTextBox(inputF, e);
        }
        private void inputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumberTextBox(inputC, e);
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            double F, C, res;
            if (radioF_C.Checked)
            {
                F = Convert.ToDouble(inputF.Text);
                C = (F - 32) * 5 / 9;
                inputC.Text = string.Format("{0:F}", C);
                textBoxHistory.Text = textBoxHistory.Text + string.Format("{0} C -> {1} F \r\n", inputC.Text, inputF.Text);
            }
            else
            {
                C = Convert.ToDouble(inputC.Text);
                F = 32 + C * 9 / 5;
                inputF.Text = string.Format("{0:F}", F);
                textBoxHistory.Text = textBoxHistory.Text + string.Format("{0} F -> {1} C \n", inputF.Text, inputC.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryReset_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioF_C.Checked) {
                inputF.Focus();
                inputF.ReadOnly = false;
                inputC.ReadOnly = true;

            } else {
                inputC.Focus();
                inputF.ReadOnly = true;
                inputC.ReadOnly = false;
            }
            inputF.Text = "";
            inputC.Text = "";
        }
    }
}
