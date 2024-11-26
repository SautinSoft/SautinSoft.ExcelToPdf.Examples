using SautinSoft;
using System;
using System.IO;

namespace Sample
{
    class Sample
    {
        static void Main(string[] args)
        {
            // Convert a password protected workbook
            ExcelToPdf x = new ExcelToPdf();

            // Set PDF as output format.
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;

            // Set the user password for restricting access to opening the PDF file.
            x.Options.PdfSecurity.UserPassword = "qwerty";

            // Set the owner password for controlling permissions for editing, printing, and other modifications.
            x.Options.PdfSecurity.OwnerPassword = "";

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