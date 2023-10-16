using System;

class Program
{
    static void Main()
    {
        int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            for (int j = elements.Length - 1; j >= 0; j--)
            {
                int temp = elements[elements.Length - 1];
                elements[elements.Length - 1] = elements[j];
                elements[j] = temp;
            }
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}
