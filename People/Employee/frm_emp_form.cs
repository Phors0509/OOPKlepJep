using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class frm_employees : Form
    {
        public frm_employees()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e){
            db_view view = new db_view();
            Employee.Employee vem= new Employee.Employee();
            vem.dataEmpty = txt_name.Text;
            vem.dataEmpty = txt_floor.Text;
            if (vem.isvalidation == true)
            {
                using (SqlConnection DBC = new SqlConnection(DBCON.db_address))
                {
                    try
                    {
                        DBC.Open();
                        string DATA = "INSERT INTO tbl_class (name,floor,des)VALUES(@name,@floor,@des)";
                        using (SqlCommand cmd = new SqlCommand(DATA, DBC))
                        {
                            try
                            {
                                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                                cmd.Parameters.AddWithValue("@floor", txt_floor.Text);
                                cmd.Parameters.AddWithValue("@des", txt_des.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data has been saved!");
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else if (vem.isvalidation == false)
            {
                MessageBox.Show("Data must be input for correct name ! ");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            db_view view = new db_view();
            if (chk_search_by_code.Checked == true){
                view.view_table(dgr, view.student_all, txt_search.Text);
            }
            if (chk_search_by_all.Checked == true){
                view.view_table(dgr, view.student_all);
            }
            if(chk_search_by_id.Checked == true){
                view.view_table(dgr, view.student_all,Convert.ToInt16(txt_search.Text));
            }
            if(chk_search_by_name.Checked == true)
            {
                string lname = txt_search.Text;
                string fname = txt_search.Text;
                view.view_table(dgr, view.student_all, fname,lname);
            }
            
        }

        private void chk_search_by_name_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            Employee.Employee em = new OOP.Employee.Employee();
            em.Name = txt_name.Text;
            txt_name.Text = em.Name;    
        }

        
    }
}
