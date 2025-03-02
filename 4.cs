using System;
class Speed {
  static void Main() {
    while (true) {
        Console.WriteLine("Select speed conversion:");
        Console.WriteLine("1. Km/hour");
        Console.WriteLine("2. M/sec");
        Console.WriteLine("3. Exit");
        
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        
        switch (choice) {
            case "1":
                Console.WriteLine("Enter speed in km/hour: ");
                if (double.TryParse(Console.ReadLine(), out double Km)) {
                    Console.WriteLine($"{Km} Km/hour to M/sec is: {Km * 5/18}");
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "2":
                Console.WriteLine("Enter speed in m/sec: ");
                if (double.TryParse(Console.ReadLine(), out double M)) {
                    Console.WriteLine($"{M} M/sec to Km/hour is: {M * 18/5}");
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