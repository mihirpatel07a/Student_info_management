using SMI_Client.StudentServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class CreateBranch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();   

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
             BranchServiceReference.Branch branch = new BranchServiceReference.Branch();

            branch.BranchName = name.Value;
            branch.Location = location.Value;
            branch.HOD = HOD.Value;
            branch.NumberOfFaculty = Convert.ToInt32(faculty.Value);
            

            bool isInserted = false;
            isInserted = branchClient.InsertBranch(branch);
            if (isInserted)
            {
                Response.Redirect("Branch.aspx");
            }
        }
    }
}