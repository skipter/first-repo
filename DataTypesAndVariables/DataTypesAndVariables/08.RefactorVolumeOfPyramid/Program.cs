﻿namespace _08.RefactorVolumeOfPyramid
{
    using System;
    public class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = 0;
            length = double.Parse(Console.ReadLine());
            
            Console.Write("Width: ");
            double width = 0;
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = 0;
            height = double.Parse(Console.ReadLine());

            double volume = (height * length * width) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
