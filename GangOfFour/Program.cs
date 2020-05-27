using System;
using System.Collections.Generic;

namespace GangOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello To Design Patterns!");

           

            IExport export = new ExportToExcel();
            export.Save();

            export = new ExportToWord();
            export.Save();

            Console.WriteLine("Adapter : Before");
            ThirdPartyLibraryExportPDF  thirdPartyLibraryExportPDF = new ThirdPartyLibraryExportPDF();
            thirdPartyLibraryExportPDF.Export();

            Console.WriteLine("Adapter : After");
            export = new PDFExportAdaptor();
            export.Save();

            Console.WriteLine("Factory : Before");
            //ITax tax = new Tax1();
            ITax tax = new NewTax();//No decoupling because each time there is a change 
            //we need to change it here in the client side. Solution: centralise the New Keyword/Create

            tax.Calculate();

            Console.WriteLine("Factory : After");
            ITax tx = SimpleFactory.Create(1);
            tx.Calculate();

            Console.WriteLine("Iterator : Before");
            Report report = new Report();
            report.GetCountries();
            Console.WriteLine("Iterator : After");
            IEnumerable<Country> coun = report.GetCountries();
            Console.ReadLine();
        }
    }
}
