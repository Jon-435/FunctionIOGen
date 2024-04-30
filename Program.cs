using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void GenLinear(int a, int b)
    {
        if (File.Exists("train.txt"))
        {
            File.Delete("train.txt");
        }
        Console.WriteLine("Enter the minimum value for x:");
        double minX;
        while (!double.TryParse(Console.ReadLine(), out minX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the maximum value for x:");
        double maxX;
        while (!double.TryParse(Console.ReadLine(), out maxX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the number of values to generate:");
        int numValues;
        while (!int.TryParse(Console.ReadLine(), out numValues) || numValues <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }

        Random rand = new Random();
        List<double> testDataX = new List<double>();
        List<double> testDataY = new List<double>();

        for (int i = 0; i < numValues; i++)
        {
            double x = minX + (maxX - minX) * rand.NextDouble(); // Random x value within the specified range
            testDataX.Add(x);
        }

        foreach (double x in testDataX)
        {
            double y = a * x + b;
            testDataY.Add(y);
        }

        Console.WriteLine("Generated Linear Testing Data:");
        Console.WriteLine("X\tY");
        using (StreamWriter writer = new StreamWriter("train.txt", true))
        {
            for (int i = 0; i < testDataX.Count; i++)
            {
                string dataLine = testDataX[i].ToString("0.##########") + "," + testDataY[i].ToString("0.##########"); // Comma-separated values
                Console.WriteLine(dataLine);
                writer.WriteLine(dataLine);
            }
        }
        Console.WriteLine("Data saved to train.txt");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void GenQuad(int a, int b, int c)
    {
        // Check if the file exists and delete it if it does
        if (File.Exists("train.txt"))
        {
            File.Delete("train.txt");
        }

        // Ask the user for the range of x values and the number of values to generate
        Console.WriteLine("Enter the minimum value for x:");
        double minX;
        while (!double.TryParse(Console.ReadLine(), out minX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the maximum value for x:");
        double maxX;
        while (!double.TryParse(Console.ReadLine(), out maxX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the number of values to generate:");
        int numValues;
        while (!int.TryParse(Console.ReadLine(), out numValues) || numValues <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }

        // Generate testing data for a quadratic function
        Random rand = new Random();
        List<double> testDataX = new List<double>();
        List<double> testDataY = new List<double>();

        // Generate x values within the specified range
        for (int i = 0; i < numValues; i++)
        {
            double x = minX + (maxX - minX) * rand.NextDouble(); // Random x value within the specified range
            testDataX.Add(x);
        }

        // Calculate corresponding y values using the quadratic equation y = ax^2 + bx + c
        foreach (double x in testDataX)
        {
            double y = a * x * x + b * x + c;
            testDataY.Add(y);
        }

        // Display and save generated testing data
        Console.WriteLine("Generated Quadratic Testing Data:");
        Console.WriteLine("X\tY");
        using (StreamWriter writer = new StreamWriter("train.txt", true))
        {
            for (int i = 0; i < testDataX.Count; i++)
            {
                string dataLine = testDataX[i].ToString("0.##########") + "," + testDataY[i].ToString("0.##########"); // Comma-separated values
                Console.WriteLine(dataLine);
                writer.WriteLine(dataLine);
            }
        }
        Console.WriteLine("Data saved to train.txt");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void GenSine(int a, int b)
    {
        // Check if the file exists and delete it if it does
        if (File.Exists("train.txt"))
        {
            File.Delete("train.txt");
        }

        // Ask the user for the range of x values and the number of values to generate
        Console.WriteLine("Enter the minimum value for x:");
        double minX;
        while (!double.TryParse(Console.ReadLine(), out minX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the maximum value for x:");
        double maxX;
        while (!double.TryParse(Console.ReadLine(), out maxX))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Enter the number of values to generate:");
        int numValues;
        while (!int.TryParse(Console.ReadLine(), out numValues) || numValues <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }

        // Generate testing data for a sine function
        Random rand = new Random();
        List<double> testDataX = new List<double>();
        List<double> testDataY = new List<double>();

        // Generate x values within the specified range
        for (int i = 0; i < numValues; i++)
        {
            double x = minX + (maxX - minX) * rand.NextDouble(); // Random x value within the specified range
            testDataX.Add(x);
        }

        // Calculate corresponding y values using the sine function y = a * sin(bx)
        foreach (double x in testDataX)
        {
            double y = a * Math.Sin(b * x);
            testDataY.Add(y);
        }

        // Display and save generated testing data
        Console.WriteLine("Generated Sine Testing Data:");
        Console.WriteLine("X\tY");
        using (StreamWriter writer = new StreamWriter("train.txt", true))
        {
            for (int i = 0; i < testDataX.Count; i++)
            {
                string dataLine = testDataX[i].ToString("0.##########") + "," + testDataY[i].ToString("0.##########"); // Comma-separated values
                Console.WriteLine(dataLine);
                writer.WriteLine(dataLine);
            }
        }
        Console.WriteLine("Data saved to train.txt");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }


    //MAIN FUNCTION

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FunctionIOGen. Copyright (C) 2024 jon | jon435.com");
        Console.WriteLine("Choose a function to generate training data for:");
        Console.WriteLine("1. Linear Function f(x)= ax + b\n2. Quadratic Function f(x)= ax^2 + bx + c\n3. Sine Function f(x)= a * sin(bx)");

        int menuSelect;
        if (int.TryParse(Console.ReadLine(), out menuSelect))
        {
            switch (menuSelect)
            {
                case 1:
                    Console.WriteLine("Enter the coefficient for x:");
                    int linearA;
                    if (!int.TryParse(Console.ReadLine(), out linearA))
                    {
                        Console.WriteLine("Invalid input for coefficient.");
                        return;
                    }

                    Console.WriteLine("Enter the constant term:");
                    int linearB;
                    if (!int.TryParse(Console.ReadLine(), out linearB))
                    {
                        Console.WriteLine("Invalid input for constant.");
                        return;
                    }

                    GenLinear(linearA, linearB);
                    break;
                case 2:
                    Console.WriteLine("Enter the coefficient for x^2:");
                    int quadA;
                    if (!int.TryParse(Console.ReadLine(), out quadA))
                    {
                        Console.WriteLine("Invalid input for coefficient.");
                        return;
                    }

                    Console.WriteLine("Enter the coefficient for x:");
                    int quadB;
                    if (!int.TryParse(Console.ReadLine(), out quadB))
                    {
                        Console.WriteLine("Invalid input for coefficient.");
                        return;
                    }

                    Console.WriteLine("Enter the constant term:");
                    int quadC;
                    if (!int.TryParse(Console.ReadLine(), out quadC))
                    {
                        Console.WriteLine("Invalid input for constant.");
                        return;
                    }

                    GenQuad(quadA, quadB, quadC);
                    break;
                case 3:
                    Console.WriteLine("Enter the coefficient for x:");
                    int sineA;
                    if (!int.TryParse(Console.ReadLine(), out sineA))
                    {
                        Console.WriteLine("Invalid input for coefficient.");
                        return;
                    }

                    Console.WriteLine("Enter the constant term:");
                    int sineB;
                    if (!int.TryParse(Console.ReadLine(), out sineB))
                    {
                        Console.WriteLine("Invalid input for constant.");
                        return;
                    }

                    GenSine(sineA, sineB);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose a number between 1 and 3.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter a valid number.");
        }
    }
}
