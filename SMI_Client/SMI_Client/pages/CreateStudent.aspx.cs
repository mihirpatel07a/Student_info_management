using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        StudentServiceReference.StudentServiceClient studentServiceClient = new StudentServiceReference.StudentServiceClient();
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            StudentServiceReference.Student student = new StudentServiceReference.Student();
            student.Name = name.Value; 
            student.Email = email.Value;
            student.Age = int.Parse(age.Value);
            student.Branch = branch.SelectedItem.Value;
            student.Gender = Gen.SelectedItem.Value;

            bool isInserted = false;
            isInserted = studentServiceClient.Insert(student);
            if (isInserted)
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}