using SMI_Client.BranchServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
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

                PopulateBranchDropdown();

                StudentServiceReference.Student student = new StudentServiceReference.Student();


                student = studentServiceClient.GetStudent(studentid);

                name.Value = student.Name;
                email.Value = student.Email;
                age.Value = student.Age.ToString();
                branch.SelectedItem.Value= student.Branch;
                Gen.SelectedItem.Value = student.Gender;

            }
        }

        private void PopulateBranchDropdown()
        {

            BranchServiceReference.BranchData branchData = new BranchServiceReference.BranchData();
            BranchServiceReference.BranchClient branchClient = new BranchServiceReference.BranchClient();
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