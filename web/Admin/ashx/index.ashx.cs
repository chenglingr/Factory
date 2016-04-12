using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web.Admin.ashx
{
    /// <summary>
    /// l2 的摘要说明
    /// </summary>
    public class index : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            if (action == "Show")
            {

                if (context.Session["ID"] == null)
                {
                    json = "{}";
                }
                else
                {
                    BLL.Admin bll = new BLL.Admin();
                    DataSet ds = bll.GetList("");//获取所有的用户
                    ds.Tables[0].TableName = "Admin";//修改数据表的名字

                    DataSet dstop5 = bll.GetList(5);//获取前5个用户

                    DataTable top5 = dstop5.Tables[0].Copy();
                    top5.TableName = "top5"; //改名
                    ds.Tables.Add(top5);//把前5个用户的数据表，加到数据集ds中

                    //返回列表
                    json = Web.DataConvertJson.Dataset2Json(ds);//转换

                }
            }

            context.Response.Write(json);
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}