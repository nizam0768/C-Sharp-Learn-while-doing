**NET Interview: Junior Level**
1. [What is the Common Intermediate Language CIL?](#What-is-the-Common-Intermediate-Language-CIL)
2. [What is the Common Language Runtime CLR?](#What-is-the-Common-Language-Runtime-CLR)
3. [What is the difference between C sharp and Dot NET?](#What-is-the-difference-between-C-sharp-and-Dot-NET)
4. [What is the difference between value types and reference types?](#What-is-the-difference-between-value-types-and-reference-types)
5. [What is boxing and unboxing?](#What-is-boxing-and-unboxing)
6. [What-are-the-three-maintypes-of-errors?](#What-are-the-three-main-types-of-errors)
7. [How-Are-Exceptions-Handled-in-C-sharp?](#How-Are-Exceptions-Handled-in-C-sharp)
8. [Types-of-Access-Modifiers-in-C-sharp](#Types-of-Access-Modifiers-in-C-sharp)
9. [What is the Purpose of the sealed Modifier in C sharp?](#What-is-the-Purpose-of-the-sealed-Modifier-in-C-sharp?)
10. [What is the Purpose of the params Keyword in C sharp?](#What-is-the-Purpose-of-the-params-Keyword-in-C-sharp)
11. [Difference Between a Class and a Struct in C sharp?](#Difference-Between-a-Class-and-a-Struct-in-C-sharp)
12. [What does the new keyword do?](#What-does-the-new-keyword-do)
13. [Concurrency-vs-Multithreading-in-C-sharp?](#Concurrency-vs-Multithreading-in-C-sharp)
14. [What is the difference between a class and a struct?](#What-is-the-difference-between-a-class-and-a-struct)
15. [What are Partial Classes?](#What-are-Partial-Classes)
16. [What is the Purpose of the static Keyword?](#What-is-the-Purpose-of-the-static-Keyword)
17. [What is the purpose of the ternary conditional operator?](#What-is-the-purpose-of-the-ternary-conditional-operator)
18. [What is the purpose of the null coalescing and null conditional operator?](#What-is-the-purpose-of-the-null-coalescing-and-null-conditional-operator)
19. [What is encapsulation?](#What-is-encapsulation)
20. [What is LINQ?](#What-is-LINQ)
21. [What are extension methods?](#What-are-extension-methods)
22. [What is IEnumerable?](#What-is-IEnumerable)
23. [What is the difference between the equality operator and Equals?](#What-is-the-difference-between-the-equality-operator-and-Equals)
24. [What is the difference between deep copy and shallow copy?](#What-is-the-difference-between-deep-copy-and-shallow-copy)
25. [What is the Garbage Collector?](#What-is-the-Garbage-Collector)
26. [What are nullable types?](#What-are-nullable-types)
27. [What is a property?](#What-is-a-property)
28. [What are generics?](#What-are-generics)
29. [What is the difference between the const and the readonly modifiers?](#What-is-the-difference-between-the-const-and-the-readonly-modifiers)
30. [What is the difference between the ref and the out keywords?](#What-is-the-difference-between-the-ref-and-the-out-keywords)
31. [What is the difference between an interface and an abstract class?](#What-is-the-difference-between-an-interface-and-an-abstract-class)
32. [.What is polymorphism?](#.What-is-polymorphism)
###  What is the Common Intermediate Language CIL?

## Common Intermediate Language (CIL)

Common Intermediate Language, often abbreviated as CIL, is the low-level, platform-independent instruction set into which all .NET languages—such as C#, VB.NET, or F#—are compiled.

When writing code in C#, the compiler does not directly translate it into machine code. Instead, it compiles the code into CIL, which is stored in an assembly (DLL or EXE). At runtime, the Just-In-Time (JIT) compiler of the .NET Common Language Runtime (CLR) takes this CIL and compiles it into native machine code specific to the operating system and hardware architecture.

This two-step compilation process provides multiple key advantages:

- **Language Interoperability:** Since all .NET languages compile down to the same CIL, different languages can seamlessly work together in the same application.
- **Portability:** The same CIL code can run on different platforms, provided a suitable CLR exists for that platform.
- **Security and Optimization:** CIL enables the CLR to enforce code access security, verify code safety, and apply runtime optimizations to improve performance.

This architecture is fundamental to the .NET ecosystem, supporting its cross-language and cross-platform capabilities.

---

### What is the Common Language Runtime CLR?

## Common Language Runtime (CLR)

The Common Language Runtime (CLR) is the execution engine of the .NET framework and serves as the heart of the .NET architecture. It provides the environment in which .NET applications run and manages the execution of code written in different .NET languages.

When writing C# code, it is first compiled into Common Intermediate Language (CIL). At runtime, the CLR uses the Just-In-Time (JIT) compiler to translate this CIL into native machine code that the CPU can execute.

Beyond executing code, the CLR offers a rich set of services, including:

- **Memory Management & Garbage Collection (GC):** Automatically handles memory allocation and cleanup, reducing memory leaks.
- **Type Safety:** Ensures code adheres to defined data types, preventing unsafe operations.
- **Exception Handling:** Provides a structured way to handle runtime errors across multiple languages.
- **Security:** Enforces code access security (CAS) and verifies CIL before execution to maintain safety.
- **Interoperability:** Enables managed code to interact seamlessly with unmanaged code (such as COM objects and native DLLs).
- **Language Interoperability:** Since all .NET languages compile into CIL, the CLR ensures they can work together seamlessly within the same application.

Understanding the CLR is essential for developing robust, secure, and performant .NET applications, as it provides the core runtime environment that brings .NET programs to life.

---

###  What is the difference between C sharp and Dot NET?

## C#

C# (pronounced "C-sharp") is a programming language developed by Microsoft. It is object-oriented, type-safe, and modern, featuring capabilities like LINQ, async/await, generics, and pattern matching. C# itself is a language specification—it defines syntax and semantics but does not execute on its own.

## .NET

.NET is a software development framework and platform that provides the runtime (CLR), libraries, and tools needed to build and run applications written in C#, VB.NET, F#, and other supported languages. It includes the Base Class Library (BCL), the runtime environment (CLR), and various APIs for file handling, networking, databases, web development (ASP.NET), and more.

.NET has evolved from the original .NET Framework to .NET Core and now unified into .NET 5+ which is cross-platform, supporting Windows, Linux, macOS, and even mobile platforms through MAUI and Xamarin.

## Simple Analogy

Think of **C#** as the language you use to write instructions.

Think of **.NET** as the ecosystem (the engine, tools, and libraries) that makes those instructions executable.

---

### What is the difference between value types and reference types?

## Value Types vs Reference Types

### Value Types:
- Stored directly on the **stack** (for local variables).
- Hold the **actual value**.
- Each variable has its **own copy**,
  so changes in one variable do **not** affect another.
- **Examples:** `int`, `float`, `bool`, `struct`, `enum`.

### Reference Types:
- Stored on the **heap**, 
  but the variable holds a **reference (pointer)** to the actual object.
- Multiple variables can point to the **same object**,
  so changes in one are **visible to others**.
- **Examples:** `class`, `object`, `string`, `array`, `delegate`.

---

### What is boxing and unboxing?

## Boxing and Unboxing

### Boxing:
- The process of converting a **value type** into a **reference type** 
  (specifically into an `object` or an interface it implements).
- The value type is wrapped ("boxed") inside a reference type object and stored on the **heap**.

### Unboxing:
- The reverse process — extracting the **value type** from the **reference type**.
- This requires an **explicit cast**.

  ### Code Example:
    ```csharp
       // Boxing
      int num = 42;            // Value type
      object obj = num;        // Boxing: num is stored as an object on the heap
      
      // Unboxing
      int unboxedNum = (int)obj; // Unboxing: extracting back into a value type

### Key Points to Remember:
- Boxing is **implicit**, but unboxing is **explicit** (needs casting).
- Boxing/unboxing has **performance costs**, because:
  - Boxing allocates memory on the **heap**.
  - Unboxing requires type checking and copying the value back.
- Frequent boxing/unboxing in performance-critical code should be avoided.  
  Instead, use **generics** to reduce it.

### Real-Life Analogy:
- Think of a value type (like `int`) as a **book**.
- Boxing: Putting the book inside a **box** (object) to ship it.
- Unboxing: Taking the book out of the box to read it again.

---

### What are the three main types of errors?

## Three Main Types of Errors in Programming

### 1. Compilation Errors
- Also known as **syntax errors**.
- Occur when the program code violates the language's syntax rules.
- Detected by the compiler **before** the program runs.
- Examples: missing semicolons, misspelled keywords, incorrect language constructs.
- The compiler reports these errors, and the program will **not compile** until they are fixed.

### 2. Runtime Errors
- Occur during program execution **after successful compilation**.
- Caused by exceptional conditions like dividing by zero, accessing invalid array indexes, or null reference exceptions.
- Typically throw exceptions that can be caught and handled.
- Examples: `DivideByZeroException`, `NullReferenceException`, `IndexOutOfRangeException`.

### 3. Logical Errors
- Occur when the program runs without crashing but produces incorrect or unintended results.
- Caused by flawed logic or incorrect algorithm implementation.
- Hardest to detect because the program appears to run normally.
- Example: Using incorrect formulas or wrong conditional checks leading to wrong output.

> Understanding these error types is fundamental to debugging and writing robust code in C# or any programming language.

---

### How Are Exceptions Handled in C sharp?

- Exceptions in C# are handled using a structured mechanism involving the keywords:  
  `try`, `catch`, `finally`, and optionally `throw`.
  
- **try block:**  
  Encloses code that might throw an exception. The runtime monitors this code for errors.
  
- **catch block:**  
  Handles exceptions thrown inside the corresponding `try` block. Multiple `catch` blocks can be used to handle different exception types specifically.
  
- **finally block:**  
  Contains code that runs **regardless** of whether an exception occurs or not, usually for cleanup actions like closing files or releasing resources.
  
- **throw statement:**  
  Used to explicitly raise an exception or re-throw a caught exception, preserving the original stack trace.

  ### Syntax Example:
    ```csharp
        try
        {
            // Code that may throw exceptions
        }
        catch (ExceptionType1 ex1)
        {
            // Handle ExceptionType1
        }
        catch (ExceptionType2 ex2)
        {
            // Handle ExceptionType2
        }
        catch (Exception ex)
        {
            // Handle all other exceptions
        }
        finally
        {
            // Code that always executes (cleanup)
        }

### Key Points:
- When an exception occurs, the control jumps immediately to the appropriate `catch` block.
- If no matching `catch` block is found, the program terminates.
- The `finally` block always executes, even if no exception occurs or if one is re-thrown.
- Specific exception types should be caught before more general ones.
- Re-throw exceptions using `throw;` to preserve the original stack trace.

This exception handling model promotes writing robust and maintainable C# applications by managing errors gracefully during runtime.

---

### Types of Access Modifiers in C sharp

- **Public**  
  The type or member can be used by any other type from **any assembly**.  
  Accessible everywhere.

- **Internal**  
  The type or member can be used by any type from the **same assembly** it is defined in.  
  Not accessible outside this assembly.

- **Protected**  
  The type or member can be used only in the **same class** or in a **derived class** (no matter which assembly).

- **Protected Internal**  
  - Within the same assembly, acts like **internal** (accessible to all types).  
  - Outside the assembly, acts like **protected** (accessible only to derived classes).

- **Private Protected**  
  - Within the same assembly, acts like **protected** (accessible only in declaring class or derived classes).  
  - Outside the assembly, this member is **not accessible**, even to derived classes.

- **Private**  
  The type or member can be used **only within the same class** where it is declared.

---

**Summary Table:**

| Access Modifier      | Same Class | Derived Class | Same Assembly | Other Assemblies |
|---------------------|------------|---------------|---------------|------------------|
| Public              | Yes        | Yes           | Yes           | Yes              |
| Internal            | Yes        | Yes           | Yes           | No               |
| Protected           | Yes        | Yes           | No            | No               |
| Protected Internal  | Yes        | Yes           | Yes           | Yes (only derived classes) |
| Private Protected   | Yes        | Yes (same assembly) | Yes       | No               |
| Private             | Yes        | No            | No            | No               |

This clear structure helps understand how accessibility varies across different contexts in C# programming.  

---

### What is the Purpose of the sealed Modifier in C sharp?

- The `sealed` modifier in C# is used to **prevent inheritance**.
- When a class is marked as **sealed**, it **cannot be inherited** by any other class.
- This is useful to **lock down the class design** and prevent unintended or unauthorized extension.
- A **sealed method** is a method that **cannot be overridden** by derived classes.
- Sealed members enforce **strict control** over how classes and methods are extended and modified.

### Why Use `sealed`?

  - To **protect the behavior** and implementation of a class or method.
  - To **ensure stability** by preventing changes through inheritance.
  - To allow certain **runtime optimizations** by the compiler.
  - To **signal clear intent** to other developers that the class or method is not designed for extension.

     ## Example of a Sealed Class:
       ```csharp
        sealed class Animal
        {
        public void MakeSound()
        {
        Console.WriteLine("Generic animal sound");
        }
        }
        
        // The following will cause a compilation error:
        // class Dog : Animal {}
       
        --sealed method
       
        class BaseClass
        {
        public virtual void Display()
        {
        Console.WriteLine("Base Display");
        }
        }
        
        class DerivedClass : BaseClass
        {
        public sealed override void Display()
        {
        Console.WriteLine("Derived Display");
        }
        }
      
      // Any further override attempts will cause a compilation error.

In summary, the `sealed` modifier is a tool to control inheritance and method overriding, helping maintain code integrity and reliability.

---

### What is the Purpose of the params Keyword in C sharp?

- The `params` keyword allows a method to accept a **variable number of arguments** of the same type.
- It simplifies method calls by letting you pass multiple arguments without explicitly creating an array.
- The parameter with `params` must be the **last** parameter in the method signature.
- The parameter type must be a **single-dimensional array**.

### Benefits
- Enables flexibility when the number of arguments is unknown or varies.
- Makes method calls cleaner and more readable.
- Avoids multiple overloads for methods that accept different numbers of parameters.

  ### Syntax Example
    ```csharp
      public void PrintNumbers(params int[] numbers)
      {
      foreach (int number in numbers)
      {
      Console.WriteLine(number);
      }
      }
    
     --Usage Example
    
      PrintNumbers(1, 2, 3, 4); // Pass multiple arguments without creating an array
      PrintNumbers(); // Allowed, no arguments passed means an empty array
      int[] nums = { 5, 6, 7 };
      PrintNumbers(nums); // Can also pass an array explicitly

### Key Points to Remember
- Only one `params` keyword is allowed per method.
- It must be the **last parameter** in the method declaration.
- If no arguments are passed, the `params` parameter is treated as an **empty array**.
- Useful for APIs where flexibility in the number of arguments improves usability and code clarity.

This keyword enhances method design by allowing variable-length input in a clean and efficient way.

---

### Difference Between a Class and a Struct in C sharp?

| Aspect                  | Class                                       | Struct                                      |
|-------------------------|---------------------------------------------|---------------------------------------------|
| **Type**                | Reference type                              | Value type                                  |
| **Memory Allocation**   | Allocated on the **heap**                    | Allocated on the **stack**                   |
| **Inheritance**         | Supports inheritance (can inherit and be inherited) | Does **not** support inheritance            |
| **Default Constructor** | Has a default constructor                    | Does **not** have a parameterless default constructor |
| **Instantiation**       | Created using the `new` keyword              | Can be instantiated **with or without** `new` |
| **Copy Behavior**       | Copies the reference (two variables refer to the same object) | Copies the actual data (each variable has its own copy) |
| **Nullability**         | Can be `null`                                | Cannot be `null`                            |
| **Use Case**            | Suitable for complex objects with identity, behavior, and polymorphism | Suitable for small, simple data containers |
| **Performance**         | Slightly slower due to heap allocation and garbage collection | Faster because of stack allocation and less overhead |
| **Polymorphism**        | Supports polymorphism (virtual, abstract)   | Does **not** support polymorphism          |

### Summary:
- **Classes** are for more complex data and behavior, enabling inheritance and usage in larger applications.
- **Structs** are lightweight, best for small data structures that benefit from high performance and copy-by-value semantics.
- Choosing between them depends on usage scenarios, performance considerations, and object design.

  ### Example:
     ```csharp
        // Class example
        class Person
        {
        public string Name;
        }
        
        // Struct example
        struct Point
        {
        public int X;
        public int Y;
        }
  
> Understanding these differences is critical in designing efficient and maintainable C# applications.

---

### What Does the new Keyword Do in C sharp?

- The `new` keyword is used to **create instances of types**, typically objects of classes or arrays.
- It **allocates memory** on the **heap** for reference types and calls the constructor to initialize the object.
- For value types (structs), using `new` initializes the instance by calling the default constructor, but memory allocation might happen on the stack or inlined depending on scope.
- Without `new`, reference type variables only hold a null reference and do **not** point to an object.
- `new` is **mandatory** when creating objects of classes in C# to properly allocate memory and initialize the object.
- It distinguishes **object instantiation** from variable declaration.

  ### Example:
    ```csharp
       // Declaration without 'new' - reference is null
      Car car1;
      
      // Using 'new' to create an instance, allocates memory and calls constructor
      Car car2 = new Car();
      
      // For structs, 'new' initializes all fields
      Point p = new Point();
  
### Key Points:
- `new` signals that a **new object** or **array** is created with allocated memory.
- It’s essential for **reference types**, optional but recommended for **value types**.
- Enables constructor invocation and ensures objects are properly initialized.

> In summary, `new` is the operator that creates and initializes objects allowing the program to use them safely.

---

### Concurrency vs Multithreading in C sharp?

## 📌 Concurrency
- **Definition**: Concurrency means handling multiple tasks at the same time **conceptually**, but not necessarily executing them simultaneously.  
- In C#, concurrency is often achieved with **asynchronous programming** (`async`/`await`, `Task`, `Task<T>`).  
- It’s about **task switching efficiently** — while one task is waiting (e.g., for I/O), the CPU can work on another.  

**Use Cases:**
- Making multiple API calls without blocking the main thread.  
- Reading from a file while also updating the UI.  

👉 Concurrency = *Dealing with lots of things at once.*

---

## 📌 Multithreading
- **Definition**: Multithreading means executing multiple threads in **parallel** on different CPU cores (or time-sliced on the same core).  
- In C#, you can create and manage threads using:  
  - `Thread` class  
  - `ThreadPool`  
  - `Task.Run()` (wraps thread-pool threads)  
- It’s about **parallel execution of code**.  

**Use Cases:**
- Running CPU-intensive operations like image processing or complex calculations.  
- Handling multiple clients in a server application simultaneously.  

👉 Multithreading = *Doing lots of things at the same time (true parallelism when hardware allows).*

---

## 🔑 Key Differences

| Aspect | Concurrency | Multithreading |
|--------|-------------|----------------|
| **Concept** | Ability to deal with multiple tasks logically at the same time | Actual parallel execution of code on multiple threads |
| **Execution** | Not necessarily parallel; often task switching | Truly parallel (if multiple cores available) |
| **C# Mechanism** | `async/await`, `Task`, I/O-bound operations | `Thread`, `ThreadPool`, `Task.Run`, `Parallel.For`, `PLINQ` |
| **Use Case** | Best for I/O-bound operations (network calls, DB queries, file reads) | Best for CPU-bound operations (math, processing, compression) |
| **Resource Usage** | More efficient (fewer threads, less memory) | Can be resource-heavy (thread context switching) |

---

### What is the difference between a class and a struct?

### Brief Summary
1. Structs are value types, and classes are reference types.  
2. Structs can only have constructors with parameters, and all fields must be assigned in this constructor.  
3. Structs cannot have explicit parameterless constructors.  
4. Structs cannot have destructors (finalizers).  

---

### Key Differences

- **Structs are value types**  
  - Inherit from `System.ValueType`  
  - Passed by copy (assignment or parameter passing creates a new copy)  
  - Sealed (cannot be inherited)  
  - Stored on the stack  

- **Classes are reference types**  
  - Inherit from `System.Object`  
  - Passed by reference (assignment or parameter passing passes the address)  
  - Can support inheritance (not sealed by default)  
  - Stored on the heap  

---

### Constructor and Destructor Rules
- Structs:
  - Can only have constructors **with parameters**.
  - Must initialize all fields in the constructor.
  - Cannot have explicit parameterless constructors.
  - Cannot have destructors.

- Classes:
  - Can have parameterless constructors.
  - Can have destructors (finalizers).
  - Fields do not need to be initialized in the constructor.

---

### Why Structs Cannot Have Destructors
Structs are value types, so every copy of a struct is independent.  
If structs had destructors, each copy created (by method calls, assignments, etc.) would potentially call the destructor and interfere with resources (e.g., closing a database connection). This could invalidate other copies of the struct, leading to unexpected behavior.  
Hence, **structs do not support destructors**.

---

### When to Use Structs
Structs are best used when:
- The type is **logically small** (e.g., represents a single value like `int`, `double`, `bool`).  
- The size is **small in memory** (less than 16 bytes).  
- The type is **immutable** (state does not change after creation).  
- The type is **short-lived**.  
- The type is commonly **embedded inside other objects**.  
- You need **value type semantics** (copy on assignment).  
- The type will **not be frequently boxed**.

If these criteria are not met, you should generally prefer using a **class**.

---

### Common Interview Questions on Struct vs Class
- **What is the base type for structs?**  
  `System.ValueType`

- **Can a struct be inherited?**  
  No, all structs are sealed.

- **How would you represent a point in the Cartesian coordinate system?**  
  By creating a struct with two `readonly float` properties: `X` and `Y`.

---

### What are Partial Classes?

### Definition
A **partial class** in C# allows the definition of a single class to be split across two or more files within the same namespace and assembly. The `partial` keyword is used in each part. At compile time, the compiler combines all parts into a single class.

---

### Key Points

- Declared with the `partial` keyword.
- All parts must use the same class name and namespace.
- All parts must have the same accessibility (e.g., `public`, `private`).
- Used mainly to separate auto-generated code (like UI designer files) from user-written code, making large projects easier to maintain.
- Supports the definition of fields, methods, properties, events, and nested classes.
- Cannot be used with enums or delegates.
- Often used in scenarios with designer-generated code (Windows Forms, ASP.NET, code generators) and when multiple developers collaborate on a class.

---

**File 1: Employee_BusinessLogic.cs**
  
    ```csharp
        public partial class Employee
        {
        public void CalculatePay()
        {
        // Implementation of pay calculation
        }
        }
---

**File 2: Employee_DataAccess.cs**
  
    ```csharp
    public partial class Employee
    {
    public void Load()
    {
    // Implementation of data loading
    }
    }

At compile-time, both files are merged, resulting in a single `Employee` class with both methods.

---

### Why Use Partial Classes?

- Keep related code separate (e.g., business logic vs. UI logic).
- Make it easier for teams to work simultaneously on different class features.
- Avoid modifying generated code files directly — custom code can live in its own file.
- Reduces merge conflicts and improves code organization.

---

### Limitations

| Limitation                                   | Description                                  |
|----------------------------------------------|----------------------------------------------|
| Same assembly & namespace required           | All parts must be in the same assembly/namespace. |
| Only at compile-time                         | The splitting is only at the source code, not at runtime. |
| Cannot define the same member in two parts   | Doing so will lead to a compile error.       |
| Not for enums or delegates                   | Only classes, structs, and interfaces supported. |

---

### Typical Use Cases

- Separating auto-generated code from developer-written code.
- Large codebases where different features are managed by different teams.
- Codebases using source generators or tools that scaffold partial classes.

---

### What is the Purpose of the static Keyword?

# The `static` Keyword in C#

## 📌 Definition
The `static` keyword in C# is used to declare **members (fields, methods, properties, constructors, classes, etc.)** that belong to the **type itself** rather than to a specific instance of the type.  

- A **non-static member** belongs to an **object (instance)**.  
- A **static member** belongs to the **class itself**.  

---

## 📌 Key Points About `static`

1. **Static Members**
   - Belong to the class, not objects.  
   - Can be accessed using the **class name** directly.  
   - Example: `Math.Sqrt(25)`.  

2. **Static Classes**
   - Declared with the `static` keyword.  
   - Cannot be instantiated (`new` is not allowed).  
   - Can only contain static members.  
   - Examples: `System.Console`, `System.Math`.  

3. **Static Constructors**
   - Used to initialize static data.  
   - Executed **only once**, automatically, before the first use of the class.  
   - Cannot have parameters or access modifiers.  

4. **Restrictions**
   - Static classes cannot be inherited.  
   - Static methods cannot access instance members directly (no `this` reference).  
   - Instance methods **can** access static members.  

---

 ## 💻 Example

    ```csharp
    public class Calculator
    {
        public static double Pi = 3.14159; // static field
    
        public static double Square(double number) // static method
        {
            return number * number;
        }
    }
    
    class Program
    {
        static void Main()
        {
            // Access static members without creating an object
            Console.WriteLine(Calculator.Pi);        // Output: 3.14159
            Console.WriteLine(Calculator.Square(5)); // Output: 25
        }
    }

---

# Static Class in C#

## 📌 Definition
A **static class** in C# is a class that is declared with the `static` keyword and **cannot be instantiated**.  
- It can contain only **static members** (fields, methods, properties, constructors, etc.).  
- The CLR ensures the class is loaded into memory **only once**.  

---

## 📌 Characteristics of a Static Class
1. **Cannot be instantiated**  
   - You cannot use `new` to create an object of a static class.  
   - Example: `new Math(); // ❌ not allowed`  

2. **Contains only static members**  
   - All fields, properties, and methods inside must be `static`.  

3. **No inheritance**  
   - A static class cannot be inherited or serve as a base class.  

4. **Static constructor**  
   - Can have a static constructor that initializes data **only once** when the class is first accessed.  

5. **Performance**  
   - Slightly faster access since no object instance is created.  

---

  ## 💻 Example

    ```csharp
    public static class MathHelper
    {
        public static double Pi = 3.14159;
    
        public static double Square(double number)
        {
            return number * number;
        }
    
        static MathHelper() // Static constructor
        {
            Console.WriteLine("Static class initialized!");
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine(MathHelper.Pi);        // Output: 3.14159
            Console.WriteLine(MathHelper.Square(4)); // Output: 16
        }
    }

---

### What is the purpose of the ternary conditional operator?

It's a shorter syntax for the if-else clause. It evaluates a boolean expression and returns the result of one of the two expressions, depending on whether the boolean expression evaluates to true or false

 var value = boolean expression ? value if true : value if false

 This is why this operator is called a ternary operator- because it needs three
 operands

- "Can a ternary operator always be translated to an if-else statement?"
 Yes. The ternary operator is just a shorter syntax for if-else statements.

- "Can an if-else statement always be translated to a ternary operator?"
 No. The ternary operator can only be used with an assignment to a variable, so
 we can't use it, for example, to call Console.WriteLine method with some
 argument if the condition is true, and with another, if it is false
 
---

### What is the purpose of the null coalescing and null conditional operator?

  ## Null coalescing operator and null coalescing assignment operator
    The null coalescing and null conditional operators allow us to perform some operations if a value is null, and others if it's not.
    It is a typical example when we wanttodosomethingifthevalue is not null, and if it is null, we want to do something else - possibly use some kind of default.
     var result = value ?? Some default is "value" is null

  ## Null conditional operator:
     It is a typical example when we wanttodosomethingifthevalue is not null, and if it is null, we want to do something else - possibly use some kind of default.
     The null coalescing operator returns the left-hand operand if its' value is not null, otherwise, it returns the right-hand operand. The general pattern looks like this:
      var result = value ?? Some default is "value" is null

---

### What is encapsulation?
Encapsulation is one of the fundamental concepts of object-oriented programming. "It means bundling of data with the methods that operate on that data." The term comes from the word "capsule" because we can think of it as the data and the methods are enclosed in a capsule together.

<img width="497" height="394" alt="image" src="https://github.com/user-attachments/assets/72107fcd-4333-46f2-a211-56393f912edb" />

---

### What is LINQ?

LINQ is a set of technologies that allow simple and efficient querying over different kinds of data.

<img width="263" height="77" alt="image" src="https://github.com/user-attachments/assets/76bbb199-69c5-4c11-b1bc-5397aee1d018" />

---

### What are extension methods?

An extension method is a method defined outside a class, that can be called upon this class's objects as a regular member method. Extension methods allow you to add new functionality to a class without modifying it.

<img width="328" height="254" alt="image" src="https://github.com/user-attachments/assets/04790cca-2b82-4a71-848b-1b8c2da75d72" />

---

###  What is IEnumerable?
 IEnumerable is an interface that enables iterating over a collection with a foreach loop.
 -  It allows looping over collections with a foreach loop.
 -  t works with LINQ query expressions.
 -  It allows read-only access to a collection.

 ##  "What is an enumerator?"
  An enumerator is a mechanism that allows iterating over collection elements.
  It's a kind of a pointer that points to a "current" element in the collection.

 ##  "Assuming a method returns a collection of some kind, how to best express your intent if you don't want the user to modify this collection?"
 By returning it as IEnumerable or another readonly collection type.

 ---

 ### What is the difference between the equality operator and Equals?
 In C#, the difference between == and .Equals() changes slightly because of how the language handles operator overloading.  Here is the precise C# answer:

 - The Core Difference
   By default, == compares reference identity, while .Equals() compares structural value. However, == can be overloaded to    compare values, whereas .Equals() is a virtual method designed for polymorphic override.

 - The Details That Matter
   - The == Operator (Reference/Static):
     - By default for reference types, it checks if both references point to the same object in memory.
     - Crucial C# Detail: It is a statically bound operator. The compiler decides which == to use based on the compile-    time type, not the runtime type.

 - The .Equals() Method (Value/Dynamic):
   - By default, it behaves like ==, but it is designed to be overridden in custom classes (like a Customer class) to  compare internal property values.
   - Crucial C# Detail: It is a virtual method (or implemented via IEquatable<T>). It uses virtual method dispatch, meaning it evaluates the actual runtime type of the object.

The "Must-Know" C# Exceptions
   - Strings: In C#, the == operator is explicitly overloaded for the string class to compare the text content, making string1 == string2 behave exactly like a value comparison.
   - Structs (Value Types): You cannot use == on a custom struct unless you explicitly overload the operator. You must use .Equals(), which uses reflection by default (though overriding it is recommended for performance).

---

### What is the difference between deep copy and shallow copy?
- The Core Difference
  - A shallow copy duplicates the object, but copies the references to its nested objects. A deep copy duplicates the object and all nested objects recursively, creating a completely independent clone.
- The Details That Matter
  Shallow Copy (MemberwiseClone):
   - It creates a new instance of the object.
   - Value type fields (like int, bool) are copied directly.
   - Reference type fields (like classes or lists) just have their memory address copied. Both the original and the copy  now point to the exact same nested object in memory.
   - Modifying a nested object in the copy will change the original object.

- Deep Copy:
  - It creates a new instance of the object and new instances of all nested reference types.
  - It untangles the two objects completely.
  - Modifying any part of the deep copy will not affect the original object.
- How to Implement It in C#
  - For Shallow Copy: C# provides a built-in protected method called MemberwiseClone(). You typically wrap this in a custom Clone() method.
  - For Deep Copy: There is no built-in "magic button." You must implement it yourself. The most common enterprise approaches are:
    - Manual Cloning: Instantiating new nested objects and mapping properties one by one (best performance).
    - Serialization: Serializing the object to JSON (using JsonSerializer) and immediately deserializing it back into a new object (easiest to write, slight performance overhead).

---

### What is the Garbage Collector?

- The Core Difference
  - The Garbage Collector (GC) is .NET’s automatic memory management engine. It automatically allocates and releases memory for your application, primarily managed on the Garbage Collected Heap.

- The Details That Matter
  - How It Works (The 3 Phases):
    - Marking: The GC traverses the application roots (static variables, local variables currently on the stack, CPU registers) to identify all live objects.
    - Relocating: It updates the references to the objects that will be moved during compaction.
    - Compacting: It reclaims the dead memory and shifts the surviving live objects together to eliminate memory fragmentation, updating their pointers accordingly.

- The Generational Pipeline (Performance Optimization):
The heap is divided into three generations based on the assumption that "newer objects have shorter lifetimes":

  - Generation 0: Holds short-lived objects (e.g., local variables). This is the smallest and most frequently collected generation.
  - Generation 1: Acts as a buffer between short-lived and long-lived objects.
  - Generation 2: Holds long-lived objects (e.g., static data, singletons). Collected infrequently because it is performance-heavy.
  - Note: Large objects (over 85,000 bytes) go directly into a special Large Object Heap (LOH), which is treated as Gen 2 but is rarely compacted due to the high CPU cost of moving large memory blocks.

Key Interview Distinction: Managed vs. Unmanaged Resources
 - Managed Resources: Memory handled entirely by the GC (e.g., C# class instances, strings, arrays). You do not need to free these manually.
 - Unmanaged Resources: Resources outside the .NET runtime (e.g., file handles, database connections, network sockets, OS windows). The GC does not know how to clean these up.
 - The Solution: To prevent leaks, classes holding unmanaged resources must implement the IDisposable interface and its Dispose() method, typically wrapped in a using statement.

Why It Matters (The Impact)
While the GC prevents classic memory leaks (like dangling pointers in C++), poor coding practices—such as holding onto static references indefinitely or causing frequent Gen 2 collections—can lead to "GC Pauses." This freezes the application threads and degrades system performance.

--- 

### What are nullable types?
- The Core Difference
  - By default, value types (like int or bool) cannot be null. Nullable types allow value types to represent a missing or undefined state. Additionally, modern C# introduces Nullable Reference Types to catch null-pointer exceptions at compile time.
- The Details That Matter
  1. Nullable Value Types (Nullable<T> or T?)
     - Used exclusively for value types (structs, enums, primitives).
     - Under the hood, int? is syntactic sugar for the System.Nullable<T> struct.
     - It wraps the value and exposes two key properties:
       - .HasValue: A bool indicating if a value exists.
       - .Value: Retrieves the actual value (throws an InvalidOperationException if the value is null).
     - Often used when mapping database columns that allow NULL to C# variables.
  2. Nullable Reference Types (NRT)
     - Reference types (like string or custom classes) are inherently allowed to be null.
     - However, starting in C# 8, enabling the Nullable Reference Types feature changes how the compiler treats them:
       - string x; is treated as non-nullable. The compiler will warn you if you try to assign null to it.
       - string? x; is explicitly marked as nullable.
     - Crucial Interview Point: This is a compiler-enforced safety feature, not a runtime change. It generates build-time warnings to prevent the dreaded NullReferenceException.
- Operators You Must Mention
When working with nullable types, the interviewer will expect you to know these three operators:
  - Null-coalescing operator (??): Provides a fallback value if the left side is null.
int result = myNullableInt ?? 0;
  - Null-coalescing assignment (??=): Assigns a value only if the variable is currently null.
myClass ??= new MyClass();
  - Null-conditional operator (?.): Short-circuits and returns null if the object is null, preventing a crash.
int? length = customer?.Name?.Length;

Why It Matters (The Impact)
Properly using nullable value types aligns your C# domain models cleanly with relational databases. Simultaneously, adopting Nullable Reference Types shifts the discovery of null bugs from production runtime crashes to compile-time warnings, significantly improving code reliability.

---

### What is a property?
- The Core Definition
  - A property is a class member that provides a flexible mechanism to read, write, or compute the value of a private field. It exposes data like a public variable, but under the hood, it uses special methods called "accessors" (get and set) to enforce encapsulation.

- The Details That Matter
  - The Backing Field: Properties act as wrappers around a private variable, known as the backing field. This allows you to validate or modify data before it enters or leaves the class.
  - Auto-Implemented Properties: If you don't need custom logic, you use auto-properties (public int Id { get; set; }). The C# compiler automatically creates a hidden private backing field for you at compile time.
  - Access Modifiers: You can restrict access to individual accessors. For example, public string Name { get; private set; } means anyone can read the name, but only the class itself can change it.

- Key Features to Mention (Show Seniority)
  - Expression-Bodied Members: For read-only properties that compute a value, use modern expression syntax:
public string FullName => $"{FirstName} {LastName}";
  - Init-Only Setters (init): Replaces set to allow a property to be assigned only during object creation (initialization), making the object immutable thereafter: public int Id { get; init; }
- Why Not Just Use Public Fields? (The Impact)
An interviewer will often ask, "Why not just use a public variable?" You use properties because:
  - Validation: You can add logic to a set accessor to reject invalid data (e.g., throwing an exception if Age < 0).
  - Data Binding: Many framework features (like WPF, EF Core, or Blazor) strictly require properties to bind data to user interfaces or databases; they cannot bind to raw fields.
  - Future-Proofing: Changing a public field to a property later breaks binary compatibility for external applications relying on your DLL. Starting with a property ensures your API contract remains stable.

---

### What are generics?
- The Core Definition
  - Generics allow you to write classes, interfaces, and methods with a placeholder (parameter) for the data type. This decouples your logic from the specific data type, deferring type specification until the code is actually declared and instantiated.
- The Details That Matter
To understand why generics are essential, look at how we handled collections before they existed (e.g., using ArrayList vs. List<T>):
  - Type Safety: Without generics, an ArrayList stores everything as an object. You can accidentally add an int and a string to the same list, which causes runtime crashes. With generics (List<int>), the compiler enforces that only integers can be added, catching errors at compile time.
  - Performance (No Boxing/Unboxing): When storing value types (like int or structs) as an object, the runtime must "box" it (move it from the stack to the managed heap). Retrieving it requires "unboxing". Generics eliminate this overhead completely because the CLR generates concrete, type-specific code at runtime.
- Advanced Concept: Generic Constraints (where)
Interviewers love to ask how you limit what types can be passed into a generic class or method. In C#, you use the where keyword:
<img width="1088" height="180" alt="image" src="https://github.com/user-attachments/assets/23ef51fe-66b6-449b-9c67-eaa31851032a" />

- Common constraints include:
  - where T : struct (Must be a value type)
  - where T : class (Must be a reference type)
  - where T : MyBaseClass (Must derive from a specific base class)
- Why It Matters (The Impact)
Generics prevent code duplication. Instead of creating an IntegerRepository, a StringRepository, and a CustomerRepository with identical logic, you write a single Repository<T>. This keeps your codebase DRY (Don't Repeat Yourself), highly performant, and completely type-safe.

---

### What is the difference between the const and the readonly modifiers?
const is a compile-time constant whose value is baked directly into the application's IL code, whereas readonly is a runtime constant whose value is evaluated and set when the program executes.
<img width="532" height="312" alt="image" src="https://github.com/user-attachments/assets/94505da2-930d-42b8-babc-7df9249c9fd4" />
- The "Version Break" Bug (Show Seniority)
Interviewers love to ask about the architectural risk of const.

Imagine you build a shared library (DLL) with a const value: public const int MaxUsers = 100;. When another team references your DLL, the compiler grabs that 100 and bakes it directly into their code.

If you update your DLL later to change MaxUsers = 200 and deploy just your DLL, the other team's app will still use 100 until they recompile their code. If you use readonly instead, their app will dynamically fetch the new value from your DLL at runtime without needing a recompile.

- Why It Matters (The Impact)
  - Use const for unchangeable mathematical constants, configurations, or physics truths (e.g., const double Pi = 3.14159).
  - Use readonly when the value depends on a runtime condition (like a database connection string from an appsettings.json file) or when dealing with complex object configurations.

---

### What is the difference between the ref and the out keywords?
- The Core Difference
  Both keywords cause arguments to be passed by reference rather than by value. The difference lies in initialization requirements: ref requires the variable to be initialized before passing it into the method, while out allows uninitialized variables but forces the method to assign a value before it returns.

- The Details That Matter
  The ref Keyword (Two-Way Data Highway):
  - Caller Obligation: The variable must be explicitly initialized before calling the method.
  - Callee (Method) Obligation: The method reading the parameter can instantly read it, modify it, or completely ignore it. It is not required to write a new value.
  - Best For: Scenarios where you need to read and update an existing state (e.g., a custom Swap(ref int a, ref int b) method).
- The out Keyword (One-Way Exit Only):
  - Caller Obligation: The variable can be declared right inside the method call argument list without initialization (e.g., out var result).
  - Callee (Method) Obligation: The method must assign a valid value to this parameter along all execution code paths before the method finishes execution. Failing to do so causes a compilation error.
  - Best For: Returning multiple values from a single method.
- Crucial C# Under-the-Hood Nuance
  - Method Overloading: You cannot overload a method where the only difference is one takes ref and the other takes out (e.g., void Process(ref int x) and void Process(out int x) will throw a compile error). Under the hood, the IL code treats them identically as reference pointers.
  - Modern Alternative: In modern C#, if your goal is just to return multiple values from a method, Tuples (public (bool Success, int Value) MyMethod()) are widely preferred over out variables because they produce cleaner, more functional code.

Why It Matters (The Impact)
Using ref and out incorrectly can bypass safety guardrails or create rigid code. Knowing out allows the common .TryParse() pattern (like int.TryParse(input, out int value)) to run completely safely without crashing your application on bad string data.

---

### What is the difference between an interface and an abstract class?
- The Core Difference
An abstract class defines an identity (what an object is), allowing you to share code and state across a single inheritance hierarchy. An interface defines a contract (what an object can do), allowing completely unrelated classes to implement identical behavior.
   <img width="524" height="350" alt="image" src="https://github.com/user-attachments/assets/50684ca3-446e-460b-bfec-b7c30cb3268c" />

- Crucial C# Evolution (Show Seniority)
Interviewers love to check if your knowledge is up-to-date with modern .NET. You must mention Default Interface Methods (DIMs) introduced in C# 8:
  - Historically, adding a new method to an interface would break every single class that implemented it.
  - Now, you can provide a default concrete implementation directly inside an interface:
    <img width="401" height="89" alt="image" src="https://github.com/user-attachments/assets/287463df-e7d7-4868-9ecb-141f8b149177" />
  - The Interview Catch: While interfaces can now have behavior like abstract classes, they still cannot hold instance state (fields).
When to Use Which? (The Impact)
  - Use an Abstract Class when building a closely related family of objects where you want to provide common, ready-to-use functionality (e.g., a base Shape class with concrete properties like Color and Position, inherited by Circle and Square).
  - Use an Interface when you want to enforce a specific capability across completely disconnected classes (e.g., ISerializable or IDisposable). A User class and a DatabaseConnection class are completely unrelated, but they can both implement IDisposable.

---

### What is polymorphism?
- The Core Definition
Polymorphism—meaning "many forms"—is the ability of different classes to respond to the same method call in their own unique way. It allows you to treat derived objects as if they were instances of their parent base type or interface, making code highly extensible.

The Details That Matter
In C#, polymorphism is split into two primary categories that you must distinguish:

1. Compile-Time Polymorphism (Static Binding)
   - This is achieved using Method Overloading.
   - It allows a single class to have multiple methods with the exact same name but different signatures (different parameter types or counts).
   - Why it's "static": The compiler determines exactly which method overload to execute at compile time based on the arguments you pass in.

2. Runtime Polymorphism (Dynamic Binding)
   - This is achieved using Method Overriding (via inheritance or interfaces).
   - A derived class provides a specific implementation of a method that is already defined in its base class using the virtual and override keywords.
   - Why it's "dynamic": The .NET CLR resolves which method to execute at runtime based on the actual runtime type of the object, using virtual method dispatch.
   <img width="529" height="257" alt="image" src="https://github.com/user-attachments/assets/b08fa59e-8257-438b-8e84-e93b7b0532c6" />
   
- Why It Matters (The Impact)
Polymorphism allows you to adhere to the Open/Closed Principle (the 'O' in SOLID). You can write high-level code that processes a list of Animal objects without needing to know their specific types. If tomorrow you add a Cat or a Bird class, your existing business logic won't need a single modification to support them; they will inherently execute their own overridden behavior.

---





