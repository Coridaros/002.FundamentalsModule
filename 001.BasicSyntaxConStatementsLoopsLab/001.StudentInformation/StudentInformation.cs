//Basic syntax, conditional statements and loops - lab, Task 001
//19.05.2025, 22:39

string studentNames = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double grade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {studentNames}, Age: {age}, Grade: {grade:F2}");