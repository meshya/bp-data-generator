using DataGenerator.Handlers.DataGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    internal class Startup
    {
        private Application application;
        public Startup (Application application) 
        {
            this.application = application;
        }
        public void StartUp() 
        {
            application.Enable<BasicDataGenerator>("base");
        }
    }
}
