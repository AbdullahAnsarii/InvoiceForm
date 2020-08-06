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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            txtfirstname.Text = invoiceData.firstname;
            txtlastname.Text = invoiceData.lastname;
            txtcompany.Text = invoiceData.companyname;

            if (invoiceData.trial)
            {
                xtrial.Text = "✓";
            }
            if (invoiceData.basic)
            {
                xbasic.Text = "✓";
            }
            if (invoiceData.premium)
            {
                xpremium.Text = "✓";
            }


        }


        private void btnok_Click(object sender, EventArgs e)
        {
            invoiceData i = new invoiceData();
            this.Hide();
            i.Show();
        }
    }
}
