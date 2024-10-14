Imports System
Imports System.IO
Imports SautinSoft

Module Sample

    Sub Main()
	
		' Before starting, we recommend to get a free 100-day key:
        ' https://sautinsoft.com/start-for-free/
            
        ' Apply the key here:
		' SautinSoft.ExcelToPdf.SetLicense("...");
        ' Get sheets number.
        Dim x As New ExcelToPdf()

        Dim excelFile As New FileInfo("..\..\..\test.xlsx")

        Try
            Dim sheets As Integer = x.GetSheetsNumber(excelFile.FullName)
            Console.WriteLine("The file {0} has {1} sheet{2}.", excelFile.Name, sheets, If(sheets > 1, "s", ""))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadLine()
    End Sub
End Module
