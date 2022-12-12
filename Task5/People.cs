using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sity { get; set; }

        public int CompareTo(People people)
        {
            if (Name.CompareTo(people.Name) != 0)
            {
                return Name.CompareTo(people.Name);
            }

            if (Age.CompareTo(people.Age) != 0)
            {
                return Age.CompareTo(people.Age);
            }

            return Sity.CompareTo(people.Sity);
        }
    }
}
