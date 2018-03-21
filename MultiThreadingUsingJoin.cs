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
    class MultiThreadingUsingJoin
    {
        public void Thread1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    public class ThreadExample5
    {
static void Main(String[] args)
        {
            MultiThreadingUsingJoin mt = new MultiThreadingUsingJoin();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            Console.ReadKey();
        }
    }
}
