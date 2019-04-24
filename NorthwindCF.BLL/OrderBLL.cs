using NorthwindCF.DAL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.BLL
{
   public static class OrderBLL
    {

        public static List<Order> OrderListele(string CustomerID)
        {
            NorthwindDbConext order = new NorthwindDbConext();
            return order.Orders.Where(x => x.CustomerID == CustomerID).ToList();


        }
       

    }
}
