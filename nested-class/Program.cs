// In C#, nested classes are classes defined within other classes. 
// They allow for a way to logically group classes that are only used in one place, 
// encapsulate the nested class from the outside world, and maintain a strong relationship between the nested class and the outer class.
// Here's an overview of nested classes in C#:

// 1. Definition and Structure
// A nested class is a class that is declared inside another class. 
// The containing class is referred to as the "outer class," and the class within it is the "nested class."

public class OuterClass
{
    public class NestedClass
    {
        // Members of the nested class
    }

    // Members of the outer class
}

// 2. Access Modifiers
// A nested class can have any access modifier (public, private, protected, internal, protected internal, private protected). 
// The accessibility of the nested class is relative to the outer class.

// private: The nested class is only accessible within the outer class.
// public: The nested class is accessible from outside the outer class.
// protected: The nested class is accessible from the outer class and its derived classes.
// internal: The nested class is accessible within the same assembly.
public class OuterClass2
{
    private class NestedClass
    {
        // Accessible only within OuterClass
    }
}

// 3. Access to Outer Class Members
// A nested class has access to the members (both static and instance) of the outer class, 
// including private members, even though it might be private itself. 
// This allows the nested class to act as a helper for the outer class.
public class OuterClass3
{
    private int outerField = 10;

    public class NestedClass
    {
        public void AccessOuterClassMember()
        {
            OuterClass3 outer = new OuterClass3();
            Console.WriteLine(outer.outerField); // Accessing private member of OuterClass
        }
    }
}

// 4. Instantiation
// To instantiate a nested class, you typically need an instance of the outer class unless the nested class is static.

// Non-static nested class:
// OuterClass outer = new OuterClass();
// OuterClass.NestedClass nested = new OuterClass.NestedClass();

// Static nested class:
// public class OuterClass
// {
//     public static class NestedClass
//     {
//         // Members of static nested class
//     }
// }

// // Instantiation
// OuterClass.NestedClass nested = new OuterClass.NestedClass();


// 5. Use Cases
// Encapsulation: Nested classes can be used to encapsulate helper classes that are not needed outside the context of the outer class.
// Logical Grouping: If a class is only relevant to the outer class, nesting it helps in logically grouping related classes together.
// Type Hiding: Nested classes can be hidden from other classes, reducing the scope of exposure and potential misuse.

// 6. Static Nested Classes
// A static nested class can only contain static members. It is commonly used when the nested class does not need to access the instance members of the outer class.

public class OuterClass4
{
    public static class NestedStaticClass
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello from NestedStaticClass");
        }
    }
}




class Program{
    static void Main(){
        // Usage
        OuterClass4.NestedStaticClass.DisplayMessage();
    }
}



// 7. Limitations
// Outer Class Dependencies: A nested class can tightly couple with its outer class, leading to potential maintenance challenges.
// Complexity: Overusing nested classes can make the code harder to read and maintain.