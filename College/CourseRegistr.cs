using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace College
{
    public partial class CourseRegistr : Form
    {
        mainForm MainFormRefrens;
        public CourseRegistr(mainForm _mainFormRefrens)
        {
            InitializeComponent();
            MainFormRefrens = _mainFormRefrens;
            showAllCourses();
            showAllstudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = lblCourceName.Text;
            string student = lblStudentName.Text;
            if (lblCourceName.Text == "בחר שם סטודנט" ||
                lblStudentName.Text == "בחר שם קורס")
            {
                MessageBox.Show("full all fild");
                return;
            }

            string query = @"INSERT INTO student_of_course(student_id, course_id)
                            VALUES ((SELECT id FROM student WHERE student_name = @studentName),
		                            (SELECT id FROM courses WHERE type = @courseName))";
            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@courseName", course);
                cmd.Parameters.AddWithValue("@studentName", student);

                int updateRows = cmd.ExecuteNonQuery();

                if (updateRows > 0)
                {
                    MessageBox.Show("נוסף בהצלחה");
                    //showAllLecturers();
                    MainFormRefrens.disConnectDb();
                    lblCourceName.Text = "בחר שם סטודנט";
                    lblStudentName.Text = "בחר שם קורס";
                    return;
                }
            }

        }

        private void ltsStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStudentName.Text = ltsStudent.SelectedItem.ToString();
        }

        private void ltsCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCourceName.Text = ltsCourses.SelectedItem.ToString();
        }

        private void showAllCourses()
        {
            // like to fillter the name by defualt return all name becuas that select % filter operator
            string query = @"SELECT type FROM courses";

            if (MainFormRefrens.connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);

                // make the query and read the result
                SqlDataReader reader = cmd.ExecuteReader();

                // מנקה את כל הנתונים שיש בתיבה שמציגה את הנושאים
                ltsCourses.Items.Clear();

                if (reader.HasRows)
                {
                    Console.WriteLine("ok");
                    while (reader.Read())
                    {
                        ltsCourses.Items.Add(reader[0].ToString());
                    }
                }
                MainFormRefrens.disConnectDb();
            }

        }

        private void showAllstudents()
        {
            // like to fillter the name by defualt return all name becuas that select % filter operator
            string query = @"SELECT student_name FROM student";

            if (MainFormRefrens.connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);

                // make the query and read the result
                SqlDataReader reader = cmd.ExecuteReader();

                // מנקה את כל הנתונים שיש בתיבה שמציגה את הנושאים
                ltsStudent.Items.Clear();

                if (reader.HasRows)
                {
                    Console.WriteLine("ok");
                    while (reader.Read())
                    {
                        ltsStudent.Items.Add(reader[0].ToString());
                    }
                }
                MainFormRefrens.disConnectDb();
            }

        }
    }
}
