//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_4
//{
//    class Delegates
//    {
//        delegate int CountIt(int x);
//        delegate int MultiplyIt(int x, int y);

//        static void Main(string[] args)
//        {
//            CountIt testDel = (int x) => x + 5;
//            MultiplyIt multiplyDel = (int x, int y) => x * y;

//            int result = testDel(5);
//            Console.WriteLine("Result of testDel: " + result);

//            int multiplyResult = multiplyDel(3, 4);
//            Console.WriteLine("Result of multiplyDel: " + multiplyResult);
//        }
//    }
//}
