using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OOP.Employee
{
    internal class Employee
    {
        private string _name;
        private string detec_symbol = @"[!@#$%^&*()_+=\[{\]};:<>|./?]";
        private string detect_number = @"^-?[0-9]+$";
        private bool symbol = false;
        private bool number = false;

        private string _data;
        private string _unicode;
        public bool isvalidation = false;
        public string dataEmpty
        {
            get { return _data; }
            set {
                if (String.IsNullOrEmpty(value)) isvalidation = false;
                else if (!String.IsNullOrEmpty(value))
                {
                    if (isvalidation == true) isvalidation = true;
                }
            }
        }

        public string DetectUnicode
        {
            get { return _unicode; }
            set
            {   
                bool containsUnicode = value.Any(c => c > 127);
                if (containsUnicode)
                {
                    MessageBox.Show("The string contains Unicode characters.");
                }
                else { _unicode=value; }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                symbol = Regex.IsMatch(value, detec_symbol);
                number = Regex.IsMatch(value, detect_number);
                if (symbol == true || number == true)
                {
                    MessageBox.Show("cannot use symbol and number here!");
                    _name = "";
                }
                else { _name = value.ToUpper(); }
            }
        }
    }
}
