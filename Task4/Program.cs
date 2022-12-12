using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

            Lake lake = new Lake(stones);

            foreach (var item in lake)
            {
                Console.Write(", "+item);
            }

            
        }
    }
}
