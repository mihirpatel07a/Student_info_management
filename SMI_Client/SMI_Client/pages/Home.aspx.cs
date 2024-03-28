using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class Home1 : System.Web.UI.Page
    {
        StudentServiceReference.StudentServiceClient studentServiceClient = new StudentServiceReference.StudentServiceClient();
        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();   
        protected void Page_Load(object sender, EventArgs e)
        {
            int count_no = 0;

            int branch_count = 0;

            branch_count = branchClient.GetBranchCount();

            count_no = studentServiceClient.GetStudentCount();
            Label4.Text = branch_count.ToString();

            Label3.Text = count_no.ToString();


        }
    }
    
}