using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["UniversityManagementConnectionString"].ConnectionString;

        private bool isUpdateMode = false;

        private int studentID;

        List<Students> studentList = new List<Students>();
        private void saveButton_Click(object sender, EventArgs e)
        {

            string stuName = studentNameTextBox.Text;
            int stuRegNo = Convert.ToInt32(studentRegNoTextBox.Text);
            string stuDepart = departmentTextBox.Text;
            string stuSession = sessionTextBox.Text;
            string mobile = mobileNoTextBox.Text;

            if (isUpdateMode)
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string updateQuery = "UPDATE student_info SET StudentName='" + stuName + "', Department='" + stuDepart + "', Session='" + stuSession + "', MobileNo='" + mobile + "' WHERE id='"+studentID+"' ";

                SqlCommand command = new SqlCommand(updateQuery, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show(@"Student successfully Update...!");

                    isUpdateMode = false;
                    saveButton.Text = "Save Student";
                    studentID = 0;

                    ShowAllStudent();

                    studentNameTextBox.Clear();
                    studentRegNoTextBox.Clear();
                    departmentTextBox.Clear();
                    sessionTextBox.Clear();
                    mobileNoTextBox.Clear();
                }
                else
                {
                    MessageBox.Show(@"Update Failed..!");
                }
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string insertQuery = "INSERT INTO student_info(StudentName, RegNo, Department, Session, MobileNo) VALUES('" + stuName + "','" + stuRegNo + "','" + stuDepart + "','" + stuSession + "','" + mobile + "')";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show(@"Student data successfully Inserted..!");
                }
                else
                {
                    MessageBox.Show(@"Operation Failed..!");
                }
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllStudent();
        }

        public void ShowAllStudent()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT * FROM student_info";

            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Students students = new Students();

                students.stuId = int.Parse(reader["id"].ToString());
                students.stuName = reader["StudentName"].ToString();
                students.stuRegNo = int.Parse(reader["RegNo"].ToString());
                students.stuDepartment = reader["Department"].ToString();
                students.stuSession = reader["Session"].ToString();
                students.stuMobile = reader["MobileNo"].ToString();

                studentList.Add(students);
            }
            reader.Close();
            connection.Close();

            LoadStudentListView(studentList);
        }

        public void LoadStudentListView(List<Students> studentses )
        {
            
            foreach (var student in studentList)
            {
                showStudentListView.Items.Clear();
                ListViewItem item = new ListViewItem(student.stuId.ToString());

                item.SubItems.Add(student.stuName);
                item.SubItems.Add(student.stuRegNo.ToString());
                item.SubItems.Add(student.stuDepartment);
                item.SubItems.Add(student.stuSession);
                item.SubItems.Add(student.stuMobile);


                showStudentListView.Items.Add(item);
            }
        }

        private void showStudentListView_DoubleClick_1(object sender, EventArgs e)
        {
            ListViewItem item = showStudentListView.SelectedItems[0];

            int id = int.Parse(item.Text.ToString());

            Students students = GetStudentByID(id);

            if (students != null)
            {
                isUpdateMode = true;
                saveButton.Text = @"Update Student";
                deleteButton.Visible = true;
                studentID = students.stuId;

                studentNameTextBox.Text = students.stuName;
                studentRegNoTextBox.Text = Convert.ToString(students.stuRegNo);
                departmentTextBox.Text = students.stuDepartment;
                sessionTextBox.Text = students.stuSession;
                mobileNoTextBox.Text = students.stuMobile;
            }
        }
        
        
        public Students GetStudentByID(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT * FROM student_info WHERE id='" + id + "'";

            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Students students = new Students();

                students.stuId = int.Parse(reader["id"].ToString());
                students.stuName = reader["StudentName"].ToString();
                students.stuRegNo = int.Parse(reader["RegNo"].ToString());
                students.stuDepartment = reader["Department"].ToString();
                students.stuSession = reader["Session"].ToString();
                students.stuMobile = reader["MobileNo"].ToString();

                studentList.Add(students);
            }
            reader.Close();
            connection.Close();

            return studentList.FirstOrDefault();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "DELETE FROM student_info WHERE id='" + studentID + "'";

            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show(@"Student successfully Delete...!");
                ShowAllStudent();


                studentNameTextBox.Clear();
                studentRegNoTextBox.Clear();
                departmentTextBox.Clear();
                sessionTextBox.Clear();
                mobileNoTextBox.Clear();
            }
            else
            {
                MessageBox.Show(@"Delete Failed..!");
            }
        }

       
    }
}
