using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System;
using Northwind.Model;

namespace Northwind
{
    public class ReadCustomersIdList : CRUD<NorthwindEntities>, IRead<string, string, string, ComboBox>
    {
        public string[] Read ([Optional] string Id)
        {
            return (
                        from c in edm.Customers
                        orderby c.CustomerID ascending
                        select c.CustomerID
                       )
                        .ToArray ();
        }

        public void Display (string[] CustomersId, ComboBox cboCustomerId)
        {
            foreach (string id in CustomersId)
                cboCustomerId.Items.Add (id);
        }
    }

    public class ReadCustomers : CRUD<NorthwindEntities>, IRead<Customers, string, Customers, DataGridView>
    {
        public Customers[] Read ([Optional] string Id)
        {
            if (Id == null)
            {
                return (
                            from c in edm.Customers
                            orderby c.CompanyName ascending
                            select c
                           )
                            .ToArray ();
            }
            else
            {
                return (
                            from c in edm.Customers
                            where c.CustomerID == Id
                            orderby c.CompanyName ascending
                            select c
                           )
                           .ToArray ();
            }
        }

        public void Display (Customers[] customers, DataGridView Grid)
        {
            Grid.Visible = false;
            Grid.ColumnCount = 4;
            Grid.Columns[0].Visible = true;
            Grid.Rows.Clear ();

            foreach (Customers c in customers)
                Grid.Rows.Add (c.CustomerID, c.CompanyName, c.Country, c.City);

            Grid.Visible = true;
        }
    }

    public class UpdateCustomer : CRUD<NorthwindEntities>, IUpdate<DataGridViewCellCollection>
    {
        public void Update (DataGridViewCellCollection Fields)
        {
            try
            {
                string Id = (string)Fields[0].Value;
                Customers Customer = edm.Customers.First (c => c.CustomerID == Id);

                Customer.CompanyName = (string)Fields[1].Value;
                Customer.Country = (string)Fields[2].Value;
                Customer.City = (string)Fields[3].Value;

                //EntityModel.Entry(Customer).CurrentValues.SetValues(Fields);
                int num = edm.SaveChanges ();
                Console.WriteLine (num.ToString () + " updates saved.");
            }
            catch (Exception err)
            {
                Console.WriteLine (err.InnerException.Message);
            }
        }
    }
}

