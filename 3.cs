using System;
class Temperature {
  static void Main() {
    while (true) {
        Console.WriteLine("Select temperature conversion:");
        Console.WriteLine("1. Fahrenheit");
        Console.WriteLine("2. Celsius");
        Console.WriteLine("3. Exit");
        
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        
        switch (choice) {
            case "1":
                Console.WriteLine("Enter temperature in fahrenheit: ");
                if (double.TryParse(Console.ReadLine(), out double F)) {
                    Console.WriteLine($"{F} Fahrenheit to Celsius is: {(F - 32) / 1.8}");
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "2":
                Console.WriteLine("Enter temperature in Celsius: ");
                if (double.TryParse(Console.ReadLine(), out double C)) {
                    Console.WriteLine($"{C} Celsius to Fahrenheit is: {1.8 * C + 32}");
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "3":
                return;
            default: Console.WriteLine("Invalid selection, try again.");
                break;
        }
    }
  }
}