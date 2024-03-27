using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.ServiceModel;
using System.Data;

namespace SMI_Service
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class StudentService : IStudentService
    {

        public bool Insert(Student student)
        {
            bool isInserted = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO SMI_DB.dbo.Student_DB (Name, Email, Age , Branch, Gender) values (@Name, @Email ,@Age, @Branch, @Gender)", con);
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@Branch", student.Branch);

            int g = cmd.ExecuteNonQuery();
            if(g == 1)
            {
                isInserted = true;
            }
            con.Close();
            return isInserted;

         }

        public bool Update(int id , Student student)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE SMI_DB.dbo.Student_DB " +
                                             "SET Name = @Name, " +
                                             "    Email = @Email, " +
                                             "    Age = @Age, " +
                                             "    Branch = @Branch " +
                                             "WHERE Student_id = @id", con);

            cmd.Parameters.AddWithValue("@id", id); // Corrected parameter name
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            cmd.Parameters.AddWithValue("@Branch", student.Branch);

            // Execute the update query
            int rowsAffected = cmd.ExecuteNonQuery();

            // Check if any rows were affected
            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM SMI_DB.dbo.Student_DB WHERE Student_id = @id", con);

            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected > 0;


        }

        public List<Student> GetStudents()
        {

            List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SMI_DB.dbo.Student_DB", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Assuming Student has a parameterized constructor
                Student student = new Student
                {
                  
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Branch = reader["Branch"].ToString(),
                    
                };

                students.Add(student);
            }
            return students;

        }

        public StudentData GetStudentData()
        {

            StudentData studentData = new StudentData();    


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT * FROM SMI_DB.dbo.Student_DB", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable studentTable = new DataTable("studentTable");

            adapter.Fill(studentTable);

            studentData.studentTable = studentTable;

            con.Close();

            return studentData;

        }
    }
}
