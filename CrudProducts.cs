using System.Windows.Forms;
using System.Linq;
using Northwind.Model;

namespace Northwind
{
    public class ReadProductsByOrderId : CRUD<NorthwindEntities>, IRead<Products, int, Products, DataGridView>
    {
        public Products[] Read (int OrderId)
        {
            return (
                        from p in edm.Products
                        join o in edm.Order_Details
                        on p.ProductID equals o.ProductID
                        where o.OrderID == OrderId
                        select p
                       )
                        .ToArray ();
        }

        public void Display (Products[] products, DataGridView Grid)
        {
            Grid.Visible = false;
            Grid.Rows.Clear ();

            foreach (Products p in products)
            {
                Grid.Rows.Add (p.ProductName, p.UnitPrice + " €", p.UnitsInStock + " in stock");
                Grid.Rows[Grid.RowCount - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

                foreach (Order_Details o in p.Order_Details)
                {
                    Grid.Rows.Add (
                                             o.Orders.ShipName,
                                             o.Orders.ShipAddress,
                                             o.Quantity +
                                                        " ordered and required before '" +
                                                        System.String.Format ("{0:d MMMM yyyy}", o.Orders.RequiredDate) + "'"
                                             );
                }
                Grid.Rows.Add ();
            }
            Grid.Visible = true;
        }
    }
}
