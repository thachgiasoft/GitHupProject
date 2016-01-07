using System;
namespace shaoqi.Model
{
    /// <summary>
    /// Announce:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Announce
    {
        public Announce()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _anncontent;
        private int _adminid;
        private DateTime _addtime;
        private string _adminName;





        public string adminName
        {
            set { _adminName = value; }
            get { return _adminName; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AnnContent
        {
            set { _anncontent = value; }
            get { return _anncontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AdminId
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model

    }
}

