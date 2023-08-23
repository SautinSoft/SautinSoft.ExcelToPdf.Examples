![Nuget](https://img.shields.io/nuget/v/SautinSoft.ExcelToPdf) ![Nuget](https://img.shields.io/nuget/dt/SautinSoft.ExcelToPdf) 
![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%202505%20tests%20passed%20(0%20failed)-logo=visualstudio) 
![windows](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=windows)
![macOS](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=apple)
![linux](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=linux&logoColor=white)
![docker](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=docker&logoColor=white)
![aws](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=amazonaws)
![microsoftazure](https://img.shields.io/badge/%20-%20%E2%9C%93?logo=microsoftazure)
# .NET SDK to convert Excel (xls, xlsx) to PDF


![Excel](https://user-images.githubusercontent.com/79837963/229030126-091cb2c1-5b13-4295-8f44-ed2b3e34aab1.png)



[SautinSoft.Excel](https://sautinsoft.com/products/excel-to-pdf/) is .NET assembly (SDK) to convert Excel  workbooks to PDF, RTF, DOCX, Word.

## Quick links

+ [Developer Guide](https://sautinsoft.com/products/excel-to-pdf/help/net/getting-started/overview.php)
+ [API Reference](https://sautinsoft.com/products/excel-to-pdf/help/net/api-reference/html/N_SautinSoft.htm)

## Top Features

+ [Convert Excel file to PDF file.](https://sautinsoft.com/products/excel-to-pdf/help/net/developer-guide/convert-excel-file-to-pdf-file-csharp-vb-net.php)
+ [Convert Excel file to DOCX file.](https://sautinsoft.com/products/excel-to-pdf/help/net/developer-guide/convert-excel-file-to-docx-file-csharp-vb-net.php)
+ [Split/Merge PDF files.](https://sautinsoft.com/products/excel-to-pdf/help/net/developer-guide/split-and-merge-pdf-csharp-vb-net.php)


## System Requirement

* .NET Framework 4.6.1 - 4.8.1
* .NET Core 2.0 - 3.1, .NET 5, 6, 7, 8
* .NET Standard 2.0
* Windows, Linux, macOS, Android, iOS.

## Getting Started with Excel to PDF .Net

Are you ready to give Excel to PDF .NET a try? Simply execute `Install-Package sautinsoft.exceltopdf` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Excel to PDF .NET and want to upgrade the version, please execute `Update-Package sautinsoft.exceltopdf` to get the latest version.

## Convert XLSX to PDF

```csharp
ExcelToPdf x = new ExcelToPdf();
// Set PDF as output format.
x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;
string excelFile = Path.GetFullPath(@"..\..\test.xlsx");
string pdfFile = Path.ChangeExtension(excelFile, ".pdf"); 
x.ConvertFile(excelFile, pdfFile);
```
## Convert XLSX to DOCX


```csharp
ExcelToPdf x = new ExcelToPdf();
// Set DOCX as output format.
x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Docx;
string excelFile = Path.GetFullPath(@"..\..\test.xlsx");
string docxFile = Path.ChangeExtension(excelFile, ".docx"); 
x.ConvertFile(excelFile, docxFile);
```
## Merge PDF

```csharp
ExcelToPdf x = new ExcelToPdf();
FileInfo pdfFile = new FileInfo(Path.ChangeExtension(excelFile, ".pdf"));
string singlePdf = Path.Combine(pdfFile.Directory.FullName, "Single.pdf");
x.MergePDFFileArrayToPDFFile(new string[] { pdfFile.FullName, pdfFile.FullName }, singlePdf);
```

## Resources

+ **Website:** [www.sautinsoft.com](https://www.sautinsoft.com)
+ **Product Home:** [Excel to PDF .Net](https://sautinsoft.com/products/excel-to-pdf/)
+ [Download SautinSoft.ExcelToPdf](https://sautinsoft.com/products/excel-to-pdf/download.php)
+ [Developer Guide](https://sautinsoft.com/products/excel-to-pdf/help/net/getting-started/overview.php)
+ [API Reference](https://sautinsoft.com/products/excel-to-pdf/help/net/api-reference/html/N_SautinSoft.htm)
+ [Support Team](https://sautinsoft.com/support.php)
<<<<<<< HEAD
+ [License](https://sautinsoft.com/products/excel-to-pdf/help/net/getting-started/agreement.php)
=======
+ [License](https://sautinsoft.com/products/excel-to-pdf/help/net/getting-started/agreement.php)

