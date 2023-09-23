namespace ConsoleApp1;

abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Temperature Converter: Fahrenheit to Celsius");
        Console.Write("Enter temperature in Fahrenheit: ");

        var input = Console.ReadLine();
        try
        {
            var fahrenheit = double.Parse(input);
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}