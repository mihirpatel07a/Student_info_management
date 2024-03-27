using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMI_Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void loginbtn_Click(object sender, EventArgs e)
        {

            if (U_name.Value == "" || Password.Value == "")
            {
                ErrMsg.Text = "Missing Detail !!";
            }
            else if (U_name.Value == "Admin@gmail.com" && Password.Value == "password")
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                
                    ErrMsg.Text = "User not found";
                
                
            }
        }
    }
}