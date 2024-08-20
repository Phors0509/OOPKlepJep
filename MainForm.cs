using MultiForm.Items;
using OOP.Employee;
using OOP.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_create_employee fremp = new frm_create_employee();
            fremp.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People.Customer.frm_create_customer fccustomer = new People.Customer.frm_create_customer();
            fccustomer.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People.Sale.frm_create_sale fcsale = new People.Sale.frm_create_sale(); 
            fcsale.Show();
        }

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_item_brand frm_Item_Brand = new frm_item_brand();
            frm_Item_Brand.Show();
        }

        private void itemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_item_category frm_Item_Category = new frm_item_category();
            frm_Item_Category.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_create_item frm_Create_Item = new frm_create_item();
            frm_Create_Item.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_item_brand frm_Item_Brand2 = new frm_item_brand();
            frm_Item_Brand2.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_item_category frm_Item_Category2 = new frm_item_category(); 
            frm_Item_Category2.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ViewStockForm viewStockForm = new ViewStockForm();
            viewStockForm.Show();

        }
    }
}
