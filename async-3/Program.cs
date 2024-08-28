// Async and Await in Practice
// Asynchronous programming is particularly useful for I/O-bound operations, such as web requests or file operations. 
// Here’s a more practical example involving an HTTP request:


public async Task<string> GetWebPageContentAsync(string url)
{
    using HttpClient client = new HttpClient();
    string content = await client.GetStringAsync(url);
    return content;
}


// 5. Parallelism vs. Asynchronous Programming
// It's important to differentiate between parallelism and asynchronous programming. 
// Parallelism involves running multiple tasks concurrently to utilize multiple cores, 
// while asynchronous programming focuses on managing operations that are not CPU-bound (like I/O operations) to avoid blocking.

// 6. ConfigureAwait
// By default, await will attempt to resume on the original context (e.g., the UI thread in a desktop app). 
// In some cases, you might not need to resume on the original context, and you can use ConfigureAwait(false):

public async Task ProcessDataAsync()
{
    await SomeOperationAsync().ConfigureAwait(false);
    // Continue work that does not need to be on the original context
}


// 7. Task.Run for CPU-bound Work
// For CPU-bound operations, you can use Task.Run to run code on a background thread:

public async Task<int> ComputeHeavyOperationAsync()
{
    return await Task.Run(() =>
    {
        // Simulate a CPU-bound operation
        int result = 0;
        for (int i = 0; i < 1000000; i++)
        {
            result += i;
        }
        return result;
    });
}