namespace HumanResources
{
    partial class MainForm
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
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.EmployeeInfo = new System.Windows.Forms.GroupBox();
            this.tabEmployeeJob = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureEmployeePhoto = new System.Windows.Forms.PictureBox();
            this.datePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelINN = new System.Windows.Forms.Label();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabEmployeePromotion = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxEmployee.SuspendLayout();
            this.EmployeeInfo.SuspendLayout();
            this.tabEmployeeJob.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmployeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.listEmployees);
            this.groupBoxEmployee.Controls.Add(this.btnFind);
            this.groupBoxEmployee.Controls.Add(this.textBoxFind);
            this.groupBoxEmployee.Location = new System.Drawing.Point(13, 13);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(213, 398);
            this.groupBoxEmployee.TabIndex = 0;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee";
            // 
            // listEmployees
            // 
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.Location = new System.Drawing.Point(7, 48);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(200, 342);
            this.listEmployees.TabIndex = 2;
            this.listEmployees.SelectedValueChanged += new System.EventHandler(this.listEmployees_SelectedValueChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(132, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(6, 21);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(120, 20);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Controls.Add(this.tabEmployeeJob);
            this.EmployeeInfo.Location = new System.Drawing.Point(233, 13);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(483, 398);
            this.EmployeeInfo.TabIndex = 1;
            this.EmployeeInfo.TabStop = false;
            this.EmployeeInfo.Text = "Employee Info";
            this.EmployeeInfo.TabIndexChanged += new System.EventHandler(this.EmployeeInfo_TabIndexChanged);
            // 
            // tabEmployeeJob
            // 
            this.tabEmployeeJob.Controls.Add(this.tabEmployee);
            this.tabEmployeeJob.Controls.Add(this.tabEmployeePromotion);
            this.tabEmployeeJob.Controls.Add(this.tabPage1);
            this.tabEmployeeJob.Location = new System.Drawing.Point(7, 20);
            this.tabEmployeeJob.Name = "tabEmployeeJob";
            this.tabEmployeeJob.SelectedIndex = 0;
            this.tabEmployeeJob.Size = new System.Drawing.Size(470, 370);
            this.tabEmployeeJob.TabIndex = 0;
            this.tabEmployeeJob.TabIndexChanged += new System.EventHandler(this.tabEmployeeJob_TabIndexChanged);
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnSave);
            this.tabEmployee.Controls.Add(this.pictureEmployeePhoto);
            this.tabEmployee.Controls.Add(this.datePickerBirthDate);
            this.tabEmployee.Controls.Add(this.labelBirthDate);
            this.tabEmployee.Controls.Add(this.labelINN);
            this.tabEmployee.Controls.Add(this.textBoxINN);
            this.tabEmployee.Controls.Add(this.labelLastName);
            this.tabEmployee.Controls.Add(this.textBoxLastName);
            this.tabEmployee.Controls.Add(this.labelFirstName);
            this.tabEmployee.Controls.Add(this.textBoxFirstName);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(462, 344);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureEmployeePhoto
            // 
            this.pictureEmployeePhoto.Location = new System.Drawing.Point(266, 24);
            this.pictureEmployeePhoto.Name = "pictureEmployeePhoto";
            this.pictureEmployeePhoto.Size = new System.Drawing.Size(158, 199);
            this.pictureEmployeePhoto.TabIndex = 9;
            this.pictureEmployeePhoto.TabStop = false;
            // 
            // datePickerBirthDate
            // 
            this.datePickerBirthDate.Location = new System.Drawing.Point(18, 203);
            this.datePickerBirthDate.Name = "datePickerBirthDate";
            this.datePickerBirthDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerBirthDate.TabIndex = 8;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(15, 187);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(55, 13);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "Birth date:";
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(15, 129);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(29, 13);
            this.labelINN.TabIndex = 5;
            this.labelINN.Text = "INN:";
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(18, 145);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(200, 20);
            this.textBoxINN.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(15, 78);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(18, 94);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(15, 24);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(18, 40);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // tabEmployeePromotion
            // 
            this.tabEmployeePromotion.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeePromotion.Name = "tabEmployeePromotion";
            this.tabEmployeePromotion.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeePromotion.Size = new System.Drawing.Size(462, 344);
            this.tabEmployeePromotion.TabIndex = 1;
            this.tabEmployeePromotion.Text = "Promotion";
            this.tabEmployeePromotion.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 344);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 423);
            this.Controls.Add(this.EmployeeInfo);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.EmployeeInfo.ResumeLayout(false);
            this.tabEmployeeJob.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmployeePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxEmployee;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox textBoxFind;
        public System.Windows.Forms.ListBox listEmployees;
        public System.Windows.Forms.GroupBox EmployeeInfo;
        public System.Windows.Forms.TabControl tabEmployeeJob;
        public System.Windows.Forms.TabPage tabEmployee;
        public System.Windows.Forms.TabPage tabEmployeePromotion;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label labelFirstName;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.Label labelBirthDate;
        public System.Windows.Forms.Label labelINN;
        public System.Windows.Forms.TextBox textBoxINN;
        public System.Windows.Forms.Label labelLastName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.DateTimePicker datePickerBirthDate;
        public System.Windows.Forms.PictureBox pictureEmployeePhoto;
        private System.Windows.Forms.Button btnSave;
    }
}

