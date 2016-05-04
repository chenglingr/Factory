using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web.Admin.ashx
{
    /// <summary>
    /// l1 的摘要说明
    /// </summary>
    public class list2 : IHttpHandler, System.Web.SessionState.IRequiresSessionState//session接口
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            int displayStart = int.Parse(context.Request["offset"]);
            int displayLength = int.Parse(context.Request["limit"]);

            BLL.Admin bll = new BLL.Admin();
                    DataSet ds = bll.GetListByPage("","", displayStart, displayStart+ displayLength);
                    ds.Tables[0].TableName = "Admin";
                    //返回列表
                    json = Web.DataConvertJson.DataTable2Json(ds.Tables[0]);
            //http://down.admin5.com/info/2015/1209/130229.html
            //??服务器端返回的数据中还要包括page（页数），total（数据总量）两个字段，前端要根据这两个字段分页。

            //if (action == "Del")//删除操作
            //{
            //    string DelNumS = context.Request.Form["DelNumS"];//获取批量删除的编号

            //    if (bll.DeleteList(DelNumS))
            //    {
            //        json = "{'info':'删除成功'}";
            //    }
            //    else
            //    { json = "{'info':'删除失败'}"; }
            //}
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