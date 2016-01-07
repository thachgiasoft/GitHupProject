using System;
namespace shaoqi.Model
{
	/// <summary>
	/// Comment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Comment
	{
		public Comment()
		{}
		#region Model
		private int _id;
		private Model.CatroonInfo _cartoonid=new CatroonInfo();
		private string _comcontent;
		private Model.User _userid=new User();
		private DateTime _addtime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Model.CatroonInfo CartoonId
		{
			set{ _cartoonid=value;}
			get{return _cartoonid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComContent
		{
			set{ _comcontent=value;}
			get{return _comcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Model.User UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

