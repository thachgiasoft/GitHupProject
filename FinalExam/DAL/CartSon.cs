using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace shaoqi.DAL
{
    /// <summary>
    /// 数据访问类:CartSon
    /// </summary>
    public partial class CartSon
    {
        public CartSon()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CartSon");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(shaoqi.Model.CartSon model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CartSon(");
            strSql.Append("CartoonSonName,CartNum,CartoonSonIamge,CartId,AddDateTime)");
            strSql.Append(" values (");
            strSql.Append("@CartoonSonName,@CartNum,@CartoonSonIamge,@CartId,@AddDateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CartoonSonName", SqlDbType.VarChar,50),
					new SqlParameter("@CartNum", SqlDbType.Int,4),
					new SqlParameter("@CartoonSonIamge", SqlDbType.VarChar,100),
					new SqlParameter("@CartId", SqlDbType.Int,4),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.CartoonSonName;
            parameters[1].Value = model.CartNum;
            parameters[2].Value = model.CartoonSonIamge;
            parameters[3].Value = model.CartId;
            parameters[4].Value = model.AddDateTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(shaoqi.Model.CartSon model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CartSon set ");
            strSql.Append("CartoonSonName=@CartoonSonName,");
            strSql.Append("CartNum=@CartNum,");
            strSql.Append("CartoonSonIamge=@CartoonSonIamge,");
            strSql.Append("CartId=@CartId,");
            strSql.Append("AddDateTime=@AddDateTime");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@CartoonSonName", SqlDbType.VarChar,50),
					new SqlParameter("@CartNum", SqlDbType.Int,4),
					new SqlParameter("@CartoonSonIamge", SqlDbType.VarChar,100),
					new SqlParameter("@CartId", SqlDbType.Int,4),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.CartoonSonName;
            parameters[1].Value = model.CartNum;
            parameters[2].Value = model.CartoonSonIamge;
            parameters[3].Value = model.CartId;
            parameters[4].Value = model.AddDateTime;
            parameters[5].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CartSon ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CartSon ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public shaoqi.Model.CartSon GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CartoonSonName,CartNum,CartoonSonIamge,CartId,AddDateTime from CartSon ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            shaoqi.Model.CartSon model = new shaoqi.Model.CartSon();
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
        public shaoqi.Model.CartSon DataRowToModel(DataRow row)
        {
            shaoqi.Model.CartSon model = new shaoqi.Model.CartSon();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["CartoonSonName"] != null)
                {
                    model.CartoonSonName = row["CartoonSonName"].ToString();
                }
                if (row["CartNum"] != null && row["CartNum"].ToString() != "")
                {
                    model.CartNum = int.Parse(row["CartNum"].ToString());
                }
                if (row["CartoonSonIamge"] != null)
                {
                    model.CartoonSonIamge = row["CartoonSonIamge"].ToString();
                }
                if (row["CartId"] != null && row["CartId"].ToString() != "")
                {
                    model.CartId = int.Parse(row["CartId"].ToString());
                }
                if (row["AddDateTime"] != null && row["AddDateTime"].ToString() != "")
                {
                    model.AddDateTime = DateTime.Parse(row["AddDateTime"].ToString());
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
            strSql.Append("select Id,CartoonSonName,CartNum,CartoonSonIamge,CartId,AddDateTime ");
            strSql.Append(" FROM CartSon ");
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
            strSql.Append(" Id,CartoonSonName,CartNum,CartoonSonIamge,CartId,AddDateTime ");
            strSql.Append(" FROM CartSon ");
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
            strSql.Append("select count(1) FROM CartSon ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from CartSon T ");
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
            parameters[0].Value = "CartSon";
            parameters[1].Value = "Id";
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

