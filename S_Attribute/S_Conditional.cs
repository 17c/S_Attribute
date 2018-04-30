#define DEBUG1
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Attribute
{

    class S_conditional
    {
        /// <summary>
        /// 存在这个宏定义才可以使用
        /// </summary>
        [Conditional("DEBUG1")]
        public static void Print()
        {
            Console.WriteLine("hello,world!");  
        }
    }
}
