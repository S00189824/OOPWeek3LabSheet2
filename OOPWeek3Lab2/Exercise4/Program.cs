﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deferred Execution

            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            //var query = number in numbers
            //            select DoubleIt(numbers)

            var query = numbers.Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach Loop");

            foreach (var item in query)
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
