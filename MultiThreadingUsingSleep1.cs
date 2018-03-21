using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class MultiThreadingUsingSleep1
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

    public class ThreadExample3
    {
        static void Main(string[] args)
        {
            MultiThreadingUsingSleep1 mt = new MultiThreadingUsingSleep1();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    } 
}
