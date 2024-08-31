// Operator overloading in C# allows you to define or alter the behavior of operators for user-defined types (such as classes and structs). 
// This enables objects of those types to interact using standard operators like +, -, *, /, ==, !=, etc., in a way that is consistent with their intended use.
// Key Points of Operator Overloading in C#
// Syntax:

// To overload an operator in C#, you define a static method in your class or struct, which uses the operator keyword followed by the operator you wish to overload.
// The return type of the method should match the result of the operation.

// public static returnType operator operatorSymbol(parameters)
// {
//     // Implementation
// }

// Supported Operators:

// C# supports overloading of most of the standard operators, 
// including arithmetic (+, -, *, /, %), comparison (==, !=, <, >, <=, >=), and even some logical (&&, ||, !) and bitwise operators (&, |, ^, <<, >>).
// However, you cannot overload certain operators like &&, ||, and ? :, but you can overload their bitwise counterparts.
// Unary and Binary Operators:

// Unary operators take a single operand (e.g., +, -, !), while binary operators take two (e.g., +, -, *, /).
// Operator Pairs:

// Certain operators must be overloaded in pairs. 
// For example, if you overload ==, you should also overload !=. Similarly, if you overload <, you should also overload >.

// Example: Overloading the + operator for a Complex number class.
public class Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Overloading the == operator
    public static bool operator ==(Complex c1, Complex c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    // Overloading the != operator
    public static bool operator !=(Complex c1, Complex c2)
    {
        return !(c1 == c2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Complex other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (Real, Imaginary).GetHashCode();
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

// Usage
class Program{
    static void Main(){
        Complex c1 = new Complex(2, 3);
        Complex c2 = new Complex(1, 4);
        Complex result = c1 + c2; // result is 3 + 7i
        Console.WriteLine(result);
        bool isEqual = c1 == c2;  // isEqual is false
        Console.WriteLine(isEqual);
    }
}




// Best Practices:

// Ensure that overloaded operators behave intuitively and consistently.
// Overload operators in pairs (e.g., == and !=) to maintain logical consistency.
// Override the Equals and GetHashCode methods when overloading == and !=.
// Restrictions:

// Not all operators can be overloaded.
// You cannot create new operators—only existing ones can be overloaded.
// Advantages of Operator Overloading
// Readability: It allows code to be more intuitive and readable when dealing with complex data types.
// Consistency: You can define how your objects interact in a consistent and expected manner, making the code easier to maintain and understand.
// Potential Pitfalls
// Misuse: Overloading operators in a way that is non-intuitive or inconsistent with common usage can make the code confusing.
// Complexity: Overloaded operators can sometimes obscure what the code is doing, leading to hidden bugs.
// By carefully designing operator overloads, you can greatly enhance the expressiveness and clarity of your C# programs.