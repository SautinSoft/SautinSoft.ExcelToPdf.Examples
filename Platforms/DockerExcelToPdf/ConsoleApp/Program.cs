// Get your free key here:   
// https://sautinsoft.com/start-for-free/

using SautinSoft;

// Convert Excel to PDF in memory
ExcelToPdf x = new ExcelToPdf();

// Set PDF as output format.
x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;

string excelFile = @"test.xlsx";
string pdfFile = @"test.pdf";
byte[] pdfBytes = null;

try
{
    // Let us say, we have a memory stream with Excel data.
    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(excelFile)))
    {
        pdfBytes = x.ConvertBytes(ms.ToArray());
    }
    // Save pdfBytes to a file for demonstration purposes.
    File.WriteAllBytes(pdfFile, pdfBytes);
  //  System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfFile) { UseShellExecute = true });

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}
