using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDD_Day2_Homework.Model;

namespace TDD_Day2_Homework.Service.Tests
{
    [TestClass()]
    public class ShoppingCartServiceTests
    {
        [TestMethod()]
        public void 優惠促銷_第一集買了一本_其他都沒買_價格應為100元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 0 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 0 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 0 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 100;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一二集買了一本_其他都沒買_價格應為190元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 1 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 0 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 0 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 190;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一二三集各買了一本_其他都沒買_價格應為270元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 1 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 1 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 0 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 270;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一二三四集各買了一本_其他都沒買_價格應為320元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 1 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 1 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 1 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 320;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一二三四五集各買了一本_其他都沒買_價格應為375元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 1 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 1 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 1 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 1 }
            };

            var expected = 375;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一二集各買了一本_第三集買了兩本_價格應為370元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 1 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 2 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 0 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 370;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 優惠促銷_第一集買了一本_第二三集各買了兩本_價格應為460元()
        {
            //Arrange
            List<Book> books = new List<Book>
            {
                new Book {ID = 1, Name = "第一集", Price = 100, Quantity = 1 },
                new Book {ID = 2, Name = "第二集", Price = 100, Quantity = 2 },
                new Book {ID = 3, Name = "第三集", Price = 100, Quantity = 2 },
                new Book {ID = 4, Name = "第四集", Price = 100, Quantity = 0 },
                new Book {ID = 5, Name = "第五集", Price = 100, Quantity = 0 }
            };

            var expected = 460;
            var target = new ShoppingCartService();

            //Act
            int actual = target.CheckOut(books);

            //aAsert
            Assert.AreEqual(expected, actual);
        }
    }
}