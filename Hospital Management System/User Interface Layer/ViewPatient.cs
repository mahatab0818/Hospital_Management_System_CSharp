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
    public partial class ViewPatient : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();

        int x;

        public ViewPatient()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewPatient(info);
            dataGridViewEmp.DataSource = dt;
            dataGridViewEmp.Columns[0].HeaderCell.Value = "Patient ID";
            dataGridViewEmp.Columns[3].HeaderCell.Value = "Date of Birth";

            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePatient up = new UpdatePatient();
            up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int rows = opr.deletePatient(SelectedEvent());
            if (rows > 0)
            {
                MessageBox.Show("Deleted!");
                dataGridViewEmp.Refresh();
                dataGridViewEmp.Rows.RemoveAt(dataGridViewEmp.SelectedRows[0].Index);
            }
        }

        private void dataGridViewEmp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.x = Convert.ToInt32(dataGridViewEmp.Rows[e.RowIndex].Cells["PID"].Value);
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
            AdminPatient ap = new AdminPatient();
            ap.Show();
        }

        private void ViewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            int rows = opr.exitLgdIn();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDiagnosis vd = new ViewDiagnosis();
            vd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewDiagnosis(info, SelectedEvent());

            float x = 0, y = 0;

            if (dt.Rows[0]["Operation"].ToString() == "High Cost")
            {
                x = x + 20000;
            }
            else if (dt.Rows[0]["Operation"].ToString() == "Medium Cost")
            {
                x = x + 10000;
            }
            else if (dt.Rows[0]["Operation"].ToString() == "Low Cost")
            {
                x = x + 5000;
            }


            if (dt.Rows[0]["Cabin"].ToString() == "Luxery")
            {
                y = (y + 5000) * (Convert.ToInt32(dt.Rows[0]["Days"]));
            }
            else if (dt.Rows[0]["Cabin"].ToString() == "Delux")
            {
                y = (y + 1500) * (Convert.ToInt32(dt.Rows[0]["Days"]));
            }
            else if (dt.Rows[0]["Cabin"].ToString() == "General")
            {
                y = (y + 500) * (Convert.ToInt32(dt.Rows[0]["Days"]));
            }

            info.bill = x + y;

            int rows = opr.updateBill(info, SelectedEvent());

            this.Hide();
            Billing b = new Billing();
            b.Show();
        }
    }
}
