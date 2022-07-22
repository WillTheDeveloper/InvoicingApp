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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new InvoicingApp.masterDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.masterDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(844, 605);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttn_delete_product);
            this.Controls.Add(this.bttn_edit_product);
            this.Controls.Add(this.bttn_create_product);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_create_product;
        private System.Windows.Forms.Button bttn_edit_product;
        private System.Windows.Forms.Button bttn_delete_product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
    }
}