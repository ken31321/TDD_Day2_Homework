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
            return 0;
        }

        private int CalculateDiscont(int count)
        {
            //打折乘物
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
                default:
                    break;
            }

            int discountAmount = Convert.ToInt32(100 * count * multiplier);

            return discountAmount;
        }


    }
}
