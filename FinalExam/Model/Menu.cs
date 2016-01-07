using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shaoqi.Model
{

    /// <summary>
    /// Menu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Menu
    {
        public Menu()
        { }
        #region Model
        private string _id;
        private string _pid;
        private string _classname;
        private int? _classorder;
        private int _classtype;
        private int _isopen;
        private int? _issystem;
        private string _webtype;
        private string _outlinkurl;
        private string _classnameen;
        /// <summary>
        /// 
        /// </summary>
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pId
        {
            set { _pid = value; }
            get { return _pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string className
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? classOrder
        {
            set { _classorder = value; }
            get { return _classorder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ClassType
        {
            set { _classtype = value; }
            get { return _classtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isOpen
        {
            set { _isopen = value; }
            get { return _isopen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isSystem
        {
            set { _issystem = value; }
            get { return _issystem; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Webtype
        {
            set { _webtype = value; }
            get { return _webtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OutLinkURL
        {
            set { _outlinkurl = value; }
            get { return _outlinkurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string classNameEn
        {
            set { _classnameen = value; }
            get { return _classnameen; }
        }
        #endregion Model

    }
}
