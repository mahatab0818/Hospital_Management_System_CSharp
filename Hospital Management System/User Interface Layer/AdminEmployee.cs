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
    public partial class AdminEmployee : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void AdminEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.Show();
        }
    }
}
