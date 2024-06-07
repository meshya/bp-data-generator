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
    internal class ExcelExporter: BaseExporter
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
                foreach(var col in new Enumurate<DataRaw>(matris))
                {
                    foreach(var data in new Enumurate<Data>(col.value)) 
                    {
                        worksheet.Cells[col.num + 1, data.num + 1].Value = data.value.ToSting();
                    }
                }
                package.SaveAs(new FileInfo(setting));
            }
        }
    }
}
