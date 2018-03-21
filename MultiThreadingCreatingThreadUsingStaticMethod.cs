using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class MultiThreadingCreatingThreadUsingStaticMethod
    {
        public static void Thread1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class ThreadExample
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(MultiThreadingCreatingThreadUsingStaticMethod.Thread1);
            Thread t2 = new Thread(MultiThreadingCreatingThreadUsingStaticMethod.Thread1);

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
