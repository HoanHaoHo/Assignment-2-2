using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment_2_2.Models.ActionFilter
{
    public class LogActionFilterAttribute : ActionFilterAttribute
    {
        private Stopwatch stopWatch = new Stopwatch();
        private ApplicationDbContext db = new ApplicationDbContext();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            stopWatch.Reset();
            stopWatch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stopWatch.Stop();
            var actionLog = new ActionLogs();
            actionLog.ExecutionTimeInMs = stopWatch.ElapsedMilliseconds;
            //actionLog.ControllerName = filterContext.RouteData.Values["controller"].ToString();
            actionLog.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            actionLog.ActionName = filterContext.ActionDescriptor.ActionName;

            db.ActionLog.Add(actionLog);
            db.SaveChanges();
        }
    }
}