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
using System.Xml.Linq;

namespace MultiForm.Items
{
    public partial class frm_item_brand : Form
    {
        db_view vData = new db_view();
        public frm_item_brand()
        {
            InitializeComponent();
        }

        private void btn_item_brand_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection DBC = new SqlConnection(DBCON.db_address))
            {
                try
                {
                    DBC.Open();

                    using (SqlCommand cmd = new SqlCommand(CLSItem.SAVE_BRAND, DBC))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@brand_name", txt_brand_name.Text);
                            cmd.Parameters.AddWithValue("@brand_code", txt_brand_code.Text);
                            cmd.Parameters.AddWithValue("@brand_des", txt_brand_des.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been saved!");
                           // v.View_ListBox(ltb_brand, Items.DBItem.ITEM_BRAND_SELECT_DATA);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void frm_item_brand_Load(object sender, EventArgs e)
        {

            vData.View_ListBoX(ltb_brand, CLSItem.SELECT_BRAND);
        }
    }
}
