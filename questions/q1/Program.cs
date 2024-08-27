// In C#, static and final are concepts that are used to define how classes and their members behave.
// However, it's worth noting that C# doesn't have a final keyword for classes.
// Instead, it uses sealed for a similar purpose. Let's break down both static and sealed:

// Static Classes
// A static class in C# is a class that cannot be instantiated, meaning you cannot create objects of this class. It's designed to hold static members only. Here are some key points about static classes:

// Declaration: A static class is declared using the static keyword.
public static class MathUtilities
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Instantiation: You cannot create an instance of a static class. The members are accessed directly via the class name.
// Members: All members of a static class must be static. You cannot have instance members in a static class.
// Inheritance: A static class cannot be inherited, nor can it inherit from another class (except for object).
// Usage: Static classes are often used to group utility functions or constants.




// Sealed Classes
// A sealed class is a class that cannot be inherited.
// This is useful when you want to prevent other classes from extending a class and potentially altering its behavior. Here are some key points about sealed classes:

// Declaration: A sealed class is declared using the sealed keyword.
public sealed class FinalClass
{
    public void DisplayMessage()
    {
        Console.WriteLine("This class cannot be inherited.");
    }
}
// Inheritance: You cannot create a subclass from a sealed class. Attempting to do so will result in a compilation error
// Usage: Sealed classes are often used to ensure that certain classes remain as they are, without modification through inheritance.
class Program{
    static void Main(string[] args){
        int result = MathUtilities.Add(5, 3);
        Console.WriteLine(result);

    }
}