using DataGenerator.Domain.Models;
using DataGenerator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Domain.Types
{
    public class DataRaw: AutoEnumurable<Data>
    {
        public State state { get; set; }
        public List<Data> datas { get; set; }
        public DataRaw() 
        {
            datas = new List<Data>();
        }
        public void Push(double value)
        {
            datas.Add(new Data(value));
        }
        public void Push(Data value)
        {
            datas.Add(value);
        }
        internal override List<Data> GetList()
        {
            return datas;
        }
    }
}
