/**  版本信息模板在安装目录下，可自行修改。
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
using System.Text;
using System.Data.SqlClient;
using IDAL;

namespace SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Admin
	/// </summary>
	public partial class Admin:IAdmin
	{
		public Admin()
		{  }
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.LoginID != null)
			{ 
				strSql1.Append("LoginID,");
				strSql2.Append("'"+model.LoginID+"',");
			}
			if (model.LoginPWD != null)
			{
				strSql1.Append("LoginPWD,");
				strSql2.Append("'"+model.LoginPWD+"',");
			}
			if (model.AdminName != null)
			{
				strSql1.Append("AdminName,");
				strSql2.Append("'"+model.AdminName+"',");
			}
			if (model.sex != null)
			{
				strSql1.Append("sex,");
				strSql2.Append(""+(model.sex? 1 : 0) +",");
			}
			strSql.Append("insert into Admin(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			strSql.Append(";select @@IDENTITY");
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Admin set ");
			if (model.LoginID != null)
			{
				strSql.Append("LoginID='"+model.LoginID+"',");
			}
			else
			{
				strSql.Append("LoginID= null ,");
			}
			if (model.LoginPWD != null)
			{
				strSql.Append("LoginPWD='"+model.LoginPWD+"',");
			}
			else
			{
				strSql.Append("LoginPWD= null ,");
			}
			if (model.AdminName != null)
			{
				strSql.Append("AdminName='"+model.AdminName+"',");
			}
			else
			{
				strSql.Append("AdminName= null ,");
			}
			if (model.sex != null)
			{
				strSql.Append("sex="+ (model.sex? 1 : 0) +",");
			}
			else
			{
				strSql.Append("sex= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where adminID="+ model.adminID+"");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int adminID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Admin ");
			strSql.Append(" where adminID="+adminID+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string adminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Admin ");
			strSql.Append(" where adminID in ("+adminIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Admin GetModel(int adminID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" adminID,LoginID,LoginPWD,AdminName,sex ");
			strSql.Append(" from Admin ");
			strSql.Append(" where adminID="+adminID+"" );
			Model.Admin model=new Model.Admin();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Admin DataRowToModel(DataRow row)
		{
			Model.Admin model=new Model.Admin();
			if (row != null)
			{
				if(row["adminID"]!=null && row["adminID"].ToString()!="")
				{
					model.adminID=int.Parse(row["adminID"].ToString());
				}
				if(row["LoginID"]!=null)
				{
					model.LoginID=row["LoginID"].ToString();
				}
				if(row["LoginPWD"]!=null)
				{
					model.LoginPWD=row["LoginPWD"].ToString();
				}
				if(row["AdminName"]!=null)
				{
					model.AdminName=row["AdminName"].ToString();
				}
				if(row["sex"]!=null && row["sex"].ToString()!="")
				{
					if((row["sex"].ToString()=="1")||(row["sex"].ToString().ToLower()=="true"))
					{
						model.sex=true;
					}
					else
					{
						model.sex=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select adminID,LoginID,LoginPWD,AdminName,sex ");
			strSql.Append(" FROM Admin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" adminID,LoginID,LoginPWD,AdminName,sex ");
			strSql.Append(" FROM Admin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Admin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.adminID desc");
			}
			strSql.Append(")AS Row, T.*  from Admin T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

