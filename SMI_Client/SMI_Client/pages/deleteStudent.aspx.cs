using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        StudentServiceReference.StudentServiceClient studentServiceClient = new StudentServiceReference.StudentServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                int studentid = Convert.ToInt32(Request.QueryString["Id"]);

                bool isDeleted = false;

                isDeleted = studentServiceClient.Delete(studentid);

                if(isDeleted == true)
                {
                    Response.Redirect("Student.aspx");
                }


            }
        }
    }
}