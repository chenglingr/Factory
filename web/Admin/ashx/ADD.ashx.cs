﻿using System;
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
            context.Response.ContentType = "text/plain"; 

            string json = "{'info':'增加数据失败'}";

            //获取GET方法传递参数：Request.QueryString["参数名称"];
            //获取POST方法传递参数：Request.Form["参数名称"];
            string txtUserName =context.Request.Form["UserName"]; //保存文本框对象，提高效率
            string txtPassWord = context.Request.Form["PassWord"];
            string txtRealName = context.Request.Form["RealName"];
            string adminSex = context.Request.Form["adminSex"];


            Model.Admin model = new Model.Admin();
            model.LoginID = txtUserName;
            model.LoginPWD = txtPassWord;
            model.AdminName = txtRealName;
            model.sex = false;
            if (adminSex == "true") { model.sex = true; }

            BLL.Admin bll = new BLL.Admin();
            int n= bll.Add(model);
            //返回单个文字信息
            if (n > 0) { json = "{'info':'增加数据成功,编号是："+n+"'}"; }
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