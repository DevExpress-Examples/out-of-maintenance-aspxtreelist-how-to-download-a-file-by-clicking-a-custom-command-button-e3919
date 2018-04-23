using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoadFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		string fileName = "Images/" + Request.Params[0] + ".jpg";
		string filePath = Server.MapPath(fileName);

		Response.AddHeader("Content-Disposition", "attachment; filename=" + Request.Params[0] + ".jpg");
		Response.ContentType = "image/x-jpg";
		Response.TransmitFile(filePath);
		Response.End();
    }
}