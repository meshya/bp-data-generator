using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Modules
{
    internal class ListEnumurator<T> : IEnumerator<T>
    {
        private List<T> _items;
        private int _position = -1;

        public ListEnumurator(List<T> dict)
        {
            _items = dict;
        }

        public T Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
            // Dispose resources if needed
        }
    }

}
