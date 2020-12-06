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
    public partial class DocCPList : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["DoctorHome"];

        public Operations opr = new Operations();
        public Informations info = new Informations();

        int x;

        public DocCPList()
        {
            InitializeComponent();
        }

        private void DocCPList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewCurrentPatient(info, ((DoctorHome)f).docLogged());
            dataGridViewDCPList.DataSource = dt;

            dataGridViewDCPList.Columns[0].HeaderCell.Value = "Diagnose ID";

            dataGridViewDCPList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiagnosePatient dp = new DiagnosePatient();
            dp.Show();
        }

        public int SelectedEvent()
        {
            return this.x;
        }

        private void dataGridViewDCPList_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.x = Convert.ToInt32(dataGridViewDCPList.Rows[e.RowIndex].Cells["DID"].Value);
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
            DoctorHome dh = new DoctorHome();
            dh.Show();
        }

        private void DocCPList_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

    }
}
