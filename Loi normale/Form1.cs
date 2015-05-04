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
using System.Text.RegularExpressions;

namespace Loi_normale
{
    public partial class Form1 : Form
    {
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
            LB_Erreur.Text = "";
        }
        public string FinaliserProb(double prob)
        {
            string probFini = (prob * 100).ToString();
            if (prob == 0)
                probFini += "%";
            else if(prob == 1)
                probFini += "%";
            else
                probFini = probFini.Substring(0, probFini.IndexOf('.') + 3) + "%";
            return probFini;
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
            TB_Reponse.Text = "";
            LB_Erreur.Text = "";

            bool sup = false, inf = false, erreur=false;
            double probabiblite = 0;
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
                if (Zb > 4)
                    probabiblite = 0.5;
                else
                    probabiblite = TrouverProb(Zb);
            }
            else if (Za < 0 && Zb == 0 && !sup && !inf) //b
            {
                probabiblite = TrouverProb(Za * -1);
            }
            else if (Za > 0 && Za <= 4 && Zb > 0 && Zb <= 4 && !sup && !inf) //c
            {
                probabiblite = (TrouverProb(Zb) - TrouverProb(Za));
            }
            else if (Za < 0 && Zb < 0 && !sup && !inf) //d
            {
                probabiblite = (TrouverProb(Za * -1) - TrouverProb(Zb * -1));
            }
            else if (sup && !inf) //e
            {
                if(Za > 0 && Za < 4)
                    probabiblite = (0.5 - TrouverProb(Za));
                else if (Za < 0 && Za > -4)
                    probabiblite = (TrouverProb(Za * -1) + 0.5);
                else if (Za <= -4)
                    probabiblite = 1;
                else
                    probabiblite = TrouverProb(Za);
            }
            else if (inf && !sup) //f
            {
                if (Zb > 0 && Zb < 4)
                    probabiblite = (TrouverProb(Zb) + 0.5);
                else if (Zb > 4)
                    probabiblite = 1;
                else
                    probabiblite = (0.5 - TrouverProb(Zb * -1));
            }
            else if ((Za > 4 && Zb > 4) || (Za < -4 && Zb < -4) && !sup && !inf) //g
            {
                probabiblite = 0;
            }
            else if(Za < 0 && Zb > 0 && !sup && !inf)
            {
                probabiblite = (TrouverProb(Za * -1) + TrouverProb(Zb));
            }
            else
            {
                TB_Reponse.Text = "";
                LB_Erreur.Text = "Erreur: Valeurs incohérentes";
                erreur = true;
            }

            if(!erreur)
                TB_Reponse.Text = FinaliserProb(probabiblite);
        }
        public double TrouverProb(double coteZ)
        {
            int resA = 0, resB = 0;
            for (int i = 1; i < DGV_Table.RowCount; i++)
            {
                if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) != 0)
                {
                    if (coteZ.ToString().Length >= 3)
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
                else
                {
                    if (coteZ.ToString().Length >= 3)
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, 3)))
                            resA = 1;
                    }
                    else
                    {
                        if (Convert.ToDouble(DGV_Table.Rows[i].Cells[0].Value) == Convert.ToDouble(coteZ.ToString().Substring(0, coteZ.ToString().Length)))
                            resA = 1;
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
                        resB = 1;
                    }
                }
            }
            return Convert.ToDouble(DGV_Table.Rows[resA].Cells[resB].Value);
        }

        private void TB_Min_TextChanged(object sender, EventArgs e)
        {
            if(CB_Inferieure.Checked)
            {
                if (Regex.IsMatch(TB_Max.Text, @"^([-]?\d*[.]?\d{1,2})$") && Regex.IsMatch(TB_Moyenne.Text, @"^([-]?\d*[.]?\d{1,2})$") && Regex.IsMatch(TB_Ecart.Text, @"^([-]?\d*[.]?\d{1,2})$"))
                {
                    BTN_Calculer.Enabled = true;
                    LB_Erreur.Text = "";           
                }
                else
                {
                    BTN_Calculer.Enabled = false;
                    LB_Erreur.Text = "Erreur: Valeurs incohérentes";
                    TB_Reponse.Text = "";
                }
            }
            else
            {
                if (Regex.IsMatch(TB_Min.Text, @"^([-]?\d*[.]?\d{1,2})$") && Regex.IsMatch(TB_Moyenne.Text, @"^([-]?\d*[.]?\d{1,2})$") && Regex.IsMatch(TB_Ecart.Text, @"^([-]?\d*[.]?\d{1,2})$"))
                {
                    BTN_Calculer.Enabled = true;
                    LB_Erreur.Text = "";
                }
                else
                {
                    BTN_Calculer.Enabled = false;
                    LB_Erreur.Text = "Erreur: Valeurs incohérentes";
                    TB_Reponse.Text = "";
                }
            }

        }

        private void CB_Superieure_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Superieure.Checked)
            {
                CB_Inferieure.Checked = false;
                TB_Max.Text = "";
                TB_Min.Enabled = true;
                TB_Max.Enabled = false;
            }
            else
            {
                TB_Min.Enabled = true;
                TB_Max.Enabled = true;
            }
        }

        private void CB_Inferieure_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Inferieure.Checked)
            {
                CB_Superieure.Checked = false;
                TB_Min.Text = "";
                TB_Min.Enabled = false;
                TB_Max.Enabled = true;
            }
            else
            {
                TB_Min.Enabled = true;
                TB_Max.Enabled = true;
            }
        }
    }
}
