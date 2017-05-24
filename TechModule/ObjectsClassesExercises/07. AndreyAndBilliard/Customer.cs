using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Customer
    {
        public string Name
        {
            get;
            set;
        }
        public Dictionary<string, int> ShopList
        {
            get;
            set;
        }
        public decimal Bill
        {
            get;
            set;
        }
    }
}
