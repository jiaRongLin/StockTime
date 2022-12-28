using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrading
{
    //更新版
    public static class Trading_Extension
    {/// <summary>
    /// 判斷日期
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="beginDay">起始日</param>
    /// <param name="endDay">到期日</param>
    /// <returns></returns>
        public static bool IsDayOfWeek(this DateTime dt,int beginDay,int endDay)
            => dt.DayOfWeek >= (DayOfWeek)beginDay && dt.DayOfWeek <= (DayOfWeek)endDay;
     /// <summary>
     /// 判斷時間
     /// </summary>
     /// <param name="dt"></param>
     /// <param name="beginTime">開始時間</param>
     /// <param name="endTime">結束時間</param>
     /// <returns></returns>
        public static bool IsTimeOfDay(this DateTime dt,double beginTime,double endTime)
            =>dt.TimeOfDay>=TimeSpan.FromHours(beginTime) &&dt.TimeOfDay<=TimeSpan.FromHours(endTime);
    }

    public static class Trading_Time
    {/// <summary>
    /// 判斷是否為股票盤中時間
    /// </summary>
    /// <param name="dt">時間</param>
    /// <returns>回傳是否為營業時間</returns>
        public static bool IsTradingHour(DateTime dt)
            => dt.IsDayOfWeek(1, 5) && dt.IsTimeOfDay(9, 13.5);
    }
}
