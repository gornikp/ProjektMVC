using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            //string UrlId = Request.Url.ToString();
            //if (requestContext.HttpContext.Session["URLHistory"] != null)
            //{
            //    //The session variable exists. So the user has already visited this site and sessions is still alive. Check if this page is already visited by the user
            //    List<string> HistoryURLs = (List<string>)requestContext.HttpContext.Session["URLHistory"];
            //    if (HistoryURLs.Exists((element => element == UrlId)))
            //    {
            //        //If the user has already visited this page in this session, then we can ignore this visit. No need to update the counter.
            //        requestContext.HttpContext.Session["VisitedURL"] = 0;
            //    }
            //    else
            //    {
            //        //if the user is visting this page for the first time in this session, then count this visit and also add this page to the list of visited pages(URLHistory variable)
            //        HistoryURLs.Add(UrlId);
            //        requestContext.HttpContext.Session["URLHistory"] = HistoryURLs;

            //        //Make a note of the page Id to update the database later 
            //        requestContext.HttpContext.Session["VisitedURL"] = UrlId;
            //    }
            //}
            //else
            //{
            //    //if there is no session variable already created, then the user is visiting this page for the first time in this session. Then create a session variable and take the count of the page Id
            //    List<string> HistoryURLs = new List<string>();
            //    HistoryURLs.Add(UrlId);
            //    requestContext.HttpContext.Session["URLHistory"] = HistoryURLs;
            //    requestContext.HttpContext.Session["VisitedURL"] = UrlId;
            //}
            //base.Initialize(requestContext);
        }
    }
}
