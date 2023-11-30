using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectNumber(userInput))
        {
            Console.WriteLine($"{userInput} is a Perfect Number");
        }
        else
        {
            Console.WriteLine($"{userInput} is Not A Perfect Number");
        }
  }

    static bool IsPerfectNumber(int num)
    {
        int sum = 0;

        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum == num;
  }
}