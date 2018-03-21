using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    
    class MultiThreadUsingCreatingThreads
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }
        static void Main(String[] args)
        {
            //represent a method that executes on a thread.
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the child thread");
            //create and control the thread,set its priority and get its status.
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
