using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array1 = new int[n];
        int[] array2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int number1 = int.Parse(input[0]);
            int number2 = int.Parse(input[1]);

            if ((i % 2) == 0)
            {
                array1[i] = number1;
                array2[i] = number2;
            }
            else
            {
                array1[i] = number2;
                array2[i] = number1;
            }
        }

        Console.WriteLine(string.Join(" ", array1));
        Console.WriteLine(string.Join(" ", array2));
    }
}
