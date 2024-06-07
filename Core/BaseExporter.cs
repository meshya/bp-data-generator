using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Domain.Types;

namespace DataGenerator.Core
{
    public class BaseExporter
    {
        internal TableStructure structure;
        public BaseExporter(TableStructure tbstr) 
        {
            structure = tbstr;
        }
        public virtual void export(Matris data, string setting) { }
    }
}
