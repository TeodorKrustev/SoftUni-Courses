﻿namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Greater number: " + num1);

            if (num2 > num1)
                Console.WriteLine("Greater number: " + num2);
        }
    }
}
