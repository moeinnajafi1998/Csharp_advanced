// 3. Thread Safety and Race Conditions
// Thread safety ensures that your code behaves correctly when accessed from multiple threads simultaneously. 
// Race conditions occur when the outcome of a program depends on the timing or sequence of uncontrollable events, like thread scheduling.

// Race Conditions:
// A race condition can occur if two or more threads access shared data concurrently and try to change it at the same time.

// Example:

// class Program
// {
//     static int counter = 0;

//     static void Main()
//     {
//         Thread t1 = new Thread(IncrementCounter);
//         Thread t2 = new Thread(IncrementCounter);

//         t1.Start();
//         t2.Start();

//         t1.Join();
//         t2.Join();

//         Console.WriteLine(counter); // May not be 2000000 due to race condition
//     }

//     static void IncrementCounter()
//     {
//         for (int i = 0; i < 1000000; i++)
//         {
//             counter++;
//         }
//     }
// }

// Avoiding Race Conditions:
// Use lock, Mutex, Monitor, or other synchronization primitives to avoid race conditions.
// Example using lock to make the previous example thread-safe:

class Program
{
    static int counter = 0;
    static readonly object _lock = new object();

    static void Main()
    {
        Thread t1 = new Thread(IncrementCounter);
        Thread t2 = new Thread(IncrementCounter);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine(counter); // Should be 2000000
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 1000000; i++)
        {
            lock (_lock)
            {
                counter++;
            }
        }
    }
}
// By understanding and properly implementing these concepts, you can create efficient, safe, and responsive multithreaded applications in C#.