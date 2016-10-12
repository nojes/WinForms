namespace _01_CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textSum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboCurrency = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCurrencyRUB = new System.Windows.Forms.TextBox();
            this.textCurrencyEUR = new System.Windows.Forms.TextBox();
            this.textCurrencyUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRUB = new System.Windows.Forms.TextBox();
            this.textEUR = new System.Windows.Forms.TextBox();
            this.textUSD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioSell = new System.Windows.Forms.RadioButton();
            this.radioBuy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(8, 22);
            this.textSum.Margin = new System.Windows.Forms.Padding(4);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(119, 21);
            this.textSum.TabIndex = 0;
            this.textSum.TextChanged += new System.EventHandler(this.textSum_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCurrency);
            this.groupBox1.Controls.Add(this.textSum);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(224, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сумма";
            // 
            // comboCurrency
            // 
            this.comboCurrency.FormattingEnabled = true;
            this.comboCurrency.Items.AddRange(new object[] {
            "UAN",
            "USD",
            "EUR",
            "RUB"});
            this.comboCurrency.Location = new System.Drawing.Point(149, 22);
            this.comboCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.comboCurrency.Name = "comboCurrency";
            this.comboCurrency.Size = new System.Drawing.Size(64, 23);
            this.comboCurrency.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCurrencyRUB);
            this.groupBox2.Controls.Add(this.textCurrencyEUR);
            this.groupBox2.Controls.Add(this.textCurrencyUSD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textRUB);
            this.groupBox2.Controls.Add(this.textEUR);
            this.groupBox2.Controls.Add(this.textUSD);
            this.groupBox2.Location = new System.Drawing.Point(14, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(223, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // textCurrencyRUB
            // 
            this.textCurrencyRUB.Location = new System.Drawing.Point(163, 82);
            this.textCurrencyRUB.Name = "textCurrencyRUB";
            this.textCurrencyRUB.Size = new System.Drawing.Size(50, 21);
            this.textCurrencyRUB.TabIndex = 8;
            // 
            // textCurrencyEUR
            // 
            this.textCurrencyEUR.Location = new System.Drawing.Point(162, 52);
            this.textCurrencyEUR.Name = "textCurrencyEUR";
            this.textCurrencyEUR.Size = new System.Drawing.Size(50, 21);
            this.textCurrencyEUR.TabIndex = 7;
            // 
            // textCurrencyUSD
            // 
            this.textCurrencyUSD.Location = new System.Drawing.Point(162, 22);
            this.textCurrencyUSD.Name = "textCurrencyUSD";
            this.textCurrencyUSD.Size = new System.Drawing.Size(50, 21);
            this.textCurrencyUSD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(115, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RUB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(115, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "USD";
            // 
            // textRUB
            // 
            this.textRUB.Location = new System.Drawing.Point(7, 82);
            this.textRUB.Margin = new System.Windows.Forms.Padding(4);
            this.textRUB.Name = "textRUB";
            this.textRUB.Size = new System.Drawing.Size(92, 21);
            this.textRUB.TabIndex = 2;
            // 
            // textEUR
            // 
            this.textEUR.Location = new System.Drawing.Point(7, 52);
            this.textEUR.Margin = new System.Windows.Forms.Padding(4);
            this.textEUR.Name = "textEUR";
            this.textEUR.Size = new System.Drawing.Size(92, 21);
            this.textEUR.TabIndex = 1;
            // 
            // textUSD
            // 
            this.textUSD.Location = new System.Drawing.Point(7, 22);
            this.textUSD.Margin = new System.Windows.Forms.Padding(4);
            this.textUSD.Name = "textUSD";
            this.textUSD.Size = new System.Drawing.Size(92, 21);
            this.textUSD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioSell);
            this.groupBox3.Controls.Add(this.radioBuy);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Я хочу";
            // 
            // radioSell
            // 
            this.radioSell.AutoSize = true;
            this.radioSell.Location = new System.Drawing.Point(119, 20);
            this.radioSell.Name = "radioSell";
            this.radioSell.Size = new System.Drawing.Size(76, 19);
            this.radioSell.TabIndex = 6;
            this.radioSell.Text = "Продать";
            this.radioSell.UseVisualStyleBackColor = true;
            // 
            // radioBuy
            // 
            this.radioBuy.AutoSize = true;
            this.radioBuy.Checked = true;
            this.radioBuy.Location = new System.Drawing.Point(34, 20);
            this.radioBuy.Name = "radioBuy";
            this.radioBuy.Size = new System.Drawing.Size(66, 19);
            this.radioBuy.TabIndex = 5;
            this.radioBuy.TabStop = true;
            this.radioBuy.Text = "Купить";
            this.radioBuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 270);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCurrencyRUB;
        private System.Windows.Forms.TextBox textCurrencyEUR;
        private System.Windows.Forms.TextBox textCurrencyUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioSell;
        private System.Windows.Forms.RadioButton radioBuy;
        private System.Windows.Forms.TextBox textUSD;
        private System.Windows.Forms.TextBox textEUR;
        private System.Windows.Forms.TextBox textRUB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboCurrency;
    }
}

