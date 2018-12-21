using MaterialSkin;
using MaterialSkin.Controls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2
{
    public partial class GameRank : MaterialForm
    {
        private string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ToString();
        
        public GameRank()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connection))
            {
                // 커넥션 오픈
                conn.Open();

                // 커맨드 생성
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT RANK() OVER (ORDER BY score DESC,gametime asc ) as rank,username, levelname,score,gametime FROM CARDGAME order by score desc , gametime asc";

                    // select 문 쿼리
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnToExcelSave_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "CardGameFile.xlsx");
            if (File.Exists(filePath))
            {
                updateExcelRankFile(filePath);
            }
            else
            {
                makeExcelRankFile(filePath);
            }
        }

        private void updateExcelRankFile(string filePath)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Open(filePath);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.Worksheets.Item["Sheet1"];
                worksheet = workbook.ActiveSheet;
                foreach (dynamic worksheet1 in workbook.Worksheets)
                {
                    worksheet.Cells.ClearContents();
                }
                //// Title
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Content
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                worksheet.Columns.AutoFit();

                workbook.Save();

                workbook.Close(true);
                
                app.Quit();
                
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ReleaseExcelObject(worksheet);
                ReleaseExcelObject(workbook);
                ReleaseExcelObject(app);
            }


        }

        private void makeExcelRankFile(string filePath)
        { 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            
            // Excel 범위에 색칠하기.
            var columnHeadingsRange = worksheet.Range["A1:E1"];
            columnHeadingsRange.Interior.Color = Color.SteelBlue;
            columnHeadingsRange.Font.Color = Color.White;

            try
            {
                //// Title
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Content
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                worksheet.Columns.AutoFit();


                workbook.SaveAs(filePath, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                workbook.Close(true);
                app.Quit();
                MessageBox.Show("Export Successful", "출력 메시지");

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ReleaseExcelObject(worksheet);
                ReleaseExcelObject(workbook);
                ReleaseExcelObject(app);
            }
        }

        private void btnExcelOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\workspace\VisualStudio\CSharpBook\CardGame2\bin\Debug\test.xls");
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
