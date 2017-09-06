using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkipList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array that is IEnumerable for demonstration.
            int[] array = { 1, 3, 5, 7, 9, 11 };
            // Get collection of all elements except first two.
            var items1 = array.Skip(2);
            Console.WriteLine("The first two numbers in the array are missing");
            foreach (var value in items1)
            {
                Console.WriteLine(value);
            }
            // Call Skip again but skip the first four elements this time.
            Console.WriteLine();
            var items2 = array.Skip(4);
            Console.WriteLine("The first four numbers are skipped");
            foreach (var value in items2)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
