using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Delegates
    {
        delegate int CountIt(int x);

        static void Main(string[] args)
        {
            Person p = new Person();
            p.cashEvent += () => Console.WriteLine("Person has 100 bucks");

            p.AddCash(50);
            p.AddCash(50);
        }


    }

    class Person
    {
        public delegate void MyEventHandler();

        public event MyEventHandler cashEvent;

        private int cash;
        public int Cash
        {
            get 
            { 
                return cash;
            }
            set 
            {
                cash = value;
                if (cash >= 100)
                {
                    if (cashEvent != null) 
                    { 
                    cashEvent();
                    }
                }
            }
        }
    
    public void AddCash(int amount)
        {
            Cash += amount;
        }
    }
}
