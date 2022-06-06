#nullable disable
Console.Clear();

// hello user
Console.WriteLine("Welcome to the Distance Calculator");
Console.Write("Enter x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2: "); int y2 = Convert.ToInt32(Console.ReadLine());

// Process


// Output
Console.WriteLine($"Distance between points is {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");