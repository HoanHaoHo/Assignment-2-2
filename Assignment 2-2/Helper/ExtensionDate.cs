using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_2.Helper
{
    public class ExtensionDate
    {
        static void Main(string[] args)
        {
            //Gives date of birth
            DateTime dob = new DateTime(1989, 10, 30, 23, 31, 00);

            //Gives current age
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (today < dob.AddYears(age)) age--;

            //age plus ten years
            age = age + 10;

            DateTime agePlusTen = dob.AddYears(age);

            Console.WriteLine(agePlusTen.ToShortDateString());

            Console.ReadLine();
        }
    }
    public static class MyDateTimeExtension
    {
        public static string GetDiffDate(this DateTime dtt)
        {
            int intYear, intMonth, intDay;
            DateTime td = DateTime.Now;
            int leapYear = 0;
            for (int i = dtt.Year; i < td.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++leapYear;
                }
            }
            TimeSpan timespan = td.Subtract(dtt);
            intDay = timespan.Days - leapYear;
            int intResult = 0;
            intYear = Math.DivRem(intDay, 365, out intResult);
            intMonth = Math.DivRem(intResult, 30, out intResult);
            intDay = intResult;
            string dateFormat = String.Format(intYear.ToString() + "/" + intMonth + "/" + intDay);
            return dateFormat;
        }
    }
}