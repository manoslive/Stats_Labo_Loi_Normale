using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Loi_normale
{
    public partial class Form1 : Form
    {
        String coteZ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImportTable();
        }
        private void ViderChamps()
        {
            TB_Ecart.Text = "";
            TB_Marge.Text = "";
            TB_Moyenne.Text = "";
            TB_Niveau.Text = "";
            TB_Reponse.Text = "";
            TB_TailleEchantillon.Text = "";
        }

        public void ImportTable()
        {
            System.Data.DataTable dt = new System.Data.DataTable("dataTable");
            DataSet dsSource = new DataSet("dataSet");
            dt.Reset();

            Excel.Workbook ExWorkbook;
            Excel.Worksheet ExWorksheet;
            Excel.Range ExRange;
            Excel.Application ExObj = new Excel.Application();


            ExWorkbook = ExObj.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + "\\tablenormale.xlsx", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            ExWorksheet = (Excel.Worksheet)ExWorkbook.Sheets.get_Item(1);
            ExRange = ExWorksheet.UsedRange;

            for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(new DataColumn((ExRange.Cells[1, Cnum] as Excel.Range).Value2.ToString()));
            }
            dt.AcceptChanges();

            string[] columnNames = new String[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                columnNames[0] = dt.Columns[i].ColumnName;
            }
            //string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();

            for (int Rnum = 2; Rnum <= ExRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                {
                    if ((ExRange.Cells[Rnum, Cnum] as Excel.Range).Value2 != null)
                    {
                        dr[Cnum - 1] = (ExRange.Cells[Rnum, Cnum] as Excel.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
            }
            ExWorkbook.Close(true, Missing.Value, Missing.Value);
            ExObj.Quit();

            DGV_Table.DataSource = dt;
        }
        private void BTN_Vider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
        }
    }
}
