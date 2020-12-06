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
    public partial class PatientRegistration : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        string g;
        double a;

        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.name = txtname.Text;

            if (rbmale.Checked == true)
            {
                g = "Male";
            }
            if (rbfemale.Checked == true)
            {
                g = "Female";
            }
            info.gender = g;
            info.dob = dateTimePicker1.Value.ToString();

            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan tSpan = to - from;
            a = tSpan.TotalDays;

            info.age = (a / 365).ToString("0");
            info.address = txtaddress.Text;
            info.phoneNo = txtphonno.Text;


            info.description = txtdescription.Text;
            info.eid = Convert.ToInt32(txteid.Text);

            int rows=opr.insertPatient(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.selectPIDfordiag();
                info.pid= Convert.ToInt32(dt.Rows[0]["PID"]);

                int rows2 = opr.insertDiagnosis(info);
                if (rows2 > 0)
                {
                    MessageBox.Show("Registration Completed!");
                    this.Hide();
                    AdminPatient ap = new AdminPatient();
                    ap.Show();
                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPatient ap = new AdminPatient();
            ap.Show();
        }

    }
}
