using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 The Abort() method is used for destroying threads.The runtime aborts the thread by throwing a ThreadAbortException. This exception cannot be caught, the control is sent 
 to the finally block, if any.

*/
namespace LoopConcept
{
    class MultiThreadingUsingAbort 

    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                //do some work,like counting to 10
                for(int counter=0;counter<=10;counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thread Completed.");
                Console.ReadKey();
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine("Thread Abort Exception");
            }

            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        static void Main(String[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            //Thread.CurrentThread.Abort();
            childThread.Start();
            
            //stop the main thread for some time
            Thread.Sleep(2000);
            
            //now abprt the child
            Console.WriteLine("In Main: Aborting the Child thread");

            childThread.Abort();
            Console.ReadKey();
        }
    }
}
