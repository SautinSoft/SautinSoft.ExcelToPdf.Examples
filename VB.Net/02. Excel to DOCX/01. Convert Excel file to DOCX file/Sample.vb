Imports System
Imports System.IO
Imports SautinSoft

Module Sample

    Sub Main()
	
		' Before starting, we recommend to get a free key:
        ' https://sautinsoft.com/start-for-free/
            
        ' Apply the key here:
		' SautinSoft.ExcelToPdf.SetLicense("...");
        ' Convert Excel file to DOCX file
        Dim x As New ExcelToPdf()

        ' Set DOCX as output format.
        x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Docx

        Dim excelFile As String = Path.GetFullPath("..\..\..\test.xlsx")
        Dim docxFile As String = Path.ChangeExtension(excelFile, ".docx")

        Try
            x.ConvertFile(excelFile, docxFile)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(docxFile) With {.UseShellExecute = True})
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub
End Module
