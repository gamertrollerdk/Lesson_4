﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_4
//{
//    delegate string MyDel();
//    delegate string ConcatenateDel(string str1, string str2);

//    class delegates
//    {
//        static void Main(string[] args)
//        {
//            MyDel testDel = TestFunction;
//            testDel += TestFunction2;

//            string result = testDel();
//            Console.WriteLine(result);

//            ConcatenateDel concatDelegate = ConcatenateStrings;
//            string concatenatedResult = concatDelegate("Hello, ", "world!");
//            Console.WriteLine(concatenatedResult);
//        }

//        static string TestFunction()
//        {
//            return "hello world";
//        }

//        static string TestFunction2()
//        {
//            return "bye world";
//        }

//        static string ConcatenateStrings(string str1, string str2)
//        {
//            return str1 + str2;
//        }
//    }
//}
