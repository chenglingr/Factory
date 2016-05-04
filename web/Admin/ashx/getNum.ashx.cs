using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Admin.ashx
{
    /// <summary>
    /// Summary description for getNum
    /// </summary>
    public class getNum : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string json = "{'info':'0'}";

            BLL.Admin bll = new BLL.Admin();
            int n = bll.GetRecordCount("");
            json = "{'info':'" + n + "'}";
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