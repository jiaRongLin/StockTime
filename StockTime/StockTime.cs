using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTime
{
    //原版
    public class StockTime
    {/// <summary>
    /// 判斷是否為股票交易時間
    /// </summary>
    /// <param name="dt">輸入時間</param>
    /// <returns>是否為交易時間</returns>
        public static bool IsTradingHours(DateTime dt)
        {
            var day = dt.DayOfWeek;
            string AM = "9:00:00";
            string PM = "13:30:00";
            string Now = dt.ToString();
            TimeSpan timeAM = DateTime.Parse(AM).TimeOfDay;
            TimeSpan timePM = DateTime.Parse(PM).TimeOfDay;
            TimeSpan timeNow = DateTime.Parse(Now).TimeOfDay;
            if (day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Wednesday
                || day == DayOfWeek.Thursday || day == DayOfWeek.Friday)
            {
                if (timeNow >= timeAM && timeNow <= timePM)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
