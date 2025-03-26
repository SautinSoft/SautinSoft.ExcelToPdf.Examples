Imports System
Imports System.IO
Imports SautinSoft

Module Sample

    Sub Main()
        ' Activate your license here
		
		' Before starting, we recommend to get a free key:
        ' https://sautinsoft.com/start-for-free/
            
        ' Apply the key here:
		' SautinSoft.ExcelToPdf.SetLicense("...");
      
        ' Place your serial(s) number.
        ' You will get own serial number(s) after purchasing the license.
        ' If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.

        ' Convert Excel file to PDF file
        Dim x As New ExcelToPdf()

        ' Set PDF as output format.
        x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf

        Dim excelFile As String = Path.GetFullPath("..\..\..\test.xlsx")
        Dim pdfFile As String = Path.ChangeExtension(excelFile, ".pdf")

        Try
            x.ConvertFile(excelFile, pdfFile)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(pdfFile) With {.UseShellExecute = True})
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub
End Module
