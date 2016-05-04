
using System;
using System.Data;
namespace IDAL
{
	/// <summary>
	/// 接口层student
	/// </summary>
	public interface Istudent
	{
        DataSet GetNameNoList(int top);
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Model.student model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Model.student model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int stuID);
		bool DeleteList(string stuIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Model.student GetModel(int stuID);
		Model.student DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
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
