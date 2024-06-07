using System;
using System.Threading;
using DataGenerator.Domain.Types;
using DataGenerator.Domain.Models;
using DataGenerator.Core;
using DataGenerator.Modules;
using DataGenerator.Handlers.Exporters;

namespace DataGenerator
{
    internal class Control
    {
        private Application app;
        private TableStructure structure;
        private BaseExporter exporter;
        public Control(Application application)
        {
            this.app = application;
            structure = new TableStructure(
                                 new List<Infrastructure>
                                 {
                                     new Infrastructure(1),
                                     new Infrastructure(2),
                                     new Infrastructure(3),
                                     new Infrastructure(4),
                                     new Infrastructure(5),
                                     new Infrastructure(6),
                                     new Infrastructure(7),
                                     new Infrastructure(8),
                                     new Infrastructure(9),
                                     new Infrastructure(10),
                                     new Infrastructure(11),
                                     new Infrastructure(12),
                                     new Infrastructure(13),
                                     new Infrastructure(14),
                                     new Infrastructure(15),
                                     new Infrastructure(16),
                                 },
                                 new List<State>
                                 {
                                    new State(1),
                                    new State(2),
                                    new State(3),
                                    new State(4),
                                    new State(5),
                                    new State(6),
                                    new State(7),
                                    new State(8),
                                    new State(9),
                                    new State(10),
                                 }
                );
            exporter = new ExcelExporter(structure);
        }
        public void Run()
        {
            while (true)
            {
                var data = Generate();
                Export(data);
                Console.WriteLine("Wrote Excel");
                Thread.Sleep(10000);
            }
        }
        public Matris Generate()
        {
            var matris = new Matris();
            foreach (var infrastructure in new Enumurate<Infrastructure>(structure.infrastructures))
            {
                var raw = new DataRaw();
                foreach (var state in new Enumurate<State>(structure.states))
                {
                    bool gened = false;
                    foreach (var generatorType in app.dataGeneratorHolder)
                    {
                        BaseDataGenerator generator = (BaseDataGenerator)Activator
                            .CreateInstance(
                            generatorType,
                            new object[] { structure, state.value, infrastructure.value }
                            );
                        if (generator.MayYouDo())
                        {
                            raw.Push(
                                    generator.Generate()
                                );
                            gened = true;
                            break;
                        }
                    }
                    if (!gened)
                        raw.Push(new Data(0,1));
                }
                matris.Push(raw);
            }
            return matris;
        }
        public void Export(Matris matris)
        {
            exporter.export(matris, "excel.xlsx");
        }
    }
}
