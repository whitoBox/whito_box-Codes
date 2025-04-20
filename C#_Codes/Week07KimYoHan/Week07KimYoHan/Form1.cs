using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07KimYoHan
{
    public partial class Form1: Form
    {
        List<Product> Products;
        public Form1()
        {
            InitializeComponent();
            Products = new List<Product>();
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //이름
            if (true == string.IsNullOrEmpty(tbxInputProductName.Text))
            {
                return;
            }
            else
            {
                product.Name = tbxInputProductName.Text;
            }
            //가격
            if (true == string.IsNullOrEmpty(tbxInputProductPrice.Text))
            {
                return;
            }
            else if (false == int.TryParse(tbxInputProductPrice.Text.Trim(), out int _))
            {
                return;
            }
            else
            {
                product.Price = int.Parse(tbxInputProductPrice.Text.Trim());
            }

            //재고
            if (true == string.IsNullOrEmpty(tbxInputProductStock.Text))
            {
                return;
            }
            else if (false == int.TryParse(tbxInputProductStock.Text.Trim(), out int stock))
            {
                return;
            }
            else
            {
                product.Stock = int.Parse(tbxInputProductStock.Text.Trim());
            }
            //코드
            string code;
            Boolean IsSameCheck = false;
            do
            {
                code = DateTime.Now.ToString("yyyyMMdd") + new Random().Next(1000).ToString("D3");
                foreach(var Product in Products)
                {
                    if (code == product.Code)
                        IsSameCheck = true;
                }
            }
            while (IsSameCheck);
            product.Code = code;
            //등록날짜
            product.RegDate = DateTime.Now.AddDays(-(new Random().Next(20, 100)));

            Products.Add(product);
            MessageBox.Show("등록완료");
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            clearSerchBoxes();
            string serchText = tbxSerchNameCode.Text.Trim();
            foreach(var product in Products)
            {
                if ((product.Code.Contains(serchText)) || (product.Name.Contains(serchText)))
                {
                    lbxSerchProduct.Items.Add(product);
                }
            }
            if(lbxSerchProduct.Items.Count == 0)
            {
                MessageBox.Show("그런건 없어요");
            }
        }

        private void clearSerchBoxes()
        {
            lbxSerchProduct.Items.Clear();
            lblSerchProductName.Text = string.Empty;
            lblSerchProductCode.Text = string.Empty; 
            lblSerchProductPrice.Text = string.Empty;
            lblSerchProductSalePrice.Text = string.Empty;
            lblSerchProductStock.Text = string.Empty;
            lblSerchProductRegDate.Text = string.Empty;
            tbxSerchProductCount.Clear();
            lblSerchProductTotalPrice.Text = string.Empty;
        }

        private void lbxSerchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSerchProduct.SelectedItem == null)
                return;
            var target = lbxSerchProduct.SelectedItem as Product;
            lblSerchProductName.Text = target.Name;
            lblSerchProductCode.Text = target.Code;
            lblSerchProductPrice.Text = target.Price.ToString();
            lblSerchProductSalePrice.Text = target.SalePrice().ToString();
            lblSerchProductStock.Text = target.Stock.ToString();
            lblSerchProductRegDate.Text = target.RegDate.ToString("yyyy-MM-dd");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblSerchProductTotalPrice.Text = string.Empty;
            if(int.TryParse(tbxSerchProductCount.Text, out int count)){
               if(count < 0 || count > (lbxSerchProduct.SelectedItem as Product).Stock)
               {
                    return;
                }
                else
                {
                    int stocknum = int.Parse(tbxSerchProductCount.Text.Trim());
                    int num = (lbxSerchProduct.SelectedItem as Product).CalPrice(stocknum);
                    lblSerchProductTotalPrice.Text = num.ToString();    
                }
            }
        }
    }
}
