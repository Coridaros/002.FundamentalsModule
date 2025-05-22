//Basic syntax, conditional statements and loops - lab, Task 011
//21.05.2025, 01:19

int n = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

if(times <= 10)
{
    for(int i = times; i <= 10; i++)
    {
        Console.WriteLine($"{n} X {i} = {n * i}");
    }
}
else
{
    Console.WriteLine($"{n} X {times} = {n * times}");
}