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
    public partial class DoctorHome : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        public DoctorHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocCPList dcp = new DocCPList();
            dcp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocDiagnosList ddl = new DocDiagnosList();
            ddl.Show();
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.selectLgdIn(info);
            int a = Convert.ToInt32(dt.Rows[0]["UID"]);

            DataTable dt2 = new DataTable();
            dt2 = opr.viewSpEmployee(a);
            string b = dt2.Rows[0]["Name"].ToString();

            label2.Text = "Welcome: " + b + ". Your User ID is: " + a.ToString();
        }

        public int docLogged()
        { 
             DataTable dt = new DataTable();
            dt = opr.selectLgdIn(info);

            int x = Convert.ToInt32(dt.Rows[0]["UID"]);
            return x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void DoctorHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

    }
}
