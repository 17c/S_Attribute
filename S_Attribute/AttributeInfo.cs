using System;

namespace S_Attribute
{
    /// <summary>
    /// 自定义的Attribute
    /// </summary>
    class AttributeInfo:Attribute
    {
        public int InfoId;
        public string InfoName;
        public string message;
        public AttributeInfo(int InfoId, string InfoName)
        {
            this.InfoId = InfoId;
            this.InfoName = InfoName;
            printInfo();
        }

        public string Message { get; set; }

        public void printInfo()
        {
            Console.WriteLine("我才没有写 hello,world!!");
            Console.WriteLine("\n" + this.InfoName + this.InfoId);
        }
    }
}
