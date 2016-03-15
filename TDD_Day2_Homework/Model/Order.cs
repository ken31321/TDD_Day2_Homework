using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day2_Homework.Model
{
    public class Order
    {

        /// <summary>
        /// 訂單編號
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 訂單項目
        /// </summary>
        public List<Book> OrderItem { get; set; }

    }
}
