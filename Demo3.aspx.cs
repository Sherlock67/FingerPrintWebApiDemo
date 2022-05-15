using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo3 : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
    //SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        sqlConnection.Open();
        string query = "select * from FingersData";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@fingerBmpImage", TextBox1.Text);
        sqlCommand.Parameters.AddWithValue("@fingerTemplateImage", TextBox2.Text);
        sqlCommand.ExecuteNonQuery();
        Console.WriteLine("Okay");
        sqlConnection.Close();

    }
}