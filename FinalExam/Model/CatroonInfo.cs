using System;
namespace shaoqi.Model
{
    /// <summary>
    /// CatroonInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CatroonInfo
    {
        public CatroonInfo()
        { }
        #region Model
        private int _id;
        private string _cartoonname;
        private string _cartoonintroduce;
        private string _cartoonimage;
        private int _categoriesid;
        private DateTime? _adddatetime;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartoonName
        {
            set { _cartoonname = value; }
            get { return _cartoonname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartoonIntroduce
        {
            set { _cartoonintroduce = value; }
            get { return _cartoonintroduce; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartoonImage
        {
            set { _cartoonimage = value; }
            get { return _cartoonimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CategoriesId
        {
            set { _categoriesid = value; }
            get { return _categoriesid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AddDateTime
        {
            set { _adddatetime = value; }
            get { return _adddatetime; }
        }
        #endregion Model
    }
}

