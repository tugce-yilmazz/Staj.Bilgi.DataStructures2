using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HashTableSayma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Hashtable.
            Hashtable clouds = new Hashtable();
            clouds.Add("Cirrus", "Castellanus");
            clouds.Add("Cirrocumulus", "Stratiformis");
            clouds.Add("Altostratus", "Radiatus");
            clouds.Add("Stratocumulus", "Perlucidus");
            clouds.Add("Stratus", "Fractus");
            clouds.Add("Nimbostratus", "Pannus");
            clouds.Add("Cumulus", "Humilis");
            clouds.Add("Cumulonimbus", "Incus");
            // Displays the keys and values of the Hashtable using GetEnumerator()
            Console.WriteLine("Displays the keys and values of the Hashtable using GetEnumerator()--------");
            IDictionaryEnumerator denum = clouds.GetEnumerator();
            DictionaryEntry dentry;
            Console.WriteLine();
            Console.WriteLine("    Cloud Type       Variation");
            Console.WriteLine("    -----------------------------");
            while (denum.MoveNext()) {
                dentry = (DictionaryEntry)denum.Current;
                Console.WriteLine("    {0,-17}{1}", dentry.Key, dentry.Value);
            }
            // Displays the keys and values of the Hashtable using foreach statement
            Console.WriteLine("\nDisplays the keys and values of the Hashtable using foreach statement--------");
            Console.WriteLine("\n    Cloud Type       Variation");
            Console.WriteLine("    -----------------------------");
            foreach (DictionaryEntry de in clouds) {
                Console.WriteLine("    {0,-17}{1}", de.Key, de.Value);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
