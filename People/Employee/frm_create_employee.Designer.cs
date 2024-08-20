namespace OOP.Employee
{
    partial class frm_create_employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_emp_name_en = new System.Windows.Forms.TextBox();
            this.txt_emp_name_kh = new System.Windows.Forms.TextBox();
            this.txt_emp_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_emp_name_en
            // 
            this.txt_emp_name_en.Location = new System.Drawing.Point(99, 72);
            this.txt_emp_name_en.Name = "txt_emp_name_en";
            this.txt_emp_name_en.Size = new System.Drawing.Size(236, 20);
            this.txt_emp_name_en.TabIndex = 0;
            this.txt_emp_name_en.Leave += new System.EventHandler(this.txt_emp_name_en_Leave);
            // 
            // txt_emp_name_kh
            // 
            this.txt_emp_name_kh.Location = new System.Drawing.Point(99, 98);
            this.txt_emp_name_kh.Name = "txt_emp_name_kh";
            this.txt_emp_name_kh.Size = new System.Drawing.Size(236, 20);
            this.txt_emp_name_kh.TabIndex = 0;
            // 
            // txt_emp_code
            // 
            this.txt_emp_code.Location = new System.Drawing.Point(99, 46);
            this.txt_emp_code.Name = "txt_emp_code";
            this.txt_emp_code.Size = new System.Drawing.Size(236, 20);
            this.txt_emp_code.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name En";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "EMP Code";
            // 
            // frm_create_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_emp_code);
            this.Controls.Add(this.txt_emp_name_kh);
            this.Controls.Add(this.txt_emp_name_en);
            this.Name = "frm_create_employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_emp_name_en;
        private System.Windows.Forms.TextBox txt_emp_name_kh;
        private System.Windows.Forms.TextBox txt_emp_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}