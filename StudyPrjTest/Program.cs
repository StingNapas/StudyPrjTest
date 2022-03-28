using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyPrjTest
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + b);
            Console.WriteLine("Test добавил перед сбросом");
            //Method1(ref a);
        }

        public static void Method1(ref int t)
        {
            t += 1;
            Console.WriteLine(t);
        }

        public static void Test1()
        {
            int[] arr = { 1, 2, 3 };
            ref int a = ref arr[0];
        }

        public static void TestMeth() => Console.WriteLine("ss");

    }
}
