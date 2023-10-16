using System;
class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int sequenceLength = 1;
        int longestSequence = 0;
        int longestSequenceNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                int nextNumber = numbers[j];

                if (currentNumber == nextNumber)
                {
                    sequenceLength++;
                }
                else
                {
                    break;
                }
            }

            if (sequenceLength > longestSequence)
            {
                longestSequence = sequenceLength;
                longestSequenceNumber = numbers[i];
            }

            sequenceLength = 1;
        }

        for (int k = 0; k < longestSequence; k++)
        {
            Console.Write($"{longestSequenceNumber} ");
        }
    }
}
