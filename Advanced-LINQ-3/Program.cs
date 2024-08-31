// 3. Custom LINQ Operators
// Custom LINQ operators allow you to extend the LINQ library by creating your own query methods. 
// These are typically implemented as extension methods on IEnumerable<T> or IQueryable<T>.

// Example: Custom Filter Operator:
public static class LINQExtensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}



class Program{
    public static void Main(){
        // Usage
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.Filter(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
                

    }
}
// In this example, we create a custom Filter operator that works similarly to Where, allowing us to filter a collection based on a predicate.