//Basic syntax, conditional statements and loops - exercise, Task 007
//09.06.2025, 00:31

public class VendingMachine
{
    static void Main()
    {
        double sum = 0.0;

        while(true)
        {
            string input = Console.ReadLine().ToLower();

            if(input == "start")
            {
                break;
            }

            double coins = double.Parse(input);

            if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
            {
                sum += coins;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coins}");
            }
        }

        while(true)
        {
            string product = Console.ReadLine().ToLower();

            if(product == "end")
            {
                Console.WriteLine($"Change: {sum:F2}");
                break;
            }

            if(product == "nuts")
            {
                if(sum >= 2.0)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= 2.0;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(product == "water")
            {
                if (sum >= 0.7)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= 0.7;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(product == "crisps")
            {
                if (sum >= 1.5)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= 1.5;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(product == "soda")
            {
                if (sum >= 0.8)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= 0.8;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(product == "coke")
            {
                if (sum >= 1.0)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= 1.0;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }
        }
    }
}