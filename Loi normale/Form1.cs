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
            TB_Min.Text = "";
            TB_Moyenne.Text = "";
            TB_Max.Text = "";
            TB_Reponse.Text = "";
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

            //string[] columnNames = new String[dt.Columns.Count];
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
            //    columnNames[0] = dt.Columns[i].ColumnName;
            //}
            //string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();

            for (int Rnum = 1; Rnum <= ExRange.Rows.Count; Rnum++)
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
            bool sup = false, inf = false;
            double min = 0;
            double max = 0;
            if (TB_Min.Text == "")
                inf = true;
            else
                min = Convert.ToDouble(TB_Min.Text);

            if (TB_Max.Text == "")
                sup = true;
            else
                max = Convert.ToDouble(TB_Max.Text);

            double moyenne = Convert.ToDouble(TB_Moyenne.Text);
            double ecartType = Convert.ToDouble(TB_Ecart.Text);


            double Za = (min - moyenne) / ecartType;
            double Zb = (max - moyenne) / ecartType;

            if (Za == 0 && Zb > 0 && !sup && !inf) //a
            {
                TB_Reponse.Text = TrouverProb(Zb).ToString();
            }
            else if (Za < 0 && Zb == 0 && !sup && !inf) //b
            {
                TB_Reponse.Text = TrouverProb(Za * -1).ToString();
            }
            else if (Za > 0 && Za <= 4 && Zb > 0 && Zb <= 4 && !sup && !inf) //c
            {
                TB_Reponse.Text = (TrouverProb(Zb) - TrouverProb(Za)).ToString();
            }
            else if (Za < 0 && Zb < 0 && !sup && !inf) //d
            {
                TB_Reponse.Text = (TrouverProb(Za * -1) - TrouverProb(Zb * -1)).ToString();
            }
            else if (sup && Zb > 4 && !inf) //////////////inverser inf sup pt etre
            {
                TB_Reponse.Text = "0.5";
            }
            else if (sup && !inf) //e   //////////////inverser inf sup pt etre
            {
                if (Za < 0)
                    TB_Reponse.Text = (TrouverProb(Za * -1) + 0.5).ToString();
                else
                    TB_Reponse.Text = TrouverProb(Za).ToString();
            }
            else if (inf && Za < -4 && !sup)//////////////inverser inf sup pt etre
            {
                TB_Reponse.Text = "0.5";
            }
            else if (inf && !sup) //f//////////////inverser inf sup pt etre
            {
                if (Zb < 0)
                    TB_Reponse.Text = (0.5 - TrouverProb(Zb * -1)).ToString();
                else
                    TB_Reponse.Text = TrouverProb(Zb).ToString();
            }
            else if ((Za > 4 && Zb > 4) || (Za < -4 && Zb < -4) && !sup && !inf) //g
            {
                TB_Reponse.Text = "0";
            }
        }
        public double TrouverProb(double coteZ)
        {
            int resA = 0, resB = 0;
            for (int i = 1; i < DGV_Table.RowCount; i++)
            {
                if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) != 0)
                {
                    if(coteZ.ToString().Length>=3)
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, 3)))
                            resA = i;
                    }
                    else
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, coteZ.ToString().Length)))
                            resA = i;
                    }
                }
            }
            for (int j = 1; j < DGV_Table.ColumnCount; j++)
            {
                if (Convert.ToDouble(DGV_Table.Rows[0].Cells[j].Value) != 0)
                {
                    if (coteZ.ToString().Length > 3)
                    {
                        if (Convert.ToDouble(coteZ.ToString().Substring(3, 1)) == Convert.ToDouble((DGV_Table.Rows[0].Cells[j].Value).ToString().Substring(3, 1)))
                            resB = j;
                    }
                    else
                    {
                        resB = 0;
                    }
                }
            }
            return Convert.ToDouble(DGV_Table.Rows[resA].Cells[resB].Value);
        }
    }
}
