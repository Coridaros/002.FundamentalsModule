//Basic syntax, conditional statements and loops - lab, Task 013
//21.05.2025, 01:29

using System.Globalization;

var startDate = DateTime.ParseExact(Console.ReadLine(),
    "dd.m.yyyy", CultureInfo.InvariantCulture);
var endDate = DateTime.ParseExact(Console.ReadLine(),
    "dd.m.yyyy", CultureInfo.InvariantCulture);
var holidaysCount = 0;
for (var date = startDate; date <= endDate; date.AddDays(1))
    if (date.DayOfWeek == DayOfWeek.Saturday &&
        date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
Console.WriteLine(holidaysCount);
