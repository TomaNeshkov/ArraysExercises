using System;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            bool isTopInteger = true;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                int nextNumber = numbers[j];
                if (nextNumber >= currentNumber)
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                Console.Write($"{currentNumber} ");
            }
        }
    }
}
