/**  版本信息模板在安装目录下，可自行修改。
* Grade.cs
*
* 功 能： N/A
* 类 名： Grade
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
namespace Model
{
	/// <summary>
	/// Grade:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Grade
	{
		public Grade()
		{}
		#region Model
		private int _gradeid;
		private string _gradename;
		/// <summary>
		/// 
		/// </summary>
		public int GradeID
		{
			set{ _gradeid=value;}
			get{return _gradeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GradeName
		{
			set{ _gradename=value;}
			get{return _gradename;}
		}
		#endregion Model

	}
}

