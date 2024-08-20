using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP.Stocks
{
    public partial class ViewStockForm : Form
    {
        db_view vData = new db_view();

        public ViewStockForm()
        {
            InitializeComponent();
            filterByBrand.SelectedIndexChanged += filterByBrand_SelectedIndexChanged;
            filterByCategory.SelectedIndexChanged += filterByCategory_SelectedIndexChanged;
            btnSearchStock.Click += btnSearchStock_Click;
            btnClearSearch.Click += btnClearSearch_Click;
        }

        private void ViewStockForm_Load(object sender, EventArgs e)
        {
            vData.view_table(dgvStock, CLSStock.select_stock);
            PopulateBrandComboBox();
            filterByBrand.SelectedValue = "All";
            filterByBrand_SelectedIndexChanged(this, EventArgs.Empty);
            PopulateCategoryComboBox();
            filterByCategory.SelectedValue = "All";
            filterByCategory_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void PopulateBrandComboBox()
        {
            string query = "SELECT DISTINCT brand_name FROM production.brands";
            DataTable brands = vData.data_table(query);

            // Add "All" option
            DataRow allRow = brands.NewRow();
            allRow["brand_name"] = "All";
            brands.Rows.InsertAt(allRow, 0);

            filterByBrand.DataSource = brands;
            filterByBrand.DisplayMember = "brand_name";
            filterByBrand.ValueMember = "brand_name";
        }

        private void PopulateCategoryComboBox()
        {
            string query = "SELECT DISTINCT category_name FROM production.categories";
            DataTable categories = vData.data_table(query);

            // Add "All" option
            DataRow allRow = categories.NewRow();
            allRow["category_name"] = "All";
            categories.Rows.InsertAt(allRow, 0);

            filterByCategory.DataSource = categories;
            filterByCategory.DisplayMember = "category_name";
            filterByCategory.ValueMember = "category_name";
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void filterByBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterStockData();
        }

        private void filterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterStockData();
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            FilterStockData();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchStock.Clear();
            filterByBrand.SelectedValue = "All";
            filterByCategory.SelectedValue = "All";
            FilterStockData();
        }

        private void FilterStockData()
        {
            string selectedBrand = filterByBrand.SelectedValue?.ToString();
            string selectedCategory = filterByCategory.SelectedValue?.ToString();
            string searchTerm = txtSearchStock.Text.Trim();
            string query = CLSStock.select_stock;

            if (selectedBrand != "All" && selectedCategory != "All")
            {
                query = CLSStock.select_brand_and_category
                    .Replace("@BrandName", $"'{selectedBrand}'")
                    .Replace("@CategoryName", $"'{selectedCategory}'");
            }
            else if (selectedBrand != "All")
            {
                query = CLSStock.select_brand.Replace("@BrandName", $"'{selectedBrand}'");
            }
            else if (selectedCategory != "All")
            {
                query = CLSStock.select_category.Replace("@CategoryName", $"'{selectedCategory}'");
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += $" AND pp.product_name LIKE '%{searchTerm}%'";
            }

            vData.view_table(dgvStock, query);
        }
    }
}
