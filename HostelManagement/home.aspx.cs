using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HostelManagement
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            
        }
        //this wont work because we are directly passing table name as bind parameter, sql injection
        //private void loadData(String tb_name)
        //{
        //    OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        //    OracleCommand cmd = new OracleCommand();
        //    con.Open();
        //    cmd.Connection = con;
        //    cmd.CommandText = "select * from :tb_name";
        //    cmd.Parameters.Add("tbname", OracleType.VarChar).Value = tb_name;
        //    OracleDataAdapter ada = new OracleDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    ada.Fill(ds);
        //    data.DataSource = ds;
        //    data.DataBind();

        //}
        private void loadData(String tb_name)
        {
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
            OracleCommand cmd = new OracleCommand("select * from "+tb_name,con);
            con.Open();
            //cmd.Connection = con;
            //cmd.CommandText =;
            //cmd.Parameters.Add("tbname", OracleType.VarChar).Value = tb_name;
            OracleDataAdapter ada = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            data.DataSource = ds;
            data.DataBind();

        }
        //private void loadData(string tb_name)
        //{
        //    // Using statement ensures proper disposal of resources
        //    using (OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
        //    {
        //        // Construct the SQL query with the table name parameter
        //        string query = "SELECT * FROM " + tb_name;

        //        // Create and execute the command
        //        using (OracleCommand cmd = new OracleCommand(query, con))
        //        {
        //            con.Open();

        //            // Use OracleDataAdapter to fill a DataSet with the query results
        //            using (OracleDataAdapter ada = new OracleDataAdapter(cmd))
        //            {
        //                DataSet ds = new DataSet();
        //                ada.Fill(ds);

        //                // Bind the DataSet to the data control
        //                data.DataSource = ds;
        //                data.DataBind();
        //            }
        //        }
        //    }
        //}

        protected void data_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                // Handle the Edit command
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = data.Rows[rowIndex];
                int id = Convert.ToInt32(row.Cells[0].Text);
                // Perform the edit action here
            }
            else if (e.CommandName == "Delete")
            {
                // Handle the Delete command
                int id = Convert.ToInt32(e.CommandArgument);
                // Perform the delete action here
            }
            else if (e.CommandName == "Lock")
            {
                // Handle the Lock command
                int id = Convert.ToInt32(e.CommandArgument);
                // Perform the lock action here
            }
        }
        protected void data_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton editButton = (LinkButton)e.Row.FindControl("editButton");
                LinkButton deleteButton = (LinkButton)e.Row.FindControl("deleteButton");
                LinkButton lockButton = (LinkButton)e.Row.FindControl("lockButton");
                int id = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ID"));
                editButton.CommandArgument = id.ToString();
                deleteButton.CommandArgument = id.ToString();
                lockButton.CommandArgument = id.ToString();
            }
        }

        protected void Unnamed_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(dp_list.SelectedValue.ToString());
        }

        protected void data_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }

}