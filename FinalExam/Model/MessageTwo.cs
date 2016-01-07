using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shaoqi.Model
{
    public class MessageTwo
    {
        public MessageTwo()
        {

        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _msgcontext;

        public string MsgContext
        {
            get { return _msgcontext; }
            set { _msgcontext = value; }
        }


        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        private DateTime _addTime;

        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

    }
}
