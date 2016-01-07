using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shaoqi.Model
{
    //Id, CartoonId, ComContent, UserId, AddTime
    [Serializable]
    public class CommentTwo
    {
        public CommentTwo()
        {
        }
        #region shuxing
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _cartoonName;

        public string CartoonName
        {
            get { return _cartoonName; }
            set { _cartoonName = value; }
        }

        private string _commentContext;

        public string CommentContext
        {
            get { return _commentContext; }
            set { _commentContext = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        private DateTime _addTime;

        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

        #endregion


    }



}
