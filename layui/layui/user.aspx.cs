using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace layui
{
    public partial class user : System.Web.UI.Page
    {
        String connstr = "server = localhost;uid =sa ;pwd = sa123;database = test";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }
        public void bind(String sql)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            GridView1.DataKeyNames = new string[] { "id" };
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable td = new DataTable();
            sda.Fill(td);
            GridView1.DataSource = td;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            String sql = "update user_info set user_name = '" + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.Trim() + "'," +
                "gender='"+((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim()+"'," +
                "mobile_phone = '" + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.Trim()+"'" +
                "where id = '"+GridView1.DataKeys[e.RowIndex].Value.ToString()+"'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            GridView1.EditIndex = -1;
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            String sql = "update user_info set is_delete ='1'" +
                "where id = '" + GridView1.DataKeys[e.RowIndex].Value. 
                 ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            String key = this.TB_key.Text.Trim();
            String Sql = "select * from user_info where user_name like '%" + key + "%' and is_delete=0";
            bind(Sql);
        }
    }
}