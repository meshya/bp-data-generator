using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Modules
{
    public class Enumurate<T> : IEnumerable<EnumurateObject<T>>
    {
        private IEnumerable<T> _enumerable;
        public Enumurate(IEnumerable<T> enumerable)
        {
            _enumerable = enumerable;
        }

        public IEnumerator<EnumurateObject<T>> GetEnumerator()
        {
            return new EnumurateEnumurator<T>(_enumerable);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
