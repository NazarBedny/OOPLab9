using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            if (countOfPeople > 100 || countOfPeople < 0)
            {
                Console.WriteLine("uncorrect count");
            }
            SortedSet<Person> sortByName = new SortedSet<Person>(new CompareName());
            SortedSet<Person> sortByAge = new SortedSet<Person>(new CompareAge());


            for (int i = 0; i < countOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (int.Parse(input[1]) > 100 || int.Parse(input[1]) < 1 || input[0].Length > 50|| input[0].Length<1)
                {
                    Console.WriteLine("uncorrect input");
                }
                Person person = new Person(input[0], int.Parse(input[1]));
                sortByName.Add(person);
                sortByAge.Add(person);
            }


            foreach (var person in sortByName)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            foreach (var person in sortByAge)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
