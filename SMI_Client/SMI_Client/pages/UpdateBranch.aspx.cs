using SMI_Client.BranchServiceReference;
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
    public partial class UpdateBranch : System.Web.UI.Page
    {
        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();
        int branchid;
        protected void Page_Load(object sender, EventArgs e)
        {
            branchid = Convert.ToInt32(Request.QueryString["ID"]);

            if (!IsPostBack)
            {
                BranchServiceReference.Branch branch = new BranchServiceReference.Branch();


                branch = branchClient.GetBranch(branchid);

                name.Value = branch.BranchName;
                location.Value = branch.Location;
                HOD.Value = branch.HOD;
                faculty.Value = branch.NumberOfFaculty.ToString();

            } 
        }


        protected void SaveBtn_Click(object sender, EventArgs e)
        {
           
            
                BranchServiceReference.Branch branch = new BranchServiceReference.Branch();

                bool isupdated = false;

                branch.BranchName = name.Value;
                branch.Location = location.Value;
                branch.HOD = HOD.Value;
                branch.NumberOfFaculty = Convert.ToInt32(faculty.Value);

                isupdated = branchClient.UpdateBranch(branchid, branch);
                if (isupdated) {

                    Response.Redirect("Branch.aspx");
                }
            

        }
    }
}