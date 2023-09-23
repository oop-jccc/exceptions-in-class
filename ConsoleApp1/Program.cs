namespace ConsoleApp1;

static class Program
{
    private static void Main()
    {
        Console.WriteLine("Temperature Converter: Fahrenheit to Celsius");
        Console.Write("Enter temperature in Fahrenheit: ");

        var input = Console.ReadLine();
        if (double.TryParse(input, out var fahrenheit))
        {
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}