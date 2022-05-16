using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo3 : System.Web.UI.Page
{
    

    
    //SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
       /// Button1.Attributes.Add("onclick","return confirm('okaaay')");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        //string jsMethodName = "helloWorld()";
        //ScriptManager.RegisterClientScriptBlock(this, GetType(), "uniqueKey", jsMethodName, true);
        
        SqlCommand cmd = new SqlCommand("Select fingerTemplateImage from FingersData where fingerId = 12", sqlConnection);
        sqlConnection.Open();
        using (SqlDataReader oReader = cmd.ExecuteReader())
        {
            if (oReader.HasRows)
            {
                while (oReader.Read())
                {
                    var fptmpimage = oReader["fingerTemplateImage"].ToString();
                    string jsFunc = "helloWorld(" + fptmpimage + ")";
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "myJsFn", jsFunc, true);
                    //ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:helloWorld(" + fptmpimage + ");", true);
                    //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "myJsFn", "javascript:helloWorld(" + fptmpimage + ")", true);
                }
               
            }

            sqlConnection.Close();
        }

    }

   
}