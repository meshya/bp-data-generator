using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Domain.Models
{
    public class State
    {
        public int num;
        public State(int num) { this.num = num; }
        public override string ToString()
        {
            return "state: "+num.ToString();
        }
    }
}
