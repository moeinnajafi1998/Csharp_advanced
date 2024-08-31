// Asynchronous programming in C# allows you to perform tasks without blocking the main thread, which can make your applications more responsive and efficient. 
// The core of this approach in C# is the async and await keywords. 
// Let’s break down the key concepts:

// 1. Async Methods
// An async method is a method that performs an asynchronous operation. 
// It’s marked with the async keyword, which allows you to use the await keyword inside it.
// Here’s a basic example:


// In this example, FetchDataAsync is an asynchronous method that returns a Task<int>. 
// The await keyword is used to asynchronously wait for the completion of Task.Delay, which simulates a delay.

// 2. Awaiting Tasks
// The await keyword is used to pause the execution of an async method until a Task completes. This doesn’t block the thread but allows other work to be done while waiting. For instance:
class Program{
    static void Main(){
        UseFetchDataAsync();
        Console.Write("Enter your name: ");
        Console.ReadLine();
    }
    public static async void UseFetchDataAsync()
    {
        int result = await FetchDataAsync();
        Console.WriteLine($"Result: {result}");
    }

    public static async Task<int> FetchDataAsync()
    {
        // Simulate a delay for an asynchronous operation
        Console.WriteLine("before delay 2 secs");
        await Task.Delay(2000);
        Console.WriteLine("after delay 2 secs");
        return 42;
    }

}

// In UseFetchDataAsync, the await keyword waits for FetchDataAsync to complete before continuing to the next line of code.