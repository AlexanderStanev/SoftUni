using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    public class Program
    {
        static void Main(string[] args)
        {
            var productsCount = int.Parse(Console.ReadLine());

            var productsPrices = new Dictionary<string, decimal>();
            var input = new List<string>();
            for (int i = 0; i < productsCount; i++)
            {
                input = Console.ReadLine().Split('-').ToList();
                productsPrices[input[0]] = decimal.Parse(input[1]);
            }

            var listOfCustomers = new List<Customer>();

            input = Console.ReadLine().Split('-').ToList();
            while (input[0] != "end of clients")
            {
                var currentCustomer = new Customer();
                currentCustomer.Name = input[0];

                var isACustomer = false;
                var productsQuantity = input[1].Split(',');
                for (int i = 0; i < productsQuantity.Length; i = i + 2)
                {
                    isACustomer = false;
                    var item = productsQuantity[i];
                    var quantity = int.Parse(productsQuantity[i + 1]);

                    if (productsPrices.ContainsKey(item))
                    {
                        currentCustomer.ShopList = new Dictionary<string, int>();
                        currentCustomer.ShopList.Add(item, quantity);
                        isACustomer = true;
                    }
                }

                if (isACustomer)
                {
                    listOfCustomers.Add(currentCustomer);
                }

                input = Console.ReadLine().Split('-').ToList();
            }

            var TotalBill = 0m;
            foreach (var customer in listOfCustomers)
            {
                foreach (var item in customer.ShopList)
                {
                    customer.Bill += productsPrices[item.Key] * item.Value;
                    TotalBill += customer.Bill;
                }
            }

            foreach (var customer in listOfCustomers.OrderBy(x => x.Bill))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {TotalBill:F2}");

        }
    }
}
