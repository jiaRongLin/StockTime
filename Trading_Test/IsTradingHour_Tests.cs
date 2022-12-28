using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using StockTrading;

namespace Trading_Test
{
    internal class IsTradingHour_Test
    {
        [TestCase("2022/12/21 09:00:01")]
        [TestCase("2022/12/20 13:30:00")]
        [TestCase("2022/12/22 12:50:01")]
        [TestCase("2022/12/19 09:30:01")]

        public void IsTradingHour_平日盤中(string time)
        {
            DateTime dt = DateTime.Parse(time);
            bool actual = Trading_Time.IsTradingHour(dt);

            Assert.IsTrue(actual);
        }

        [TestCase("2022/12/17 09:00:01")]
        [TestCase("2022/12/24 13:30:00")]
        [TestCase("2022/12/25 12:50:01")]
        [TestCase("2022/12/31 09:30:01")]

        public void IsTradingHour_假日盤中(string time)
        {
            DateTime dt = DateTime.Parse(time);
            bool actual = Trading_Time.IsTradingHour(dt);

            Assert.IsFalse(actual);
        }

        [TestCase("2022/12/21 08:59:59")]
        [TestCase("2022/12/20 13:30:01")]
        [TestCase("2022/12/22 18:50:00")]
        [TestCase("2022/12/19 05:00:50")]

        public void IsTradingHour_平日收盤(string time)
        {
            DateTime dt = DateTime.Parse(time);
            bool actual = Trading_Time.IsTradingHour(dt);

            Assert.IsFalse(actual);
        }
    }
    
}
