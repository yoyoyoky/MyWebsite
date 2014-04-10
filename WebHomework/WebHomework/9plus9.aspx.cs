using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHomework
{
    public partial class _9plus9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    s += (i + "×" + j +"="+ i*j+"\t");
                }
                s += "<br>";
            }
            Label1.Text = s;
        }
    }
}