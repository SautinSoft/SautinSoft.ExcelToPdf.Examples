using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Sample
    {
        static void Main(string[] args)
        {
			// Before starting, we recommend to get a free key:
            // https://sautinsoft.com/start-for-free/
            
            // Apply the key here:
			// SautinSoft.ExcelToPdf.SetLicense("...");
            // Get sheets number.
            ExcelToPdf x = new ExcelToPdf();

            FileInfo excelFile = new FileInfo(@"..\..\..\test.xlsx");            

            try
            {
                int sheets = x.GetSheetsNumber(excelFile.FullName);
                Console.WriteLine("The file {0} has {1} sheet{2}.",excelFile.Name, sheets, (sheets>1)?"s":"");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.ReadLine();
        }
    }
}
