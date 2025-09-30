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
13. []

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

# Concurrency vs Multithreading in C#

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

## 💻 Code Examples
## Concurrency (I/O-bound: `async/await`)
   ```csharp
      // Example of concurrency
      public async Task FetchDataAsync()
      {
          var task1 = GetDataFromApiAsync("url1");
          var task2 = GetDataFromApiAsync("url2");
      
          await Task.WhenAll(task1, task2); 
          // Concurrent but not necessarily multiple threads
      }

---


















