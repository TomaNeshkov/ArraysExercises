using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] train = new int[n];
        int peopleCount = 0;

        for (int i = 0; i < n; i++)
        {
            int peoplePerWagon = int.Parse(Console.ReadLine());
            train[i] = peoplePerWagon;
            peopleCount += peoplePerWagon;
        }

        Console.WriteLine(string.Join(" ", train));
        Console.WriteLine(peopleCount);
    }
}
