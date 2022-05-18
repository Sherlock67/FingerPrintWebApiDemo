using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Demo1 : System.Web.UI.Page
{
	SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
	protected void Page_Load(object sender, EventArgs e)
    {

		
	}

    protected void Button1_Click(object sender, EventArgs e)
    {
		sqlConnection.Open();
		string query = "Insert into [dbo].[FingersData] (fingerBmpImage,fingerTemplateImage) Values (@fingerBmpImage,@fingerTemplateImage)";
        //string regex = @"[^0-9a-zA-Z]+";
        //TextBox2.Text = Regex.Replace(TextBox2.Text, regex, "");
        
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@fingerBmpImage",TextBox1.Text);
        sqlCommand.Parameters.AddWithValue("@fingerTemplateImage",TextBox2.Text);
      
        sqlCommand.ExecuteNonQuery();
        //Response.Write(TextBox1.Text);

        //Response.Write(TextBox2.Text);
        sqlConnection.Close();
    }
}