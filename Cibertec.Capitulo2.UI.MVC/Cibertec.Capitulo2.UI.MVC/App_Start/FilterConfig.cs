﻿using System.Web;
using System.Web.Mvc;

namespace Cibertec.Capitulo2.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
