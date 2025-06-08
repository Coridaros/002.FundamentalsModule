//Basic syntax, conditional statements and loops - exercise, Task 003
//08.06.2025, 23:49

public class Vacation
{
    static void Main()
    {
        int peopleCnt = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();

        double discount = 0.0;
        double price = 0.0;

        if(day == "friday")
        {
            if(groupType == "students")
            {
                price = peopleCnt * 8.45;

                if(peopleCnt >= 30)
                {
                    discount = price * 0.15;
                    price -= discount;
                }
            }
            else if(groupType == "business")
            {
                price = peopleCnt * 10.90;

                if (peopleCnt >= 100)
                {
                    price = (peopleCnt - 10) * 10.90;
                }
            }
            else if(groupType == "regular")
            {
                price = peopleCnt * 15;

                if(peopleCnt >= 10 && peopleCnt <= 20)
                {
                    discount = price * 0.05;
                    price -= discount;
                }
            }
        }
        else if(day == "saturday")
        {
            if (groupType == "students")
            {
                price = peopleCnt * 9.80;

                if (peopleCnt >= 30)
                {
                    discount = price * 0.15;
                    price -= discount;
                }
            }
            else if (groupType == "business")
            {
                price = peopleCnt * 15.60;

                if (peopleCnt >= 100)
                {
                    price = (peopleCnt - 10) * 15.60;
                }
            }
            else if (groupType == "regular")
            {
                price = peopleCnt * 20;

                if (peopleCnt >= 10 && peopleCnt <= 20)
                {
                    discount = price * 0.05;
                    price -= discount;
                }
            }
        }
        else if(day == "sunday")
        {
            if (groupType == "students")
            {
                price = peopleCnt * 10.46;

                if (peopleCnt >= 30)
                {
                    discount = price * 0.15;
                    price -= discount;
                }
            }
            else if (groupType == "business")
            {
                price = peopleCnt * 16;

                if (peopleCnt >= 100)
                {
                    price = (peopleCnt - 10) * 16;
                }
            }
            else if (groupType == "regular")
            {
                price = peopleCnt * 22.50;

                if (peopleCnt >= 10 && peopleCnt <= 20)
                {
                    discount = price * 0.05;
                    price -= discount;
                }
            }
        }

        Console.WriteLine($"Total price: {price:F2}");
    }
}