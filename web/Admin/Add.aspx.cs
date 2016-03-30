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
using Model;
using BLL;
namespace Web
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        protected void btnSave_Click(object sender, EventArgs e)
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
			
				return;
			}
			string LoginID=this.txtLoginID.Text;
			string LoginPWD=this.txtLoginPWD.Text;
			string AdminName=this.txtAdminName.Text;
			bool sex=true;
            if (sexm.Checked) { sex = true; }
            if (sexf.Checked) { sex = false; }

			Model.Admin model=new Model.Admin();
			model.LoginID=LoginID;
			model.LoginPWD=LoginPWD;
			model.AdminName=AdminName;
			model.sex=sex;

		    BLL.Admin bll=new BLL.Admin();
			bll.Add(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
