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
            this.components = new System.ComponentModel.Container();
            this.bttn_create_product = new System.Windows.Forms.Button();
            this.bttn_edit_product = new System.Windows.Forms.Button();
            this.bttn_delete_product = new System.Windows.Forms.Button();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new InvoicingApp.masterDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_create_product
            // 
            this.bttn_create_product.Location = new System.Drawing.Point(9, 8);
            this.bttn_create_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_create_product.Name = "bttn_create_product";
            this.bttn_create_product.Size = new System.Drawing.Size(121, 63);
            this.bttn_create_product.TabIndex = 0;
            this.bttn_create_product.Text = "Create Product";
            this.bttn_create_product.UseVisualStyleBackColor = true;
            // 
            // bttn_edit_product
            // 
            this.bttn_edit_product.Location = new System.Drawing.Point(133, 8);
            this.bttn_edit_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_edit_product.Name = "bttn_edit_product";
            this.bttn_edit_product.Size = new System.Drawing.Size(121, 63);
            this.bttn_edit_product.TabIndex = 1;
            this.bttn_edit_product.Text = "Edit Product";
            this.bttn_edit_product.UseVisualStyleBackColor = true;
            // 
            // bttn_delete_product
            // 
            this.bttn_delete_product.Location = new System.Drawing.Point(258, 8);
            this.bttn_delete_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_delete_product.Name = "bttn_delete_product";
            this.bttn_delete_product.Size = new System.Drawing.Size(121, 63);
            this.bttn_delete_product.TabIndex = 2;
            this.bttn_delete_product.Text = "Delete Product";
            this.bttn_delete_product.UseVisualStyleBackColor = true;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.masterDataSetBindingSource;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "products";
            this.productsBindingSource1.DataSource = this.masterDataSetBindingSource;
            this.productsBindingSource1.CurrentChanged += new System.EventHandler(this.productsBindingSource1_CurrentChanged);
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "products";
            this.productsBindingSource2.DataSource = this.masterDataSet;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 487);
            this.Controls.Add(this.bttn_delete_product);
            this.Controls.Add(this.bttn_edit_product);
            this.Controls.Add(this.bttn_create_product);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_create_product;
        private System.Windows.Forms.Button bttn_edit_product;
        private System.Windows.Forms.Button bttn_delete_product;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}