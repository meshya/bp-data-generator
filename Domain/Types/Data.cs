using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Domain.Types
{
    public struct Data
    {
        public double value;
        public int error = 0;
        public Data(double value)
        {
            this.value = value;
        }
        public Data(double value, int error)
        {
            this.value = value;
            this.error = error;
        }
        public string ToSting()
        {
            return Convert.ToString(value);
        }
    }
}
