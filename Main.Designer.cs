namespace InvoicingApp
{
    partial class Main
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
            this.bttn_new_invoice = new System.Windows.Forms.Button();
            this.bttn_manage_products = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_new_invoice
            // 
            this.bttn_new_invoice.Location = new System.Drawing.Point(13, 13);
            this.bttn_new_invoice.Name = "bttn_new_invoice";
            this.bttn_new_invoice.Size = new System.Drawing.Size(227, 63);
            this.bttn_new_invoice.TabIndex = 0;
            this.bttn_new_invoice.Text = "New Invoice";
            this.bttn_new_invoice.UseVisualStyleBackColor = true;
            // 
            // bttn_manage_products
            // 
            this.bttn_manage_products.Location = new System.Drawing.Point(246, 12);
            this.bttn_manage_products.Name = "bttn_manage_products";
            this.bttn_manage_products.Size = new System.Drawing.Size(227, 63);
            this.bttn_manage_products.TabIndex = 1;
            this.bttn_manage_products.Text = "Manage Products";
            this.bttn_manage_products.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 828);
            this.Controls.Add(this.bttn_manage_products);
            this.Controls.Add(this.bttn_new_invoice);
            this.Name = "Form1";
            this.Text = "Invoicing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_new_invoice;
        private System.Windows.Forms.Button bttn_manage_products;
    }
}

