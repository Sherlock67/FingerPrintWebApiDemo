using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.UI;

public partial class Demo3 : System.Web.UI.Page
{



    //SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        SqlCommand cmd = new SqlCommand("select fingerId from FingersData", sqlConnection);
        /// Button1.Attributes.Add("onclick","return confirm('okaaay')");
        sqlConnection.Open();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);


        SqlCommand cmd = new SqlCommand("Select * from FingersData where fingerId =" +DropDownList1.SelectedItem.Value, sqlConnection);
        sqlConnection.Open();
        using (SqlDataReader oReader = cmd.ExecuteReader())
        {

            if (oReader.HasRows)
            {
                while (oReader.Read())
                {
                    var fptmpimage = oReader["fingerTemplateImage"].ToString();
                    //var fptmpimage = oReader.GetString(0);
                    //string Encodedfptmpimage = HttpUtility.UrlEncode(fptmpimage);
                   // Response.Write(Encodedfptmpimage);
                    //var hardCodedFptImage = "Rk1SACAyMAAAAAF0AAABLAGQAMUAxQEAAABROYBgABYUAEDMADKHAEC7ADwGAIBxAD0QAEDSAEv7AEAwAFIhAECaAFIGAEAwAGceAEB1AGydAEC1AG6AAECzAH2DAECLAIMKAIC5AIWEAEClAIwHAIB2AI4YAEB3AJWaAIBMAJkkAEC3AKcDAIDkAKh2AIChAK6JAEAyALCnAEAdALkoAEBWALshAEAnANssAEEJAN5pAEDlAOD0AECgAOybAIBKAP4wAICiAQMUAIC4AQsAAEAuARGzAEDmARdpAICrAR4RAIBPASCyAEAzASgzAECmATAVAEDSATBuAEDzATRnAEBmATcsAEBZATcwAECpAT8QAEDQAT9xAEDoAUHoAEDEAUOAAEB / AUaqAEDUAUbjAEDAAUjxAEBRAUm1AEBEAUszAEC6AU / qAIC0AVXZAEDSAVbUAEDHAV / KAECwAWa7AEDrAWfGAECoAW6xAEDLAXhDAAAA;
                    //Response.Write(fptmpimage);
                    //var afterEncoding = Server.UrlEncode(fptmpimage);
                    string SuccessFunc1 = "SuccessFunc1('" + fptmpimage + "')";
                    //string SuccessFunc1 = "SuccessFunc1('Rk1SACAyMAAAAAF6AAABLAGQAMUAxQEAAABHOkDBAA4KAEC3ABqKAEDhACH7AICqAC0JAIDCAC7/AEB+ADQVAECpAD6NAEBTAE2gAEBIAFIfAECHAFMUAEDfAFd4AEDFAFmAAEBdAFmoAIBlAFwkAIAoAHCoAEBJAHcoAEBoAIwkAEAiAJMlAEC6AJWKAIBXAJesAEC6AKMDAEBBAKusAEDRALTsAIBfALirAEBFALspAEA2AMAsAEDLAMd4AEBmAMomAEDSAMzjAIB0AM8lAEDUANVsAECGANyhAEBiAOosAEDBAO7gAEAtAO8oAEA5APCzAEC4APHdAIDYAPjRAIA0AP8mAEDKAQDAAEBoAQIoAEDJARM9AEAvASuUAEAfASwUAEBOAS4kAEBUAS+dAEDCATYlAEA9AUAYAIAdAUAJAEBVAUEeAICcAUUXAIBVAVURAEChAVkNAEBOAWAKAEBoAWARAECjAWKDAEA+AWr+AEBQAXuGAAAA')";
                    //string jsFunc = "helloWorld('Rk1SACAyMAAAAAF0AAABLAGQAMUAxQEAAABROYBgABYUAEDMADKHAEC7ADwGAIBxAD0QAEDSAEv7AEAwAFIhAECaAFIGAEAwAGceAEB1AGydAEC1AG6AAECzAH2DAECLAIMKAIC5AIWEAEClAIwHAIB2AI4YAEB3AJWaAIBMAJkkAEC3AKcDAIDkAKh2AIChAK6JAEAyALCnAEAdALkoAEBWALshAEAnANssAEEJAN5pAEDlAOD0AECgAOybAIBKAP4wAICiAQMUAIC4AQsAAEAuARGzAEDmARdpAICrAR4RAIBPASCyAEAzASgzAECmATAVAEDSATBuAEDzATRnAEBmATcsAEBZATcwAECpAT8QAEDQAT9xAEDoAUHoAEDEAUOAAEB / AUaqAEDUAUbjAEDAAUjxAEBRAUm1AEBEAUszAEC6AU / qAIC0AVXZAEDSAVbUAEDHAV / KAECwAWa7AEDrAWfGAECoAW6xAEDLAXhDAAAA')";

                    //TextBox1.Text = "<script type='text/javascript lang=javascript'>helloWorld(" + fptmpimage + ")</script>";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myJsFn", SuccessFunc1, true);

                } 
            }
            sqlConnection.Close();
        }
    }
}