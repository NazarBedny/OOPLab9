using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stack<T> : IEnumerable<T>
    {
        List<T> _items;
        int position = -1;
        public Stack()
        {
            _items = new List<T>();
        }




        public void Push(List<T> elements)
        {
            _items.AddRange(elements);
            position = _items.Count()-1;
        }

        public void Pop()
        {
            if (position < 0)
            {
                throw new InvalidOperationException("No elements");
            }

            position--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = position; i>=0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
