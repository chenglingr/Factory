﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace web.Admin.ashx
{
    /// <summary>
    /// LIST 的摘要说明
    /// </summary>
    public class LIST : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "";
            string action = context.Request.Form["Action"];

            if (action == "Show")
            {

                if (context.Session["ID"] == null)
                {
                   json="{}";
                }
                else
                {
                    BLL.Admin bll = new BLL.Admin();
                    DataSet ds = bll.GetList(10);
                    ds.Tables[0].TableName = "Admin";
                    //返回列表
                     json = Web.DataConvertJson.DataTable2Json(ds.Tables[0]);
                                 
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