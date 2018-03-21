using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
It causes all the calling threads to wait until the current thread (joined thread) is terminated or completes its task. 

*/
namespace LoopConcept
{
    class MultiThreadingUsingJoin1
    {
        Thread th;
        public MultiThreadingUsingJoin1(Thread th)
        {
            this.th = th;
        }
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(i);
                Thread.Sleep(200);
               // th.Join();
            }
        }
    }
    public class ThreadExample6
    {
        static void Main(String[] args)
        {
            MultiThreadingUsingJoin1 mt = new MultiThreadingUsingJoin1(Thread.CurrentThread);
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            //Thread.CurrentThread.Join();
            t1.Start();
            t1.Join();
            t2.Start();
            //t2.Join();
            t3.Start();
            //t3.Join();
            Console.ReadKey();
        }
    }
}
