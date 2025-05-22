//Basic syntax, conditional statements and loops - lab, Task 009
//21.05.2025, 01:06

int n = int.Parse(Console.ReadLine());

int sum = 0;
int odd = 1;

for(int i = 1; i <= n; i++)
{
    Console.WriteLine(odd);
    sum += odd;
    odd += 2;
}

Console.WriteLine($"Sum: {sum}");