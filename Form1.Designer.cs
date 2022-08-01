namespace InvoicingApp
{
    partial class Form1
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
            this.bttn_products = new System.Windows.Forms.Button();
            this.bttn_customers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_products
            // 
            this.bttn_products.Location = new System.Drawing.Point(8, 8);
            this.bttn_products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_products.Name = "bttn_products";
            this.bttn_products.Size = new System.Drawing.Size(159, 60);
            this.bttn_products.TabIndex = 0;
            this.bttn_products.Text = "Products";
            this.bttn_products.UseVisualStyleBackColor = true;
            this.bttn_products.Click += new System.EventHandler(this.bttn_products_Click);
            // 
            // bttn_customers
            // 
            this.bttn_customers.Location = new System.Drawing.Point(171, 8);
            this.bttn_customers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_customers.Name = "bttn_customers";
            this.bttn_customers.Size = new System.Drawing.Size(159, 60);
            this.bttn_customers.TabIndex = 1;
            this.bttn_customers.Text = "Customers";
            this.bttn_customers.UseVisualStyleBackColor = true;
            this.bttn_customers.Click += new System.EventHandler(this.bttn_customers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 502);
            this.Controls.Add(this.bttn_customers);
            this.Controls.Add(this.bttn_products);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Invoicing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_products;
        private System.Windows.Forms.Button bttn_customers;
    }
}