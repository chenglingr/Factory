
using System;
namespace Model
{
	/// <summary>
	/// student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class student
	{
		public student()
		{}
		#region Model
		private int _stuid;
		private string _stuloginname;
		private string _stuloginpwd;
		private bool _stustate;
		private string _sturealname;
		private string _stuno;
		private bool _stusex;
		private int  _gradeid;
		private int  _classid;
		/// <summary>
		/// 
		/// </summary>
		public int stuID
		{
			set{ _stuid=value;}
			get{return _stuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuLoginName
		{
			set{ _stuloginname=value;}
			get{return _stuloginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuLoginPWD
		{
			set{ _stuloginpwd=value;}
			get{return _stuloginpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool stuState
		{
			set{ _stustate=value;}
			get{return _stustate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuRealName
		{
			set{ _sturealname=value;}
			get{return _sturealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuNo
		{
			set{ _stuno=value;}
			get{return _stuno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool stuSex
		{
			set{ _stusex=value;}
			get{return _stusex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int  gradeID
		{
			set{ _gradeid=value;}
			get{return _gradeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int  classID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		#endregion Model

	}
}

