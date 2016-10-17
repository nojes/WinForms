using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.DataLayer.BusinessLayer;
using Shop.DataLayer.DbLayer;

namespace Shop.WinForm
{
    public partial class Form1 : Form
    {
        ShopContext context;

        BindingSource categories;
        BindingSource goods;

        private string defaultImage = "images/product.png";

        public Form1()
        {
            context = new ShopContext();
            categories = new BindingSource();
            goods = new BindingSource();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Categories.Load();
            context.Goods.Load();

            RenderCategories();
            RenderGoods();
        }

        private void RenderGoods()
        {
            int categotyId = Convert.ToInt32(lbCategories.SelectedValue);
            goods.DataSource = context.Goods.Local.Where(g => g.CategoryId == categotyId);

            lbGoods.DisplayMember = "GoodName";
            lbGoods.ValueMember = "GoodId";
            lbGoods.DataSource = goods;

            int goodsCount = context.Goods.Local.Count(g => g.CategoryId == categotyId);
            gBoxGoods.Visible = (goodsCount > 0);
            gBoxGoodInfo.Visible = (goodsCount > 0);
            btnAddToCart.Visible = (goodsCount > 0);
        }

        private void RenderCategories()
        {
            categories.DataSource = context.Categories.Local;
            lbCategories.DisplayMember = "CategoryName";
            lbCategories.ValueMember = "CategoryId";
            lbCategories.DataSource = categories;
        }


        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderGoods();
        }

        private GoodInfo getGoodInfo(int goodId)
        {
            SqlParameter sqlParameter = new SqlParameter("@GoodId", goodId);

//            var query = context.Database.SqlQuery<GoodInfo>(
//                "SELECT TOP 1 g.GoodId, g.GoodName," +
//                "CASE" +
//                    "WHEN m.ManufacturerName IS NULL THEN 'Не задано'" +
//                    "ELSE m.ManufacturerName" +
//                "END ManufacturerName," +
//                "g.Price, g.GoodCount," +
//                "CASE" +
//                    $"WHEN p.PhotoPath IS NULL THEN '{defaultImage}'" +
//                    "ELSE p.PhotoPath" +
//                "END PhotoPath" +
//                "FROM dbo.Good g " +
//                "LEFT JOIN dbo.Manufacturer m ON g.ManufacturerId = m.ManufacturerId" +
//                    "LEFT JOIN dbo.Photo p ON(g.GoodId = p.GoodId)" +
//                "WHERE g.GoodId = @GoodId", sqlParameter
//            );

            var query = context.Database.SqlQuery<GoodInfo>(
                @"SELECT TOP 1 g.GoodId, g.GoodName, 
                CASE
                    WHEN m.ManufacturerName IS NULL THEN 'Не задано'
                    ELSE m.ManufacturerName
                END ManufacturerName,
                g.Price, g.GoodCount,
                CASE
                    WHEN p.PhotoPath IS NULL THEN 'images/product.png'
                    ELSE p.PhotoPath
                END PhotoPath
                FROM dbo.Good g
                    LEFT JOIN dbo.Manufacturer m ON g.ManufacturerId = m.ManufacturerId
                    LEFT JOIN dbo.Photo p ON(g.GoodId = p.GoodId)
                WHERE g.GoodId = @GoodId", sqlParameter
            );

            GoodInfo goodInfo = query.FirstOrDefault();
            return goodInfo;
        }

        private void lbGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            int goodId = Convert.ToInt32(lbGoods.SelectedValue);
            GoodInfo goodInfo = getGoodInfo(goodId);

            labelName.Text = goodInfo.GoodName;
            labelCount.Text = goodInfo.GoodCount.ToString();
            labelManufacturer.Text = goodInfo.ManufacturerName;
            labelPrice.Text = goodInfo.Price.ToString();

            Image image = Image.FromFile(goodInfo.PhotoPath);

            pictureGood.Image = image;
        }
    }
}
