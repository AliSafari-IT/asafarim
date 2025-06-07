# Practice Problem: Fibonacci Sequence Calculator

## Problem Statement
Create a console application in C# that calculates the Fibonacci sequence using both iterative and recursive approaches. The program should allow users to input a number and display the Fibonacci sequence up to that number.

### Requirements
1. Implement both iterative and recursive methods for Fibonacci calculation
2. Compare performance between the two approaches
3. Handle invalid input (negative numbers)
4. Display the sequence in a formatted way
5. Include error handling for large numbers

## Implementation Steps

### Step 1: Set Up the Project
1. Create a new Console Application in C#
2. Name it `FibonacciCalculator`

### Step 2: Implement Iterative Approach
```csharp
public static int FibonacciIterative(int n)
{
    if (n <= 1) return n;
    
    int a = 0, b = 1, result = 0;
    for (int i = 2; i <= n; i++)
    {
        result = a + b;
        a = b;
        b = result;
    }
    return result;
}
```

### Step 3: Implement Recursive Approach
```csharp
public static int FibonacciRecursive(int n)
{
    if (n <= 1) return n;
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}
```

### Step 4: Create Main Program Logic
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Enter the number of terms:");
    if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
    {
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"{FibonacciIterative(i)} ");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }
}
```

## Performance Comparison
- Iterative approach is more efficient for large numbers
- Recursive approach is simpler but has exponential time complexity

## Additional Features
1. Add memoization to optimize recursive approach
2. Implement parallel processing for large calculations
3. Add unit tests for both methods
