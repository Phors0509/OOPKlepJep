using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Employee
{
    public partial class frm_create_employee : Form
    {
        public frm_create_employee()
        {
            InitializeComponent();
        }

        private void txt_emp_name_en_Leave(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.DetectUnicode = txt_emp_name_en.Text;
            txt_emp_name_en.Text = emp.DetectUnicode;
            emp.Name = txt_emp_name_en.Text;
            txt_emp_name_en.Text = emp.Name;
        }
    }
}
