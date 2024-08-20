namespace MultiForm.Items
{
    partial class frm_create_item
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
            this.btn_item_save = new System.Windows.Forms.Button();
            this.pic_item = new System.Windows.Forms.PictureBox();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.txt_item_model = new System.Windows.Forms.TextBox();
            this.txt_item_price = new System.Windows.Forms.TextBox();
            this.cbb_item_brand = new System.Windows.Forms.ComboBox();
            this.cbb_item_category = new System.Windows.Forms.ComboBox();
            this.txt_item_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_item_save
            // 
            this.btn_item_save.Location = new System.Drawing.Point(376, 179);
            this.btn_item_save.Name = "btn_item_save";
            this.btn_item_save.Size = new System.Drawing.Size(75, 23);
            this.btn_item_save.TabIndex = 0;
            this.btn_item_save.Text = "Save";
            this.btn_item_save.UseVisualStyleBackColor = true;
            //this.btn_item_save.Click += new System.EventHandler(this.btn_item_save_Click);
            // 
            // pic_item
            // 
            this.pic_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_item.Location = new System.Drawing.Point(12, 12);
            this.pic_item.Name = "pic_item";
            this.pic_item.Size = new System.Drawing.Size(136, 161);
            this.pic_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_item.TabIndex = 1;
            this.pic_item.TabStop = false;
            //this.pic_item.Click += new System.EventHandler(this.pic_item_Click);
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(288, 47);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(163, 20);
            this.txt_item_name.TabIndex = 2;
           // this.txt_item_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_item_name_KeyPress);
            // 
            // txt_item_model
            // 
            this.txt_item_model.Location = new System.Drawing.Point(288, 73);
            this.txt_item_model.Name = "txt_item_model";
            this.txt_item_model.Size = new System.Drawing.Size(163, 20);
            this.txt_item_model.TabIndex = 3;
            // 
            // txt_item_price
            // 
            this.txt_item_price.Location = new System.Drawing.Point(288, 99);
            this.txt_item_price.Name = "txt_item_price";
            this.txt_item_price.Size = new System.Drawing.Size(163, 20);
            this.txt_item_price.TabIndex = 4;
            // 
            // cbb_item_brand
            // 
            this.cbb_item_brand.FormattingEnabled = true;
            this.cbb_item_brand.Location = new System.Drawing.Point(288, 125);
            this.cbb_item_brand.Name = "cbb_item_brand";
            this.cbb_item_brand.Size = new System.Drawing.Size(163, 21);
            this.cbb_item_brand.TabIndex = 5;
            // 
            // cbb_item_category
            // 
            this.cbb_item_category.FormattingEnabled = true;
            this.cbb_item_category.Location = new System.Drawing.Point(288, 152);
            this.cbb_item_category.Name = "cbb_item_category";
            this.cbb_item_category.Size = new System.Drawing.Size(163, 21);
            this.cbb_item_category.TabIndex = 6;
            // 
            // txt_item_code
            // 
            this.txt_item_code.Location = new System.Drawing.Point(288, 21);
            this.txt_item_code.Name = "txt_item_code";
            this.txt_item_code.Size = new System.Drawing.Size(163, 20);
            this.txt_item_code.TabIndex = 7;
            //this.txt_item_code.CursorChanged += new System.EventHandler(this.txt_item_code_CursorChanged);
           // this.txt_item_code.Leave += new System.EventHandler(this.txt_item_code_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Branch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item Category";
            // 
            // frm_create_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 215);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_item_code);
            this.Controls.Add(this.cbb_item_category);
            this.Controls.Add(this.cbb_item_brand);
            this.Controls.Add(this.txt_item_price);
            this.Controls.Add(this.txt_item_model);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.pic_item);
            this.Controls.Add(this.btn_item_save);
            this.Name = "frm_create_item";
            this.Text = "Create Item";
           // this.Load += new System.EventHandler(this.frm_create_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_item_save;
        private System.Windows.Forms.PictureBox pic_item;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.TextBox txt_item_model;
        private System.Windows.Forms.TextBox txt_item_price;
        private System.Windows.Forms.ComboBox cbb_item_brand;
        private System.Windows.Forms.ComboBox cbb_item_category;
        private System.Windows.Forms.TextBox txt_item_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}