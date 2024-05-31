using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username= TextBox1.Text;
        string password=TextBox2.Text;
        SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from users where username=@p1 and password=@p2";
        cmd.Parameters.Add("@p1", SqlDbType.VarChar, 20);
        cmd.Parameters.Add("@p2", SqlDbType.VarChar, 20);
        cmd.Parameters["@p1"].Value = username;
        cmd.Parameters["@p2"].Value = password;
      
       SqlDataReader dr=cmd.ExecuteReader();
        string u = "";
        string p = "";
        while (dr.Read())
        {
            u = (string)dr[0];
            p = (string)dr[1];
        }
     if(u==username && p==password)
        {
            Label3.Text = "suceessfully............welcome to website";
        }
        else
        {
            Label3.Text = "not matched";
        }

    }
}