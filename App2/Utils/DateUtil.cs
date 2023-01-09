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
        public static string MiladiToJalai(DateTime date, string separator = "/")
        {
            var pc = new PersianCalendar(); //using System.Globalization;
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);
            var result = "";

            // 1401/10/19
            //String Concat - badtarin performance
            //result = year + "/" + month + "/" + day;
            result = year + separator + month + separator + day;

            //String Format - performance motevasat
            //result = String.Format("{0}/{1}/{2}", year, month, day);
            result = String.Format("{0}{separator}{1}{separator}{2}", year, month, day);

            //String Interpolation - performance motevasat
            //result = $"{year}/{month}/{day}";
            result = $"{year}{separator}{month}{separator}{day}";


            //String builder - behtarin performance
            var sb = new StringBuilder();
            sb.Append(year);
            sb.Append(separator);
            sb.Append(month);
            sb.Append(separator);
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

            //switch (month)
            //{
            //    case 1:
            //        return "فروردین";
            //    case 2:
            //        return "اردیبهشت";
            //    case 3:
            //        return "خرداد";
            //    case 4:
            //        return "تیر";
            //    case 5:
            //        return "مرداد";
            //    case 6:
            //        return "شهریور";
            //    case 7:
            //        return "مهر";
            //    case 8:
            //        return "آبان";
            //    case 9:
            //        return "آذر";
            //    case 10:
            //        return "دی";
            //    case 11:
            //        return "بهمن";
            //    case 12:
            //        return "اسفند";
            //    default:
            //        throw new Exception("Wrong month");
            //        //return "nadarim";
            //}

            return month switch
            {
                1 => "فروردین",
                2 => "اردیبهشت",
                3 => "خرداد",
                4 => "تیر",
                5 => "مرداد",
                6 => "شهریور",
                7 => "مهر",
                8 => "آبان",
                9 => "آذر",
                10 => "دی",
                11 => "بهمن",
                12 => "اسفند",
                _ => throw new Exception("Wrong month")
            };
        }

        public static string GetJalaliMonthName_array(DateTime date)
        {
            string[] monthNames = //0 - 11
            {
                "فروردین",
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
            };
            var pc = new PersianCalendar();
            var month = pc.GetMonth(date); // 1-12  - 1 -> 0-11

            return monthNames[month-1];
        }


        public static string getJalaliSeasonName(DateTime date)
        {

            //string PersianSeasson = "";
            //PersianCalendar pc = new PersianCalendar();
            //DateTime thisDate = DateTime.Now;
            //int month = pc.GetMonth(thisDate);
            //if (month < 4) PersianSeasson = "بهار";
            //else if (month > 3 && month < 7) PersianSeasson = "تابستان";
            //else if (month > 6 && month < 10) PersianSeasson = "پاییز";
            //else if (month > 9) PersianSeasson = "زمستان";
            //MessageBox.Show(PersianSeasson);


            string monthName = "";
            var pc = new PersianCalendar();
            var month = pc.GetMonth(date);

            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        return "بهار";
            //    case 4:
            //    case 5:
            //    case 6:
            //        return "تابستان";
            //    case 7:
            //    case 8:
            //    case 9:
            //        return "پاییز";
            //    case 10:
            //    case 11:
            //    case 12:
            //        return "زمستان";
            //    default:
            //        throw new Exception("Wrong Month");
            //}

            //Pattern matching
            //return month switch
            //{
            //    1 => "بهار",
            //    2 => "بهار",
            //    3 => "بهار",
            //    4 => "تابستان",
            //    5 => "تابستان",
            //    6 => "تابستان",
            //    7 => "پاییز",
            //    8 => "پاییز",
            //    9 => "پاییز",
            //    10 => "زمستان",
            //    11 => "زمستان",
            //    12 => "زمستان",
            //    _ => throw new Exception("Wrong Month")
            //};

            return month switch
            {
                var m when m <= 3 => "بهار",
                var m when m <= 6 => "تابستان",
                var m when m <= 9 => "پاییز",
                _ => "زمستان",
            };
        }


        public static DateTime JalaliToMiladi(string date, string separator = "/")
        {
            // date: 1401/10/19 -> 2023/01/09
            // date: 1401-10-19 -> 2023/01/09
            // .Split("/")

            var parts = date.Split(separator);
            var year = Convert.ToInt32(parts[0]);
            var month = Convert.ToInt32(parts[1]);
            var day = Convert.ToInt32(parts[2]);

            return new DateTime(year, month, day, new PersianCalendar());
        }
    }
}
