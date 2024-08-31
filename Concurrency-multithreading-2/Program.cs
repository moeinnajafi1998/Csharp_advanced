// 2. Synchronization Techniques
// Synchronization is crucial when multiple threads access shared resources or data. 
// Without proper synchronization, you might encounter race conditions, deadlocks, or other concurrency issues.

// Locks (lock statement):
// The lock statement in C# is a basic synchronization mechanism that ensures only one thread can access a block of code at a time.

// Example:
// private static readonly object _lock = new object();

// static void CriticalSection()
// {
//     lock (_lock)
//     {
//         // Only one thread can enter this block at a time.
//         Console.WriteLine("Thread-safe code execution.");
//     }
// }
// Mutex:
// A Mutex (mutual exclusion) is like a lock, but it can be used across multiple processes.

// Example:
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();

    static void Main()
    {
        mutex.WaitOne(); // Acquire the mutex
        try
        {
            // Critical section
        }
        finally
        {
            mutex.ReleaseMutex(); // Release the mutex
        }
    }
}
// Semaphore:

// A Semaphore limits the number of threads that can access a resource or execute a particular section of code concurrently.

// Example:

// using System;
// using System.Threading;

// class Program
// {
//     static Semaphore semaphore = new Semaphore(2, 2); // Maximum 2 threads can enter

//     static void Main()
//     {
//         for (int i = 0; i < 5; i++)
//         {
//             new Thread(Enter).Start(i);
//         }
//     }

//     static void Enter(object id)
//     {
//         Console.WriteLine($"{id} waiting to enter...");
//         semaphore.WaitOne();
//         Console.WriteLine($"{id} entered.");
//         Thread.Sleep(1000); // Simulate work
//         Console.WriteLine($"{id} leaving.");
//         semaphore.Release();
//     }
// }