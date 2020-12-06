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
    public partial class UpdateEmployee : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        string g;
        double a;

        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["ViewEmployee"];

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
            info.designation = txtdesignation.Text;
            info.userType = comboBox1.Text;
            info.password = txtpassword.Text;

            int rows = opr.updateEmp(info, ((ViewEmployee)f).SelectedEvent());
            if (rows > 0)
            {
                MessageBox.Show("Updated!");
                this.Hide();
                ViewEmployee ve = new ViewEmployee();
                ve.Show();
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f=System.Windows.Forms.Application.OpenForms["ViewEmployee"];
            DataTable dt = new DataTable();
            dt = opr.viewSpEmployee(((ViewEmployee)f).SelectedEvent());

            txtname.Text = dt.Rows[0]["Name"].ToString();
            if (dt.Rows[0]["Gender"].ToString() == "Male")
            {
                rbmale.Checked = true;
            }
            else if (dt.Rows[0]["Gender"].ToString() == "Female")
            {
                rbfemale.Checked = true;
            }
            dateTimePicker1.Value=Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
            txtaddress.Text = dt.Rows[0]["Address"].ToString();
            txtphonno.Text = dt.Rows[0]["Phone_No"].ToString();
            txtdesignation.Text = dt.Rows[0]["Designation"].ToString();
            comboBox1.Text = dt.Rows[0]["User_Type"].ToString();
            txtpassword.Text = dt.Rows[0]["Password"].ToString();
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
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
        }

    }
}
