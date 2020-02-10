using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Micheal", "Sarah", "Margret", "John" };

            var query1 = from name in names
                         orderby name descending
                         select name;

            var query2 = from name in query1
                         where name.StartsWith("M")
                         select name;

            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
