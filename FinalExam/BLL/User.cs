﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using shaoqi.Model;
namespace shaoqi.BLL
{
    /// <summary>
    /// User
    /// </summary>
    public partial class User
    {
        private readonly shaoqi.DAL.User dal = new shaoqi.DAL.User();
        public User()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(shaoqi.Model.User model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(shaoqi.Model.User model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public shaoqi.Model.User GetModel(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public shaoqi.Model.User GetModelByCache()
        {
            //该表无主键信息，请自定义主键/条件字段
            string CacheKey = "UserModel-";
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(2);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (shaoqi.Model.User)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<shaoqi.Model.User> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<shaoqi.Model.User> DataTableToList(DataTable dt)
        {
            List<shaoqi.Model.User> modelList = new List<shaoqi.Model.User>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                shaoqi.Model.User model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public shaoqi.Model.User GetmodleByName(string name)
        {
            return dal.GetmodleByName(name);
        }
        public int GetinfoCount(string sql)
        {
            return dal.GetinfoCount(sql);
        }

        public string GetName(string sql)
        {
            return dal.GetName(sql);
        }
        #endregion  ExtensionMethod
    }
}

