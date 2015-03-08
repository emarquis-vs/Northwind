namespace Northwind
{
    partial class frmCustomers
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
            this.CustomerDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomerId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDetailsDataGrid
            // 
            this.CustomerDetailsDataGrid.AllowUserToAddRows = false;
            this.CustomerDetailsDataGrid.AllowUserToDeleteRows = false;
            this.CustomerDetailsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.CustomerDetailsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CustomerDetailsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetailsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.CustomerDetailsDataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.CustomerDetailsDataGrid.Location = new System.Drawing.Point(12, 58);
            this.CustomerDetailsDataGrid.Name = "CustomerDetailsDataGrid";
            this.CustomerDetailsDataGrid.ReadOnly = true;
            this.CustomerDetailsDataGrid.Size = new System.Drawing.Size(722, 441);
            this.CustomerDetailsDataGrid.TabIndex = 6;
            this.CustomerDetailsDataGrid.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer ID";
            // 
            // cboCustomerId
            // 
            this.cboCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerId.FormattingEnabled = true;
            this.cboCustomerId.Location = new System.Drawing.Point(113, 12);
            this.cboCustomerId.Name = "cboCustomerId";
            this.cboCustomerId.Size = new System.Drawing.Size(105, 28);
            this.cboCustomerId.TabIndex = 8;
            this.cboCustomerId.SelectedIndexChanged += new System.EventHandler(this.cboCustomerId_SelectedIndexChanged);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustomerId);
            this.Controls.Add(this.CustomerDetailsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDetailsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomerId;
    }
}