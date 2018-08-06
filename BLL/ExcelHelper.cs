using Janus.Windows.GridEX;
using Janus.Windows.GridEX.Export;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BLL
{
    public class ExcelHelper
    {
        public static void ExportGridEx(GridEX gridEx)
        {
            Stream streamWrite = null;
            
            try
            {
                var saveDialog = new SaveFileDialog { Filter = "Xml File (*.xml)|*.xml|All Files (*.*)|*.*" };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {                                        
                    streamWrite = new FileStream(saveDialog.FileName, FileMode.Create);
                    var gridExporter = new GridEXExporter();                   
                    gridExporter.IncludeExcelProcessingInstruction = true;
                    gridExporter.IncludeFormatStyle = true;
                    gridExporter.IncludeHeaders = true;                    
                    gridExporter.GridEX = gridEx;
                    
                    gridExporter.Export(streamWrite);                    

                    MessageBox.Show("Eksport danych do pliku został zakończony.", "Eksport do pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {                
            }
            finally
            {
                if (streamWrite != null)
                {
                    streamWrite.Flush();
                    streamWrite.Close();
                    streamWrite.Dispose();
                }
            }
        }

        public static void CreateReport_SettlemetsDetails(GridEX gridEx)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // header

            var headerRow = gridEx.GetDataRows()[0];
            int cellId = 1;
            foreach (GridEXCell cell in headerRow.Cells)
            {
                xlWorkSheet.Cells[1, cellId] = cell.Column.Caption;
                cellId++;
            }

            int rowId = 2;
            cellId = 1;
            foreach (GridEXRow row in gridEx.GetDataRows())
            {
                foreach (GridEXCell cell in row.Cells)
                {
                    xlWorkSheet.Cells[rowId, cellId] = cell.Text;
                    cellId++;
                }

                rowId++;
                cellId = 1;
            }

            xlWorkBook.SaveAs(@"C:\Users\MegaBit\Downloads\testinterop.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }

        public static bool ExportWorkbookToPdf(string workbookPath, string outputPath)
        {            
            if (string.IsNullOrEmpty(workbookPath) || string.IsNullOrEmpty(outputPath))
            {
                return false;
            }
         
            Excel.Application excelApplication;
            Excel.Workbook excelWorkbook;            
            excelApplication = new Excel.Application();
            
            excelApplication.ScreenUpdating = false;            
            excelApplication.DisplayAlerts = false;
            
            excelWorkbook = excelApplication.Workbooks.Open(workbookPath);

            if (excelWorkbook == null)
            {
                excelApplication.Quit();

                excelApplication = null;
                excelWorkbook = null;

                return false;
            }

            var exportSuccessful = true;
            try
            {                
                excelWorkbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, outputPath);
            }
            catch (System.Exception ex)
            {             
                exportSuccessful = false;
            }
            finally
            {                
                excelWorkbook.Close();
                excelApplication.Quit();
                excelApplication = null;
                excelWorkbook = null;
            }            

            return exportSuccessful;
        }
    }
}
