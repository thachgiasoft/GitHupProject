using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references

namespace shaoqi.DAL
{
    // <summary>
    /// 数据访问类:Menu
    /// </summary>
    public partial class Menu
    {
        public Menu()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Menu");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(shaoqi.Model.Menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Menu(");
            strSql.Append("id,pId,className,classOrder,ClassType,isOpen,isSystem,Webtype,OutLinkURL,classNameEn)");
            strSql.Append(" values (");
            strSql.Append("@id,@pId,@className,@classOrder,@ClassType,@isOpen,@isSystem,@Webtype,@OutLinkURL,@classNameEn)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50),
					new SqlParameter("@pId", SqlDbType.VarChar,50),
					new SqlParameter("@className", SqlDbType.VarChar,200),
					new SqlParameter("@classOrder", SqlDbType.Int,4),
					new SqlParameter("@ClassType", SqlDbType.TinyInt,1),
					new SqlParameter("@isOpen", SqlDbType.TinyInt,1),
					new SqlParameter("@isSystem", SqlDbType.TinyInt,1),
					new SqlParameter("@Webtype", SqlDbType.VarChar,10),
					new SqlParameter("@OutLinkURL", SqlDbType.VarChar,200),
					new SqlParameter("@classNameEn", SqlDbType.VarChar,200)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.pId;
            parameters[2].Value = model.className;
            parameters[3].Value = model.classOrder;
            parameters[4].Value = model.ClassType;
            parameters[5].Value = model.isOpen;
            parameters[6].Value = model.isSystem;
            parameters[7].Value = model.Webtype;
            parameters[8].Value = model.OutLinkURL;
            parameters[9].Value = model.classNameEn;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(shaoqi.Model.Menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Menu set ");
            strSql.Append("pId=@pId,");
            strSql.Append("className=@className,");
            strSql.Append("classOrder=@classOrder,");
            strSql.Append("ClassType=@ClassType,");
            strSql.Append("isOpen=@isOpen,");
            strSql.Append("isSystem=@isSystem,");
            strSql.Append("Webtype=@Webtype,");
            strSql.Append("OutLinkURL=@OutLinkURL,");
            strSql.Append("classNameEn=@classNameEn");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pId", SqlDbType.VarChar,50),
					new SqlParameter("@className", SqlDbType.VarChar,200),
					new SqlParameter("@classOrder", SqlDbType.Int,4),
					new SqlParameter("@ClassType", SqlDbType.TinyInt,1),
					new SqlParameter("@isOpen", SqlDbType.TinyInt,1),
					new SqlParameter("@isSystem", SqlDbType.TinyInt,1),
					new SqlParameter("@Webtype", SqlDbType.VarChar,10),
					new SqlParameter("@OutLinkURL", SqlDbType.VarChar,200),
					new SqlParameter("@classNameEn", SqlDbType.VarChar,200),
					new SqlParameter("@id", SqlDbType.VarChar,50)};
            parameters[0].Value = model.pId;
            parameters[1].Value = model.className;
            parameters[2].Value = model.classOrder;
            parameters[3].Value = model.ClassType;
            parameters[4].Value = model.isOpen;
            parameters[5].Value = model.isSystem;
            parameters[6].Value = model.Webtype;
            parameters[7].Value = model.OutLinkURL;
            parameters[8].Value = model.classNameEn;
            parameters[9].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Menu ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Menu ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public shaoqi.Model.Menu GetModel(string id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,pId,className,classOrder,ClassType,isOpen,isSystem,Webtype,OutLinkURL,classNameEn from Menu ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
            parameters[0].Value = id;

            shaoqi.Model.Menu model = new shaoqi.Model.Menu();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public shaoqi.Model.Menu DataRowToModel(DataRow row)
        {
            shaoqi.Model.Menu model = new shaoqi.Model.Menu();
            if (row != null)
            {
                if (row["id"] != null)
                {
                    model.id = row["id"].ToString();
                }
                if (row["pId"] != null)
                {
                    model.pId = row["pId"].ToString();
                }
                if (row["className"] != null)
                {
                    model.className = row["className"].ToString();
                }
                if (row["classOrder"] != null && row["classOrder"].ToString() != "")
                {
                    model.classOrder = int.Parse(row["classOrder"].ToString());
                }
                if (row["ClassType"] != null && row["ClassType"].ToString() != "")
                {
                    model.ClassType = int.Parse(row["ClassType"].ToString());
                }
                if (row["isOpen"] != null && row["isOpen"].ToString() != "")
                {
                    model.isOpen = int.Parse(row["isOpen"].ToString());
                }
                if (row["isSystem"] != null && row["isSystem"].ToString() != "")
                {
                    model.isSystem = int.Parse(row["isSystem"].ToString());
                }
                if (row["Webtype"] != null)
                {
                    model.Webtype = row["Webtype"].ToString();
                }
                if (row["OutLinkURL"] != null)
                {
                    model.OutLinkURL = row["OutLinkURL"].ToString();
                }
                if (row["classNameEn"] != null)
                {
                    model.classNameEn = row["classNameEn"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,pId,className,classOrder,ClassType,isOpen,isSystem,Webtype,OutLinkURL,classNameEn ");
            strSql.Append(" FROM Menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,pId,className,classOrder,ClassType,isOpen,isSystem,Webtype,OutLinkURL,classNameEn ");
            strSql.Append(" FROM Menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from Menu T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Menu";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public int GetinfoCount(string sql)
        {
            return (int)DbHelperSQL.GetSingle(sql);
        }
        #endregion  ExtensionMethod
    }


}