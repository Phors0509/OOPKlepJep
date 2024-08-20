namespace MultiForm.Items
{
    partial class frm_view_item
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
            this.dgr_view_item = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_view_item)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_view_item
            // 
            this.dgr_view_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_view_item.Location = new System.Drawing.Point(12, 58);
            this.dgr_view_item.Name = "dgr_view_item";
            this.dgr_view_item.Size = new System.Drawing.Size(776, 380);
            this.dgr_view_item.TabIndex = 0;
            // 
            // frm_view_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgr_view_item);
            this.Name = "frm_view_item";
            this.Text = "frm_view_item";
            this.Load += new System.EventHandler(this.frm_view_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_view_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_view_item;
    }
}