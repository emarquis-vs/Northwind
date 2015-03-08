using Northwind.Model;
using System;
using System.Windows.Forms;

namespace Northwind
{
    public partial class frmSuppliersProducts : Form
    {
        public frmSuppliersProducts ()
        {
            InitializeComponent ();
        }

        private void SuppliersProducts_Load (object sender, EventArgs e)
        {
            IRead<int, int, int, ComboBox> Data = new ReadSuppliersIdList ();
            Data.Display (Data.Read (), cboSupplierId);
            
            this.btnShowAllSuppliers_Click (sender, e);
        }

        private void btnShowOneSupplier_Click (object sender, EventArgs e)
        {
            if (cboSupplierId.SelectedItem != null)
            {
                IRead<Suppliers, int, Suppliers, DataGridView> Data = new ReadSuppliersProducts ();
                Data.Display (Data.Read ((int)cboSupplierId.SelectedItem), SuppliersProductsDataGrid);
            }
        }

        private void btnShowAllSuppliers_Click (object sender, EventArgs e)
        {
            IRead<Suppliers, int, Suppliers, DataGridView> Data = new ReadSuppliersProducts ();
            Data.Display (Data.Read (), SuppliersProductsDataGrid);
        }

        private void SuppliersProductsDataGrid_RowLeave (object sender, DataGridViewCellEventArgs e)
        {
            if (SuppliersProductsDataGrid.IsCurrentRowDirty)
            {
                SuppliersProductsDataGrid.EndEdit ();

                IUpdate<DataGridViewCellCollection> Data = new UpdateSupplierProduct ();
                Data.Update (SuppliersProductsDataGrid.Rows[e.RowIndex].Cells);
            }
        }
    }
}
