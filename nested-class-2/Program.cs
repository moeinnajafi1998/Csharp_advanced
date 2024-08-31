// 8. Example in Real-world Scenarios
// A common real-world example is implementing a tree structure where nodes are represented by a nested class inside a Tree class:

public class Tree
{
    public class Node
    {
        public int? Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }

    public Node? Root { get; set; }

    // Tree operations here
}
// This allows the Node class to be encapsulated within the Tree class, as it's only relevant in the context of a tree structure.

// 9. Example with private Nested Class
public class OuterClass
{
    private class NestedClass
    {
        public void NestedMethod()
        {
            Console.WriteLine("Hello from the nested class!");
        }
    }

    public void OuterMethod()
    {
        NestedClass nested = new NestedClass();
        nested.NestedMethod();
    }
}


class Program{
    static void Main(){
        // Usage
        OuterClass outer = new OuterClass();
        outer.OuterMethod();
        // In this example, NestedClass is private, so it's only accessible from within OuterClass.
    }
}

