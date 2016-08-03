using System;

namespace TestConsole
{
    public class testClass
    {
        static void Main()
        {
            Itest test1 = new Test1();
            test1.Testmethod();
            Itest test2 = new Test2();
            test2.Testmethod();
            Test2 test2Obj = new Test2();
            test2Obj.Testmethod();
        }

    }
    interface Itest
    {
        void Testmethod();
    }
    class Test1 : Itest
    {
        public void Testmethod()
        {
            Console.WriteLine("this is implicit implementation");
        }
    }
    class Test2 : Itest
    {
        void Itest.Testmethod()
        {
            Console.WriteLine("this is explicit implementation");
        }
        public void Testmethod()
        {
            Console.WriteLine("this is explicit extra implementation");
        }
    }

    public class newClass
    {
        private static IYourType yourType;
        internal newClass(IB b)
        {
            yourType = b.ReturnType();
        }

        public static int Add()
        {
            return yourType.Add(2, 3);
        }
    }
}