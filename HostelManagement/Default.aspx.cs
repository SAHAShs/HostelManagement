using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;
namespace HostelManagement
{
    public partial class _Default : Page
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        OracleCommand cmd = new OracleCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            String userName=username.Text;
            String psw = password.Text;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from login_details where USERID=:username and password=:password";
            cmd.Parameters.Add("username",OracleType.VarChar).Value=userName;
            cmd.Parameters.Add("password",OracleType.VarChar).Value=psw;
            OracleDataAdapter ada = new OracleDataAdapter(cmd);
            DataSet ds=new DataSet();
            ada.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String role = ds.Tables[0].Rows[0]["approle"].ToString();
                Session["role"] = role;
                Session["userid"] = ds.Tables[0].Rows[0]["userid"].ToString();
                
                if (role.Equals("a"))
                {
                    Response.Redirect("~/home.aspx",true);
                }
                else if(role.Equals("w"))
                {
                    Response.Redirect("~/home.aspx", true);
                }
                else if (role.Equals("s"))
                {
                    Response.Redirect("~/home.aspx", true);
                }
                else if (role.Equals("p"))
                {
                    Response.Redirect("~/home.aspx", true);
                }

            }
            else
            {
                ModalLabel.Text = "Invalid username or password.";
                ModalPanel.Visible = true;
                //string script = @"$('#exampleModal').modal('show');";
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowModal", script, true);
            }
            
        }

       
    }
}