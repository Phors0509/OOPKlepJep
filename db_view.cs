using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP
{
    internal class db_view : db_properties
    {
        public DataTable data_table(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection DBC = new SqlConnection(DBCON.db_address))
            {
                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(sql, DBC);
                    adpt.Fill(table);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
            return table;
        }
        public void view_table(DataGridView dgv, string sql)
        {
            dgv.DataSource = data_table(sql);
        }
        public void view_table(DataGridView dgv, string sql, int w_id)
        {
            dgv.DataSource = data_table(sql + " WHERE ID=" + w_id);
        }
        public void view_table(DataGridView dgv, string sql, string w_code)
        {
            dgv.DataSource = data_table(sql + $" WHERE student_code='{w_code}'");
        }

        public void view_table(DataGridView dgv, string sql, string lname, string fname)
        {
            sql = sql + $" WHERE " +
                           $"first_name = '{lname}' or " +
                           $"last_name  = '{fname}'";
            dgv.DataSource = data_table(sql);
        }

        public void View_ListBoX(ListBox ltb, string select)
        {
            using (SqlConnection DB = new SqlConnection(DBCON.db_address))
            {
                DB.Open();
                using (SqlCommand command = new SqlCommand(select, DB))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ltb.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string fullName = reader[0].ToString();
                                ltb.Items.Add(fullName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found.", "information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }
    }
}
