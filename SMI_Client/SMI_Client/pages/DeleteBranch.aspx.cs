using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class DeleteBranch : System.Web.UI.Page
    {
        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int branchid = Convert.ToInt32(Request.QueryString["ID"]);

                bool isdeleted = false;

                isdeleted = branchClient.DeleteBranch(branchid);

                if(isdeleted)
                {
                    Response.Redirect("Branch.aspx");
                }
            }
        }
    }
}