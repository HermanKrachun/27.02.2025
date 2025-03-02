using System;
class Faces {
  static void Main() {
      while (true) {
        Console.WriteLine("Select a shape for face calculation: ");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Circle");
        Console.WriteLine("4. Triangle");
        Console.WriteLine("5. Exit");
        
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        
        switch (choice) {
            case "1": 
                Console.WriteLine("Enter the side of the square:");
                if (double.TryParse(Console.ReadLine(), out double side)) {
                    Console.WriteLine($"The area of the square is: {side * side}");
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "2": 
                Console.WriteLine("Enter length: ");
                if (double.TryParse(Console.ReadLine(), out double length)) {
                        Console.WriteLine("Enter width:");
                        if (double.TryParse(Console.ReadLine(), out double width)) {
                            Console.WriteLine($"The area of a rectangle: {length * width}");
                        } else {
                            Console.WriteLine("Invalid number!");
                        }
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "3": 
                Console.WriteLine("Enter the radius of the circle:");
                if (double.TryParse(Console.ReadLine(), out double radius)) {
                    Console.WriteLine($"The area of the circle is: {Math.PI * radius * radius}");
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "4": 
                Console.WriteLine("Enter the base of the triangle: ");
                if (double.TryParse(Console.ReadLine(), out double baseLength)) {
                        Console.WriteLine("Enter the height of the triangle:");
                        if (double.TryParse(Console.ReadLine(), out double height)) {
                            Console.WriteLine($"The face of the triangle is: {0.5 * baseLength * height}");
                        } else {
                            Console.WriteLine("Invalid number!");
                        }
                } else {
                    Console.WriteLine("Invalid number!");
                }
                break;
            case "5": 
                return;
            default: Console.WriteLine("Invalid selection, try again.");
                break;
        }
    }
  }
}