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
    public partial class users : System.Web.UI.Page
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

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable td = new DataTable();
            sda.Fill(td);
            GridView1.DataSource = td;
            GridView1.DataBind();
        }
    }
}