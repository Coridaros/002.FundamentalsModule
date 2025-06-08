//Basic syantax, conditional statements and loops - exercise, Task 008
//09.06.2025, 00:47

public class TriangleOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}