// 3. Handling Exceptions
// Exceptions in asynchronous methods can be caught using try-catch blocks. For example:

class Program{
    static void Main(){
        SafeFetchDataAsync();
        Console.ReadKey();
    }
    public static async void SafeFetchDataAsync()
    {
        try
        {
            int result = await FetchDataAsync();
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
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
