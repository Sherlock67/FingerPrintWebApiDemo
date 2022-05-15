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
        string query = "SELECT TOP 1 * FROM FingersData";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //sqlCommand.Parameters.AddWithValue("@fingerBmpImage",);
        //sqlCommand.Parameters.AddWithValue("@fingerTemplateImage",);
        sqlCommand.ExecuteNonQuery();
        TextBox1.Text = "Rk1SACAyMAAAAAEIAAABLAGQAMUAxQEAAABOJ0CYABVpAIDaABZnAEB1ACBuAED6ACbdAEBJAC91AIB3AEtvAEDiAE5nAEArAFiAAECBAI5uAIAuAJMHAIB + AJV5AEBRAJ37AECrAKppAIEFAMPlAIA + AMeNAICPANBrAIBdANmEAIDAAN3hAICJAOjqAIC / APVeAEDmAPbbAEDyAQVbAECHAQbjAECfAQjgAICWAQldAICDAQ1oAEByAQ91AEDqARDdAEDBARJiAICjARllAIB6ARp9AIDSARxxAIC9ARxrAEDrASRhAECSAS3HAIDuATH1AEC0ATXRAEC + ATveAEDbAUVeAAAA"
        /*Console.WriteLine("Okay")*/;
        sqlConnection.Close();

    }
}