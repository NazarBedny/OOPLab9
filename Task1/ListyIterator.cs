using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ListyIterator<T>
    {
        List<T> _items;
        public ListyIterator(List<T> items)
        {
            _items = items;
        }


        int position = -1;
        public bool HasNext()
        {
            if (position < _items.Count-1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Move()
        {
            if (HasNext())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (_items.Count>0)
            {
                Console.WriteLine(_items[position]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation");
            }
        }
    }
}
