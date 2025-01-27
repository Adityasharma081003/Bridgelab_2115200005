feature-22-1-25 


Introduction to C# C# is just a simple, secure, robust, portable, platform-independent, architectural neutral, multithreaded, object-oriented programming language with a strong type exception handling mechanism for developing different kinds of applications such as Web, Windows Form, Console, Web Services, Mobile Apps, etc.C# was created by Microsoft in the early 2000s as part of its .NET initiative.

Abstraction from Hardware: C# abstracts away the details of the computer's hardware, making it easier to write and understand code. 
2. Platform Independence: C# programs are compiled into Intermediate Language (IL) and run on any device with the .NET runtime (CLR), adhering to the "Write Once, Run Anywhere" principle. 
3. Advanced Features: C# provides extensive libraries and frameworks for various tasks, supports object-oriented programming, and handles memory management with automatic garbage collection. 
4. Ease of Use: C# has a human-readable syntax, strong error-checking, and powerful development tools that enhance productivity and simplify complex tasks.

feature-23-1-25

CLR :The Common Language Runtime (CLR) is a core component of .NET Framework that manages the execution and the lifecycle of all .NET applications (code). It provides various services, including automatic memory management, exception handling, security, and type safety. When a .NET application is compiled, it generates an intermediate language code called Common Intermediate Language (CIL). The CLR is responsible for translating this CIL into machine code and managing the execution of the resulting program. The CLR also provides a platform for interoperability between different programming languages that target the .NET Framework. This means that a program written in one .NET language can easily use libraries written in another .



CIL is a low-level, platform-independent intermediate code used in the .NET framework. When you write and compile C# code, it gets converted into CIL by the C# compiler. This intermediate code is then executed by the Common Language Runtime (CLR).

Key Features:

Platform-Independent: CIL allows .NET applications to run on multiple platforms by being compiled into machine code specific to the platform at runtime using the Just-In-Time (JIT) compiler.
Type-Safe: CIL enforces type safety, ensuring reliable and secure execution.
Language Interoperability: Any .NET-supported language (e.g., C#, VB.NET, F#) compiles into CIL, enabling cross-language compatibility.
Managed Execution: It benefits from the CLR's features like garbage collection, exception handling, and runtime type checking.

feature-24-1-25

The data type which stores the value directly in the memory is called the Value Data Type in C#. The examples are int, char, boolean, and float which store numbers, alphabets, true/false, and floating-point numbers respectively. 
Primitive Value Types:
Numeric Types:
int: 32-bit signed integer.
long: 64-bit signed integer.
short: 16-bit signed integer.
byte: 8-bit unsigned integer.
float: 32-bit floating-point (7 digits precision).
double: 64-bit floating-point (15-16 digits precision).
char: Single 16-bit Unicode character.
bool: Boolean values (true or false).

Access Modifiers

1.public	The code is accessible for all classes
2.private	The code is only accessible within the same class
3.protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
4.internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
5.protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
6.private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
 
Type Conversion:

Implicit Conversion
Definition: Automatic type conversion performed by the compiler.

Characteristics:

No data loss occurs during conversion.
Happens between compatible types.
Does not require explicit syntax.

Explicit Conversion (Type Casting)
Definition: Conversion that requires explicit syntax because it might result in data loss or a runtime exception.

Syntax: Use the cast operator (type).













