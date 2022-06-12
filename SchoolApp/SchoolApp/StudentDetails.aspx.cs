﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SchoolApp
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }


        public void GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=VIVEK-DELL;Initial catalog=db1;Integrated security=true");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_vnrdate", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rep.DataSource = dt;
                rep.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //protected void btnedit_Click(object sender, ImageClickEventArgs e)
        //{
        //    int UserID = Convert.ToInt32(((ImageButton)(sender)).CommandArgument.ToString());
        //    Response.Redirect("editaspx.aspx?UserId=" + UserID);
        //}

        //protected void btndelete_Click(object sender, ImageClickEventArgs e)
        //{
        //    int UserID = Convert.ToInt32(((ImageButton)(sender)).CommandArgument.ToString());
        //    SqlConnection con = new SqlConnection("Data Source=(local);Initial catalog=db_vnr;Integrated security=true");
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("Delete from tbl_vnrdate where UserID =@UserID", con);
        //        cmd.Parameters.AddWithValue("@UserID", UserID);
        //        int x = cmd.ExecuteNonQuery();
        //        if (x > 0)
        //        {
        //            Response.Redirect(Request.RawUrl);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}