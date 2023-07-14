using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G10GP02_NAVARRO_HT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sName = "";
            sName = tbxName.Text;

            double dGrade = 0;
            

            double dMisc = 0;
            double dBooks = 0;
            double dUniform = 0;
            string sMisc = "";
            double dTotalmisc = 0;
            double dAnnual = 0;
            double dMonthly = 0;
            double dRmonthly = 0;
            int iMonthly = 0;
            int iLoops = 0;
            int iRt = 0;
            int iT = 0;
            string sRt = "";




            iMonthly = 1;
            dUniform = 2800.00;
            dBooks = 3120.00;
            dAnnual = 85000.00;




            if (chkTextbook.Checked)
            {
                sMisc = sMisc + "Textbook";
                dTotalmisc = dTotalmisc + dBooks;
            }
            if (chkUniform.Checked)
            {
                sMisc = sMisc + " Uniform";
                dTotalmisc = dTotalmisc + dBooks;
            }
            if (rdoMonths2.Checked)
            {
                dMonthly = dMonthly + 85000 / 2;
                iLoops = 2;
                dRmonthly = dMonthly;
            }
            if (rdoMonths5.Checked)
            {
                dMonthly = dMonthly + 85000 / 5;
                iLoops = 5;
                dRmonthly = dMonthly;

            }
            while (iLoops > 0)
            {
                sRt = sRt + "\r\nMonth " + iMonthly + " - Php " + dRmonthly;
                dRmonthly = dRmonthly + dMonthly;
                iMonthly = iMonthly + 1;
                iLoops = iLoops - 1;

            }


            tbxResult.Text = "Name: " + tbxName.Text + "\r\nGrade Level: "
                                + tbxGradelevel.Text + "\r\nMiscellaneous Items: "
                                + sMisc + "\r\nTotal Miscellaneous: " + dTotalmisc +
                                "\r\n\r\nTotal Annual Tuition Fee Due: Php" + dAnnual + "\r\nMonthly Due: Php" +
                                dMonthly + "\r\nRunning Total:" + sRt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxGradelevel.Text = "";
            tbxResult.Text = "";
            rdoMonths2.Checked = false;
            rdoMonths5.Checked = false;
            chkTextbook.Checked = false;
            chkUniform.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
