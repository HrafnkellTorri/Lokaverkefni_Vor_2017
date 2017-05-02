using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    class Adferdir
    {
        public string FindDate (int day, string month, int year)
        {
            string date = "";
            int monthnumber = 0;

            if (month == "January")
            {
                monthnumber = 1;
            }
            else if (month == "February")
            {
                monthnumber = 2;
            }
            else if (month == "March")
            {
                monthnumber = 3;
            }
            else if (month == "April")
            {
                monthnumber = 4;
            }
            else if (month == "May")
            {
                monthnumber = 5;
            }
            else if (month == "June")
            {
                monthnumber = 6;
            }
            else if (month == "July")
            {
                monthnumber = 7;
            }
            else if (month == "August")
            {
                monthnumber = 8;
            }
            else if (month == "September")
            {
                monthnumber = 9;
            }
            else if (month == "October")
            {
                monthnumber = 10;
            }
            else if (month == "November")
            {
                monthnumber = 11;
            }
            else if (month == "December")
            {
                monthnumber = 12;
            }

            date = year + "-" + monthnumber + "-" + day;

            return date;
        }
    }
}
