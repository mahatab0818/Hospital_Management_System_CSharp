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
    public partial class AdminHome : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEmployee ae = new AdminEmployee();
            ae.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPatient ap = new AdminPatient();
            ap.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.selectLgdIn(info);
            int a = Convert.ToInt32(dt.Rows[0]["UID"]);

            DataTable dt2 = new DataTable();
            dt2 = opr.viewSpEmployee(a);
            string b = dt2.Rows[0]["Name"].ToString();

            label2.Text= "Welcome: "+b+". Your User ID is: "+a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }
    }
}
