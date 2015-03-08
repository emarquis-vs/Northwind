using Northwind.Model;

namespace Northwind
{
    partial class frmSuppliersProducts
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
            this.SuppliersProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSupplierId = new System.Windows.Forms.ComboBox();
            this.btnShowOneSupplier = new System.Windows.Forms.Button();
            this.btnShowAllSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersProductsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SuppliersProductsDataGrid
            // 
            this.SuppliersProductsDataGrid.AllowUserToAddRows = false;
            this.SuppliersProductsDataGrid.AllowUserToDeleteRows = false;
            this.SuppliersProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.SuppliersProductsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SuppliersProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliersProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.SuppliersProductsDataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.SuppliersProductsDataGrid.Location = new System.Drawing.Point(16, 52);
            this.SuppliersProductsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SuppliersProductsDataGrid.Name = "SuppliersProductsDataGrid";
            this.SuppliersProductsDataGrid.Size = new System.Drawing.Size(963, 543);
            this.SuppliersProductsDataGrid.TabIndex = 9;
            this.SuppliersProductsDataGrid.Visible = false;
            this.SuppliersProductsDataGrid.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersProductsDataGrid_RowLeave);
            // 
            // A
            // 
            this.A.HeaderText = "";
            this.A.Name = "A";
            this.A.Width = 5;
            // 
            // B
            // 
            this.B.HeaderText = "";
            this.B.Name = "B";
            this.B.Width = 5;
            // 
            // C
            // 
            this.C.HeaderText = "";
            this.C.Name = "C";
            this.C.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier ID";
            // 
            // cboSupplierId
            // 
            this.cboSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplierId.FormattingEnabled = true;
            this.cboSupplierId.Location = new System.Drawing.Point(141, 10);
            this.cboSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.cboSupplierId.Name = "cboSupplierId";
            this.cboSupplierId.Size = new System.Drawing.Size(500, 33);
            this.cboSupplierId.TabIndex = 7;
            // 
            // btnShowOneSupplier
            // 
            this.btnShowOneSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOneSupplier.Location = new System.Drawing.Point(651, 9);
            this.btnShowOneSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowOneSupplier.Name = "btnShowOneSupplier";
            this.btnShowOneSupplier.Size = new System.Drawing.Size(192, 34);
            this.btnShowOneSupplier.TabIndex = 6;
            this.btnShowOneSupplier.Text = "Show this Supplier";
            this.btnShowOneSupplier.UseVisualStyleBackColor = true;
            this.btnShowOneSupplier.Click += new System.EventHandler(this.btnShowOneSupplier_Click);
            // 
            // btnShowAllSuppliers
            // 
            this.btnShowAllSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllSuppliers.Location = new System.Drawing.Point(851, 9);
            this.btnShowAllSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllSuppliers.Name = "btnShowAllSuppliers";
            this.btnShowAllSuppliers.Size = new System.Drawing.Size(128, 34);
            this.btnShowAllSuppliers.TabIndex = 10;
            this.btnShowAllSuppliers.Text = "Show All";
            this.btnShowAllSuppliers.UseVisualStyleBackColor = true;
            this.btnShowAllSuppliers.Click += new System.EventHandler(this.btnShowAllSuppliers_Click);
            // 
            // frmSuppliersProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 608);
            this.Controls.Add(this.btnShowAllSuppliers);
            this.Controls.Add(this.SuppliersProductsDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSupplierId);
            this.Controls.Add(this.btnShowOneSupplier);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuppliersProducts";
            this.Text = "Suppliers Products";
            this.Load += new System.EventHandler(this.SuppliersProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersProductsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SuppliersProductsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSupplierId;
        private System.Windows.Forms.Button btnShowOneSupplier;
        private System.Windows.Forms.Button btnShowAllSuppliers;
    }
}