﻿using FoodTrace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoodTrace.IDBAccess
{
    public interface IProductTypeAccess : IBaseAccess<ProductTypeModel>
    {
        int GetEntityCount(string name);

        List<ProductTypeModel> GetPagerProductTypeByConditions(string name, int pageIndex, int pageSize);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        MessageModel DeleteByIds(string ids);
    }
}
