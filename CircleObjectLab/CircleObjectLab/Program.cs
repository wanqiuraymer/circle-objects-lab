using CircleObjectLab;
while (true)
{
    Console.WriteLine("Welcome to the Circle Tester!");
    Console.WriteLine("Enter a radius: ");
    double radius = 0;
    try
    {
        radius = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid number");
        continue;
    }
    Circle circle = new Circle (radius);
    while (true)
    {
        Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");

        Console.WriteLine("Should the circle grow? (y/n)");
        if (Console.ReadLine() == "y")
        {
            Console.WriteLine("The circle is magically growing.");
            circle.Grow();
        }
        else
        {
            Console.WriteLine("Goodbye!");
            break;
        }
    }
    Console.WriteLine($"The circle's final radius is {circle.GetRadius()}.");
    break;


}

