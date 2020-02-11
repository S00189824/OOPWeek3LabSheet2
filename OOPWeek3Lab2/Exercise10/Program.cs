using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCustomers();
            Console.ReadLine();
        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            var query1 = from c in customers
                         where c.City == "Dublin" || c.City == "Galway"
                         orderby c.Name
                         select c;

            foreach (var item in query1)
            {
                Console.WriteLine(item.Name + " " + item.City);
            }

            return customers;

        }

    }
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
