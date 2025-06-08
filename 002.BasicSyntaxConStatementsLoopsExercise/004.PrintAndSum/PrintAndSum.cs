//Basic syntax, conditional statements and loop - exercise, Task 004
//09.06.2025, 00:02

public class PrintAndSum
{
    static void Main()
    {
        int sum = 0;

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }

        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");
    }
}