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
    public partial class StuffViewDiagnosis : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        public StuffViewDiagnosis()
        {
            InitializeComponent();
        }

        private void ViewDiagnosis_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["ViewPatient"];

            DataTable dt = new DataTable();
            dt = opr.viewDiagnosis(info, ((ViewPatient)f).SelectedEvent());
            dataGridViewDiagnos.DataSource = dt;
            dataGridViewDiagnos.Columns[0].HeaderCell.Value = "Diagnosis ID";
            dataGridViewDiagnos.Columns[1].HeaderCell.Value = "Patient ID";
            dataGridViewDiagnos.Columns[2].HeaderCell.Value = "Doctor ID";
            dataGridViewDiagnos.Columns[3].HeaderCell.Value = "Diagnosis Status";
            dataGridViewDiagnos.Columns[9].HeaderCell.Value = "Billing Status";
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
            StuffViewPatient svp = new StuffViewPatient();
            svp.Show();
        }

        private void ViewDiagnosis_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }
    }
}
