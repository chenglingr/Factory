﻿/**  版本信息模板在安装目录下，可自行修改。
* Admin.cs
*
* 功 能： N/A
* 类 名： Admin
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/3/1 16:02:52   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
namespace IDAL
{
	/// <summary>
	/// 接口层Admin
	/// </summary>
	public interface IAdmin
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Model.Admin model);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">登录名</param>
        /// <param name="pwd">密码</param>
        /// <returns>返回用户编号。没有此用户返回-1</returns>
        int Login(string name,string pwd);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Model.Admin model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int adminID);
		bool DeleteList(string adminIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Model.Admin GetModel(int adminID);
		Model.Admin DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
        /// <summary>
        /// 获取最新几个用户
        /// </summary>
        /// <param name="top">前top个</param>
        /// <returns></returns>
        DataSet GetList(int top);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
