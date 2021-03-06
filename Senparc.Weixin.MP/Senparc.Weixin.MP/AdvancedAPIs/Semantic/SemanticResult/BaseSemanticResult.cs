﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs
{
    public class BaseSemanticResultJson : WxJsonResult
    {
        /// <summary>
        /// 用于标识用户请求后的状态
        /// </summary>
        public int res { get; set; }
        /// <summary>
        /// 用户的输入字符串
        /// </summary>
        public string query { get; set; }
        /// <summary>
        /// 服务的全局类别id
        /// </summary>
        public string type { get; set; }
    }

    //public class BaseSemantic
    //{
    //    /// <summary>
    //    /// SEARCH 普通查询
    //    /// ROUTE 路线查询
    //    /// </summary>
    //    public string intent { get; set; }
    //}
}
