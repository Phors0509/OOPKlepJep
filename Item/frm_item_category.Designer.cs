namespace MultiForm.Items
{
    partial class frm_item_category
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
            this.btn_item_category_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.txt_category_des = new System.Windows.Forms.TextBox();
            this.txt_category_code = new System.Windows.Forms.TextBox();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.ltb_category = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_item_category_save
            // 
            this.btn_item_category_save.Location = new System.Drawing.Point(267, 138);
            this.btn_item_category_save.Name = "btn_item_category_save";
            this.btn_item_category_save.Size = new System.Drawing.Size(75, 23);
            this.btn_item_category_save.TabIndex = 29;
            this.btn_item_category_save.Text = "Save";
            this.btn_item_category_save.UseVisualStyleBackColor = true;
            this.btn_item_category_save.Click += new System.EventHandler(this.btn_item_category_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Code";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(49, 23);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 28;
            this.Name.Text = "Name";
            // 
            // txt_category_des
            // 
            this.txt_category_des.Location = new System.Drawing.Point(115, 75);
            this.txt_category_des.Multiline = true;
            this.txt_category_des.Name = "txt_category_des";
            this.txt_category_des.Size = new System.Drawing.Size(227, 57);
            this.txt_category_des.TabIndex = 25;
            // 
            // txt_category_code
            // 
            this.txt_category_code.Location = new System.Drawing.Point(115, 49);
            this.txt_category_code.Name = "txt_category_code";
            this.txt_category_code.Size = new System.Drawing.Size(227, 20);
            this.txt_category_code.TabIndex = 24;
            this.txt_category_code.TextChanged += new System.EventHandler(this.txt_category_code_TextChanged);
            this.txt_category_code.Leave += new System.EventHandler(this.txt_category_code_Leave);
            // 
            // txt_category_name
            // 
            this.txt_category_name.Location = new System.Drawing.Point(115, 23);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(227, 20);
            this.txt_category_name.TabIndex = 23;
            this.txt_category_name.Leave += new System.EventHandler(this.txt_category_name_Leave);
            // 
            // ltb_category
            // 
            this.ltb_category.FormattingEnabled = true;
            this.ltb_category.Location = new System.Drawing.Point(29, 177);
            this.ltb_category.Name = "ltb_category";
            this.ltb_category.Size = new System.Drawing.Size(313, 251);
            this.ltb_category.TabIndex = 22;
            // 
            // frm_item_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn_item_category_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txt_category_des);
            this.Controls.Add(this.txt_category_code);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.ltb_category);
            //this.Name = "frm_item_category";
            this.Text = "Item Category";
            this.Load += new System.EventHandler(this.frm_item_category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_item_category_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txt_category_des;
        private System.Windows.Forms.TextBox txt_category_code;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.ListBox ltb_category;
        private System.Windows.Forms.ListBox viewStockData; 
    }
}