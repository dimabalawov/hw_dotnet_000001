// See https://aka.ms/new-console-template for more information
void task1()
{
    Console.Write("Enter your number from 1 to 100: ");
    int number = int.Parse(Console.ReadLine());
    if (number < 1 && number > 100)
    { throw new Exception("The number is out of range!"); }
    if (number % 3 == 0)
        Console.WriteLine("Fizz");
    else if (number % 5 == 0)
        Console.WriteLine("Buzz");
    else Console.WriteLine(number);
}
void task2()
{
    Console.Write("Enter your number: ");
    double number = Double.Parse(Console.ReadLine());
    Console.Write("Enter your %: ");
    int procent = int.Parse(Console.ReadLine());
    double res = (number / 100) * procent;
    Console.WriteLine($"Result: {res}");
}
void task3()
{
    Console.Write("Enter your 1st number: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Enter your 2nd number: ");
    int number2 = int.Parse(Console.ReadLine());
    Console.Write("Enter your 3rd number: ");
    int number3 = int.Parse(Console.ReadLine());
    Console.Write("Enter your 4th number: ");
    int number4 = int.Parse(Console.ReadLine());
    int[] arr = new int[] { number1, number2, number3, number4 };
    int res = 0;
    foreach (int i in arr)
    {
        res += i;
        if (i < 3)
            res *= 10;
    }
    Console.WriteLine($"Res: {res}");
}
void task4()
{
    Console.Write("Enter 6 digits number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Enter 1st place: ");
    int a1 = int.Parse(Console.ReadLine());
    Console.Write("Enter 2nd place: ");
    int a2 = int.Parse(Console.ReadLine());
    int[] arr = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    int temp = arr[a1];
    arr[a1] = arr[a2];
    arr[a2] = temp;
    number = int.Parse(string.Join("", arr));
    Console.WriteLine("Result: {0}", number);
}
double CelsiusToFahrenheit(double celsius)
{
    return (9.0 / 5.0) * celsius + 32;
}
 double FahrenheitToCelsius(double fahrenheit)
{
    return (5.0 / 9.0) * (fahrenheit - 32);
}
void task6()
{
    Console.WriteLine("1 - Celsius to Fahrenheit");
    Console.WriteLine("2 -  Fahrenheit to Celsius");
    short choice = SByte.Parse(Console.ReadLine());
    Console.Write("Enter your temperature: ");
    int temp = int.Parse(Console.ReadLine());
    if (choice == 1)
    { Console.WriteLine($"Celsius to Fahrenheit: {CelsiusToFahrenheit(temp)}"); }
    else if (choice == 2)
    { Console.WriteLine($"Fahrenheit to Celsius: {FahrenheitToCelsius(temp)}"); }
    else { throw new Exception("Wrong choice!"); }
}
void task7()
{
    Console.Write("Enter the start of diapozon: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Enter the end of diapozon: ");
    int end = int.Parse(Console.ReadLine());
    if(start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    for (int i = start; i < end; i++)
        if (i % 2 == 0)
            Console.Write($"{i}, ");
}

task1();
task2();
task3();
task4();
task6();
task7();
