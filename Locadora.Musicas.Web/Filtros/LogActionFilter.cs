﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora.Musicas.Web.Filtros
{
    public class LogActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //[data/hora] finalizou : [controller]/[action]
           string mensagem = string.Format("[{0}] Finalizou : {1}/{2}",
            DateTime.Now.ToString(),
            filterContext.RouteData.Values["Controller"].ToString(),
            filterContext.RouteData.Values["Action"].ToString()
            );
            Debug.WriteLine(mensagem);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //[data/hora] finalizou : [controller]/[action]
            string mensagem = string.Format("[{0}] Inicio : {1}/{2}",
             DateTime.Now.ToString(),
             filterContext.RouteData.Values["Controller"].ToString(),
             filterContext.RouteData.Values["Action"].ToString()
             );
            Debug.WriteLine(mensagem);
        }
    }
}