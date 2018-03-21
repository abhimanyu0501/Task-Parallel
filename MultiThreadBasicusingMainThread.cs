using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace LoopConcept
{
    /// <summary>
    /// In C#, the System.Threading.Thread class is used for working with threads. It allows creating and accessing individual threads in a multithreaded
    /// application. The first thread to be executed in a process is called the main thread.When a C# program starts execution, the main thread is 
    /// automatically created. The threads created using the Thread class are called the child threads of the main thread. You can access a thread 
    /// using the CurrentThread property of the Thread class.
    /// </summary>
    class MultiThreadBasicusingMainThread
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
    static void Main(string[] args)
        {
            //get the current running thread.
            Thread th = Thread.CurrentThread;
            //set the name of the thread.
            th.Name = "Main Thread";
            //get the name of the thread.
            Console.WriteLine("This is {0}",th.Name);
            Console.ReadKey();
        }
    }
}
