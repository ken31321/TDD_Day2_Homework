using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD_Day2_Homework.Model;

namespace TDD_Day2_Homework.Service
{
    public class ShoppingCartService
    {
        public int CheckOut(List<Book> books)
        {
            //訂單總金額
            int totalAmount = 0;

            //計算折扣金額
            totalAmount = CalculateDiscont(books);

            return totalAmount;
        }

        private int CalculateDiscont(List<Book> books)
        {
            int subAmount = 0;

            while (books.Where(item => item.Quantity > 0).Any())
            {
                //計算不同書的數量
                IEnumerable<int> ListOtherbook = books.Where(item => item.Quantity > 0)
                                                    .Select(item => item.ID)
                                                    .Distinct();

                //打折乘數
                double multiplier = 1;
                switch (ListOtherbook.Count())
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
                }

                //書籍單價總和
                int sumPrice = books.Where(item => item.Quantity > 0)
                                    .Sum(item => item.Price);

                //打折後金額
                subAmount += Convert.ToInt32(Math.Round(sumPrice * multiplier, MidpointRounding.AwayFromZero));

                foreach (var bookID in ListOtherbook)
                {
                    books.Where(item => item.ID == bookID).First().Quantity--;
                }
            }

            return subAmount;
        }

    }
}
