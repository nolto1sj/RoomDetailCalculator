bool loop = true;
while (loop)
{
    try
    {
        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!\n");
        Console.Write("Enter Length: ");
        var inputLength = float.Parse(Console.ReadLine());
        Console.Write("Enter Width: ");
        var inputWidth = float.Parse(Console.ReadLine());
        Console.Write("Enter Height: ");
        var inputHeight = float.Parse(Console.ReadLine());
        var area = inputLength * inputWidth;
        var perimeter = 2 * (inputLength + inputWidth);
        var volume = inputWidth * inputHeight * inputLength;

        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Volume: {volume}");

        if (area <= 250)
        {
            Console.WriteLine("This is a small room.");
        }
        else if (area <= 650)
        {
            Console.WriteLine("This is a medium room.");
        }
        else
        {
            Console.WriteLine("This is a large room.");
        }
        loop = false;
    }
    catch
    {
        Console.WriteLine("Please enter a valid input");
        Thread.Sleep(1000);
        Console.Clear();
    }
}

Console.WriteLine("\nThank you for using the Room Detail Generator!");