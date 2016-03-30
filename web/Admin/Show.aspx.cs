using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using BLL;
using Model;
namespace Web
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int adminID=(Convert.ToInt32(strid));
					ShowInfo(adminID);
				}
			}
		}
		
	private void ShowInfo(int adminID)
	{
        BLL.Admin bll = new BLL.Admin();
        Model.Admin model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID.ToString();
		this.lblLoginID.Text=model.LoginID;
		this.lblLoginPWD.Text=model.LoginPWD;
		this.lblAdminName.Text=model.AdminName;
		this.lblsex.Text=model.sex?"男":"女";

	}


    }
}
