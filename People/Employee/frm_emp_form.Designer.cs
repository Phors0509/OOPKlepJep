namespace OOP
{
    partial class frm_employees
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
            this.dgr = new System.Windows.Forms.DataGridView();
            this.dgr_class = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.chk_search_by_code = new System.Windows.Forms.CheckBox();
            this.chk_search_by_all = new System.Windows.Forms.CheckBox();
            this.chk_search_by_id = new System.Windows.Forms.CheckBox();
            this.chk_search_by_name = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(12, 243);
            this.dgr.Name = "dgr";
            this.dgr.Size = new System.Drawing.Size(855, 184);
            this.dgr.TabIndex = 0;
            // 
            // dgr_class
            // 
            this.dgr_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgr_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_class.Location = new System.Drawing.Point(300, 55);
            this.dgr_class.Name = "dgr_class";
            this.dgr_class.Size = new System.Drawing.Size(567, 125);
            this.dgr_class.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(86, 55);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(197, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(86, 81);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(197, 20);
            this.txt_floor.TabIndex = 2;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(86, 110);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(197, 63);
            this.txt_des.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(208, 179);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(652, 217);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(136, 20);
            this.txt_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(792, 214);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chk_search_by_code
            // 
            this.chk_search_by_code.AutoSize = true;
            this.chk_search_by_code.Location = new System.Drawing.Point(530, 220);
            this.chk_search_by_code.Name = "chk_search_by_code";
            this.chk_search_by_code.Size = new System.Drawing.Size(103, 17);
            this.chk_search_by_code.TabIndex = 7;
            this.chk_search_by_code.Text = "Search By Code";
            this.chk_search_by_code.UseVisualStyleBackColor = true;
            // 
            // chk_search_by_all
            // 
            this.chk_search_by_all.AutoSize = true;
            this.chk_search_by_all.Location = new System.Drawing.Point(433, 220);
            this.chk_search_by_all.Name = "chk_search_by_all";
            this.chk_search_by_all.Size = new System.Drawing.Size(74, 17);
            this.chk_search_by_all.TabIndex = 8;
            this.chk_search_by_all.Text = "Search All";
            this.chk_search_by_all.UseVisualStyleBackColor = true;
            // 
            // chk_search_by_id
            // 
            this.chk_search_by_id.AutoSize = true;
            this.chk_search_by_id.Location = new System.Drawing.Point(328, 219);
            this.chk_search_by_id.Name = "chk_search_by_id";
            this.chk_search_by_id.Size = new System.Drawing.Size(89, 17);
            this.chk_search_by_id.TabIndex = 9;
            this.chk_search_by_id.Text = "Search By ID";
            this.chk_search_by_id.UseVisualStyleBackColor = true;
            // 
            // chk_search_by_name
            // 
            this.chk_search_by_name.AutoSize = true;
            this.chk_search_by_name.Location = new System.Drawing.Point(208, 218);
            this.chk_search_by_name.Name = "chk_search_by_name";
            this.chk_search_by_name.Size = new System.Drawing.Size(106, 17);
            this.chk_search_by_name.TabIndex = 11;
            this.chk_search_by_name.Text = "Search By Name";
            this.chk_search_by_name.UseVisualStyleBackColor = true;
            this.chk_search_by_name.CheckedChanged += new System.EventHandler(this.chk_search_by_name_CheckedChanged);
            // 
            // frm_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.chk_search_by_name);
            this.Controls.Add(this.chk_search_by_id);
            this.Controls.Add(this.chk_search_by_all);
            this.Controls.Add(this.chk_search_by_code);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgr_class);
            this.Controls.Add(this.dgr);
            this.Name = "frm_employees";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.DataGridView dgr_class;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox chk_search_by_code;
        private System.Windows.Forms.CheckBox chk_search_by_all;
        private System.Windows.Forms.CheckBox chk_search_by_id;
        private System.Windows.Forms.CheckBox chk_search_by_name;
    }
}

