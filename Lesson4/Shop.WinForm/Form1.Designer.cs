namespace Shop.WinForm
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
            this.gBoxCategories = new System.Windows.Forms.GroupBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.gBoxGoods = new System.Windows.Forms.GroupBox();
            this.lbGoods = new System.Windows.Forms.ListBox();
            this.gBoxGoodInfo = new System.Windows.Forms.GroupBox();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.gBoxCategories.SuspendLayout();
            this.gBoxGoods.SuspendLayout();
            this.gBoxGoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxCategories
            // 
            this.gBoxCategories.Controls.Add(this.lbCategories);
            this.gBoxCategories.Location = new System.Drawing.Point(12, 12);
            this.gBoxCategories.Name = "gBoxCategories";
            this.gBoxCategories.Size = new System.Drawing.Size(200, 206);
            this.gBoxCategories.TabIndex = 0;
            this.gBoxCategories.TabStop = false;
            this.gBoxCategories.Text = "Категории";
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(7, 20);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(187, 173);
            this.lbCategories.TabIndex = 0;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            // 
            // gBoxGoods
            // 
            this.gBoxGoods.Controls.Add(this.lbGoods);
            this.gBoxGoods.Location = new System.Drawing.Point(218, 12);
            this.gBoxGoods.Name = "gBoxGoods";
            this.gBoxGoods.Size = new System.Drawing.Size(282, 206);
            this.gBoxGoods.TabIndex = 1;
            this.gBoxGoods.TabStop = false;
            this.gBoxGoods.Text = "Товары";
            // 
            // lbGoods
            // 
            this.lbGoods.FormattingEnabled = true;
            this.lbGoods.Location = new System.Drawing.Point(7, 19);
            this.lbGoods.Name = "lbGoods";
            this.lbGoods.Size = new System.Drawing.Size(268, 173);
            this.lbGoods.TabIndex = 1;
            this.lbGoods.SelectedIndexChanged += new System.EventHandler(this.lbGoods_SelectedIndexChanged);
            // 
            // gBoxGoodInfo
            // 
            this.gBoxGoodInfo.Controls.Add(this.pictureGood);
            this.gBoxGoodInfo.Controls.Add(this.labelManufacturer);
            this.gBoxGoodInfo.Controls.Add(this.labelCount);
            this.gBoxGoodInfo.Controls.Add(this.labelPrice);
            this.gBoxGoodInfo.Controls.Add(this.labelName);
            this.gBoxGoodInfo.Location = new System.Drawing.Point(12, 225);
            this.gBoxGoodInfo.Name = "gBoxGoodInfo";
            this.gBoxGoodInfo.Size = new System.Drawing.Size(488, 148);
            this.gBoxGoodInfo.TabIndex = 2;
            this.gBoxGoodInfo.TabStop = false;
            this.gBoxGoodInfo.Text = "Информация о товаре";
            // 
            // pictureGood
            // 
            this.pictureGood.Location = new System.Drawing.Point(271, 10);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(210, 132);
            this.pictureGood.TabIndex = 4;
            this.pictureGood.TabStop = false;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(16, 59);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelManufacturer.TabIndex = 3;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(16, 114);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(35, 13);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Count";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(16, 87);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(367, 379);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(133, 29);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 474);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gBoxGoodInfo);
            this.Controls.Add(this.gBoxGoods);
            this.Controls.Add(this.gBoxCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxCategories.ResumeLayout(false);
            this.gBoxGoods.ResumeLayout(false);
            this.gBoxGoodInfo.ResumeLayout(false);
            this.gBoxGoodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCategories;
        private System.Windows.Forms.GroupBox gBoxGoods;
        private System.Windows.Forms.GroupBox gBoxGoodInfo;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.ListBox lbGoods;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.PictureBox pictureGood;
    }
}

