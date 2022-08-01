namespace InvoicingApp
{
    partial class Customers
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
            this.bttn_create_customer = new System.Windows.Forms.Button();
            this.bttn_edit_customer = new System.Windows.Forms.Button();
            this.bttn_delete_customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_create_customer
            // 
            this.bttn_create_customer.Location = new System.Drawing.Point(11, 11);
            this.bttn_create_customer.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_create_customer.Name = "bttn_create_customer";
            this.bttn_create_customer.Size = new System.Drawing.Size(121, 63);
            this.bttn_create_customer.TabIndex = 1;
            this.bttn_create_customer.Text = "Create Customer";
            this.bttn_create_customer.UseVisualStyleBackColor = true;
            // 
            // bttn_edit_customer
            // 
            this.bttn_edit_customer.Location = new System.Drawing.Point(136, 11);
            this.bttn_edit_customer.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_edit_customer.Name = "bttn_edit_customer";
            this.bttn_edit_customer.Size = new System.Drawing.Size(121, 63);
            this.bttn_edit_customer.TabIndex = 2;
            this.bttn_edit_customer.Text = "Edit Customer";
            this.bttn_edit_customer.UseVisualStyleBackColor = true;
            // 
            // bttn_delete_customer
            // 
            this.bttn_delete_customer.Location = new System.Drawing.Point(261, 11);
            this.bttn_delete_customer.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_delete_customer.Name = "bttn_delete_customer";
            this.bttn_delete_customer.Size = new System.Drawing.Size(121, 63);
            this.bttn_delete_customer.TabIndex = 3;
            this.bttn_delete_customer.Text = "Delete Customer";
            this.bttn_delete_customer.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 482);
            this.Controls.Add(this.bttn_delete_customer);
            this.Controls.Add(this.bttn_edit_customer);
            this.Controls.Add(this.bttn_create_customer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customers_FormClosed);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_create_customer;
        private System.Windows.Forms.Button bttn_edit_customer;
        private System.Windows.Forms.Button bttn_delete_customer;
    }
}