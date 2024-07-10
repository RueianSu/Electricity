using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity
{
    internal class Program
    {

        static void Main(string[] args)
        {
            NonBusiness.Summer summer = new NonBusiness.Summer();

            Console.WriteLine("請輸入度數 ：");
            var kwh = Console.ReadLine();

            var money = !IsInteger(kwh) ? 0 : int.Parse(kwh);

            Console.WriteLine($"全部 ： {summer.CalculateCost(money)} 元");
            Console.Read();
        }

        static bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }
    }

    /// <summary>
    /// 非營業用電
    /// </summary>
    public class NonBusiness { 

        /// <summary>
        /// 非營業 - 夏季用電
        /// </summary>
        public class Summer
        {
            private const float BelowKWh = 1.63f;
            private const float L_121_330_KWh = 2.38f;
            private const float L_331_500_KWh = 3.52f;
            private const float L_501_700_KWh = 4.80f;
            private const float L_701_1100_KWh = 5.66f;
            private const float MAX_KWh = 6.41f;

            /// <summary>
            /// 非營業 - 夏季用電
            /// </summary>
            /// <param name="kwh">度</param>
            /// <returns></returns>
            public float CalculateCost(float kwh) 
            {
                float calculateCostMoney = 0;

                //120 度
                if (kwh <= 120)
                {
                    calculateCostMoney = kwh * BelowKWh;
                    Console.WriteLine($"120 度：{calculateCostMoney} 元");
                }
                else
                {
                    calculateCostMoney = 120 * BelowKWh;
                    Console.WriteLine($"120 度：{calculateCostMoney} 元");
                }

                // 121-330 度
                if (kwh > 120 && kwh <= 330)
                {
                    calculateCostMoney += (kwh-120) * L_121_330_KWh;
                    Console.WriteLine($"120 - 330 度：{(kwh - 120) * L_121_330_KWh} 元");
                }
                else if (kwh > 330)
                {
                    calculateCostMoney += (330 - 120) * L_121_330_KWh;
                    Console.WriteLine($"120 - 330 度：{(330 - 120) * L_121_330_KWh} 元");
                }

                // 331 - 500 度
                if (kwh > 330 && kwh <= 500)
                {
                    calculateCostMoney += (kwh - 330) * L_331_500_KWh;
                    Console.WriteLine($"330 - 500 度：{(kwh - 330) * L_331_500_KWh} 元");
                }
                else if (kwh > 500)
                {
                    calculateCostMoney += (500 - 330) * L_331_500_KWh;
                    Console.WriteLine($"330 - 500 度：{(500 - 330) * L_331_500_KWh} 元");
                }

                // 501 - 700
                if (kwh > 500 && kwh <= 700)
                {
                    calculateCostMoney += (kwh - 500) * L_501_700_KWh;
                    Console.WriteLine($"500 - 700 度：{(kwh - 500) * L_501_700_KWh} 元");
                }
                else if (kwh > 700)
                {
                    calculateCostMoney += (700 - 500) * L_501_700_KWh;
                    Console.WriteLine($"500 - 700 度：{(700 - 500) * L_501_700_KWh} 元");
                }

                if (kwh > 700 && kwh <= 1000)//700 - 1000
                {
                    calculateCostMoney += (kwh - 700) * L_701_1100_KWh;
                    Console.WriteLine($"700 - 1000 度：{(kwh - 700) * L_701_1100_KWh} 元");

                }
                else if (kwh > 1000) //1000以上
                {
                    calculateCostMoney += (1000 - 700) * L_701_1100_KWh + (kwh -1000) * MAX_KWh;
                    Console.WriteLine($"700 - 1000 度：{(1000 - 700) * L_701_1100_KWh} 元");
                    Console.WriteLine($"1000 度以上：{(kwh - 1000) * MAX_KWh} 元");
                }
                Console.WriteLine("=======================================");

                return calculateCostMoney;
            }
        }

        /// <summary>
        /// 非營業 - 非夏季用電
        /// </summary>
        public class NonSummer
        {
            private const float BelowKWh = 1.63f;
            private const float L_121_330_KWh = 2.1f;
            private const float L_331_500_KWh = 2.89f;
            private const float L_501_700_KWh = 4.6f;
            private const float L_701_1100_KWh = 5.03f;
            private const float MAX_KWh = 6.41f;

            /// <summary>
            /// 非營業 - 非夏季用電
            /// </summary>
            /// <param name="kwh">度</param>
            /// <returns></returns>
            public float CalculateCost(float kwh)
            {
                float calculateCostMoney = 0;

                //120 度
                if (kwh <= 120)
                {
                    calculateCostMoney = kwh * BelowKWh;
                    Console.WriteLine($"120 度：{calculateCostMoney} 元");
                }
                else
                {
                    calculateCostMoney = 120 * BelowKWh;
                    Console.WriteLine($"120 度：{calculateCostMoney} 元");
                }

                // 121-330 度
                if (kwh > 120 && kwh <= 330)
                {
                    calculateCostMoney += (kwh - 120) * L_121_330_KWh;
                    Console.WriteLine($"120 - 330 度：{(kwh - 120) * L_121_330_KWh} 元");
                }
                else if (kwh > 330)
                {
                    calculateCostMoney += (330 - 120) * L_121_330_KWh;
                    Console.WriteLine($"120 - 330 度：{(330 - 120) * L_121_330_KWh} 元");
                }

                // 331 - 500 度
                if (kwh > 330 && kwh <= 500)
                {
                    calculateCostMoney += (kwh - 330) * L_331_500_KWh;
                    Console.WriteLine($"330 - 500 度：{(kwh - 330) * L_331_500_KWh} 元");
                }
                else if (kwh > 500)
                {
                    calculateCostMoney += (500 - 330) * L_331_500_KWh;
                    Console.WriteLine($"330 - 500 度：{(500 - 330) * L_331_500_KWh} 元");
                }

                // 501 - 700
                if (kwh > 500 && kwh <= 700)
                {
                    calculateCostMoney += (kwh - 500) * L_501_700_KWh;
                    Console.WriteLine($"500 - 700 度：{(kwh - 500) * L_501_700_KWh} 元");
                }
                else if (kwh > 700)
                {
                    calculateCostMoney += (700 - 500) * L_501_700_KWh;
                    Console.WriteLine($"500 - 700 度：{(700 - 500) * L_501_700_KWh} 元");
                }

                if (kwh > 700 && kwh <= 1000)//700 - 1000
                {
                    calculateCostMoney += (kwh - 700) * L_701_1100_KWh;
                    Console.WriteLine($"700 - 1000 度：{(kwh - 700) * L_701_1100_KWh} 元");
                }
                else if (kwh > 1000) //1000以上
                {
                    calculateCostMoney += (1000 - 700) * L_701_1100_KWh + (kwh - 1000) * MAX_KWh;
                    Console.WriteLine($"700 - 1000 度：{(1000 - 700) * L_701_1100_KWh} 元");
                    Console.WriteLine($"1000 度以上：{(kwh - 1000) * MAX_KWh} 元");
                }
                Console.WriteLine("=======================================");

                return calculateCostMoney;
            }

        }

    }

    /// <summary>
    /// 營業用電
    /// </summary>
    public class Business
    {
        /// <summary>
        /// 營業 - 夏季用電
        /// </summary>
        public class Summer
        {
            private const float BelowKWh = 2.53f;
            private const float L_330_700_KWh = 3.55f;
            private const float L_700_1500_KWh = 4.25f;
            private const float MAX_KWh = 6.43f;


            /// <summary>
            /// 營業 - 夏季用電
            /// </summary>
            /// <param name="kwh">度</param>
            /// <returns></returns>
            public float CalculateCost(float kwh)
            {
                float calculateCostMoney = 0;

                //330 度
                if (kwh <= 330)
                {
                    calculateCostMoney = kwh * BelowKWh;
                    Console.WriteLine($"330 度：{calculateCostMoney} 元");
                }
                else
                {
                    calculateCostMoney = 330 * BelowKWh;
                    Console.WriteLine($"330 度：{calculateCostMoney} 元");
                }

                // 330-700 度
                if (kwh > 330 && kwh <= 700)
                {
                    calculateCostMoney += (kwh - 330) * L_330_700_KWh;
                    Console.WriteLine($"330 - 700 度：{(kwh - 330) * L_330_700_KWh} 元");
                }
                else if (kwh > 700)
                {
                    calculateCostMoney += (700 - 330) * L_330_700_KWh;
                    Console.WriteLine($"330 - 700 度：{(700 - 330) * L_330_700_KWh} 元");
                }

                if (kwh > 700 && kwh <= 1500)//700 - 1500
                {
                    calculateCostMoney += (kwh - 700) * L_700_1500_KWh;
                    Console.WriteLine($"700 - 1500 度：{(kwh - 700) * L_700_1500_KWh} 元");
                }
                else if (kwh > 1500) //1500以上
                {
                    calculateCostMoney += (1500 - 700) * L_700_1500_KWh + (kwh - 1500) * MAX_KWh;
                    Console.WriteLine($"700 - 1500 度：{(1500 - 700) * L_700_1500_KWh} 元");
                    Console.WriteLine($"1500 度以上：{(kwh - 1500) * MAX_KWh} 元");
                }
                Console.WriteLine("=======================================");

                return calculateCostMoney;
            }
        }

        /// <summary>
        /// 營業 - 非夏季用電
        /// </summary>
        public class NonSummer
        {
            private const float BelowKWh = 2.12f;
            private const float L_330_700_KWh = 2.91f;
            private const float L_700_1500_KWh = 3.44f;
            private const float MAX_KWh = 5.05f;

            /// <summary>
            /// 營業 -  非夏季用電
            /// </summary>
            /// <param name="kwh">度</param>
            /// <returns></returns>
            public float CalculateCost(float kwh)
            {
                float calculateCostMoney = 0;

                //330 度
                if (kwh <= 330)
                {
                    calculateCostMoney = kwh * BelowKWh;
                    Console.WriteLine($"330 度：{calculateCostMoney} 元");
                }
                else
                {
                    calculateCostMoney = 330 * BelowKWh;
                    Console.WriteLine($"330 度：{calculateCostMoney} 元");
                }

                // 330-700 度
                if (kwh > 330 && kwh <= 700)
                {
                    calculateCostMoney += (kwh - 330) * L_330_700_KWh;
                    Console.WriteLine($"330 - 700 度：{(kwh - 330) * L_330_700_KWh} 元");
                }
                else if (kwh > 700)
                {
                    calculateCostMoney += (700 - 330) * L_330_700_KWh;
                    Console.WriteLine($"330 - 700 度：{(700 - 330) * L_330_700_KWh} 元");
                }

                if (kwh > 700 && kwh <= 1500)//700 - 1500
                {
                    calculateCostMoney += (kwh - 700) * L_700_1500_KWh;
                    Console.WriteLine($"700 - 1500 度：{(kwh - 700) * L_700_1500_KWh} 元");
                }
                else if (kwh > 1500) //1500以上
                {
                    calculateCostMoney += (1500 - 700) * L_700_1500_KWh + (kwh - 1500) * MAX_KWh;
                    Console.WriteLine($"700 - 1500 度：{(1500 - 700) * L_700_1500_KWh} 元");
                    Console.WriteLine($"1500 度以上：{(kwh - 1500) * MAX_KWh} 元");
                }
                Console.WriteLine("=======================================");

                return calculateCostMoney;
            }
        }
    }
}


