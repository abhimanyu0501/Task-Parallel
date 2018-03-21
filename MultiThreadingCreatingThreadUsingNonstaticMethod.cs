using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class MultiThreadingCreatingThreadUsingNonstaticMethod
    {
public void Thread1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class ThreadExample1
    {
        static void Main(string[] args)
        {
            MultiThreadingCreatingThreadUsingNonstaticMethod mt = new MultiThreadingCreatingThreadUsingNonstaticMethod();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(mt.Thread1);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
