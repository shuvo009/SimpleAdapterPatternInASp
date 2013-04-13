using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleAdapterPatternInASp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = new GetDataAdapter().GetMyDataUsingAdapter(new GetingDataFromTxtConnector(), Server.MapPath(@"~/Resources/MyTextFile.txt"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = new GetDataAdapter().GetMyDataUsingAdapter(new GetDataFromXAMLConnector(), Server.MapPath(@"~/Resources/MyXmlFile.xml"));
        }
    }
}