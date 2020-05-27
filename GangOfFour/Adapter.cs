using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour
{
    class Adapter
    {
    }
    public class PDFExportAdaptor : IExport
    {
        public void Save()
        {
            ThirdPartyLibraryExportPDF thirdPartyLibraryExportPDF = new ThirdPartyLibraryExportPDF
                ();
            thirdPartyLibraryExportPDF.Export();
        }
    }
}
