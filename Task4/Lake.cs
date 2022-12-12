using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Lake : IEnumerable
    {
        int[] _items;
        public Lake(int[] items)
        {
            _items = items;
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i += 2)
            {
                yield return _items[i];
            }

            int backwardsStartIndex = _items.Length % 2 == 0 ? _items.Length - 1 : _items.Length - 2;

            for (int i = backwardsStartIndex; i > 0; i -= 2)
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
