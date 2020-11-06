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
//Find the product of corresponding items in arrays
class MainClass {
  public static void Main (string[] args) 
  {
    int[] array_1 = {1, 3, -5, 4};
    int[] array_2 = {1, 4, -5, -2};


    Console.WriteLine("Array 1: [{0}]", string.Join(", ", array_1));
    Console.WriteLine("Array 2: [{0}]", string.Join(", ", array_2));

    Console.WriteLine("Product of each corresponding array elements\n");

    for (int i = 0; i < array_1.Length; i++)
    {
      Console.Write(array_1[i] * array_2[i] + " ");
    }
     Console.WriteLine("\n");
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
