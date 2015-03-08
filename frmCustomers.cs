using Northwind.Model;
using System;
using System.Windows.Forms;

namespace Northwind
{
    public partial class frmCustomers : Form
    {
        public frmCustomers ()
        {
            InitializeComponent ();
        }

        private void frmCustomers_Load (object sender, EventArgs e)
        {
            IRead<string, string, string, ComboBox> AllCustId = new ReadCustomersIdList ();
            AllCustId.Display (AllCustId.Read (), cboCustomerId);

            IRead<Customers, string, Customers, DataGridView> AllCust = new ReadCustomers ();
            AllCust.Display (AllCust.Read (), CustomerDetailsDataGrid);
        }

        private void cboCustomerId_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cboCustomerId.SelectedItem != null)
            {
                IRead<Customers, string, Customers, DataGridView> Data = new ReadCustomers ();
                Data.Display (Data.Read ((string)cboCustomerId.SelectedItem), CustomerDetailsDataGrid);
            }
        }

    }
}
