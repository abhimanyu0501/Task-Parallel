using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 You can change or get the name of the thread by using Name property of Thread class. Let's see an example where we are 
 setting and getting names of the threads.
*/
namespace LoopConcept
{
    class MultiThreadingUsingNameAttribute
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name+" is running");
        }
    }

    public class ThreadExample7
    {
static void Main()
        {
            MultiThreadingUsingNameAttribute mt = new MultiThreadingUsingNameAttribute();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";

            t1.Start();
            t2.Start();
            //thread cannot be restart again.
            //t2.Start();
            t3.Start();

            Console.ReadKey();

        }
    }
}
