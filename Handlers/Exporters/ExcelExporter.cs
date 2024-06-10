using DataGenerator.Core;
using DataGenerator.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using DataGenerator.Modules;

namespace DataGenerator.Handlers.Exporters
{
    class ExcelWriter 
    {
        private ExcelWorksheet _wsh;
        private int _i = 1, _j = 1;
        public ExcelWriter(ExcelWorksheet wsh)
        {
            _wsh = wsh;
        }
        public void nextRow()
        {
            _i++;
            _j = 1;
        }
        public void insert(string value)
        {
            _wsh.Cells[_i, _j].Value = value;
            _j++;            
        }
    }
    public class ExcelExporter: BaseExporter
    {
        public ExcelExporter(TableStructure _tbstr):base(_tbstr)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
        }
        public override void export(Matris matris, string setting)
        {
            using(var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                var wshWriter = new ExcelWriter(worksheet);
                wshWriter.insert("id");
                wshWriter.insert("name");
                wshWriter.insert("type");
                wshWriter.insert("method id");
                wshWriter.insert("method name");
                foreach (var state in structure.states)
                {
                    wshWriter.insert(state.ToString());
                }
                wshWriter.nextRow();
                foreach(var col in new Enumurate<DataRaw>(matris))
                {
                    wshWriter.insert(col.value.infrastructure.id.ToString());
                    wshWriter.insert(col.value.infrastructure.name.ToString());
                    wshWriter.insert(col.value.infrastructure.type.ToString());
                    wshWriter.insert(col.value.infrastructure.calcMethodId.ToString());
                    wshWriter.insert(col.value.infrastructure.calcMethodName.ToString());
                    foreach(var data in new Enumurate<Data>(col.value)) 
                    {
                        wshWriter.insert(((data.value.value/100 + 1)*data.value.infrastructure.data).ToString());
                    }
                    wshWriter.nextRow();
                }
                package.SaveAs(new FileInfo(setting));
            }
        }
    }
}
