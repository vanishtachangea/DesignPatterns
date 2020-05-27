using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour
{
    public interface IExport
    {
        void Save();
    }
    public class ExportToWord : IExport
    {
        public void Save()
        {
            Console.WriteLine("Save To Word");
           // throw new NotImplementedException();
        }
    }
    public class ExportToExcel : IExport
    {
        public void Save()
        {
            Console.WriteLine("Save To Excel");
            //throw new NotImplementedException();
        }
    }
    public class Test : IExport
    {
        public void Save()
        {
            Console.WriteLine("Save To Excel");
            //throw new NotImplementedException();
        }
    }

    public class ThirdPartyLibraryExportPDF 
    {
        public void Export()
        {
            Console.WriteLine("Export to PDF Using third party library");
        }
    }
}
