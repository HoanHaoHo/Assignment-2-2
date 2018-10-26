using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_2.Models
{
    public class ActionLogs
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public long ExecutionTimeInMs { get; set; }
    }
}