using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Modules;


namespace DataGenerator.Core
{
    public class ModuleHolder<TBase> : IEnumerable<Type>
    {
        private Dictionary<string, Type> dict = new Dictionary<string, Type>();
        public ModuleHolder () 
        { }
        public void Add<T> (string name)
        {
            if (typeof(T).IsSubclassOf(typeof(TBase)))
                dict.Add(name, typeof(T));
            else
                throw new ArgumentException();
        }
        public IEnumerator<Type> GetEnumerator()
        {
            return new DictEnumurator<string,Type>(dict);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
