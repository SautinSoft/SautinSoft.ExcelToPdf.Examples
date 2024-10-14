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
            // Make a password in resulting PDF
            ExcelToPdf x = new ExcelToPdf();

            // Set PDF as output format.
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;

            // Set the password for PDF.
            x.Options.PdfSecurity.EncryptionAlgorithm = ExcelToPdf.PdfEncryptionAlgorithm.RC4_128;
            x.Options.PdfSecurity.Permissions = ExcelToPdf.PdfPermissions.Printing;
            x.Options.PdfSecurity.UserPassword = "123456";
            // The password cannot be in PDF-A. Change to PDF 1.5.
            x.Options.PdfVersion = ExcelToPdf.COptions.ePdfVersion.PDF_15;

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
