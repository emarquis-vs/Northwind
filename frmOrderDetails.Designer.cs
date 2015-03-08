using Northwind.Model;

namespace Northwind
{
    partial class frmOrderDetails
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
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOrderId
            // 
            this.cboOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(88, 6);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(105, 28);
            this.cboOrderId.TabIndex = 2;
            this.cboOrderId.SelectedIndexChanged += new System.EventHandler(this.cboOrderId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID";
            // 
            // OrderDetailsDataGrid
            // 
            this.OrderDetailsDataGrid.AllowUserToAddRows = false;
            this.OrderDetailsDataGrid.AllowUserToDeleteRows = false;
            this.OrderDetailsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.OrderDetailsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderDetailsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.OrderDetailsDataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.OrderDetailsDataGrid.Location = new System.Drawing.Point(12, 40);
            this.OrderDetailsDataGrid.Name = "OrderDetailsDataGrid";
            this.OrderDetailsDataGrid.ReadOnly = true;
            this.OrderDetailsDataGrid.Size = new System.Drawing.Size(722, 441);
            this.OrderDetailsDataGrid.TabIndex = 5;
            this.OrderDetailsDataGrid.Visible = false;
            // 
            // A
            // 
            this.A.HeaderText = "";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 5;
            // 
            // B
            // 
            this.B.HeaderText = "";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 5;
            // 
            // C
            // 
            this.C.HeaderText = "";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 5;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataSource = typeof(Products);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(Employees);
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataMember = "Order_Details";
            this.ProductsBindingSource.DataSource = typeof(Products);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 494);
            this.Controls.Add(this.OrderDetailsDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrderId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderDetailsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
    }
}

