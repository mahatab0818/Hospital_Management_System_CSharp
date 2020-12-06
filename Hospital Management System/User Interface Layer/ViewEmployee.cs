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

using System.Data.SqlClient;

namespace User_Interface_Layer
{
    public partial class ViewEmployee : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        int x;

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewEmployee(info);
            dataGridViewEmp.DataSource = dt;
            dataGridViewEmp.Columns[0].HeaderCell.Value = "Employee ID";
            dataGridViewEmp.Columns[3].HeaderCell.Value = "Date of Birth";
            dataGridViewEmp.Columns[6].HeaderCell.Value = "Phone Number";
            dataGridViewEmp.Columns[8].HeaderCell.Value = "Employee ID";

            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployee ue = new UpdateEmployee();
            ue.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int rows = opr.deleteEmp(SelectedEvent());
            if (rows > 0)
            {
                MessageBox.Show("Deleted!");
                dataGridViewEmp.Refresh();
                dataGridViewEmp.Rows.RemoveAt(dataGridViewEmp.SelectedRows[0].Index);
            }
        }

        private void dataGridViewEmp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.x = Convert.ToInt32(dataGridViewEmp.Rows[e.RowIndex].Cells["EID"].Value);
        }

        public int SelectedEvent()
        {
            return this.x;
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
            AdminEmployee ae = new AdminEmployee();
            ae.Show();
        }

        private void ViewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }
    }
}
