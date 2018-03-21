using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
Let's see an example where we are changing the priority of the thread. The high priority thread can be executed first. But it is not guaranteed because thread is highly 
system dependent. It increases the chance of the high priority thread to execute before low priority thread.
The output is unpredictable because threads are highly system dependent. It may follow any algorithm preemptive or non-preemptive.
 */
namespace LoopConcept
{
    class MultiThreadingUsingThreadPriority
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name+" is running");
            Console.WriteLine("Priority of thread "+t.Name+" is: "+t.Priority);
        }
    }
    public class ThreadExample8
    {
        static void Main(string[] args)
        {
            Thread tmain = Thread.CurrentThread;
            Console.WriteLine("the priority of thread "+tmain+" is "+tmain.Priority);
            MultiThreadingUsingThreadPriority mt = new MultiThreadingUsingThreadPriority();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            Console.WriteLine("the priority of thread " + tmain + " is " + tmain.Priority);
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";
//set or get a value indecting the scheduling priority of a thread.
            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }
}
