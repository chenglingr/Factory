using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Admin.ashx
{
    /// <summary>
    /// ADD 的摘要说明
    /// </summary>
    public class ADD : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json"; //指定返回数据格式为json

            string json = "[{'user_id':'123'}]";
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