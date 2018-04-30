using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Attribute
{
    class S_attribute
    {
        [AttributeInfo(1,"att", Message = "hello,world")]
        public static void Print()
        {
            Console.WriteLine("hello world!!");
        }
    }
}
