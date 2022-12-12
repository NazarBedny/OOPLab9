using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var info = input.Split(' ');
                var name = info[0];
                var age = int.Parse(info[1]);
                var sity = info[2];
                people.Add(new People { Name = name, Age = age, Sity = sity });
            }
            int index = int.Parse(Console.ReadLine()) - 1;
            People person = people[index];

            int coincidence = 0;
            int  dismatch= 0;

            foreach (var item in people)
            {
                if (item.CompareTo(person) == 0)
                {
                    coincidence++;
                }
                else
                {
                    dismatch++;
                }
            }

            if (coincidence > 1)
            {
                Console.WriteLine($"{coincidence} {dismatch} {coincidence + dismatch}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
