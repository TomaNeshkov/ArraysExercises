using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numStrings = input.Split(" ");
        int[] numbers = new int[numStrings.Length];

        for (int i = 0; i < numStrings.Length; i++)
        {
            numbers[i] = int.Parse(numStrings[i]);
        }

        int result = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }

            for (int k = i + 1; k < numbers.Length; k++)
            {
                rightSum += numbers[k];
            }

            if (leftSum == rightSum)
            {
                result = i;
                break;
            }
        }

        if (result != -1)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
