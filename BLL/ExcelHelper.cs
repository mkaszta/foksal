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

        public static void CreateReport_SettlementsDetails(GridEX gridEx, string filePath, bool createSumRow)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp.DisplayAlerts = false;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            decimal sumAdvance = 0;
            decimal sumUnearnedAdvance = 0;
            decimal sumReckoning = 0;
            decimal sumPayment = 0;

            // header

            var headerRow = gridEx.GetDataRows()[0];
            int cellId = 1;

            foreach (GridEXCell cell in headerRow.Cells)
            {
                if (cell.Column.Visible)
                {
                    xlWorkSheet.Cells[1, cellId] = cell.Column.Caption;

                    xlWorkSheet.Columns[cellId].NumberFormat = cell.Column.FormatString.Replace(".", ",");

                    cellId++;
                }
            }

            int rowId = 2;
            cellId = 1;
            foreach (GridEXRow row in gridEx.GetDataRows())
            {
                foreach (GridEXCell cell in row.Cells)
                {
                    if (cell.Column.Visible)
                    {
                        if (cell.Value.ToString() == "" && cell.Column.NullText != "")
                        {
                            xlWorkSheet.Cells[rowId, cellId] = cell.Column.NullText;
                        }
                        else
                        {
                            xlWorkSheet.Cells[rowId, cellId] = cell.Value;
                        }

                        cellId++;
                    }
                }

                // IF SUBSUM
                if ((int)row.Cells["typ"].Value == 1)
                {
                    sumAdvance += (decimal)row.Cells["Zaliczka"].Value;
                    sumUnearnedAdvance += (decimal)row.Cells["NiewypracowanaZaliczka"].Value;
                    sumReckoning += (decimal)row.Cells["KwotaRozliczenia"].Value;
                    sumPayment += (decimal)row.Cells["DoWyplaty"].Value;

                    xlWorkSheet.Range[xlWorkSheet.Rows[rowId].Cells[1], xlWorkSheet.Rows[rowId].Cells[cellId - 1]].Interior.Color = System.Drawing.Color.LightCyan;
                }

                rowId++;
                cellId = 1;
            }

            if (createSumRow)
            {
                xlWorkSheet.Cells[rowId, 1] = "SUMA";
                xlWorkSheet.Cells[rowId, 22] = sumAdvance;
                xlWorkSheet.Cells[rowId, 23] = sumUnearnedAdvance;
                xlWorkSheet.Cells[rowId, 24] = sumReckoning;
                xlWorkSheet.Cells[rowId, 25] = sumPayment;

                xlWorkSheet.Range[xlWorkSheet.Rows[rowId].Cells[1], xlWorkSheet.Rows[rowId].Cells[25]].Interior.Color = System.Drawing.Color.Bisque;
            }

            xlWorkSheet.Columns.ColumnWidth = 15;
            xlWorkSheet.Rows[1].WrapText = true;

            xlWorkSheet.Columns["A:Y"].EntireColumn.AutoFit();

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

            decimal sumPayment = 0;

            // DATE
            xlWorkSheetReport.Cells[3, 13] = string.Format("Warszawa, {0}", AppUser.Instance.DateForReports.ToShortDateString());

            // HEADER            
            templateHeaderRow.Copy(System.Type.Missing);
            xlWorkSheetReport.Rows[reportRowId].PasteSpecial(XlPasteType.xlPasteAll, XlPasteSpecialOperation.xlPasteSpecialOperationNone, misValue, misValue);

            reportRowId++;

            foreach (GridEXRow gridexRow in gridEx.GetDataRows())
            {
                if ((reportPage == 1 && reportRowId > firstPageRows) || (reportPage > 1 && reportPageRowId > nextPageRows))
                {
                    // HEADER
                    templateHeaderRow.Copy(System.Type.Missing);
                    xlWorkSheetReport.Rows[reportRowId].PasteSpecial(XlPasteType.xlPasteAll, XlPasteSpecialOperation.xlPasteSpecialOperationNone, misValue, misValue);

                    reportPageRowId = 2;
                    reportRowId++;
                    reportPage++;
                }

                if ((int)gridexRow.Cells["typ"].Value == 1)
                {
                    // SUM
                    templateSumRow.Copy(System.Type.Missing);
                    xlWorkSheetReport.Rows[reportRowId].PasteSpecial(XlPasteType.xlPasteAll, XlPasteSpecialOperation.xlPasteSpecialOperationNone, misValue, misValue);

                    xlWorkSheetReport.Cells[reportRowId, 12] = gridexRow.Cells["Zaliczka"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 13] = gridexRow.Cells["DoWyplaty"].Value;

                    sumPayment += (decimal)gridexRow.Cells["DoWyplaty"].Value;
                }
                else
                {
                    // LINE
                    templateLineRow.Copy(System.Type.Missing);
                    xlWorkSheetReport.Rows[reportRowId].PasteSpecial(XlPasteType.xlPasteAll, XlPasteSpecialOperation.xlPasteSpecialOperationNone, misValue, misValue);

                    xlWorkSheetReport.Cells[reportRowId, 1] = gridexRow.Cells["lp"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 2] = gridexRow.Cells["Tytul"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 3] = gridexRow.Cells["autor"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 4] = gridexRow.Cells["naklad"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 5] = gridexRow.Cells["CenaDetaliczna"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 6] = gridexRow.Cells["CenaNetto"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 7] = gridexRow.Cells["Okres"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 8] = gridexRow.Cells["sprzedaz"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 9] = gridexRow.Cells["PodstawaDoRozliczen"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 10] = gridexRow.Cells["HonorariumProcent"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 11] = gridexRow.Cells["Honorarium"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 12] = gridexRow.Cells["Zaliczka"].Value;
                    xlWorkSheetReport.Cells[reportRowId, 13] = gridexRow.Cells["DoWyplaty"].Value;
                }

                reportRowId++;
                reportPageRowId++;
            }

            // FOOTER
            templateFooterRow.Copy(System.Type.Missing);
            xlWorkSheetReport.Rows[reportRowId].PasteSpecial(XlPasteType.xlPasteAll, XlPasteSpecialOperation.xlPasteSpecialOperationNone, misValue, misValue);
            xlWorkSheetReport.Cells[reportRowId, 13] = sumPayment;

            // FORMATTING
            //xlWorkSheetReport.Columns[5].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[6].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[9].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[10].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[11].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[12].NumberFormat = "# ##0,00";
            //xlWorkSheetReport.Columns[13].NumberFormat = "# ##0,00";

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
