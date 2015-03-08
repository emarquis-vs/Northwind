using Northwind.Model;
using System;
using System.Windows.Forms;

namespace Northwind
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails ()
        {
            InitializeComponent ();
        }

        private void OrderDetails_Load (object sender, EventArgs e)
        {
            IRead<int, int, int, ComboBox> Data = new ReadOrdersId ();
            Data.Display (Data.Read (), cboOrderId);
        }

        private void cboOrderId_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cboOrderId.SelectedItem != null)
            {
                IRead<Products, int, Products, DataGridView> Data = new ReadProductsByOrderId ();
                Data.Display (Data.Read ((int)cboOrderId.SelectedItem), OrderDetailsDataGrid);
            }
        }
    }
}
