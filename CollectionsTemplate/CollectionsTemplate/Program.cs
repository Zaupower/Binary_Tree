using System;
using System.Collections.Generic;

namespace CollectionsTemplate
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // RandomizedList
            Console.WriteLine("RandomizedList");

            RandomizedList<int> randomCollection = new RandomizedList<int>(new int[] 
            { 
                1,2,3,4,5,6,7,8,9
            });

            foreach (var item in randomCollection)
            {
                Console.WriteLine(item);
            }

            // SimpleCollection
            Console.WriteLine("SimpleCollection");

            SimpleCollection simpleCollection = new SimpleCollection();

            foreach (var item in simpleCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
