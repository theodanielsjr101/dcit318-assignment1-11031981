﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90) Console.WriteLine("Grade: A");
        else if (grade >= 80) Console.WriteLine("Grade: B");
        else if (grade >= 70) Console.WriteLine("Grade: C");
        else if (grade >= 60) Console.WriteLine("Grade: D");
        else Console.WriteLine("Grade: F");
    }
}

