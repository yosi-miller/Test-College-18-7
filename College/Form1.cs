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

namespace College
{
    public partial class mainForm : Form
    {
        // מגדיר מתשנה שכיל את הערך שחוזר בעת חיבור לדאטה בייס
        public SqlConnection connection;

        // מגדיר את נתיב החיבור לשרת SQL
        public readonly string connectionString = "server=YOSEF-MILLER\\SQLEXPRESS; initial catalog=college; user id=sa; password=1234; TrustServerCertificate=Yes";

        public mainForm()
        {
            InitializeComponent();
        }

        public bool connectDb()
        {
            try
            {
                // create a connection to DB
                connection = new SqlConnection(connectionString);

                // open the connection
                connection.Open();
                Console.WriteLine("החיבור הצליח");

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // disconnect to DB
        public void disConnectDb()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // פותח את תפריט מתעניינים
        private void btnLeads_Click(object sender, EventArgs e)
        {
            Leads leadsForm = new Leads(this);
            leadsForm.ShowDialog();
        }

        // פותח את תפריט הוספת וניהול קורסים ומרצים
        private void btnManagementLecturersAndCourses_Click(object sender, EventArgs e)
        {
            ManagementLecturersAndCourses managementLecturersAndCourses = new ManagementLecturersAndCourses(this);
            managementLecturersAndCourses.ShowDialog();
        }

        private void btnCourseRegistr_Click(object sender, EventArgs e)
        {
            CourseRegistr courseRegistr = new CourseRegistr(this);
            courseRegistr.ShowDialog();
        }
    }
}
