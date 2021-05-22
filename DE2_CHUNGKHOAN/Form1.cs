using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DE2_CHUNGKHOAN
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public string m_connect = @"Data Source=HUONG\SERVER1;Initial Catalog=CHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=1234";
        SqlConnection con = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;
        public Form1()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cKDataSet.SP_GETROW' table. You can move, or remove it, as needed.
            this.sP_GETROWTableAdapter.Fill(this.cKDataSet.SP_GETROW);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
