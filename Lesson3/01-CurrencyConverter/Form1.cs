using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CurrencyConverter
{
    public partial class Form1 : Form
    {
        private double sum;

        private double UAN;
        private double EUR;
        private double USD;
        private double RUB;

        private double currencyUSD;
        private double currencyUAN;
        private double currencyRUB;
        private double currencyEUR;

        public Form1()
        {
            InitializeComponent();

            currencyUSD = 25.851713;
            currencyRUB = 0.415660;
            currencyEUR = 28.641113;
            comboCurrency.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textCurrencyEUR.Text = currencyEUR.ToString();
            textCurrencyUSD.Text = currencyUSD.ToString();
            textCurrencyRUB.Text = currencyRUB.ToString();
        }

        private void textSum_TextChanged(object sender, EventArgs e)
        {
            if (textSum.Text.Length != 0) {
                Read();
                Calc();
                Render();
            } else {
                Reset();
            }
        }

        private void Read()
        {
            sum = Convert.ToDouble(textSum.Text);
        }

        private void Calc()
        {
            USD = sum / currencyUSD;
            EUR = sum / currencyEUR;
            RUB = sum / currencyRUB;
        }

        private void Render()
        {
            textUSD.Text = USD.ToString();
            textEUR.Text = EUR.ToString();
            textRUB.Text = RUB.ToString();
        }

        private void Reset()
        {
            textUSD.Text = "";
            textEUR.Text = "";
            textRUB.Text = "";
        }
    }
}
