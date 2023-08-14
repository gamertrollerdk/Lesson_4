//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_4
//{
//    delegate void MyDel(string s);
//    delegate void NewDel(string s); 

//    internal class Delegates
//    {
//        static void Main(string[] args)
//        {
//            MyDel del = TestFunction;
//            del += TestFunction;
//            del("hello world");

//            Console.WriteLine();

//            NewDel newDel = NewTestFunction;
//            newDel += NewTestFunction;
//            newDel("new hello world");
//        }

//        static void TestFunction(string text)
//        {
//            Console.WriteLine(text);
//        }

//        static void NewTestFunction(string text) 
//        {
//            Console.WriteLine("New function: " + text);
//        }
//    }
//}
