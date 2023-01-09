using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Utils
{
    public static class DateUtil
    {
        public static string MiladiToJalai(DateTime date)
        {
            var pc = new PersianCalendar(); //using System.Globalization;
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);
            var result = "";

            // 1401/10/19
            //String Concat - badtarin performance
            result = year + "/" + month + "/" + day;

            //String Format - performance motevasat
            result = String.Format("{0}/{1}/{2}", year, month, day);

            //String Interpolation - performance motevasat
            result = $"{year}/{month}/{day}";


            //String builder - behtarin performance
            var sb = new StringBuilder();
            sb.Append(year);
            sb.Append("/");
            sb.Append(month);
            sb.Append("/");
            sb.Append(day);
            result = sb.ToString();


            return result;
        }


        public static string GetJalaliMonthName_switch(DateTime date)
        {
            /*
             * "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
             */
            var pc = new PersianCalendar();
            var month = pc.GetMonth(date); // 1-12

            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
            }


            return "دی";
        }
    }
}
