Imports SautinSoft
Imports System
Imports System.IO

Namespace Sample
	Friend Class Sample
		Shared Sub Main(ByVal args() As String)
			' Convert a password protected workbook
			Dim x As New ExcelToPdf()

			' Set PDF as output format.
			x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf

			' Set the user password for restricting access to opening the PDF file.
			x.Options.PdfSecurity.UserPassword = "qwerty"

			' Set the owner password for controlling permissions for editing, printing, and other modifications.
			x.Options.PdfSecurity.OwnerPassword = ""

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
	End Class
End Namespace
