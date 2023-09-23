# In-Class Programming Assignment: Temperature Converter

## Objective
Learn how to replace `try-catch` blocks with `TryParse` for better input validation in a simple console application.

## Instructions

### Step 1: Understand the Starter Code
You are provided with a simple console application that converts temperatures from Fahrenheit to Celsius. The starter code uses a `try-catch` block to handle invalid input.

### Step 2: Remove the `try-catch` Block
Your task is to remove the `try-catch` block and replace it with `TryParse` for input validation.

### Step 3: Implement `TryParse`
Use the `double.TryParse` method to validate the user input. If the input is valid, proceed with the temperature conversion. If the input is invalid, display an error message.

### Step 4: Test Your Code
Run your application and test it with both valid and invalid inputs to make sure it works as expected.

## Expected Output
Hint: Your code should look something like this:
You just need to replace the `TODO` with the correct code.

```csharp
private static void Main()
{
    Console.WriteLine("Temperature Converter: Fahrenheit to Celsius");
    Console.Write("Enter temperature in Fahrenheit: ");
    var input = Console.ReadLine();
    if (/* TODO: Implement TryParse */)
    {
        var celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
```

Once you've completed these steps, your application should no longer use `try-catch` for input validation and should instead use `TryParse`.