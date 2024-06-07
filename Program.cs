using DataGenerator.Core;

namespace DataGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            new Application().Run();
        }
    }
    internal class Application
    {
        public ModuleHolder<BaseDataGenerator> dataGeneratorHolder = new ModuleHolder<BaseDataGenerator>();
        public ModuleHolder<BaseExporter> exporterHolder = new ModuleHolder<BaseExporter>();
        public Application ()
        {
        }
        public void Run ()
        {
            new Startup(this).StartUp();
            new Control(this).Run();
        }
        public void Enable<T>(string name)
        {
            if (typeof(T).IsSubclassOf(typeof(BaseDataGenerator)))
                this.dataGeneratorHolder.Add<T>(name);
            else if (typeof(T).IsSubclassOf(typeof(BaseExporter)))
                this.exporterHolder.Add<T>(name);
        }

    }
}