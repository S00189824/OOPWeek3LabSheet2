﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (MyFileInfo item in query)
            {
                Console.WriteLine(
                    "{0} \t{1} bytes,\t{2}",
                    item.Name, item.Length, item.CreationTime);
            }
            Console.ReadKey();
        }

        
    }

    public class MyFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-30} {1 : F0} MB\t{2}",Name, Length/10000, CreationTime);
        }
    }
}
