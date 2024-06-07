using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Modules
{
    public class EnumurateEnumurator<T> : IEnumerator<EnumurateObject<T>>
    {
        private IEnumerator<T> _enumurator;
        private int _position = -1;

        public EnumurateEnumurator(IEnumerable<T> enumurable)
        {
            _enumurator = enumurable.GetEnumerator();
        }

        public EnumurateObject<T> Current
        {
            get
            {
                try
                {
                    return new EnumurateObject<T>
                    {
                        num = _position,
                        value = _enumurator.Current
                    };
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
            return _enumurator.MoveNext();
        }

        public void Reset()
        {
            _position = -1;
            _enumurator.Reset();
        }

        public void Dispose()
        {
            _enumurator.Dispose();
        }
    }

}
