using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_2.Helper
{
    public static class ExtensionDate
    {
        public static int ToAge(this DateTime date)
        {
            var currentAge = DateTime.Now - date;
            return currentAge.Days;
        }
    }
   
}