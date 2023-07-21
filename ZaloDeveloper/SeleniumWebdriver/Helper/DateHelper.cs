using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Helper
{
    public class DateHelper
    {
        public static DateTime Convert(string date)
        {
            string format = "dd' tháng 'MM', 'yyyy";
            DateTime dateTime = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            return dateTime;

        }
    }
}
