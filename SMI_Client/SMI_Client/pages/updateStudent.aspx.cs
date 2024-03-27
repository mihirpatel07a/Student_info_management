using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client
{
    public partial class updateStudent : System.Web.UI.Page
    {
        StudentServiceReference.StudentServiceClient studentServiceClient = new StudentServiceReference.StudentServiceClient();
        int studentid;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            studentid = Convert.ToInt32(Request.QueryString["ID"]);

            if (!IsPostBack)
            {
                StudentServiceReference.Student student = new StudentServiceReference.Student();


                student = studentServiceClient.GetStudent(studentid);

                name.Value = student.Name;
                email.Value = student.Email;
                age.Value = student.Age.ToString();
                branch.SelectedValue= student.Branch;
                Gen.SelectedValue = student.Gender;

            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            StudentServiceReference.Student student = new StudentServiceReference.Student();

            student.Name = name.Value;
            student.Email = email.Value;
            student.Age = int.Parse(age.Value);
            student.Gender = Gen.SelectedItem.Value;
            student.Branch = branch.SelectedItem.Value;




            bool isupdated = false;



            isupdated = studentServiceClient.Update(studentid, student);

            if(isupdated)
            {
                Response.Redirect("Student.aspx");
            }
        }
    }
}