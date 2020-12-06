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
    public partial class LogIn : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        string userType;

        DataTable dt = new DataTable();

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.ActiveControl=label1;
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            info.eid = Convert.ToInt32(txtuid.Text);
            info.password = txtpassword.Text;

            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                int lgdin = opr.insertLgdIn(info);
                userType = dt.Rows[0]["User_Type"].ToString();

                if (userType == "Admin")
                {
                    this.Hide();
                    AdminHome adh = new AdminHome();
                    adh.Show();
                }
                else if (userType == "Stuff")
                {
                    this.Hide();
                    StuffHome sh = new StuffHome();
                    sh.Show();
                }
                else if (userType == "Doctor")
                {
                    this.Hide();
                    DoctorHome dh = new DoctorHome();
                    dh.Show();
                }
            }

            else
            {
                MessageBox.Show("Invalid User ID or Password! Try Again!");
                txtuid.Clear();
                txtpassword.Clear();
            }
        }

        private void txtuid_Validating(object sender, CancelEventArgs e)
        {
            int r;
            if (int.TryParse(txtuid.Text, out r))
            {

            }
            else
            {
                MessageBox.Show("User ID must be numbers!");
                txtuid.Clear();
            }
        }


    }
}
