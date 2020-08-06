using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoiceApp
{
    public partial class invoiceData : Form
    {
        public static string firstname;
        public static string lastname;
        public static string companyname;
        public static Boolean trial;
        public static Boolean basic;
        public static Boolean premium;

        Reciept r = new Reciept();
        //invoiceData i = new invoiceData();


        public invoiceData()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            firstname = fname.Text;
            lastname = lname.Text;
            companyname = company.Text;

            this.Hide();
            //i.Hide();
            r.Show();


        }

        private void chkTrial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrial.Checked)
            {
                trial = true;
                trialtxt.Text = ("1 month trial version");
            }
            else
            {
                trial = false;
                trialtxt.Text = "";
            }
        }

        private void chkBasic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBasic.Checked)
            {
                basic = true;
                basictxt.Text = ("12 month subscription");
            }
            else
            {
                basic = false;
                basictxt.Text = "";
            }

        }

        private void chkPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPremium.Checked)
            {
                premium = true;
                premiumtxt.Text = ("Lifetime Subscription");
            }
            else
            {
                premium = false;
                premiumtxt.Text = "";
            }
        }

    }
}
