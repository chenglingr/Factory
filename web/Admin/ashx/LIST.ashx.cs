using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace web.Admin.ashx
{
    /// <summary>
    /// LIST 的摘要说明
    /// </summary>
    public class LIST : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
          
            BLL.Admin bll = new BLL.Admin();
            DataSet ds= bll.GetList("");
            ds.Tables[0].TableName = "Admin";
            //返回列表
            string json=   Web.DataConvertJson.DataTable2Json (ds.Tables[0]);
            DataSet ds1 = new DataSet();

         
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