using System;
using System.Data;
// This is a simple C# program that prints a user's name to the console.
//class Program
//{
//    static void Main()
//    {
//        string userName = "Abhay";
//        Console.WriteLine(userName);

//    }
//}
// Modify the program to print your lucky number instead of your name.
//class Program
//{
//    static void Main()
//    {
//        int luckyNumber = 7;
//        Console.WriteLine(luckyNumber);
//    }
//}
// Modify the program to print both your name and your lucky number.
//class Program
//{
//    static void Main()
//    {
//        int luckyNumber = 7;
//        string userName = "Abhay";
//        Console.WriteLine($"Name: {userName}, Lucky Number: {luckyNumber}");
//    }
//}
//class Program
// program to see error by trying to change value of constant
//{
//    static void Main()
//    {
//        const double pi = 3.14159;
//        pi = 3.13;
//        Console.WriteLine(pi);

//    }
//}
//class Program
//// program to calculate area and perimeter of circle using constant value of pi
//{
//    const double pi = 3.14159;
//    static double CalculateArea(double radius)
//    {
//        return pi * radius * radius;
//    }
//    static double CalculatePerimeter(double radius)

//    {
//        return 2 * pi * radius;
//    }
//    static void Main()
//    {
//        double radius = 5.0;
//        double area = CalculateArea(radius);
//        double perimeter = CalculatePerimeter(radius);
//        Console.WriteLine($"For a circle with radius {radius}:");
//        Console.WriteLine($"Area: {area}");
//        Console.WriteLine($"Perimeter: {perimeter}");
//    }
//}
// program to demonstrate different data types and type conversion
//class Program
//{
//    static void Main()
//    {
//        string Name = "AbhayDai";
//        int age = 21;
//        double height = 5.9;
//        char grade = 'A';
//        bool villian = true;
//        byte bytevar = 10;
//        short shortvar = 20;
//        long loVar = 30;

//        int number = 42;
//        string stringFromInt = number.ToString();

//        // Convert string "3.14" to double
//        string piString = "3.14";
//        double doubleFromString = Convert.ToDouble(piString);

//        // Print all variables
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("Age: " + age);
//        Console.WriteLine("Height: " + height);
//        Console.WriteLine("Grade: " + grade);
//        Console.WriteLine("Hero: " + hero);
//        Console.WriteLine("height (decimal): " + height);
//        Console.WriteLine("Byte variable: " + bytevar);
//        Console.WriteLine("Short variable: " + shortvar);
//        Console.WriteLine("Long variable: " + loVar);
//        Console.WriteLine("String from Int: " + stringFromInt);
//        Console.WriteLine("Double from String: " + doubleFromString);
//    }
//}
// program to demonstrate array operations: sorting, reversing, iterating, and searching
//class Program
//{
//    static void Main()
//    {
//        int[] arrayNumber = { 1, 2, 3, 4, 5 };

//        Array.Sort(arrayNumber);
//        Console.WriteLine("Sorted array:");
//        foreach (int num in arrayNumber)
//        {
//            Console.WriteLine(num);
//        }
//        Console.WriteLine();

//        Array.Reverse(arrayNumber);
//        Console.WriteLine("Reversed array:");
//        foreach (int num in arrayNumber)
//        {
//            Console.WriteLine(num);
//        }
//        Console.WriteLine();

//        Console.WriteLine("print elements using for loop:");
//        for (int i = 0; i < arrayNumber.Length; i++)
//        {
//            Console.WriteLine(arrayNumber[i]);
//        }

//        Console.WriteLine("Enter a number to search:");
//        int searchNumber = Convert.ToInt32(Console.ReadLine());
//        int index = Array.IndexOf(arrayNumber, searchNumber);
//        if (index != -1)
//        {
//            Console.WriteLine($"Number {searchNumber} found at index {index}.");
//        }
//        else
//        {
//            Console.WriteLine($"Number {searchNumber} not found in the array.");
//        }
//    }

//}
// program to demonstrate DateTime operations: calculating age, formatting dates, and adding days
//class Progam
//{
//    static void Main()
//    {
//        DateTime birthDate = new DateTime(2004, 11, 26);
//        DateTime currentDate = DateTime.Now;
//        TimeSpan ageSpan = currentDate - birthDate;
//        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

//        Console.WriteLine($"Age in years: {ageInYears}");
//        Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");

//        DateTime newDate = birthDate.AddDays(10);
//        Console.WriteLine($"Date after adding 10 days to birth date: {newDate.ToShortDateString()}");
//    }
//}
class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>() { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            { 1, "Avocado"},
            { 2, "DragonFruit"},
            { 3, "Pineapple"},
        };
        fruitDict.Add(4, "Grapes");
        Console.WriteLine("Fruits in the dictionary:");
        foreach (KeyValuePair<int, string> kvp in fruitDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
        }
    }
}
