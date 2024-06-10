using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Domain.Models
{
    public class Infrastructure
    {
        public int calcMethodId;
        public string calcMethodName = "";
        public string type;
        public string name = "";
        public double data;
        public int id;
        public Infrastructure(int id, string type)
        {
            this.type = type;
            this.id = id;
        }
        public Infrastructure(string type, string name)
        {
            this.type = type;
            this.name = name;
        }
        public Infrastructure(int id ,string type, string name, int calcMethod, string calcMethodName, double data)
        {
            this.type = type;
            this.name = name;
            this.calcMethodId = calcMethod;
            this.id = id;
            this.calcMethodName = calcMethodName;
            this.data = data;
        }
        public override string ToString()
        {
            return name + "(" + type.ToString() + ")";
        }
    }
}
