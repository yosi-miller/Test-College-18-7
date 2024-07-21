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
            if (lblCourceName.Text == "בחר שם קורס" ||
                lblStudentName.Text == "בחר שם סטודנט")
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
            // בדיקה אם לא נבחר תלמיד
            if (ltsStudent.SelectedItem == null)
            {
                MessageBox.Show("נא בחר שם תלמיד");
                return;
            }

            string studentName = ltsStudent.SelectedItem.ToString();
            lblStudentName.Text = studentName;

            int totalToPay = toPay(studentName);
            int totalPaid = toPaymed(studentName);

            Console.WriteLine($"Total to pay: {totalToPay}");
            Console.WriteLine($"Total paid: {totalPaid}");

            // הצגת המידע למשתמש בתיבת טקסט
            lblPaymed.Text = (totalToPay - totalPaid).ToString();

        }

        // מחזיר את הסכום שהתלמיד כבר שילם
        private int toPaymed(string studentName)
        {
            string query = @"SELECT SUM(pay.payment)
                            FROM pay
                            INNER JOIN student
                            ON pay.student_id = student.id
                            WHERE pay.student_id = (SELECT id FROM student WHERE student_name = @studentName) ";

            int result = 0;
            if (MainFormRefrens.connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                try
                {
                    result = (int)cmd.ExecuteScalar();
                }
                catch
                {
                    result = 0;
                }
                finally
                {
                    MainFormRefrens.disConnectDb();
                }
            }
            return result;
        }

        // מחזיר את הסכום הכולל שהלקוח התחייב לשלם על הקורסים - ולא את יתרת החוב 
        private int toPay(string studentName)
        {
            string query = @"SELECT SUM(courses.price)
                            FROM courses
                            INNER JOIN student_of_course
                            ON student_of_course.course_id = courses.id
                            WHERE student_of_course.student_id = (SELECT id FROM student WHERE student_name = @studentName)
                            ";

            int result = 0;
            if (MainFormRefrens.connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                try
                {
                    result = (int)cmd.ExecuteScalar();
                }
                catch
                {
                    result = 0;
                }
                finally
                {
                    MainFormRefrens.disConnectDb();
                }
            }
            return result;
        }

        private void ltsCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // בדיקה אם לא נבחר קורס
            if (ltsStudent.SelectedItem == null)
            {
                MessageBox.Show("נא בחר שם קורס");
                return;
            }
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
