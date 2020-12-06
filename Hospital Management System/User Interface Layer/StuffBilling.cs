using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Operation_Layer;
using Hospital_Information_Layer;

namespace User_Interface_Layer
{
    public partial class StuffBilling : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["ViewPatient"];

        int x;

        public Operations opr = new Operations();
        public Informations info = new Informations();

        public StuffBilling()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.printBill(info, ((ViewPatient)f).SelectedEvent());
            dataGridViewBill.DataSource = dt;

            x = Convert.ToInt32(dt.Rows[0]["DID"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.checkBillingStatus(info, x);

            if (dt.Rows[0]["BillingStatus"].ToString() == "Open")
            {
                int rows = opr.billclosing(info, x);
                if (rows > 0)
                {
                    MessageBox.Show("Total Bill is: "+dt.Rows[0]["Bill"].ToString()+"\nBill is closed and printed!");
                    this.Hide();
                    StuffViewPatient svp = new StuffViewPatient();
                    svp.Show();
                }
            }
            else if (dt.Rows[0]["BillingStatus"].ToString() == "Closed")
            {
                MessageBox.Show("Billing is already closed for this Diagnosis ID!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuffViewPatient svp = new StuffViewPatient();
            svp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void StuffBilling_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

    }
}
