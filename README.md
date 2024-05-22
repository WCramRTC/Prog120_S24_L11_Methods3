# Prog120_S24_L11_Methods3


---

## Switch

A switch statement is a control structure in programming that allows you to execute different parts of code based on the value of a variable. It's a more efficient and readable alternative to a long series of if-else-if statements when dealing with multiple conditions based on a single variable. Here's a simple breakdown of how a switch statement works:

### Components of a Switch Statement

- **Switch Keyword:** Starts the switch statement.
- **Expression:** The variable or expression being evaluated.
- **Case Labels:** Possible values for the expression, followed by a colon.
- **Statements:** One or more statements that execute if the expression matches the case label.
- **Break Statement:** Typically used to exit the switch block once a matching case is executed (though not always necessary).
- **Default Case:** Optional. Executes if none of the case labels match the expression.

### How It Works

1. **Evaluate Expression:** The expression specified in the switch statement is evaluated once.
2. **Match Case Label:** The value of the expression is compared with the values specified in the case labels.
3. **Execute Statements:** If a matching case is found, the code associated with that case executes.
4. **Exit Switch Block:** After executing the statements in a case, control usually exits the switch block unless prevented by fall-through behavior.
5. **Default Behavior:** If no case matches and a default case is provided, the code in the default case executes.

### Example in C#

Here's a simple example of a switch statement in C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        int day = 3;
        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day";
                break;
        }

        Console.WriteLine($"Day {day}: {dayName}");
    }
}
```

### Key Points to Remember

- **Break Statement:** Prevents fall-through in languages like C#, Java, and C++. Not all languages require this; for example, Python’s `match` case statements automatically prevent fall-through without a `break`.
- **Default Case:** It’s a good practice to include a default case to handle unexpected or invalid input.
- **Readability:** Switch statements can make the code cleaner and more readable when comparing the same variable against many constants.

Switch statements are particularly useful in scenarios where a single variable or expression is checked against multiple potential values. They are widely used in menu-driven programs, state machines, and handling varied user inputs.

---


## Expand Array

```csharp
    static int[] ExpandArray() {
        
    }
```
---

## Parallel Arrays

Parallel arrays are a technique used in programming to store related data in separate arrays, with the idea that corresponding elements in each array represent related information. This technique is often used when dealing with a set of related data items where each item has multiple attributes. 

### How Parallel Arrays Work:

1. **Definition**: Each array stores a different attribute of the related data.
2. **Indexing**: The relationship between elements is maintained through their indices. The same index in each array corresponds to related elements.
3. **Example**: Suppose you are storing information about students, including their names, ages, and grades. You would have three separate arrays:

    ```csharp
    string[] names = { "Alice", "Bob", "Charlie" };
    int[] ages = { 20, 21, 22 };
    double[] grades = { 85.5, 92.3, 78.4 };
    ```

    In this case, `names[0]` corresponds to `ages[0]` and `grades[0]`, and all three elements represent information about the same student.

### Advantages of Parallel Arrays:

1. **Simplicity**: Easy to implement and understand for simple datasets.
2. **Performance**: Can be more performant than using complex data structures, as arrays have lower overhead and provide fast access by index.

### Disadvantages of Parallel Arrays:

1. **Scalability**: Difficult to manage as the number of attributes increases. If you need to add more attributes, you must add another array.
2. **Maintainability**: More prone to errors. Ensuring the indices remain aligned across all arrays can be challenging.
3. **Readability**: Code can become hard to read and maintain, especially as the number of parallel arrays grows.

### Example Usage in C#:

Here's a simple example of how you might use parallel arrays in a C# program:

```csharp
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        int[] ages = { 20, 21, 22 };
        double[] grades = { 85.5, 92.3, 78.4 };

        // Display information about each student
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}, Grade: {grades[i]}");
        }
    }
}
```

---

## Linear Search

### Understanding Linear Search in C#

Linear search in C# works in much the same way as in other languages. It sequentially checks each element of an array until it finds the target element or exhausts all possibilities. It’s straightforward because it doesn't require the data to be sorted beforehand.

### Example of Linear Search in C#

Here is a simple C# function that implements linear search for an array of integers. The function will return the index of the target element if it's found, or -1 if it's not found in the array.

```csharp
using System;

class Program
{
    static int LinearSearch(int[] array, int target)
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == target)
            {
                return index; // Element found, return index
            }
        }
        return -1; // Element not found, return -1
    }

    static void Main(string[] args)
    {
        int[] myArray = { 5, 3, 8, 6, 7 };
        int target = 8;

        int result = LinearSearch(myArray, target);

        if (result != -1)
        {
            Console.WriteLine($"Element found at index {result}");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
```

### Key Points to Understand

- **Array Indexing:** In C#, as in many other programming languages, array indices start at 0. So, the first element of the array is at index 0, the second at index 1, and so on.
- **Looping through Arrays:** The `for` loop is used to traverse the array from the first element to the last. The loop continues as long as the index is less than the length of the array (`array.Length`).
- **Conditional Checking:** Inside the loop, there's a conditional `if` statement that checks if the current array element matches the target. If it does, the function returns the current index.
- **Returning Results:** If the loop completes without finding the target, the function returns -1, indicating that the target is not present in the array.

### Characteristics of Linear Search in C#

- **Time Complexity:** O(n), where n is the number of elements in the array.
- **Space Complexity:** O(1), since it uses a constant amount of extra space.
- **Usability:** Does not require the array to be sorted, making it applicable in many scenarios where the order of elements is arbitrary.
- **Ease of Implementation:** Very simple to code and understand, making it ideal for introductory programming courses.

This approach to explaining linear search should make it clear and accessible for a Programming 1 student learning C#.


--- 

## Bubble Sort

Bubble sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. This process is repeated until no swaps are needed, which means the list is sorted. It's called "bubble sort" because smaller elements "bubble" to the top of the list (beginning of the array) with each iteration through the array.

### How Bubble Sort Works

1. **Start at the beginning of the array:** Compare the first two elements.
2. **Compare and swap:** If the first element is greater than the second, swap them.
3. **Move to the next pair:** Move to the next pair of adjacent elements, repeat the comparison and swap if necessary.
4. **Repeat:** Continue this process for the entire array. This completes one full pass through the array.
5. **Check for more passes:** After each pass, the largest element in the remaining unsorted part will have bubbled up to its correct position.
6. **Optimization:** With each pass, you can reduce the number of elements to check since the end of the array is sorted.
7. **Termination:** Repeat the process until a complete pass is made without any swaps, indicating the array is sorted.

### Example of Bubble Sort in C#

Here’s a simple C# implementation of bubble sort:

```csharp
using System;

class Program
{
    static void BubbleSort(int[] array)
    {
        bool swapped;
        for (int i = 0; i < array.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap the elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped by inner loop, then break
            if (!swapped)
                break;
        }
    }

    static void Main(string[] args)
    {
        int[] myArray = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", myArray));

        BubbleSort(myArray);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", myArray));
    }
}
```

### Characteristics of Bubble Sort

- **Time Complexity:** Worst-case and average complexity is O(n²), where n is the number of items being sorted. The best case is O(n) when the array is already sorted.
- **Space Complexity:** O(1), as bubble sort is an in-place sorting algorithm.
- **Ease of Implementation:** It's straightforward to implement, which makes it a frequent choice for introductory programming examples.
- **Usage:** While not efficient for large datasets, it is useful for teaching purposes and small datasets.

This basic explanation and C# example should help a beginner understand the concept and mechanics of bubble sort.