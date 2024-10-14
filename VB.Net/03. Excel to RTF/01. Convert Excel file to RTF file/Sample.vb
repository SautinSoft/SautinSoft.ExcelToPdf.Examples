Imports System
Imports System.IO
Imports SautinSoft

Module Sample

    Sub Main()
	
		' Before starting, we recommend to get a free 100-day key:
        ' https://sautinsoft.com/start-for-free/
            
        ' Apply the key here:
		' SautinSoft.ExcelToPdf.SetLicense("...");
        ' Convert Excel file to RTF file
        Dim x As New ExcelToPdf()

        ' Set RTF as output format.
        x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Rtf

        Dim excelFile As String = Path.GetFullPath("..\..\..\test.xlsx")
        Dim rtfFile As String = Path.ChangeExtension(excelFile, ".rtf")


        Try
            x.ConvertFile(excelFile, rtfFile)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(rtfFile) With {.UseShellExecute = True})
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub
End Module
