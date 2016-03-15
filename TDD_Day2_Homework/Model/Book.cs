using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Day2_Homework.Model
{
    public class Book
    {

        /// <summary>
        /// 書籍序號
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 書籍名稱
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 書籍數量
        /// </summary>
        public int Quantity { get; set; }

    }
}
