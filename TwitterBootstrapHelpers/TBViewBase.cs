﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers
{
    /// <summary>
    /// Twitter Bootstrap View Base Class
    /// </summary>
    /// <typeparam name="TModel">View Model Type</typeparam>
    public abstract class TBViewBase<TModel> : WebViewPage<TModel>
    {
        /// <summary>
        /// Twitter Bootstrap Html Helper
        /// </summary>
        public TBHelper<TModel> TB { get; private set; }

        public override void InitHelpers()
        {
            base.InitHelpers();

            TB = new TBHelper<TModel>(this.ViewContext, this);
        }
    }

    /// <summary>
    /// Twitter Bootstrap View Base Class
    /// </summary>
    public abstract class TBViewBase : WebViewPage
    {
        /// <summary>
        /// Twitter Bootstrap Html Helper
        /// </summary>
        public TBHelper TB { get; private set; }

        public override void InitHelpers()
        {
            base.InitHelpers();

            TB = new TBHelper(this.ViewContext, this);
        }
    }
}
