namespace InvoicingApp
{
    partial class Products
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
            this.bttn_create_product = new System.Windows.Forms.Button();
            this.bttn_edit_product = new System.Windows.Forms.Button();
            this.bttn_delete_product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_create_product
            // 
            this.bttn_create_product.Location = new System.Drawing.Point(13, 13);
            this.bttn_create_product.Name = "bttn_create_product";
            this.bttn_create_product.Size = new System.Drawing.Size(181, 97);
            this.bttn_create_product.TabIndex = 0;
            this.bttn_create_product.Text = "Create Product";
            this.bttn_create_product.UseVisualStyleBackColor = true;
            // 
            // bttn_edit_product
            // 
            this.bttn_edit_product.Location = new System.Drawing.Point(200, 13);
            this.bttn_edit_product.Name = "bttn_edit_product";
            this.bttn_edit_product.Size = new System.Drawing.Size(181, 97);
            this.bttn_edit_product.TabIndex = 1;
            this.bttn_edit_product.Text = "Edit Product";
            this.bttn_edit_product.UseVisualStyleBackColor = true;
            // 
            // bttn_delete_product
            // 
            this.bttn_delete_product.Location = new System.Drawing.Point(387, 12);
            this.bttn_delete_product.Name = "bttn_delete_product";
            this.bttn_delete_product.Size = new System.Drawing.Size(181, 97);
            this.bttn_delete_product.TabIndex = 2;
            this.bttn_delete_product.Text = "Delete Product";
            this.bttn_delete_product.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.Controls.Add(this.bttn_delete_product);
            this.Controls.Add(this.bttn_edit_product);
            this.Controls.Add(this.bttn_create_product);
            this.Name = "Products";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_create_product;
        private System.Windows.Forms.Button bttn_edit_product;
        private System.Windows.Forms.Button bttn_delete_product;
    }
}