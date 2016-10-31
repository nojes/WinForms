namespace _01_InformationSchema
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
            this.components = new System.ComponentModel.Container();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.tabPageColumns = new System.Windows.Forms.TabPage();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.tabPageDDL = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.textDDL = new System.Windows.Forms.RichTextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabControlData.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.tabPageColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.tabPageData.SuspendLayout();
            this.tabPageDDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPageTable);
            this.tabControlData.Controls.Add(this.tabPageColumns);
            this.tabControlData.Controls.Add(this.tabPageData);
            this.tabControlData.Controls.Add(this.tabPageDDL);
            this.tabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlData.Location = new System.Drawing.Point(0, 0);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(696, 380);
            this.tabControlData.TabIndex = 0;
            this.tabControlData.SelectedIndexChanged += new System.EventHandler(this.tabControlTables_SelectedIndexChanged);
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dgvTables);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(688, 354);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Tables";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // tabPageColumns
            // 
            this.tabPageColumns.Controls.Add(this.dgvColumns);
            this.tabPageColumns.Location = new System.Drawing.Point(4, 22);
            this.tabPageColumns.Name = "tabPageColumns";
            this.tabPageColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageColumns.Size = new System.Drawing.Size(688, 354);
            this.tabPageColumns.TabIndex = 1;
            this.tabPageColumns.Text = "Columns";
            this.tabPageColumns.UseVisualStyleBackColor = true;
            // 
            // dgvColumns
            // 
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumns.Location = new System.Drawing.Point(3, 3);
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.ReadOnly = true;
            this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColumns.Size = new System.Drawing.Size(682, 348);
            this.dgvColumns.TabIndex = 0;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dgvData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(688, 354);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // tabPageDDL
            // 
            this.tabPageDDL.Controls.Add(this.textDDL);
            this.tabPageDDL.Location = new System.Drawing.Point(4, 22);
            this.tabPageDDL.Name = "tabPageDDL";
            this.tabPageDDL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDDL.Size = new System.Drawing.Size(688, 354);
            this.tabPageDDL.TabIndex = 3;
            this.tabPageDDL.Text = "DDL";
            this.tabPageDDL.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTables.Location = new System.Drawing.Point(3, 3);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(682, 348);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
            // 
            // textDDL
            // 
            this.textDDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDDL.Location = new System.Drawing.Point(3, 3);
            this.textDDL.Name = "textDDL";
            this.textDDL.Size = new System.Drawing.Size(682, 348);
            this.textDDL.TabIndex = 0;
            this.textDDL.Text = "";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(7, 7);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(240, 150);
            this.dgvData.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 380);
            this.Controls.Add(this.tabControlData);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlData.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.tabPageColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.tabPageData.ResumeLayout(false);
            this.tabPageDDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageColumns;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageDDL;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.RichTextBox textDDL;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

