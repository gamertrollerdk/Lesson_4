//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_4
//{
//    delegate string MyDel();
//    class delegates
//    {
//        static void Main(string[] args) 
//        {
//            MyDel testDel = TestFunction;
//            testDel += TestFunction2;

//            string result = testDel();

//            Console.WriteLine(result);
//        }
//        static string TestFunction()
//        {
//            return "hello world";
//        }
//        static string TestFunction2()
//        {
//            return "bye world";
//        }
//    }

//}
