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
//            Person p = new Person(50); // Set initial cash to 50
//            p.cashEvent += () => Console.WriteLine("Person has 100 bucks");
//            p.cashEventBetween50And100 += () => Console.WriteLine("Person has more than 50 bucks but less than 100");
//            p.cashEventBelow50 += () => Console.WriteLine("Person has less than 50 bucks");

//            p.AddCash(30); // Add more cash to make it between 50 and 100
//            p.AddCash(-40); // Subtract cash to trigger the event for less than 50 bucks
//        }
//    }

//    class Person
//    {
//        public delegate void MyEventHandler();
//        public event MyEventHandler cashEvent;
//        public event MyEventHandler cashEventBetween50And100;
//        public event MyEventHandler cashEventBelow50; // New event for cash below 50

//        private int cash;
//        public int Cash
//        {
//            get
//            {
//                return cash;
//            }
//            set
//            {
//                cash = value;
//                if (cash >= 100)
//                {
//                    cashEvent?.Invoke();
//                }
//                else if (cash > 50 && cash < 100)
//                {
//                    cashEventBetween50And100?.Invoke();
//                }
//                else if (cash < 50) // Check if cash is below 50
//                {
//                    cashEventBelow50?.Invoke();
//                }
//            }
//        }

//        public Person(int initialCash)
//        {
//            Cash = initialCash;
//        }

//        public void AddCash(int amount)
//        {
//            Cash += amount;
//        }
//    }
//}
