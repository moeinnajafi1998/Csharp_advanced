// In C#, memory management involves two primary areas: stack and heap memory. 
// Understanding how these two memory types work is crucial for writing efficient and performant code. 
// Let’s break down their roles, how they are managed, and how they differ from each other.

// 1. Stack Memory
// Characteristics:

// Storage: Stack memory is used for storing value types and the references (pointers) to objects in heap memory.
// Size and Allocation: Stack memory is typically much smaller than heap memory and is fixed in size. Memory allocation on the stack is done automatically when a function is called and is also freed automatically when the function exits.
// Access Speed: Access to stack memory is very fast because it is a simple, organized structure with a Last-In-First-Out (LIFO) order. The memory is contiguous, which allows for quick allocation and deallocation.
// Lifetime: Variables stored on the stack are automatically destroyed once they go out of scope (e.g., when a method finishes executing).

// Example:
void Method()
{
    int x = 10;  // Stored on the stack
    int y = 20;  // Stored on the stack
}  // x and y are automatically removed from the stack here

// Usage:
// Local variables (like int, float, char, etc.)
// Method call stack (stores return addresses, parameters, and local variables)
// Structs (since they are value types)

// 2. Heap Memory
// Characteristics:

// Storage: Heap memory is used for storing reference types, like objects, arrays, and instances of classes.
// Size and Allocation: The heap is larger and can grow in size as needed. Allocation on the heap is more flexible but requires manual management via garbage collection.
// Access Speed: Accessing heap memory is slower than stack memory due to its dynamic nature and the need for reference lookups.
// Lifetime: Objects on the heap remain in memory until they are explicitly freed or garbage collected when no longer in use.

// Example:
void Method()
{
    Person person = new Person();  // The object is stored on the heap, the reference is stored on the stack
}  // The reference is removed from the stack, but the object remains on the heap until garbage collected

// Usage:
// Objects (instances of classes)
// Arrays (since they are objects in C#)
// Large structures that exceed stack size limits
// 3. Key Differences
// Lifetime: Stack memory is automatically managed and cleaned up once a function scope ends, whereas heap memory requires garbage collection.
// Allocation/Deallocation: Stack is managed through a LIFO structure, making it simple and fast. Heap allocation is more complex and is managed by the .NET runtime’s garbage collector.
// Size: Stack is limited and can lead to stack overflow if overused (e.g., deep recursion), while the heap is larger but not infinite, and overuse can lead to out-of-memory exceptions.
// Data Types: Value types are stored on the stack, while reference types are stored on the heap (though their references are on the stack).
// 4. Garbage Collection
// Role in Heap Management: C# uses a garbage collector to manage heap memory. It automatically identifies objects that are no longer in use and frees the memory, reducing the chances of memory leaks.
// 5. Performance Considerations
// Stack: Prefer using value types (which are stack-allocated) for performance-critical sections of code where speed is essential.
// Heap: Use reference types for large or complex objects, but be mindful of the overhead due to garbage collection and potential memory fragmentation.
// Understanding the distinction between stack and heap memory in C# is fundamental for optimizing memory usage and ensuring the efficiency of your applications.