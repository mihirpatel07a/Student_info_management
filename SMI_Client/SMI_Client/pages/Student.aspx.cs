using SMI_Client.StudentServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class Student : System.Web.UI.Page
    {
        StudentServiceReference.StudentServiceClient studentServiceClient = new StudentServiceReference.StudentServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            StudentServiceReference.StudentData studentData = new StudentServiceReference.StudentData();



           studentData =  studentServiceClient.GetStudentData();

           DataTable studentTable = new DataTable();
           studentTable = studentData.studentTable;

            studentlist.DataSource = studentTable;
            studentlist.DataBind();

            if(studentlist.HeaderRow != null )
            {
                studentlist.HeaderRow.Cells[0].Text = "Update";
                studentlist.HeaderRow.Cells[1].Text = "Delete";
                studentlist.HeaderRow.Cells[2].Text = "Id";


            }





        }
    }
}