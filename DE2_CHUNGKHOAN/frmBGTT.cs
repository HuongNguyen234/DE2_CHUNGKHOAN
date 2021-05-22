using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE2_CHUNGKHOAN
{
    public partial class frmBGTT : Form
    {
        public string connectionString = @"Data Source=HUONG\SERVER1;Initial Catalog=CHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=1234";
        SqlConnection connect = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;
        public frmBGTT()
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
            SqlDependency.Stop(connectionString);
            SqlDependency.Start(connectionString);
            connect = new SqlConnection(connectionString);
        }

        private void frmBGTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cKDataSet.SP_GETROW' table. You can move, or remove it, as needed.
            //tab
            
            try
            {
                OnNewHome += new NewHome(OnNewHome1);
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", err.Message, MessageBoxButtons.OK);
            }
        }

        public void OnNewHome1()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                NewHome dd = new NewHome(OnNewHome1);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            if (connect.State == ConnectionState.Closed)
            {
                // Mở kết nối SqlConnection
                connect.Open();
            }
            // Mở kết nối SqlConnection
            SqlCommand cmd = new SqlCommand("EXEC SP_GETROW", connect);
            cmd.Notification = null;

            // -Tạo 1 dependency và liên kết nó với đối tượng SqlCommand.
            SqlDependency de = new SqlDependency(cmd);

            // Subscribe đến sự kiện SqlDependency.
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            // Thực thi lệnh trên đối tượng command.
            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            dataGridView1.DataSource = dt;
        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }
    }
}
