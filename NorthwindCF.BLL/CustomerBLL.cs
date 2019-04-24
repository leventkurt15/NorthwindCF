using NorthwindCF.DAL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCF.BLL
{
    public class CustomerBLL
    {
        public static List<Customer> Getcustomer()
        {
            NorthwindDbConext db = new NorthwindDbConext();
            return db.Customers.ToList();
        }

    }
}
