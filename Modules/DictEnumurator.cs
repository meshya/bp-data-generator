using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Modules
{
    internal class DictEnumurator<K, T> : ListEnumurator<T>
    {
        public DictEnumurator(Dictionary<K, T> dict) : base(dict.Values.ToList())
        { }
    }

}
