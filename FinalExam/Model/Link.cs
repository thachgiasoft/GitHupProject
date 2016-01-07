using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shaoqi.Model
{
    /// <summary>
    /// Link:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Link
    {
        public Link()
        { }
        #region Model
        private int _id;
        private string _linktile;
        private string _url;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string linkTile
        {
            set { _linktile = value; }
            get { return _linktile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string uRl
        {
            set { _url = value; }
            get { return _url; }
        }
        #endregion Model
    }
}
