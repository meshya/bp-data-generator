using DataGenerator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Domain.Types
{
    public class Matris: AutoEnumurable<DataRaw>
    {
        public List<DataRaw> Raws { get; set; }
        public Matris(List<DataRaw> raws) 
        { 
            Raws = raws; 
        }
        public Matris() 
        {
            Raws = new List<DataRaw>();
        }
        public void Push (DataRaw raw)
        {
            Raws.Add(raw);
        }
        internal override List<DataRaw> GetList()
        {
            return Raws;
        }
    }
}
