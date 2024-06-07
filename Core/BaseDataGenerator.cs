using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Domain.Models;
using DataGenerator.Domain.Types;

namespace DataGenerator.Core
{
    public class BaseDataGenerator
    {
        internal readonly TableStructure structure;
        internal State state;
        internal Infrastructure inf;
        public BaseDataGenerator (TableStructure tableStructure, State state, Infrastructure inf)
        {
            structure = tableStructure;
            this.state = state;
            this.inf = inf;
        }
        public virtual Data Generate() 
        {
            return new Data(0);
        }
        public virtual bool MayYouDo () 
        {
            return false;
        }
    }
}
