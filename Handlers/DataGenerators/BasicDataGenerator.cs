using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Core;
using DataGenerator.Domain.Models;
using DataGenerator.Domain.Types;

namespace DataGenerator.Handlers.DataGenerators
{
    public class BasicDataGenerator: BaseDataGenerator
    {
        private Random random;
        public BasicDataGenerator(TableStructure tableStructure, State state, Infrastructure inf):
            base(tableStructure, state, inf)
        {
            random = new Random();
        }
        public override bool MayYouDo()
        {
            return true;
        }
        public override Data Generate()
        {
            return new Data(random.Next(-10,10));
        }
    }
}
