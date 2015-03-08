using System.Runtime.InteropServices;
using System.Linq;
using Northwind.Model;

namespace Northwind
{
    public class ReadOrdersId : CRUD<NorthwindEntities>, IRead<int, int, int, System.Windows.Forms.ComboBox>
    {
        public int[] Read (int Id = 0)
        {
            return (
                        from o in edm.Order_Details
                        orderby o.OrderID ascending
                        select o.OrderID
                       )
                        .ToArray ();
        }

        public void Display (int[] OrdersId, System.Windows.Forms.ComboBox ComboBox)
        {
            foreach (int id in OrdersId.Distinct ())
                ComboBox.Items.Add (id);
        }
    }
}
