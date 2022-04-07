// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input
using System;
class Program
{
    public static void Main(string[] args)
    {
        double radius;
        double volume;

        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");
        Console.Write("Enter the radius (cm): ");
        radius = double.Parse(Console.ReadLine());

        volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine("");
        Console.Write("The volume of the sphere = " + volume.ToString("0.00") + " cm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}
