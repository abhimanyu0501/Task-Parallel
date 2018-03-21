using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class MultiThreadingUsingNonstaticMethod
    {
        public static void Thread1()
        {
            Console.WriteLine("task one");
        }

        public static void Thread2()
        {
            Console.WriteLine("task two");
        }
    }

    public class ThreadExample2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MultiThreadingUsingNonstaticMethod.Thread1));
            Thread t2 = new Thread(new ThreadStart(MultiThreadingUsingNonstaticMethod.Thread2));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

    }
}
