//Basic syntax, conditional statements and loop - exercise, Task 005
//09.06.2025, 00:09

public class Login
{
    static void Main()
    {
        string username = Console.ReadLine();

        int wrongPassCnt = 0;
        string password = string.Empty;

        for(int i = username.Length - 1; i >= 0; i--)
        {
            password += username[i];
        }

        while(true)
        {
            string pass = Console.ReadLine();

            if(wrongPassCnt >= 3)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }

            if(pass != password)
            {
                wrongPassCnt++;
                Console.WriteLine("Incorrect password. Try again.");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
        }
    }
}