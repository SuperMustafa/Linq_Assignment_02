using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Session_02_demo.MyData
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }
        public Order()
        {

        }

        public override string ToString()
            => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
    }
}
