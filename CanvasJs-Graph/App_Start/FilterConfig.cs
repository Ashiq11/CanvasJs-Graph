﻿using System.Web;
using System.Web.Mvc;

namespace CanvasJs_Graph
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
