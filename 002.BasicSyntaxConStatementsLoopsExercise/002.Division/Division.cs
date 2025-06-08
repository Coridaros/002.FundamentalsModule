//Basic syntax, conditional statements and loops - exercise, Task 002
//08.06.2025, 23:28

public class Division
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = false;
        int greater = int.MinValue;

        if(number % 2 == 0)
        {
            isDivisible = true;
            greater = 2;
        }
        if(number % 3 == 0)
        {
            isDivisible = true;
            greater = 3;
        }
        if(number % 6 == 0)
        {
            isDivisible = true;
            greater = 6;
        }
        if(number % 7 == 0)
        {
            isDivisible = true;
            greater = 7;
        }
        if(number % 10 == 0)
        {
            isDivisible = true;
            greater = 10;
        }

        if(isDivisible)
        {
            Console.WriteLine($"The number is divisible by {greater}");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }
    }
}