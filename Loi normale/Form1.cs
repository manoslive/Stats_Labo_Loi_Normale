using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void BTN_Vider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }
    }
}
