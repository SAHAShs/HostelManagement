using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HostelManagement
{
    public partial class SiteMaster : MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session != null && Session["role"] != null)
                {
                    string role = Session["role"].ToString();
                    if (role.Equals("a"))
                    {
                        AdminNavigation.Visible = true;

                    }
                    else if (role.Equals("w"))
                    {
                        wardenNavigation.Visible = true;
                    }
                    else if (role.Equals("s"))
                    {
                        Studentnavigation.Visible = true;
                    }
                    else if (role.Equals("p"))
                    {
                        ParentNavigation.Visible = true;
                    }
                }
               
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Default.aspx");
        }
    }
}