﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace RandomPlaceFQ.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                    .Include("~/Content/Site.css")  /* не перепутайте порядок */
                    .Include("~/Content/bootstrap*"));
        }
    }
}