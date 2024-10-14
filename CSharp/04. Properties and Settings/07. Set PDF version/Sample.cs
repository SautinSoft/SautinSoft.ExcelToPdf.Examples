using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Sample
    {
        static void Main(string[] args)
        {
			// Before starting, we recommend to get a free 100-day key:
            // https://sautinsoft.com/start-for-free/
            
            // Apply the key here:
			// SautinSoft.ExcelToPdf.SetLicense("...");
            // Convert Excel file to PDF file
            ExcelToPdf x = new ExcelToPdf();

            // Set PDF as output format.
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;
            // Set pdf out version as PDF_A
            // The component can create PDF_A1, PDF_A2, etc
            x.Options.PdfVersion = ExcelToPdf.COptions.ePdfVersion.PDF_A1a;

            string excelFile = Path.GetFullPath(@"..\..\..\test.xlsx");
            string pdfFile = Path.ChangeExtension(excelFile, ".pdf"); ;

            try
            {
                x.ConvertFile(excelFile, pdfFile);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfFile) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
