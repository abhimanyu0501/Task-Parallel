﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
Synchronization is a technique that allows only one thread to access the resource for the particular time. No other thread can interrupt until the assigned thread 
finishes its task.
In multithreading program, threads are allowed to access any resource for the required execution time. Threads share resources and executes asynchronously. Accessing 
shared resources (data) is critical task that sometimes may halt the system. We deal with it by making threads synchronized.
It is mainly used in case of transactions like deposit, withdraw etc.

Advantage of Thread Synchronization
Consistency Maintain
No Thread Interference

In this example, we are using lock. This example executes synchronously. In other words, there is no context-switching between the threads. In the output section, we can
see that second thread starts working after first threads finishes its tasks.
We can use C# lock keyword to execute program synchronously. It is used to get lock for the current thread, execute the task and then release the lock. It ensures that 
other thread does not interrupt the execution until the execution finish.
Here, we are creating two examples that executes asynchronously and synchronously.
*/
namespace LoopConcept
{
    class MultiThreadingWithSynchronization
    {
public  void PrintTable()
        {
            lock(this)
            {
                for(int i=0;i<10;i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
            }
        }
    }

    class ThreadProgram1
    {
static void Main(String[] args)
        {
            MultiThreadingWithSynchronization p = new MultiThreadingWithSynchronization();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
