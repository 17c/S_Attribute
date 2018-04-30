using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Attribute
{
    class S_obsolete
    {
        /// <summary>
        /// 标注为true则不再可以使用，运行时会报错
        /// </summary>
        [Obsolete("this function is Obsolete",false)]
        public static void print()
        {
            Console.WriteLine("hello,world");
        }
    }
}
