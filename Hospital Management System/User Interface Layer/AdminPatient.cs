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
    public partial class AdminPatient : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        public AdminPatient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegistration pr = new PatientRegistration();
            pr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPatient vp = new ViewPatient();
            vp.Show();
        }

        private void AdminPatient_Load(object sender, EventArgs e)
        {

        }

        private void AdminPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }
    }
}
