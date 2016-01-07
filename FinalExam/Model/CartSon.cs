using System;
namespace shaoqi.Model
{
    /// <summary>
    /// CartSon:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CartSon
    {
        public CartSon()
        { }
        #region Model
        private int _id;
        private string _cartoonsonname;
        private int _cartnum;
        private string _cartoonsoniamge;
        private int _cartid;
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
        public string CartoonSonName
        {
            set { _cartoonsonname = value; }
            get { return _cartoonsonname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CartNum
        {
            set { _cartnum = value; }
            get { return _cartnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartoonSonIamge
        {
            set { _cartoonsoniamge = value; }
            get { return _cartoonsoniamge; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CartId
        {
            set { _cartid = value; }
            get { return _cartid; }
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

