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
            // Convert Excel file to DOCX file
            ExcelToPdf x = new ExcelToPdf();

            // Set DOCX as output format.
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Docx;

            string excelFile = Path.GetFullPath(@"..\..\..\test.xlsx");
            string docxFile = Path.ChangeExtension(excelFile, ".docx"); ;

            try
            {
                x.ConvertFile(excelFile, docxFile);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(docxFile) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
