using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Now = "2022-12-19 13:30:01";
            //var time_now = DateTime.Parse(Now);
            //bool time =StockTime.StockTime.IsTradingHours(time_now);
            ////bool time = StockTime.StockTime.IsTradingHours(DateTime.Now);
            //if (time)
            //{
            //    Console.WriteLine("盤中時間!!");
            //}
            //else
            //{
            //    Console.WriteLine("已經收盤!");
            //}
            //Console.ReadKey();

            string time = "2022-12-21 9:00:01";
            DateTime dateTime=DateTime.Parse(time);
            bool result = StockTrading.Trading_Time.IsTradingHour(dateTime);
            if (result) { Console.WriteLine("盤中時間!!!"); }
            else { Console.WriteLine("收盤了!!!"); }
            //test
        }
    }
}
