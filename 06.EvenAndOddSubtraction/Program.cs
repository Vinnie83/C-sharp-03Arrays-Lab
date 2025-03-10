﻿namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }

            int diff = sumEven - sumOdd;

            Console.WriteLine(diff);
            
        }
    }
}