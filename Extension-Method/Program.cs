// In C#, an extension method is a special kind of static method that allows you to "add" new methods to existing types without modifying the original type or creating a new derived type. 
// Extension methods are defined in a static class, and they must be static themselves.

// Key Features of Extension Methods:
// Static Method in a Static Class: Extension methods are static methods that reside in a static class.
// this Keyword: The first parameter of an extension method defines the type that the method is extending, and it is prefixed with the this keyword.
// Invoked Like an Instance Method: Once defined, extension methods can be called as if they were instance methods on the extended type.
// Example:
// Let's say you want to add a method called WordCount to the string class, which counts the number of words in a string.
public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return 0;

        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}

class Program
{
    static void Main()
    {
        string sentence = "Hello, welcome to the world of C#";
        int wordCount = sentence.WordCount(); // This calls the extension method
        Console.WriteLine($"Word count: {wordCount}");
    }
}

// How it Works:
// The WordCount method appears to be a part of the string class when you call it, 
// but it's actually an extension method defined in a separate static class StringExtensions.
// The this keyword in the method definition tells the compiler that this method is an extension method, and the type it extends is string.
// Considerations:
// Namespace: For the extension methods to be available, the namespace of the static class must be included with a using directive.
// Performance: Extension methods do not change the underlying type and are as performant as static method calls.
// Discovery: Intellisense in Visual Studio will show extension methods as available methods when you work with the extended type.
// Extension methods are very useful when you want to add functionality to types that you do not have control over, such as those in the .NET Framework or third-party libraries.