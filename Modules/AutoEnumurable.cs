using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Modules
{
    public class AutoEnumurable<T>: IEnumerable<T>
    {
        internal virtual List<T> GetList()
        {
            return new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumurator<T>(GetList());
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
