﻿//-----------------------------------------------------------------------
// <copyright file="SeleniumEntity.cs" company="Personage Enterprises">
// * Copyright (C) 2018 qinchaoyue 版权所有。
// * version : 1.0
// * author  : qinchaoyue
// * FileName: SeleniumEntity.cs
// * history : created by qinchaoyue 2018-05-28 04:08:13
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace hotPot.Selenium.Net45.Entity
{
    public class SeleniumEntity
    {
        public string DebugKey { get; set; }

        /// <summary>
        /// 执行顺序
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 执行动作
        /// </summary>
        public ActionType ActionType { get; set; }

        public int MillisecondsTimeout { get; set; }

        /// <summary>
        /// url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// By
        /// </summary>
        public By By { get; set; }

        /// <summary>
        /// Keys
        /// </summary>
        public string Keys { get; set; }

        /// <summary>
        /// 是否 Find 子元素
        /// </summary>
        public bool IsChild { get; set; } = false;

        /// <summary>
        /// 图片保存路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 表达式
        /// </summary>
        public Expression<Func<IWebElement, bool>> Expression { get; set; }

        public int Height { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
    }
}
