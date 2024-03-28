using SMI_Client.BranchServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client.pages
{
    public partial class Home : System.Web.UI.Page
    {
        BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Check if it's the initial page load
            {
                // Populate the branch dropdown list
                PopulateBranchDropdown();
            }


        }

        private void PopulateBranchDropdown()
        {
          
             BranchServiceReference.BranchData branchData = new BranchServiceReference.BranchData();
                // Call the GetBranchData method to retrieve branch data
                branchData = branchClient.GetBranchData();

                // Clear existing items in the dropdown list
                branch.Items.Clear();
                
                // Add a default item if needed
                branch.Items.Add(new ListItem("Default"));

                // Add branches to the dropdown list
                foreach (DataRow row in branchData.BranchTable.Rows)
                {
                 

                    string branchName = row["BranchName"].ToString();
                    branch.Items.Add(new ListItem(branchName));
                }

            
           
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