using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace HashTableSaymaSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add four elements to Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "ocak");
            hashtable.Add(2, "şubat");
            hashtable.Add(3, "mart");
            hashtable.Add(10, "nisan");
            Console.WriteLine("Get Count of Hashtable--------");
            // Get Count of Hashtable.
            int count = hashtable.Count;
            Console.WriteLine(count);
            Console.WriteLine();
            Console.WriteLine("Clear the Hashtable--------");
            // Clear the Hashtable.
            hashtable.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Get Count of Hashtable again--------");
            // Get Count of Hashtable again.
            Console.WriteLine(hashtable.Count);
            Console.ReadLine();
        }
    }
}
