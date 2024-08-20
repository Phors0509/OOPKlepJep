
using OOP;
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

namespace MultiForm.Items
{
    public partial class frm_item_category : Form
    {
        db_view vData = new db_view();
        public frm_item_category()
        {
            InitializeComponent();
        }

        private void btn_item_category_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbc = new SqlConnection(DBCON.db_address))
            {
                try
                {
                    dbc.Open();
                    // Check if the category name already exists
                    string checkQuery = "SELECT COUNT(*) FROM production.categories WHERE category_name = @category_name";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, dbc))
                    {
                        checkCmd.Parameters.AddWithValue("@category_name", txt_category_name.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Category name already exists. Please choose a different name.");
                            return;
                        }
                    }

                    // If not duplicate, proceed with the insert
                    using (SqlCommand cmd = new SqlCommand(CLSItem.SAVE_CAT, dbc))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@category_name", txt_category_name.Text);
                            cmd.Parameters.AddWithValue("@category_code", txt_category_code.Text);
                            cmd.Parameters.AddWithValue("@category_des", txt_category_des.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data category has been saved in the database!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void frm_item_category_Load(object sender, EventArgs e)
        {
            vData.View_ListBoX(ltb_category,CLSItem.SELECT_CATEGORY);
        }

        private void txt_category_name_Leave(object sender, EventArgs e)
        {
        }

        private void txt_category_code_Leave(object sender, EventArgs e)
        {
        }

        private void txt_category_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
