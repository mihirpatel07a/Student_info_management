using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class Branch : System.Web.UI.Page
    {

        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();
        protected void Page_Load(object sender, EventArgs e)
        { 
            BranchServiceReference.BranchData branchData = new BranchServiceReference.BranchData();
            branchData = branchClient.GetBranchData();
            if (branchData != null)
            {
                DataTable branchTable = new DataTable();
                branchTable = branchData.BranchTable;

                Branchlist.DataSource = branchTable;
                Branchlist.DataBind();



            }

        }
    }
}