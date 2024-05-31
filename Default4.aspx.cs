using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string username = Login1.UserName;
        string password = Login1.Password;
     
        SqlConnection con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
        con.Open();
        SqlDataAdapter a = new SqlDataAdapter("select * from users where username=@p1 and password=@p2", con);

        a.SelectCommand.Connection = con;
        a.SelectCommand.Parameters.Add("@p1", SqlDbType.VarChar, 20);
        a.SelectCommand.Parameters.Add("@p2", SqlDbType.VarChar, 20);
        a.SelectCommand.Parameters["@p1"].Value = username;
        a.SelectCommand.Parameters["@p2"].Value = password;
        DataSet s = new DataSet();
        a.Fill(s);
        string u = "";
        string p = "";
        for (int i = 0; i < s.Tables[0].Rows.Count; i++)
        {
            u = s.Tables[0].Rows[i][0].ToString();
            p = s.Tables[0].Rows[i][1].ToString();

        }
        if (username == u && password == p)
        {
            Response.Write("<p>successfully</p>");
        }
        else
        {
            Response.Write("<p>not successfully</p>");
        }

    }
}