using Janus.Windows.GridEX;
using Janus.Windows.GridEX.Export;
using System;
using System.IO;
using System.Windows.Forms;

namespace BLL
{
    public class ExcelGenerator
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
    }
}
