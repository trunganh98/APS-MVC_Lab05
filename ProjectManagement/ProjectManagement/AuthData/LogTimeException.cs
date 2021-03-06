﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjectManagement.AuthData
{
    public class LogTimeException : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"] +
                " & " + filterContext.RouteData.Values["action"] +
                @" = OnResultExecuting " + DateTime.Now.ToString("F") + Environment.NewLine;
            Log(message);
        }

        private void Log(string message)
        {
            //string path = Path.GetFullPath("~/Content/Data.txt").Replace("~\\", "");
            string path = Path.GetFullPath(@"D:/SEM3/W/ProjectManagement/ProjectManagement/Content/Data.txt");

            File.AppendAllText(path, message);
        }
    }
}
