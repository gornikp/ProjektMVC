﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WypasionaKsiegarniaMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static string theme { set; get; }
        protected void Application_Start()
        {
            theme = "bootstrap.min.css";
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["SiteVisitedCounter"] = 0;
            Application["OnlineUserCounter"] = 0;
        }

        //void Application_Start(object sender, EventArgs e)
        //{
        //    // Code that runs on application startup
        //    Application["SiteVisitedCounter"] = 0;
        //    //to check how many users have currently opened our site write the following line
        //    Application["OnlineUserCounter"] = 0;
        //}

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            Session["licz"] = 0;
            Application.Lock();
            Application["SiteVisitedCounter"] = Convert.ToInt32(Application["SiteVisitedCounter"]) + 1;
            Session["SiteVisitedCounter"] = Application["SiteVisitedCounter"];
            //to check how many users have currently opened our site write the following line
            Application["OnlineUserCounter"] = Convert.ToInt32(Application["OnlineUserCounter"]) + 1;
            Session["OnlineUserCounter"] = Application["OnlineUserCounter"];
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends.
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer
            // or SQLServer, the event is not raised.
            Application.Lock();
            Application["OnlineUserCounter"] = Convert.ToInt32(Application["OnlineUserCounter"]) - 1;
            Application.UnLock();
        }

    }
}
