﻿using System;
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
                                             "    Branch = @Branch, " +
                                             "    Gender = @Gender " +
                                             "WHERE Student_id = @id", con);

            cmd.Parameters.AddWithValue("@id", id); // Corrected parameter name
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            cmd.Parameters.AddWithValue("@Branch", student.Branch);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);

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

        public Student GetStudent(int id)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();

            Student student = new Student();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SMI_DB.dbo.Student_DB WHERE Student_id = @id ", con);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            
                // Check if there are rows returned
                if (reader.Read())
                {
                    // Populate the student object with data from the database
                    
                    student.Name = reader.GetString(reader.GetOrdinal("Name"));
                    student.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                    student.Email = reader.GetString(reader.GetOrdinal("Email"));
                    student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                student.Branch = reader.GetString(reader.GetOrdinal("Branch"));
           
            }
            else
                {
                  
                    return null;
                }



                return student;
        }

        public int GetStudentCount()
        {
            int count = 0;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN8U3D\\SQLEXPRESS01;Initial Catalog=SMI_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SMI_DB.dbo.Student_DB", con);

            // Execute the command and retrieve the count
            count = (int)cmd.ExecuteScalar();

            return count;


        }
            

    }
}
