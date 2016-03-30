/**  版本信息模板在安装目录下，可自行修改。
* student.cs
*
* 功 能： N/A
* 类 名： student
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/3/1 16:02:53   N/A    初版
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
	/// 数据访问类:student
	/// </summary>
	public partial class student:Istudent
	{
		public student()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.student model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.stuLoginName != null)
			{
				strSql1.Append("stuLoginName,");
				strSql2.Append("'"+model.stuLoginName+"',");
			}
			if (model.stuLoginPWD != null)
			{
				strSql1.Append("stuLoginPWD,");
				strSql2.Append("'"+model.stuLoginPWD+"',");
			}
			if (model.stuState != null)
			{
				strSql1.Append("stuState,");
				strSql2.Append(""+(model.stuState? 1 : 0) +",");
			}
			if (model.stuRealName != null)
			{
				strSql1.Append("stuRealName,");
				strSql2.Append("'"+model.stuRealName+"',");
			}
			if (model.stuNo != null)
			{
				strSql1.Append("stuNo,");
				strSql2.Append("'"+model.stuNo+"',");
			}
			if (model.stuSex != null)
			{
				strSql1.Append("stuSex,");
				strSql2.Append(""+(model.stuSex? 1 : 0) +",");
			}
			if (model.gradeID != null)
			{
				strSql1.Append("gradeID,");
				strSql2.Append(""+model.gradeID+",");
			}
			if (model.classID != null)
			{
				strSql1.Append("classID,");
				strSql2.Append(""+model.classID+",");
			}
			strSql.Append("insert into student(");
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
		public bool Update(Model.student model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update student set ");
			if (model.stuLoginName != null)
			{
				strSql.Append("stuLoginName='"+model.stuLoginName+"',");
			}
			else
			{
				strSql.Append("stuLoginName= null ,");
			}
			if (model.stuLoginPWD != null)
			{
				strSql.Append("stuLoginPWD='"+model.stuLoginPWD+"',");
			}
			else
			{
				strSql.Append("stuLoginPWD= null ,");
			}
			if (model.stuState != null)
			{
				strSql.Append("stuState="+ (model.stuState? 1 : 0) +",");
			}
			else
			{
				strSql.Append("stuState= null ,");
			}
			if (model.stuRealName != null)
			{
				strSql.Append("stuRealName='"+model.stuRealName+"',");
			}
			else
			{
				strSql.Append("stuRealName= null ,");
			}
			if (model.stuNo != null)
			{
				strSql.Append("stuNo='"+model.stuNo+"',");
			}
			else
			{
				strSql.Append("stuNo= null ,");
			}
			if (model.stuSex != null)
			{
				strSql.Append("stuSex="+ (model.stuSex? 1 : 0) +",");
			}
			else
			{
				strSql.Append("stuSex= null ,");
			}
			if (model.gradeID != null)
			{
				strSql.Append("gradeID="+model.gradeID+",");
			}
			else
			{
				strSql.Append("gradeID= null ,");
			}
			if (model.classID != null)
			{
				strSql.Append("classID="+model.classID+",");
			}
			else
			{
				strSql.Append("classID= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where stuID="+ model.stuID+"");
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
		public bool Delete(int stuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from student ");
			strSql.Append(" where stuID="+stuID+"" );
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
		public bool DeleteList(string stuIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from student ");
			strSql.Append(" where stuID in ("+stuIDlist + ")  ");
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
		public Model.student GetModel(int stuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" stuID,stuLoginName,stuLoginPWD,stuState,stuRealName,stuNo,stuSex,gradeID,classID ");
			strSql.Append(" from student ");
			strSql.Append(" where stuID="+stuID+"" );
			Model.student model=new Model.student();
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
		public Model.student DataRowToModel(DataRow row)
		{
			Model.student model=new Model.student();
			if (row != null)
			{
				if(row["stuID"]!=null && row["stuID"].ToString()!="")
				{
					model.stuID=int.Parse(row["stuID"].ToString());
				}
				if(row["stuLoginName"]!=null)
				{
					model.stuLoginName=row["stuLoginName"].ToString();
				}
				if(row["stuLoginPWD"]!=null)
				{
					model.stuLoginPWD=row["stuLoginPWD"].ToString();
				}
				if(row["stuState"]!=null && row["stuState"].ToString()!="")
				{
					if((row["stuState"].ToString()=="1")||(row["stuState"].ToString().ToLower()=="true"))
					{
						model.stuState=true;
					}
					else
					{
						model.stuState=false;
					}
				}
				if(row["stuRealName"]!=null)
				{
					model.stuRealName=row["stuRealName"].ToString();
				}
				if(row["stuNo"]!=null)
				{
					model.stuNo=row["stuNo"].ToString();
				}
				if(row["stuSex"]!=null && row["stuSex"].ToString()!="")
				{
					if((row["stuSex"].ToString()=="1")||(row["stuSex"].ToString().ToLower()=="true"))
					{
						model.stuSex=true;
					}
					else
					{
						model.stuSex=false;
					}
				}
				if(row["gradeID"]!=null && row["gradeID"].ToString()!="")
				{
					model.gradeID=int.Parse(row["gradeID"].ToString());
				}
				if(row["classID"]!=null && row["classID"].ToString()!="")
				{
					model.classID=int.Parse(row["classID"].ToString());
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
			strSql.Append("select stuID,stuLoginName,stuLoginPWD,stuState,stuRealName,stuNo,stuSex,gradeID,classID ");
			strSql.Append(" FROM student ");
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
			strSql.Append(" stuID,stuLoginName,stuLoginPWD,stuState,stuRealName,stuNo,stuSex,gradeID,classID ");
			strSql.Append(" FROM student ");
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
			strSql.Append("select count(1) FROM student ");
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
				strSql.Append("order by T.stuID desc");
			}
			strSql.Append(")AS Row, T.*  from student T ");
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

