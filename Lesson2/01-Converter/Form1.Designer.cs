namespace _01_Converter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioC_F = new System.Windows.Forms.RadioButton();
            this.radioF_C = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputC = new System.Windows.Forms.TextBox();
            this.inputF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.btnHistoryReset = new System.Windows.Forms.Button();
            this.btnHistoryDisplay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioC_F);
            this.groupBox1.Controls.Add(this.radioF_C);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputC);
            this.groupBox1.Controls.Add(this.inputF);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Индикация";
            // 
            // radioC_F
            // 
            this.radioC_F.AutoSize = true;
            this.radioC_F.Location = new System.Drawing.Point(172, 42);
            this.radioC_F.Name = "radioC_F";
            this.radioC_F.Size = new System.Drawing.Size(53, 17);
            this.radioC_F.TabIndex = 5;
            this.radioC_F.TabStop = true;
            this.radioC_F.Text = "C -> F";
            this.radioC_F.UseVisualStyleBackColor = true;
            // 
            // radioF_C
            // 
            this.radioF_C.AutoSize = true;
            this.radioF_C.Checked = true;
            this.radioF_C.Location = new System.Drawing.Point(172, 19);
            this.radioF_C.Name = "radioF_C";
            this.radioF_C.Size = new System.Drawing.Size(53, 17);
            this.radioF_C.TabIndex = 4;
            this.radioF_C.TabStop = true;
            this.radioF_C.Text = "F -> C";
            this.radioF_C.UseVisualStyleBackColor = true;
            this.radioF_C.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F:";
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(275, 39);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(60, 20);
            this.inputC.TabIndex = 1;
            this.inputC.TextChanged += new System.EventHandler(this.inputC_TextChanged);
            this.inputC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputC_KeyPress);
            // 
            // inputF
            // 
            this.inputF.Location = new System.Drawing.Point(67, 39);
            this.inputF.Name = "inputF";
            this.inputF.Size = new System.Drawing.Size(60, 20);
            this.inputF.TabIndex = 0;
            this.inputF.TextChanged += new System.EventHandler(this.inputF_TextChanged);
            this.inputF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputF_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(234, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(115, 19);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxHistory);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "История";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(7, 20);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(403, 105);
            this.textBoxHistory.TabIndex = 0;
            // 
            // btnHistoryReset
            // 
            this.btnHistoryReset.Location = new System.Drawing.Point(233, 19);
            this.btnHistoryReset.Name = "btnHistoryReset";
            this.btnHistoryReset.Size = new System.Drawing.Size(75, 23);
            this.btnHistoryReset.TabIndex = 1;
            this.btnHistoryReset.Text = "Reset";
            this.btnHistoryReset.UseVisualStyleBackColor = true;
            this.btnHistoryReset.Click += new System.EventHandler(this.btnHistoryReset_Click);
            // 
            // btnHistoryDisplay
            // 
            this.btnHistoryDisplay.Location = new System.Drawing.Point(115, 19);
            this.btnHistoryDisplay.Name = "btnHistoryDisplay";
            this.btnHistoryDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnHistoryDisplay.TabIndex = 0;
            this.btnHistoryDisplay.Text = "Display";
            this.btnHistoryDisplay.UseVisualStyleBackColor = true;
            this.btnHistoryDisplay.Click += new System.EventHandler(this.btnHistoryDisplay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHistoryReset);
            this.groupBox4.Controls.Add(this.btnHistoryDisplay);
            this.groupBox4.Location = new System.Drawing.Point(13, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 57);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление историей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 430);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.TextBox inputF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioC_F;
        private System.Windows.Forms.RadioButton radioF_C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistoryReset;
        private System.Windows.Forms.Button btnHistoryDisplay;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

