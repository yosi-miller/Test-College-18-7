using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace College
{
    public partial class ManagementLecturersAndCourses : Form
    {
        mainForm MainFormRefrens;
        public ManagementLecturersAndCourses(mainForm _mainFormRefrens)
        {
            InitializeComponent();
            MainFormRefrens = _mainFormRefrens;
            showAllLecturers();
            showAllTopics();
            showAllCourses();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLecturersName.Text) ||
                string.IsNullOrEmpty(txtLecturersHourlyRate.Text))
            {
                MessageBox.Show("full all fild");
                return;
            }

            string query = @"INSERT INTO lecturer (lecturer_name, hourly_rate)
                             VALUES (@lecturerName, @hourlyRate)";
            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@lecturerName", txtLecturersName.Text);
                cmd.Parameters.AddWithValue("@hourlyRate", int.Parse(txtLecturersHourlyRate.Text));

                int updateRows = cmd.ExecuteNonQuery();

                if (updateRows > 0)
                {
                    MessageBox.Show("נוסף בהצלחה");
                    showAllLecturers();
                    MainFormRefrens.disConnectDb();
                    txtLecturersName.Text = "";
                    txtLecturersHourlyRate.Text = "";
                    return;
                }
            }
        }

        private void showAllLecturers()
        {
            DataTable result = new DataTable();
            string qurey = @"SELECT * FROM lecturer";

            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(qurey, MainFormRefrens.connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                MainFormRefrens.disConnectDb();
            }
            dgvShowAllLecturers.DataSource = result;
        }

        // מביא מאדטה בייס את כל נושאים ומציג
        private void showAllTopics()
        {
            // like to fillter the name by defualt return all name becuas that select % filter operator
            string query = @"SELECT topic FROM topics";

            if (MainFormRefrens.connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);

                // make the query and read the result
                SqlDataReader reader = cmd.ExecuteReader();

                // מנקה את כל הנתונים שיש בתיבה שמציגה את הנושאים
                ltsTopics.Items.Clear();

                if (reader.HasRows)
                {
                    Console.WriteLine("ok");
                    while (reader.Read())
                    {
                        ltsTopics.Items.Add(reader[0].ToString());
                    }
                }
                MainFormRefrens.disConnectDb();
            }

        }

        // מביא מאדטה בייס את כל נושאים ומציג
        private void showAllCourses()
        {
            DataTable result = new DataTable();
            string qurey = @"SELECT * FROM courses";

            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(qurey, MainFormRefrens.connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                MainFormRefrens.disConnectDb();
            }
            dgvCourses.DataSource = result;

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDaysCourse.Text) ||
                string.IsNullOrEmpty(txtPriceCourse.Text) ||
                string.IsNullOrEmpty(txtTimeCourse.Text) ||
                string.IsNullOrEmpty(txtTypeCourse.Text))
            {
                MessageBox.Show("full all fild");
                return;
            }

            string query = @"INSERT INTO courses (time, days, type, price, date_open)
                             VALUES (@time, @days, @type, @price, @date)";
            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@time", txtTimeCourse.Text);
                cmd.Parameters.AddWithValue("@days", txtDaysCourse.Text);
                cmd.Parameters.AddWithValue("@type", txtTypeCourse.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(txtPriceCourse.Text));
                cmd.Parameters.AddWithValue("@date", dtpOpenCourse.Value.Date.ToString("yyyyMMdd"));

                int updateRows = cmd.ExecuteNonQuery();

                if (updateRows > 0)
                {
                    MessageBox.Show("נוסף בהצלחה");
                    //showAllLecturers();
                    MainFormRefrens.disConnectDb();
                    txtDaysCourse.Text = "";
                    txtTypeCourse.Text = "";
                    txtTimeCourse.Text = "";
                    txtPriceCourse.Text = "";
                    showAllCourses();
                    return;
                }
            }
        }
    }
}
