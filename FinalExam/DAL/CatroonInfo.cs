using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace shaoqi.DAL
{
    /// <summary>
    /// 数据访问类:CatroonInfo
    /// </summary>
    public partial class CatroonInfo
    {
        public CatroonInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CatroonInfo");
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
        public int Add(shaoqi.Model.CatroonInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CatroonInfo(");
            strSql.Append("CartoonName,CartoonIntroduce,CartoonImage,CategoriesId,AddDateTime)");
            strSql.Append(" values (");
            strSql.Append("@CartoonName,@CartoonIntroduce,@CartoonImage,@CategoriesId,@AddDateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CartoonName", SqlDbType.VarChar,50),
					new SqlParameter("@CartoonIntroduce", SqlDbType.VarChar,600),
					new SqlParameter("@CartoonImage", SqlDbType.VarChar,100),
					new SqlParameter("@CategoriesId", SqlDbType.Int,4),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.CartoonName;
            parameters[1].Value = model.CartoonIntroduce;
            parameters[2].Value = model.CartoonImage;
            parameters[3].Value = model.CategoriesId;
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
        public bool Update(shaoqi.Model.CatroonInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CatroonInfo set ");
            strSql.Append("CartoonName=@CartoonName,");
            strSql.Append("CartoonIntroduce=@CartoonIntroduce,");
            strSql.Append("CartoonImage=@CartoonImage,");
            strSql.Append("CategoriesId=@CategoriesId,");
            strSql.Append("AddDateTime=@AddDateTime");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@CartoonName", SqlDbType.VarChar,50),
					new SqlParameter("@CartoonIntroduce", SqlDbType.VarChar,600),
					new SqlParameter("@CartoonImage", SqlDbType.VarChar,100),
					new SqlParameter("@CategoriesId", SqlDbType.Int,4),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.CartoonName;
            parameters[1].Value = model.CartoonIntroduce;
            parameters[2].Value = model.CartoonImage;
            parameters[3].Value = model.CategoriesId;
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
            strSql.Append("delete from CatroonInfo ");
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
            strSql.Append("delete from CatroonInfo ");
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
        public shaoqi.Model.CatroonInfo GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CartoonName,CartoonIntroduce,CartoonImage,CategoriesId,AddDateTime from CatroonInfo ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            shaoqi.Model.CatroonInfo model = new shaoqi.Model.CatroonInfo();
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
        public shaoqi.Model.CatroonInfo DataRowToModel(DataRow row)
        {
            shaoqi.Model.CatroonInfo model = new shaoqi.Model.CatroonInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["CartoonName"] != null)
                {
                    model.CartoonName = row["CartoonName"].ToString();
                }
                if (row["CartoonIntroduce"] != null)
                {
                    model.CartoonIntroduce = row["CartoonIntroduce"].ToString();
                }
                if (row["CartoonImage"] != null)
                {
                    model.CartoonImage = row["CartoonImage"].ToString();
                }
                if (row["CategoriesId"] != null && row["CategoriesId"].ToString() != "")
                {
                    model.CategoriesId = int.Parse(row["CategoriesId"].ToString());
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
            strSql.Append("select Id,CartoonName,CartoonIntroduce,CartoonImage,CategoriesId,AddDateTime ");
            strSql.Append(" FROM CatroonInfo ");
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
            strSql.Append(" Id,CartoonName,CartoonIntroduce,CartoonImage,CategoriesId,AddDateTime ");
            strSql.Append(" FROM CatroonInfo ");
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
            strSql.Append("select count(1) FROM CatroonInfo ");
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
            strSql.Append(")AS Row, T.*  from CatroonInfo T ");
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
            parameters[0].Value = "CatroonInfo";
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

