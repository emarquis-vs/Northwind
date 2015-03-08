using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System;
using Northwind.Model;

namespace Northwind
{
    public class ReadSuppliersIdList : CRUD<NorthwindEntities>, IRead<int, int, int, ComboBox>
    {
        public int[] Read ([Optional] int Id)
        {
            return (
                        from s in edm.Suppliers
                        orderby s.SupplierID ascending
                        select s.SupplierID
                       )
                        .ToArray ();
        }

        public void Display (int[] SuppliersId, ComboBox cboSupplierId)
        {
            foreach (int id in SuppliersId)
                cboSupplierId.Items.Add (id);
        }
    }

    public class ReadSuppliersProducts : CRUD<NorthwindEntities>, IRead<Suppliers, int, Suppliers, DataGridView>
    {
        public Suppliers[] Read ([Optional] int SupplierId)
        {
            if (SupplierId == 0)
            {
                return (
                            from s in edm.Suppliers
                            orderby s.CompanyName ascending
                            select s
                           )
                            .ToArray ();
            }
            else
            {
                return (
                            from s in edm.Suppliers
                            where s.SupplierID == SupplierId
                            orderby s.CompanyName ascending
                            select s
                           )
                            .ToArray ();
            }
        }

        public void Display (Suppliers[] suppliers, DataGridView Grid)
        {
            Grid.Visible = false;
            Grid.ColumnCount = 4;
            Grid.Columns[0].Visible = true;
            Grid.Rows.Clear ();

            foreach (Suppliers s in suppliers)
            {
                Grid.Rows.Add (s.SupplierID, s.CompanyName, s.Country, s.Phone);
                Grid.Rows[Grid.RowCount - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

                foreach (Products p in s.Products.OrderBy (product => product.ProductName))
                {
                    Grid.Rows.Add (
                                            p.ProductID,
                                            p.ProductName,
                                            p.UnitsInStock,
                                            p.ReorderLevel
                                           );
                }
            }
            Grid.Visible = true;
        }
    }

    public class UpdateSupplierProduct : CRUD<NorthwindEntities>, IUpdate<DataGridViewCellCollection>
    {
        public void Update (DataGridViewCellCollection Fields)
        {
            try
            {
                int Id = (int)Fields[0].Value;
                Products Product = edm.Products.First (p => p.ProductID == Id);

                Product.ProductName = Fields[1].Value.ToString ();
                Product.UnitsInStock = (short)(Fields[2].Value);
                Product.ReorderLevel = (short)(Fields[3].Value);

                //EntityModel.Entry(Product).CurrentValues.SetValues(Fields);
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

