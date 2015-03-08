using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Northwind
{
    public partial class frmNorthwindMap : Form
    {
        public frmNorthwindMap ()
        {
            InitializeComponent ();
        }

        IDictionary<string, string> FormNames = new Dictionary<string, string> ();
        private void MatchEntityTableNamesToFormNames ()
        {
            FormNames.Add ("Order_Details", "frmOrderDetails");
            FormNames.Add ("Suppliers", "frmSuppliersProducts");
            FormNames.Add ("Customers", "frmCustomers");
        }

        private void NorthwindMap_Load (object sender, EventArgs e)
        {
            MatchEntityTableNamesToFormNames ();

            CRUD<NorthwindEntities> CRUD = new CRUD<NorthwindEntities> ();
            foreach (var TableName in CRUD.EdmTablesList)
                cboSubject.Items.Add (TableName);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            string FormName = string.Empty;

            if (FormNames.TryGetValue (cboSubject.SelectedItem.ToString (), out FormName))
                ShowForm (FormName);
            else
                MessageBox.Show (
                                                "There is no screen created for " + cboSubject.SelectedItem.ToString () + " yet.",
                                                "Undefined Screen",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information
                                             );
        }

        private void ShowForm (string FormName)
        {
            try
            {
                string NameSpace = this.GetType ().Namespace.ToString ();
                Form form = (Form)Activator.CreateInstance (Type.GetType (NameSpace + "." + FormName));
                form.Show ();
            }
            catch (Exception err) { MessageBox.Show (err.Message); }
        }
    }
}
