using System;
using System.Buffers.Text;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Runtime.Intrinsics.X86;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;

namespace Day10_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem01
            // Implement a sorting algorithm using the SortingAlgorithm<T> class for an array of
            // Employee objects based on their salary in ascending order.

            //Employee[] employee =
            //{
            //    new Employee(3, "Ahmed", 3000),
            //    new Employee(2, "Doaa", 2000),
            //    new Employee(4, "Noha", 4000),
            //    new Employee(1, "ALI", 1000),
            //    new Employee(5, "Khaled", 5000)
            //};

            //Console.WriteLine("Before Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}
            //SortingAlgorithm<Employee>.Sort(employee);
            //Console.WriteLine("=====================================================");
            //Console.WriteLine("After Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}

            // =====================================================================================

            // What are the benefits of using a generic sorting algorithm over a non-generic one?

            /**
             * 1. Reusability: The same sorting algorithm can be used for different data types.
             * 2. Type Safety: The compiler can catch type mismatches at compile time.
             * 3. Performance: Generics are faster than non-generics because they do not require boxing and unboxing.
             * 4. Code Clarity: Generics make the code more readable and maintainable.
             */
            #endregion

            #region Problem02
            // Modify the SortingTwo<T>.Sort method to dynamically sort integers in descending order
            // using a lambda expression.

            //int[] arr = { 5, 3, 8, 1, 2, 9, 4, 7, 6 };
            //Console.WriteLine("Before Sorting");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //SortingDelegate<int>.Sort(arr, (a, b) => a < b);

            //Console.WriteLine("After Sorting");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            // =====================================================================================

            // How do lambda expressions improve the readability and flexibility of sorting methods?

            /**
             * Lambda expressions improve the readability and flexibility of sorting methods by
             * allowing the sorting logic to be defined inline without the need to create a separate
             * method or delegate. This makes the code more concise and easier to understand.
             */

            #endregion

            #region Problem03
            // Write a comparer function to sort strings based on their length in ascending order using
            // SortingTwo<T>.Sort.

            //string[] names = { "AbdelRahmaan", "Ali", "Ahmed", "moazz", "hosssam" };
            //Console.WriteLine("before sorting");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //SortingDelegate<string>.Sort(names, (a, b) => a.Length > b.Length);
            //Console.WriteLine("after sorting");
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //=======================================================================================================

            // Why is it important to use a dynamic comparer function when sorting objects of various
            // data types?

            /**
             * It is important to use a dynamic comparer function when sorting objects of various data types
             * because it allows the sorting logic to be customized based on the specific properties or
             * characteristics of the objects being sorted. This flexibility ensures that the sorting algorithm
             * can be adapted to handle different types of data and sorting requirements without the need to
             * modify the underlying sorting algorithm.
             */

            #endregion

            #region Problem04
            // Add a new class Manager that inherits from Employee and implements
            // IComparable<Manager>.Update the sorting logic to include Manager objects and
            // compare by Salary. 

            //Manager[] managers = 
            //{
            //    new Manager(3, "Doaa", 3000),
            //    new Manager(5, "Khaled", 5000),
            //    new Manager(2, "Ali", 2000),
            //    new Manager(4, "Noha", 4000),
            //    new Manager(1, "Ahmed", 1000)
            //};

            //Console.WriteLine("Before Sorting");
            //Console.WriteLine("---------------");
            //foreach (var item in managers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===========================================");
            //Console.WriteLine("After Sorting");
            //Console.WriteLine("---------------");
            //SortingAlgorithm<Manager>.Sort(managers);
            //foreach (var item in managers)
            //{
            //    Console.WriteLine(item);
            //}

            // =====================================================================================

            // How does implementing IComparable<T> in derived classes enable custom sorting?
            /**
             * Implementing IComparable<T> in derived classes enables custom sorting by allowing the
             * derived class to define its own comparison logic based on its specific properties or
             * characteristics. This flexibility allows the sorting algorithm to compare objects of
             * different types and sort them according to the desired criteria, such as salary in the
             * case of the Manager class.
             */

            #endregion

            #region Problem05
            // Create a delegate Func<T, T, bool> to compare Employee objects based on their Name
            // length and sort an array of employees.

            //Employee[] employees =
            //{
            //    new Employee(3, "Ahmed", 3000),
            //    new Employee(2, "Doaa", 2000),
            //    new Employee(4, "Noha", 4000),
            //    new Employee(1, "Ali", 1000),
            //    new Employee(5, "Khaled", 5000)
            //};

            //Console.WriteLine("Before Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            //SortingDelegate<Employee>.Sort2(employees, (a, b) => a.Name.Length > b.Name.Length);

            //Console.WriteLine("=====================================================");

            //Console.WriteLine("After Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            // =====================================================================================

            // What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming ?

            /**
             * The advantage of using built-in delegates like Func<T, T, TResult> in generic programming is
             * that it provides a standardized way to define and pass comparison logic to generic methods.
             * This makes the code more readable and maintainable, as developers can easily understand the
             * purpose of the delegate and its parameters based on the standard naming conventions.
             */

            #endregion

            #region Problem06
            // Use an anonymous function to sort an integer array in ascending order. Demonstrate the
            // same logic with a lambda expression. 

            //int[] arr = { 5, 3, 8, 1, 2, 9, 4, 7, 6 };
            //// Using an anonymous function
            //var compareAnonymous = delegate (int x, int y)
            //{
            //    return x > y;
            //};
            //SortingDelegate<int>.Sort2(arr, compareAnonymous);

            //Console.WriteLine("After Sorting with Anonymous Function");
            //Console.WriteLine("---------------");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //// Using a lambda expression
            //SortingDelegate<int>.Sort2(arr, (a, b) => a > b);

            //Console.WriteLine("After Sorting with Lambda Expression");
            //Console.WriteLine("---------------");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            // =========================================================================================

            //How does the usage of anonymous functions differ from lambda expressions in terms of
            // readability and efficiency ?

            /**
             * Anonymous functions and lambda expressions are similar in that they both allow inline
             * definition of code blocks, but they differ in terms of readability and efficiency.
             * 
             * Readability: Lambda expressions are more concise and easier to read than anonymous functions
             * because they use a more compact syntax and do not require the 'delegate' keyword.
             * 
             * Efficiency: Lambda expressions are more efficient than anonymous functions because they are
             * compiled as static methods, which can be cached and reused, whereas anonymous functions are
             * compiled as instance methods, which require additional memory and processing overhead.
             */

            #endregion

            #region Problem07
            //Enhance the SortingAlgorithm<T> class by implementing a standalone generic method
            // Swap<T> and demonstrate swapping elements of an integer array.

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before Swapping:");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //SortingAlgorithm<int>.Swap(ref arr[1], ref arr[3]);

            //Console.WriteLine("After Swapping:");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            // =========================================================================================

            //Why is the use of generic methods beneficial when creating utility functions like Swap?

            /**
             * The use of generic methods is beneficial when creating utility functions like Swap because
             * it allows the function to be reused with different data types without the need to duplicate
             * the code for each type. This improves code reusability, readability, and maintainability by
             * reducing the amount of boilerplate code that needs to be written and maintained.
             */


            #endregion

            #region Problem08
            // Extend SortingTwo<T>.Sort to sort Employee objects first by Salary, and in case of ties,
            // by Name using a custom comparer.

            //Employee[] employees =
            //{
            //    new Employee(3, "Ahmed", 3000),
            //    new Employee(2, "Doaa", 3000),
            //    new Employee(4, "Noha", 4000),
            //    new Employee(1, "Ali", 1000),
            //    new Employee(5, "Khaled", 1000)
            //};

            //Console.WriteLine("Before Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //SortingDelegate<Employee>.Sort(employees, SortingFunctions.sort_2stp);

            //Console.WriteLine("After Sorting");
            //Console.WriteLine("---------------");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            // =========================================================================================
            //What are the challenges and benefits of implementing multi-criteria sorting logic in
            // generic methods?

            /**
             * Challenges:
             * 1. Complexity: Implementing multi-criteria sorting logic can increase the complexity of the
             * sorting algorithm, making it harder to understand and maintain.
             * 2. Performance: Sorting based on multiple criteria may require additional comparisons and
             * operations, which can impact the performance of the sorting algorithm.
             * 3. Customization: Implementing multi-criteria sorting logic may require custom comparers or
             * delegates, which can be challenging to define and manage.
             * 
             * Benefits:
             * 1. Flexibility: Multi-criteria sorting logic allows for more fine-grained control over the
             * sorting process, enabling developers to sort objects based on multiple properties or characteristics.
             * 2. Customization: Developers can define custom comparers or delegates to implement complex sorting
             * logic tailored to the specific requirements of the application.
             * 3. Reusability: Once implemented, multi-criteria sorting logic can be reused across different data
             * types and scenarios, reducing the need to duplicate code.
             */

            #endregion

            #region problem09
            // Write a method GetDefault that uses default(T) to return the default value of generic
            // types and demonstrate its use with value types and reference types.

            //Console.WriteLine("Default value of int: " + GetDefault<int>());
            //Console.WriteLine("Default value of string: " + GetDefault<string>());
            //Console.WriteLine("Default value of Employee: " + GetDefault<Employee>());

            // =========================================================================================    

            //Why is the default(T) keyword crucial in generic programming, and how does it handle value and reference types differently ?

            /**
             * The default(T) keyword is crucial in generic programming because it allows developers to
             * obtain the default value of a generic type T, which can be useful for initializing variables,
             * handling null values, and providing default behavior for generic methods and classes.
             * 
             * Default(T) handles value and reference types differently:
             * 
             * 1. Value Types: For value types, default(T) returns the default value of the type, which is
             * typically zero or an equivalent value (e.g., 0 for int, false for bool, null for nullable types).
             * 
             * 2. Reference Types: For reference types, default(T) returns null, which is the default value for
             * reference types. This allows developers to handle null references and uninitialized objects in a
             * consistent manner across different data types.
             */

            #endregion

            #region Problem10
            // Add a constraint to the SortingAlgorithm<T> class to ensure T implements ICloneable.
            // Demonstrate cloning an Employee array before sorting it. 

            // Employee[] employees =
            //{
            //     new Employee(3, "Ahmed", 3000),
            //     new Employee(2, "Doaa", 3000),
            //     new Employee(4, "Noha", 4000),
            //     new Employee(1, "Ali", 1000),
            //     new Employee(5, "Khaled", 1000)
            // };

            // Console.WriteLine("Before Cloning and Sorting");
            // Console.WriteLine("---------------");
            // foreach (var emp in employees)
            // {
            //     Console.WriteLine(emp);
            // }

            // Employee[] ClonedEmployeeArray = SortingAlgorithm<Employee>.CloneArray(employees);
            // SortingAlgorithm<Employee>.Sort2(ClonedEmployeeArray, (a, b) => a.Salary > b.Salary);

            // Console.WriteLine("After Cloning and Sorting");
            // Console.WriteLine("---------------");
            // foreach (var emp in ClonedEmployeeArray)
            // {
            //     Console.WriteLine(emp);
            // }
            // ==================================================================================================

            // How do constraints in generic programming ensure type safety and improve the
            // reliability of generic methods?

            /**
             * Constraints in generic programming ensure type safety and improve the reliability of generic
             * methods by restricting the types that can be used with the generic method to those that meet
             * specific criteria or implement certain interfaces. This helps prevent runtime errors and
             * exceptions by enforcing compile-time checks on the generic type arguments, ensuring that they
             * support the operations and behaviors required by the generic method.
             */

            #endregion

            #region Problem11
            // Create a delegate that takes a string and returns a string. Implement a function that
            //applies this delegate to each element in a list of strings and returns the transformed list.
            //Test with different transformations like converting to uppercase, reversing the string, etc. 


            //List<string> strings = new List<string> { "hello", "world", "CSharp", "programming" };

            //// Convert to uppercase
            //List<string> upperCaseStrings = DelegateOperations.TransformStrings(strings, s => s.ToUpper());
            //Console.WriteLine("Uppercase Transformation:");
            //foreach (var item in upperCaseStrings)
            //{
            //    Console.WriteLine(item);
            //}

            //// Reverse the string
            //List<string> reversedStrings = DelegateOperations.TransformStrings(strings, s => new string(s.Reverse().ToArray()));
            //Console.WriteLine("Reversed Transformation:");
            //foreach (var item in reversedStrings)
            //{
            //    Console.WriteLine(item);
            //}

            // =========================================================================================
            // What are the benefits of using delegates for string transformations in a functional
            // programming style?

            /**
             * The benefits of using delegates for string transformations in a functional programming style
             * include:
             * 
             * 1. Reusability: Delegates allow the transformation logic to be defined once and reused with
             * different input data, making the code more modular and maintainable.
             * 
             * 2. Flexibility: Delegates provide a way to define custom transformation logic inline, allowing
             * developers to easily adapt the transformation process to different requirements and scenarios.
             * 
             * 3. Readability: Functional programming style with delegates can make the code more concise and
             * easier to understand, as the transformation logic is defined in a clear and declarative manner.
             */
            #endregion

            #region Problem12
            //Create a delegate that takes two integers and returns an integer. Implement a function that
            //takes two integers and a delegate and performs the operation defined by the delegate.
            //Test with different operations like addition, subtraction, multiplication, and division.

            //MathOperation add = (a, b) => a + b;
            //MathOperation subtract = (a, b) => a - b;
            //MathOperation multiply = (a, b) => a * b;
            //MathOperation divide = (a, b) => b != 0 ? a / b : 0;

            //Console.WriteLine("Addition: " + DelegateOperations.PerformMathOperation(10, 5, add));
            //Console.WriteLine("Subtraction: " + DelegateOperations.PerformMathOperation(10, 5, subtract));
            //Console.WriteLine("Multiplication: " + DelegateOperations.PerformMathOperation(10, 5, multiply));
            //Console.WriteLine("Division: " + DelegateOperations.PerformMathOperation(10, 5, divide));

            // =========================================================================================

            //How does the use of delegates promote code reusability and flexibility in implementing
            // mathematical operations?

            /**
             * The use of delegates promotes code reusability and flexibility in implementing mathematical
             * operations by allowing the operation logic to be defined separately from the calling code.
             * This separation of concerns enables the same operation logic to be reused with different input
             * values and scenarios, making the code more modular and maintainable. Delegates also provide a
             * way to define custom operation logic inline, allowing developers to easily adapt the operation
             * process to different requirements and scenarios without modifying the underlying algorithm.
             */

            #endregion

            #region Problem13
            //Define a generic delegate that takes a parameter of type T and returns a value of type R.
            //Implement a function that transforms a list of type T into a list of type R using this
            //delegate.Test with different transformations like converting a list of integers to their
            //string representations. 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.GetType());
            //List<string> stringNumbers = DelegateOperations.ConvertList(numbers, n => n.ToString());
            //Console.WriteLine(stringNumbers.GetType());

            //=================================================================================================

            //What are the advantages of using generic delegates in transforming data structures?

            /**
             * The advantages of using generic delegates in transforming data structures include:
             * 
             * 1. Reusability: Generic delegates allow the transformation logic to be defined once and reused
             * with different data types, making the code more modular and maintainable.
             * 
             * 2. Flexibility: Generic delegates provide a way to define custom transformation logic inline,
             * allowing developers to easily adapt the transformation process to different requirements and
             * scenarios without modifying the underlying algorithm.
             * 
             * 3. Type Safety: Generic delegates ensure type safety by enforcing compile-time checks on the
             * input and output types, preventing runtime errors and exceptions due to type mismatches.
             */

            #endregion

            #region Problem14
            //Use Func<T, TResult> to create a delegate that takes an integer and returns its square.
            //Implement a function that applies this delegate to each element in a list of integers and
            //returns the list of results. 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Func<int, int> SquareFunc = x => x * x;
            //List<int> SquaredNumbers = DelegateOperations.FunctionToList(numbers, SquareFunc);

            //foreach (var item in SquaredNumbers)
            //{
            //    Console.WriteLine(item);
            //}


            // =========================================================================================

            //How does Func simplify the creation and usage of delegates in C#?

            /**
             * Func simplifies the creation and usage of delegates in C# by providing a standardized way to
             * define and pass function-like logic to methods and functions. Func allows developers to define
             * the input and output types of the delegate using a simple and intuitive syntax, making it easier
             * to understand and use in code. Func also eliminates the need to define custom delegate types for
             * common scenarios, reducing the amount of boilerplate code that needs to be written and maintained.
             */

            #endregion

            #region Problem15
            //Use Action<T> to create a delegate that takes a string and prints it to the console.
            //Implement a function that takes a list of strings and an Action<string> delegate and
            //applies the action to each string in the list.

            //List<string> strings = new List<string> { "hello", "world", "CSharp", "programming", "DEPI" };
            //Action<string> PrintString = s => Console.WriteLine(s);
            //DelegateOperations.ActionToList(strings, PrintString);


            // =========================================================================================

            //Why is Action preferred for operations that do not return values?

            /**
             * Action is preferred for operations that do not return values because it provides a standardized
             * way to define and pass void methods or functions to other methods or functions. Action simplifies
             * the syntax for defining and using delegates that perform side effects or actions without returning
             * a value, making the code more readable and maintainable. Action also eliminates the need to define
             * custom delegate types for common scenarios, reducing the amount of boilerplate code that needs to be
             * written and maintained.
             */

            #endregion

            #region Problem16
            //Use Predicate<T> to create a delegate that checks if an integer is even.Implement a
            //function that filters a list of integers based on this predicate and returns the list of even
            //numbers.

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Predicate<int> IsEvenPredicate = x => x % 2 == 0;
            //List<int> EvenNumbers = DelegateOperations.FilterList(numbers, IsEvenPredicate);

            //foreach (var item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            // =========================================================================================

            //What role do predicates play in functional programming, and how do they enhance code
            // clarity ?

            /**
             * Predicates play a crucial role in functional programming by providing a way to define boolean
             * conditions or filters that can be applied to data structures or collections. Predicates enhance
             * code clarity by encapsulating the logic for checking a specific condition in a reusable and
             * composable form, making the code more readable and maintainable. Predicates also enable developers
             * to express complex filtering or selection criteria in a declarative and concise manner, improving
             * the overall quality and readability of the code.
             */



            #endregion

            #region Problem17
            //Implement a function that filters a list of strings based on a condition provided by an
            //anonymous function. Test with different conditions like strings that start with a specific
            //letter or contain a specific substring.

            // Usage example
            //List<string> strings = new List<string> { "hello", "world", "CSharp", "programming", "DEPI" };

            //// Filter strings that start with 'C' using an anonymous function
            //List<string> startsWithC = DelegateOperations.FilterStrings(strings, delegate (string s) { return s.StartsWith("C"); });
            //Console.WriteLine("Strings that start with 'C':");
            //foreach (var item in startsWithC)
            //{
            //    Console.WriteLine(item);
            //}

            //// Filter strings that contain 'o' using an anonymous function
            //List<string> containsO = DelegateOperations.FilterStrings(strings, delegate (string s) { return s.Contains("o"); });
            //Console.WriteLine("Strings that contain 'o':");
            //foreach (var item in containsO)
            //{
            //    Console.WriteLine(item);
            //}

            // =========================================================================================

            // How do anonymous functions improve code modularity and customization?

            /**
             * Anonymous functions improve code modularity and customization by allowing developers to define
             * inline logic that can be passed as arguments to other functions or methods. This enables developers
             * to create custom behavior or conditions on the fly without the need to define separate methods or
             * delegates. Anonymous functions also promote code reusability and maintainability by encapsulating
             * logic in a self-contained and modular form, making it easier to customize and extend the functionality
             * of existing code.
             */


            #endregion

            #region Problem18
            //Implement a function that performs a mathematical operation on two integers using an
            //anonymous function.Test with different operations like addition, subtraction, and
            //multiplication.

            //int additionResult = DelegateOperations.PerformOperation(10, 5, delegate (int x, int y) { return x + y; });
            //Console.WriteLine("Addition: " + additionResult);

            //int subtractionResult = DelegateOperations.PerformOperation(10, 5, delegate (int x, int y) { return x - y; });
            //Console.WriteLine("Subtraction: " + subtractionResult);

            //int multiplicationResult = DelegateOperations.PerformOperation(10, 5, delegate (int x, int y) { return x * y; });
            //Console.WriteLine("Multiplication: " + multiplicationResult);

            // =========================================================================================

            //When should you prefer anonymous functions over named methods in implementing
            //mathematical operations?When should you prefer anonymous functions over named methods in implementing
            //mathematical operations ?

            /**
             * Anonymous functions are preferred over named methods in implementing mathematical operations when
             * the logic is simple, short-lived, and specific to a particular context or use case. Anonymous functions
             * are ideal for defining inline logic that is tightly coupled with the calling code and does not need to
             * be reused or exposed as a separate method. In contrast, named methods are preferred when the logic is
             * complex, reusable, or requires a well-defined interface that can be shared across multiple components
             * or modules. Named methods provide better code organization, readability, and maintainability for
             * long-lived and reusable logic that needs to be encapsulated and exposed as a separate entity.
             */


            #endregion

            #region Problem19
            // Implement a function that filters a list of strings based on a condition provided by a
            // lambda expression. Test with conditions like strings that have a length greater than 3 or
            // contain the letter 'e'.


            // Usage example
            //List<string> strings = new List<string> { "hello", "world", "CSharp", "programming", "DEPI", "ali", "wow" };

            //// Filter strings that have a length greater than 3 using a lambda expression
            //List<string> lengthGreaterThan3 = DelegateOperations.FilterStrings(strings, s => s.Length > 3);
            //Console.WriteLine("Strings with length greater than 3:");
            //foreach (var item in lengthGreaterThan3)
            //{
            //    Console.WriteLine(item);
            //}

            //// Filter strings that contain the letter 'e' using a lambda expression
            //List<string> containsE = DelegateOperations.FilterStrings(strings, s => s.Contains('e'));
            //Console.WriteLine("Strings that contain the letter 'e':");
            //foreach (var item in containsE)
            //{
            //    Console.WriteLine(item);
            //}

            // =========================================================================================

            // What makes lambda expressions an essential feature in modern C# programming?

            /**
             * Lambda expressions are an essential feature in modern C# programming because they provide a
             * concise and expressive way to define inline functions or delegates without the need to create
             * separate methods or classes. Lambda expressions offer the following benefits:
             * 
             * 1. Conciseness: Lambda expressions reduce the amount of boilerplate code required to define
             * simple functions or delegates, making the code more readable and maintainable.
             * 
             * 2. Readability: Lambda expressions allow developers to define logic inline, closer to the point
             * of use, improving code readability and reducing cognitive overhead.
             * 
             * 3. Flexibility: Lambda expressions enable developers to define custom behavior or conditions on
             * the fly, making it easier to adapt the code to different requirements and scenarios.
             * 
             * 4. Functional Programming: Lambda expressions support functional programming paradigms by
             * treating functions as first-class citizens, enabling higher-order functions and functional
             * composition.
             */

            #endregion

            #region Problem20
            // Implement a function that performs a mathematical operation on two doubles using a
            // lambda expression. Test with operations like division and exponentiation.

            //double divisionResult = DelegateOperations.PerformOperation(10.0, 2.0, (x, y) => x / y);
            //Console.WriteLine("Division: " + divisionResult);

            //double exponentiationResult = DelegateOperations.PerformOperation(2.0, 3.0, (x, y) => Math.Pow(x, y));
            //Console.WriteLine("Exponentiation: " + exponentiationResult);

            // =========================================================================================

            // How do lambda expressions enhance the expressiveness of mathematical computations in C#?

            /**
             * Lambda expressions enhance the expressiveness of mathematical computations in C# by providing
             * a concise and readable way to define complex mathematical operations inline. Lambda expressions
             * allow developers to express mathematical computations as first-class functions, enabling higher-order
             * functions and functional composition. This makes it easier to define custom mathematical operations
             * on the fly and adapt the code to different requirements and scenarios without the need to create
             * separate methods or classes. Lambda expressions also promote code reusability and maintainability
             * by encapsulating mathematical logic in a self-contained and modular form.
             */

            #endregion
        }
        public static T GetDefault<T>()
        {
            return default(T);
        }
    }
}
