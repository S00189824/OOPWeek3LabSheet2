using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = from number in numbers
                         orderby number descending
                         select number;

            var query2 = from number in query1
                         where number < 8
                         select number;

            var query3 = from number in query2
                         select DoubleIt(number);

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number" + value.ToString());
            return value * 2;
        }
    }
}
