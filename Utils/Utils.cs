using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTestFramework.Utils
{
    public static class Utils
    {
        private static string _format = "M/d/yy h:mm tt";
        private static CultureInfo _provider = CultureInfo.InvariantCulture;

        public static bool IsValidFormat(string date)
        {
            Console.WriteLine(date);
            DateTime d;
            return DateTime.TryParseExact(date, _format,
            _provider, DateTimeStyles.None, out d);
            
        }

        public static DateTime ParseStringDate(string dateString)
        {
            DateTime result;
            try
            {
                result = DateTime.ParseExact(dateString, _format, _provider);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", dateString);
                result = DateTime.MinValue;
            }
            return result;
        }

        public static bool IsInRangeOfDays(DateTime date, DateTime dateInit, DateTime dateFinish)
        {
            int resultInit = DateTime.Compare(date, dateInit);
            int resultFinish = DateTime.Compare(dateFinish, date);

            return resultInit >= 0 && resultFinish >= 0;

        }
    }
}
