using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class CompareName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }
}
