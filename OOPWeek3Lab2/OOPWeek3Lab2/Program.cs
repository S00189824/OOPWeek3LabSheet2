using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputnumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach (int number in outputnumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
