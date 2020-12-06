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
    public partial class DocDiagnosList : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["DoctorHome"];

        public Operations opr = new Operations();
        public Informations info = new Informations();

        public DocDiagnosList()
        {
            InitializeComponent();
        }

        private void DocDiagnosList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewDocPaitentDiag(info, ((DoctorHome)f).docLogged());

            dataGridViewmedhistry.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = opr.exitLgdIn();

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorHome dh = new DoctorHome();
            dh.Show();
        }

        private void DocDiagnosList_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }
    }
}
