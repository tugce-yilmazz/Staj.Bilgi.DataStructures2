using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HashTableIcerik
{
    class Program
    {
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
        static void Main()
        {
            Hashtable hashtable = GetHashtable();
            Console.WriteLine("Contains Method--------");
            // See if the Hashtable contains this key.
            Console.WriteLine(hashtable.ContainsKey("Perimeter"));
            // Test the Contains method.
            // ... It works the same way.
            Console.WriteLine(hashtable.Contains("Area"));
            // Get value of Area with indexer.
            int value = (int)hashtable["Area"];
            Console.WriteLine();
            Console.WriteLine("Write the value of Area--------");
            // Write the value of Area.
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
