using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Set set1 = new Set();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            Set set2 = new Set();
            set2.Add(2);
            set2.Add(3);
            set2.Add(4);


            Console.WriteLine(" 1: " + string.Join(", ", set1.GetElements()));
            Console.WriteLine("Множина 2: " + string.Join(", ", set2.GetElements()));
            Console.WriteLine("Множині 1 належить 2: " + set1.Contains(2));
            Console.WriteLine("Множина є підмножиною Множини 2: " + set1.IsSubsetOf(set2));
            Console.WriteLine("Множина 1 дорівнює Множині 2: " + set1.Equals(set2));

            Set unionSet = set1.Union(set2);
            Console.WriteLine("Об'єднання Множини 1 і Множини 2: " + string.Join(", ", unionSet.GetElements()));

            Set intersectionSet = set1.Intersection(set2);
            Console.WriteLine("Перетин Множини 1 і Множини 2: " + string.Join(", ", intersectionSet.GetElements()));

            Set differenceSet = set1.Difference(set2);
            Console.WriteLine("Різниця Множини 1 і Множини 2: " + string.Join(", ", differenceSet.GetElements()));

            Set symmetricDifferenceSet = set1.SymmetricDifference(set2);
            Console.WriteLine("Симетрична різниця Множини 1 і Множини 2: " + string.Join(", ", symmetricDifferenceSet.GetElements()));
        }
    }
}
