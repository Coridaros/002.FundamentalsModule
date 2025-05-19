//Basic syntax, conditional statements and loops, Task 004
//19.05.2025, 22:56

int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 30;

if(minutes > 59)
{
    hours++;
    minutes -= 60;
}

if(hours > 23)
{
    hours -= 24;
}

if(minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}