﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Day2_Homework.Model;
using TDD_Day2_Homework.Service;

namespace TDD_Day2_Homework.Service.Tests
{
    [TestClass()]
    public class ShoppingCartServiceTests
    {
        [TestMethod()]
        public void 優惠促銷_第一集買了一本_其他都沒買_價格應為100元()
        {
            //Arrange
            Order order = new Order
            {
                OrderNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                OrderItem = new List<Book>
                {
                    new Book {ID = 1, Name = "第一集", Quantity = 1 },
                    new Book {ID = 2, Name = "第二集", Quantity = 0 },
                    new Book {ID = 3, Name = "第三集", Quantity = 0 },
                    new Book {ID = 4, Name = "第四集", Quantity = 0 },
                    new Book {ID = 5, Name = "第五集", Quantity = 0 }
                }
            };

            var expected = 100;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(order);

            //aAsert
            Assert.AreEqual(expected, actual);
        }
    }
}