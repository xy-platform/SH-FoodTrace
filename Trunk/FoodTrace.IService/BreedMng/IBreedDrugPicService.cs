﻿using FoodTrace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrace.IService
{
    /// <summary>
    /// 防疫图片信息
    /// </summary>
    public interface IBreedDrugPicService
    {
        /// <summary>
        /// 获取BreedDrugPic总条数
        /// </summary>
        /// <returns></returns>
        int GetBreedDrugPicCount();

        /// <summary>
        /// 获取BreedDrugPic总条数
        /// </summary>
        /// <returns></returns>
        int GetBreedDrugPicCount(string name);

        /// <summary>
        /// 获取当前用户所在公司的防疫图片信息（分页）
        /// </summary>
        /// <param name="name">查询条件：地块名称（模糊查询）</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页显示条数</param>
        /// <returns></returns>
        List<BreedDrugPicModel> GetPagerBreedDrugPic(string name, int pageIndex, int pageSize);

        /// <summary>
        /// 通过ID获取BreedDrugPic
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BreedDrugPicModel GetBreedDrugPicById(int id);

        /// <summary>
        /// 新增单条BreedDrugPic
        /// </summary>
        /// <param name="model">地块信息实体</param>
        /// <returns></returns>
        MessageModel InsertSingleBreedDrugPic(BreedDrugPicModel model);

        /// <summary>
        /// 编辑单条BreedDrugPic
        /// </summary>
        /// <param name="model">地块信息实体</param>
        /// <returns></returns>
        MessageModel UpdateSingleBreedDrugPic(BreedDrugPicModel model);

        /// <summary>
        /// 删除单条BreedDrugPic
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        MessageModel DeleteSingleEntity(int id);
    }
}

