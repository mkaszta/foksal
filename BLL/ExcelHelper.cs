using Janus.Windows.GridEX;
using Janus.Windows.GridEX.Export;
using Microsoft.Office.Interop.Excel;
using System;
using System.Configuration;
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

        public static void CreateReport_SettlementsDetails(GridEX gridEx, string filePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp.DisplayAlerts = false;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // header

            var headerRow = gridEx.GetDataRows()[0];
            int cellId = 1;
            foreach (GridEXCell cell in headerRow.Cells)
            {
                if (cell.Column.Visible)
                {
                    xlWorkSheet.Cells[1, cellId] = cell.Column.Caption;
                    cellId++;
                }
            }
            xlWorkSheet.UsedRange.Columns.AutoFit();


            int rowId = 2;
            cellId = 1;
            foreach (GridEXRow row in gridEx.GetDataRows())
            {
                foreach (GridEXCell cell in row.Cells)
                {
                    if (cell.Column.Visible)
                    {
                        xlWorkSheet.Cells[rowId, cellId] = cell.Value.ToString();
                        cellId++;
                    }
                }

                if ((int)row.Cells["typ"].Value == 1)
                {
                    xlWorkSheet.Range[xlWorkSheet.Rows[rowId].Cells[1], xlWorkSheet.Rows[rowId].Cells[cellId - 1]].Interior.Color = System.Drawing.Color.LightCyan;
                }

                rowId++;
                cellId = 1;
            }

            xlWorkBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);            
        }

        public static void CreateReport_Short(GridEX gridEx, string filePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheetReport;
            Excel.Worksheet xlWorkSheetTemplate;
            object misValue = System.Reflection.Missing.Value;

            xlApp.DisplayAlerts = false;
            xlWorkBook = xlApp.Workbooks.Open(ConfigurationSettings.AppSettings["shortReport_template"], misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            xlWorkSheetReport = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheetTemplate = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);            

            var templateHeaderRow = xlWorkSheetTemplate.Rows[1];
            var templateLineRow = xlWorkSheetTemplate.Rows[2];
            var templateSumRow = xlWorkSheetTemplate.Rows[3];
            var templateFooterRow = xlWorkSheetTemplate.Rows[4];

            int firstPageRows = Convert.ToInt16(ConfigurationSettings.AppSettings["shortReport_linesFirstPage"]);
            int nextPageRows = Convert.ToInt16(ConfigurationSettings.AppSettings["shortReport_linesPerPage"]);
            int reportRowId = 6;
            int reportPageRowId = 1;
            int reportPage = 1;

            // DATE
            xlWorkSheetReport.Cells[3, 13] = string.Format("Warszawa, {0}", DateTime.Now.ToShortDateString());

            // HEADER
            templateHeaderRow.Copy(xlWorkSheetReport.Rows[reportRowId]);
            reportRowId++;

            foreach (GridEXRow gridexRow in gridEx.GetDataRows())
            {
                if ((reportPage == 1 && reportRowId > firstPageRows) || (reportPage > 1 && reportPageRowId > nextPageRows))
                {
                    // HEADER
                    templateHeaderRow.Copy(xlWorkSheetReport.Rows[reportRowId]);
                    reportPageRowId = 2;
                    reportRowId++;
                    reportPage++;
                }

                if ((int)gridexRow.Cells["typ"].Value == 1)
                {
                    // SUM
                    templateSumRow.Copy(xlWorkSheetReport.Rows[reportRowId]);
                    xlWorkSheetReport.Cells[reportRowId, 12] = gridexRow.Cells["Zaliczka"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 13] = gridexRow.Cells["DoWyplaty"].Value.ToString();                    
                }
                else
                {
                    // LINE
                    templateLineRow.Copy(xlWorkSheetReport.Rows[reportRowId]);

                    xlWorkSheetReport.Cells[reportRowId, 1] = gridexRow.Cells["lp"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 2] = gridexRow.Cells["Tytul"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 3] = gridexRow.Cells["autor"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 4] = gridexRow.Cells["naklad"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 5] = gridexRow.Cells["CenaDetaliczna"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 6] = gridexRow.Cells["CenaNetto"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 7] = gridexRow.Cells["Okres"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 8] = gridexRow.Cells["sprzedaz"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 9] = gridexRow.Cells["PodstawaDoRozliczen"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 10] = gridexRow.Cells["Honorarium"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 11] = gridexRow.Cells["HonorariumWaluta"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 12] = gridexRow.Cells["Zaliczka"].Value.ToString();
                    xlWorkSheetReport.Cells[reportRowId, 13] = gridexRow.Cells["DoWyplaty"].Value.ToString();
                }
                
                reportRowId++;
                reportPageRowId++;
            }

            ExcelHelper.ExportWorkbookToPdf(xlWorkSheetReport, filePath);
            
            xlWorkBook.Close(false, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheetReport);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);            
        }

        private static bool ExportWorkbookToPdf(Worksheet xlWorkSheet, string outputPath)
        {            
            var exportSuccessful = true;

            try
            {
                xlWorkSheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, outputPath, XlFixedFormatQuality.xlQualityStandard, true, true);                    
            }
            catch (System.Exception ex)
            {
                exportSuccessful = false;
            }            

            return exportSuccessful;
        }
    }
}
