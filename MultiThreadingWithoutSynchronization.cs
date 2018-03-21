using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 In this example, we are not using lock. This example executes asynchronously. In other words, there is context-switching between the threads.

*/
namespace LoopConcept
{
    class MultiThreadingWithoutSynchronization
    {
        public void PrintTable()
        {
            for(int i=0;i<10;i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }
    }

    class ThreadProgram
    {
        static void Main(string[] args)
        {
            MultiThreadingWithoutSynchronization p = new MultiThreadingWithoutSynchronization();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
