using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Domain.Models;

namespace DataGenerator.Domain.Types
{
    public struct Data
    {
        public double value;
        public int error = 0;
        public Infrastructure infrastructure;
        public State state;
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
