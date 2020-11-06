using System;
//Compute the sum of the first 500 prime numbers

public class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Sum of the first 500 prime numbers.\n");
    int prime_sum = 0;
    int prime_count = 0;
    int n = 2;

    while (prime_count < 500)
    {
      if (isPrime(n))
      {
        prime_sum += n;
        prime_count++;
      }
      n++;
    }
    Console.WriteLine(prime_sum); 
  }

  public static bool isPrime (int n) 
  {
    int x = (int)Math.Floor(Math.Sqrt(n));

    if (n == 1) return false;
    if (n == 2) return true;

    for (int i = 2; i <= x; i++)
    {
      if (n % 2 != 0) return true;
    }
    return false;
  }

}

==========================================================================================================================

using System;
//Number guessing game. 

class Program 
{
    static void Main(string[] args) 
    {
        Random rnd = new Random();
        
        int return_value = rnd.Next(1,100);
        int guess = 0;
        Console.WriteLine("I'm thinking of a number between 1 & 100. Can you guess it?");
        
        while (guess != return_value)
        {
            Console.WriteLine("Enter guess: ");
            guess = Int32.Parse(Console.ReadLine());
            if (guess < return_value)
            {
                Console.WriteLine("Nope! Too low, guess again!");
            }
            else if (guess > return_value)
            {
                Console.WriteLine("Nerp! Too high, guess again!");
            }
            else 
            {
                Console.WriteLine("Congratulations!! You got it > {0}", return_value);
            }
            
        }
    }
}
