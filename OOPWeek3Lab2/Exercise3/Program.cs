using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnonymous();
        }


        private static void GetAnonymous()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine(
                    "{0} \t{1} bytes,\t{2}",
                    item.Name, item.Length, item.CreationTime);
            }
            Console.ReadLine();
        }
    }

    

    public class FileInfo
    {
        public string Name { get; set; }

        public long Length { get; set; }

        public DateTime CreationTime;
    }
}
