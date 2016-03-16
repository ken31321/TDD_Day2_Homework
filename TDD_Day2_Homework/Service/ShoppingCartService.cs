using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD_Day2_Homework.Model;

namespace TDD_Day2_Homework.Service
{
    public class ShoppingCartService
    {
        public int CheckOut(Order order)
        {
            //訂單總金額
            int totalAmount = 0;

            //計算不同本書的數量
            var otherBooks = order.OrderItem.Where(m => m.Quantity > 0).Select(m => m.ID);

            //計算折扣金額
            totalAmount = CalculateDiscont(otherBooks.Count());

            return totalAmount;
        }

        private int CalculateDiscont(int count)
        {
            //每本書的價格
            int bookPrice = 100;

            //打折乘數
            double multiplier = 1;
            switch (count)
            {
                /*
                一種書: 不打折
                兩種書: 95折
                三種書: 9折
                四種書: 8折
                五種書: 75折
                */
                case 1:
                    multiplier = 1;
                    break;
                case 2:
                    multiplier = 0.95;
                    break;
                case 3:
                    multiplier = 0.9;
                    break;
                case 4:
                    multiplier = 0.8;
                    break;
                case 5:
                    multiplier = 0.75;
                    break;
                default:
                    break;
            }

            //打折後金額
            int discountAmount = Convert.ToInt32(bookPrice * count * multiplier);

            return discountAmount;
        }

    }
}
