//Basic syntax, conditional statements and loops - lab, Task 006
//21.05.2025, 00:01

string country = Console.ReadLine().ToLower();

switch(country)
{
    case "england":
    case "usa":
        Console.WriteLine("English");
        break;
    case "spain":
    case "argentina":
    case "mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}