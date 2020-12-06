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
    public partial class DiagnosePatient : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["DocCPList"];

        public Operations opr = new Operations();
        public Informations info = new Informations();

        public DiagnosePatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.dstatus = comboBoxDS.Text;
            info.description = txtdescription.Text;
            info.operation = comboBoxOpr.Text;
            info.cabin = comboBoxCbn.Text;
            info.days = Convert.ToInt32(txtdays.Text);
            info.medicin = txtmed.Text;

            int rows = opr.updateDocDiagnos(info, ((DocCPList)f).SelectedEvent());
            if (rows > 0)
            {
                MessageBox.Show("Saved!");
                this.Hide();
                DocCPList dcp = new DocCPList();
                dcp.Show();
            }
        }

        private void DiagnosePatient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewSpDocPatient(((DocCPList)f).SelectedEvent());

            comboBoxDS.Text=dt.Rows[0]["DStatus"].ToString();
            txtdescription.Text = dt.Rows[0]["Description"].ToString();
            comboBoxOpr.Text = dt.Rows[0]["Operation"].ToString();
            comboBoxCbn.Text = dt.Rows[0]["Cabin"].ToString();
            txtdays.Text = dt.Rows[0]["Days"].ToString();
            txtmed.Text = dt.Rows[0]["Medicin"].ToString();
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
            DocCPList dcp = new DocCPList();
            dcp.Show();
        }

        private void DiagnosePatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

    }
}
