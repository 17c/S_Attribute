
using System;
/// <summary>
/// 学习Attribute Demo
/// </summary>
namespace S_Attribute
{   

    /// <summary>
    /// 总结: Conditional应该是我们最少使用的，可以通过宏定义来判断一个类是否可以使用
    /// Obsolete 是用于判断是否废弃的依据，也可以用它来定位某个方法的使用
    /// CustomAttribute可以说是我们最常用的了，可以通过调用反射，来获取对类的操作，但是这样做，会使程序的可读性变差
    /// 可以用它来记录一些信息和数据。具体情况还是要学习反射之后才能更了解
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            S_obsolete.print();
            S_conditional.Print();
            S_attribute.Print();
            Type type= typeof(S_attribute);
            foreach (var obj in type.GetMethods())
            {
                foreach(Object attr in obj.GetCustomAttributes(false))
                {
                    var attributeInfo = (AttributeInfo)attr;
                    attributeInfo.printInfo();
                }
            }
        }
    }
}
