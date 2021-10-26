using Microsoft.Office.Interop.Word;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readwriteabs
{
    public partial class ReadWrite : Form
    {
        public ReadWrite()
        {
            InitializeComponent();
        }

        public static bool IsStringEmpty(string myString)
        {

            return myString == null || myString == String.Empty || myString.Length == 0 || myString.Trim().Length == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Open(""); //todo path

            string data = doc.Content.Text;

            string[] podatci = data.Split(new[] { "\r\n", "\r", "\n" },
                               StringSplitOptions.None);

            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("Sheet1");

            IRow prviRow = sheet1.CreateRow(0);

            prviRow.CreateCell(0).SetCellValue("Category");
            prviRow.CreateCell(1).SetCellValue("Session");
            prviRow.CreateCell(2).SetCellValue("Title");
            prviRow.CreateCell(3).SetCellValue("Speakers");
            prviRow.CreateCell(4).SetCellValue("Abstract");

            IRow pomocniRow;
            int brojac = 1;

            /*
            pomocniRow = sheet1.CreateRow(1);
            pomocniRow.CreateCell(0).SetCellValue(podatci[0]);
            pomocniRow.CreateCell(1).SetCellValue(podatci[2]);
            pomocniRow.CreateCell(2).SetCellValue(podatci[4]);
            pomocniRow.CreateCell(3).SetCellValue(podatci[6]);
            pomocniRow.CreateCell(4).SetCellValue(podatci[8]); */

            //MessageBox.Show(podatci.Length.ToString());


            for (int i = 0; i < podatci.Length - 4; i = i + 10)
            {
                pomocniRow = sheet1.CreateRow(brojac);

               
                pomocniRow.CreateCell(0).SetCellValue(podatci[i]);
                if (IsStringEmpty(podatci[i + 2]))
                {
                    i++;
                }
                pomocniRow.CreateCell(1).SetCellValue(podatci[i + 2]);
                if (IsStringEmpty(podatci[i + 4]))
                {
                    i++;
                }
                pomocniRow.CreateCell(2).SetCellValue(podatci[i + 4]);
                pomocniRow.CreateCell(3).SetCellValue(podatci[i + 6]);
                if (i+8 >= podatci.Length)
                {
                    break;
                }
                if (IsStringEmpty(podatci[i+8]))
                {
                    i++;
                }
                pomocniRow.CreateCell(4).SetCellValue(podatci[i + 8]);

                brojac++;
            }

            //MessageBox.Show(podatci[39].ToString());

            for (int i = 0; i < podatci.Length; i++)
            {
                if (!IsStringEmpty(podatci[i]))
                {
                    rtbPopis.AppendText(podatci[i] + "\n");
                }
            }

            
            FileStream sw = File.Create("test.xlsx");
            workbook.Write(sw);
            sw.Close();


            app.Quit();
        }
    }
}
