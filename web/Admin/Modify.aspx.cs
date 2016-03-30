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
    public partial class Modify : Page
    {       

     protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int adminID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(adminID);
				}
			}
		}
			
	private void ShowInfo(int adminID)
	{
		BLL.Admin bll=new BLL.Admin();
	     Model.Admin model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID.ToString();
		this.txtLoginID.Text=model.LoginID;
		this.txtLoginPWD.Text=model.LoginPWD;
		this.txtAdminName.Text=model.AdminName;

            if (model.sex)
            {
                sexm.Checked = true;
                sexf.Checked = false;
            }
            else
            {
                sexm.Checked =false;
                sexf.Checked =true;
            }

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtLoginID.Text.Trim().Length==0)
			{
				strErr+="LoginID不能为空！\\n";	
			}
			if(this.txtLoginPWD.Text.Trim().Length==0)
			{
				strErr+="LoginPWD不能为空！\\n";	
			}
			if(this.txtAdminName.Text.Trim().Length==0)
			{
				strErr+="AdminName不能为空！\\n";	
			}

			if(strErr!="")
			{
			 	MessageBox.Show(this,strErr);
				return;
			}
			int adminID=int.Parse(this.lbladminID.Text);
			string LoginID=this.txtLoginID.Text;
			string LoginPWD=this.txtLoginPWD.Text;
			string AdminName=this.txtAdminName.Text;

            bool sex = true;
            if (sexm.Checked) { sex = true; }
            if (sexf.Checked) { sex = false; }


            Model.Admin model=new Model.Admin();
			model.adminID=adminID;
			model.LoginID=LoginID;
			model.LoginPWD=LoginPWD;
			model.AdminName=AdminName;
			model.sex=sex;

            BLL.Admin bll = new BLL.Admin();
            bll.Update(model);
		    MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
