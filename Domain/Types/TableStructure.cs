using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructures = System.Collections.Generic.List<DataGenerator.Domain.Models.Infrastructure>;
using States = System.Collections.Generic.List<DataGenerator.Domain.Models.State>;

namespace DataGenerator.Domain.Types
{
    public struct TableStructure
    {
        public Infrastructures infrastructures { get; }
        public States states { get; }
        public TableStructure(Infrastructures infrastructures, States states)
        {
            this.infrastructures = infrastructures;
            this.states = states;
        }
    }
}
