using OOP;
using System;
using System.Windows.Forms;

namespace MultiForm.Items
{
    public partial class frm_view_item : Form
    {
        db_view V = new db_view();
        public frm_view_item()
        {
            InitializeComponent();
        }

        private void frm_view_item_Load(object sender, EventArgs e)
        {
            V.view_table(dgr_view_item, "SELECT * FROM view_items");
        }
    }
}
