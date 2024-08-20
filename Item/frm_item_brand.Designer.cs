namespace MultiForm.Items
{
    partial class frm_item_brand
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
            this.btn_item_brand_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.txt_brand_des = new System.Windows.Forms.TextBox();
            this.txt_brand_code = new System.Windows.Forms.TextBox();
            this.txt_brand_name = new System.Windows.Forms.TextBox();
            this.ltb_brand = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_item_brand_save
            // 
            this.btn_item_brand_save.Location = new System.Drawing.Point(271, 128);
            this.btn_item_brand_save.Name = "btn_item_brand_save";
            this.btn_item_brand_save.Size = new System.Drawing.Size(75, 23);
            this.btn_item_brand_save.TabIndex = 21;
            this.btn_item_brand_save.Text = "Save";
            this.btn_item_brand_save.UseVisualStyleBackColor = true;
            this.btn_item_brand_save.Click += new System.EventHandler(this.btn_item_brand_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Code";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(53, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 20;
            this.Name.Text = "Name";
            // 
            // txt_brand_des
            // 
            this.txt_brand_des.Location = new System.Drawing.Point(119, 65);
            this.txt_brand_des.Multiline = true;
            this.txt_brand_des.Name = "txt_brand_des";
            this.txt_brand_des.Size = new System.Drawing.Size(227, 57);
            this.txt_brand_des.TabIndex = 17;
            // 
            // txt_brand_code
            // 
            this.txt_brand_code.Location = new System.Drawing.Point(119, 39);
            this.txt_brand_code.Name = "txt_brand_code";
            this.txt_brand_code.Size = new System.Drawing.Size(227, 20);
            this.txt_brand_code.TabIndex = 16;
            // 
            // txt_brand_name
            // 
            this.txt_brand_name.Location = new System.Drawing.Point(119, 13);
            this.txt_brand_name.Name = "txt_brand_name";
            this.txt_brand_name.Size = new System.Drawing.Size(227, 20);
            this.txt_brand_name.TabIndex = 15;
            // 
            // ltb_brand
            // 
            this.ltb_brand.FormattingEnabled = true;
            this.ltb_brand.Location = new System.Drawing.Point(33, 167);
            this.ltb_brand.Name = "ltb_brand";
            this.ltb_brand.Size = new System.Drawing.Size(313, 251);
            this.ltb_brand.TabIndex = 14;
            // 
            // frm_item_brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 430);
            this.Controls.Add(this.btn_item_brand_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txt_brand_des);
            this.Controls.Add(this.txt_brand_code);
            this.Controls.Add(this.txt_brand_name);
            this.Controls.Add(this.ltb_brand);
            //this.Name = "frm_item_brand";
            this.Text = "Item Brand";
            this.Load += new System.EventHandler(this.frm_item_brand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_item_brand_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txt_brand_des;
        private System.Windows.Forms.TextBox txt_brand_code;
        private System.Windows.Forms.TextBox txt_brand_name;
        private System.Windows.Forms.ListBox ltb_brand;
    }
}