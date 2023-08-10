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

//        static void Main(string[] args)
//        {
//            CountIt testDel = delegate(int x)
//            {
//                int total = 0;
//                for (int i = 0; i < 5; i++)
//                {
//                    total += x;
//                    //Console.WriteLine(x);
//                }
//                return total;
//            };
//            int overallTotal = testDel(100);
//            Console.WriteLine(overallTotal);
//        }

//    }
//}
