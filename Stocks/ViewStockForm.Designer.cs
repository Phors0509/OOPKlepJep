namespace OOP.Stocks
{
    partial class ViewStockForm
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterByBrand = new System.Windows.Forms.ComboBox();
            this.filterByCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchStock = new System.Windows.Forms.TextBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(12, 131);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(679, 342);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By Brand ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By Category ";
            // 
            // filterByBrand
            // 
            this.filterByBrand.FormattingEnabled = true;
            this.filterByBrand.Location = new System.Drawing.Point(110, 67);
            this.filterByBrand.Name = "filterByBrand";
            this.filterByBrand.Size = new System.Drawing.Size(121, 21);
            this.filterByBrand.TabIndex = 5;
            this.filterByBrand.SelectedIndexChanged += new System.EventHandler(this.filterByBrand_SelectedIndexChanged);
            // 
            // filterByCategory
            // 
            this.filterByCategory.FormattingEnabled = true;
            this.filterByCategory.Location = new System.Drawing.Point(110, 101);
            this.filterByCategory.Name = "filterByCategory";
            this.filterByCategory.Size = new System.Drawing.Size(121, 21);
            this.filterByCategory.TabIndex = 6;
            this.filterByCategory.SelectedIndexChanged += new System.EventHandler(this.filterByCategory_SelectedIndexChanged);
            // 
            // txtSearchStock
            // 
            this.txtSearchStock.Location = new System.Drawing.Point(437, 101);
            this.txtSearchStock.Name = "txtSearchStock";
            this.txtSearchStock.Size = new System.Drawing.Size(173, 20);
            this.txtSearchStock.TabIndex = 7;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Location = new System.Drawing.Point(616, 99);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStock.TabIndex = 8;
            this.btnSearchStock.Text = "Search";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(356, 101);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClearSearch.TabIndex = 9;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // ViewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 496);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearchStock);
            this.Controls.Add(this.txtSearchStock);
            this.Controls.Add(this.filterByCategory);
            this.Controls.Add(this.filterByBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStock);
            this.Name = "ViewStockForm";
            this.Text = "ViewStockForm";
            this.Load += new System.EventHandler(this.ViewStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterByBrand;
        private System.Windows.Forms.ComboBox filterByCategory;
        private System.Windows.Forms.TextBox txtSearchStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.Button btnClearSearch;
    }
}