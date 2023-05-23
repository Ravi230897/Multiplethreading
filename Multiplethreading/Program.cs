using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiplethreading
{
    internal class Program
    {
        // static task one
        public static void task1()
        {

            // It prints numbers from 0 to 10
            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine("task1 is : {0}", a);

                // When the value of I is equal to 5 then
                // this method sleeps for 6 seconds
                if (a == 5)
                {
                    Thread.Sleep(10000);
                }
            }
        }

        // static task two
        public static void task2()
        {
            // It prints numbers from 0 to 10
            for (int b = 0; b <= 10; b++)
            {
                Console.WriteLine("task2 is : {0}", b);
            }
        }

        // Main Method
        static public void Main()
        {

            // Creating and initializing threads
            Thread thr1 = new Thread(task1);
            Thread thr2 = new Thread(task2);
            thr1.Start();
            thr2.Start();
        }
    }

}
