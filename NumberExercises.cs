using System;

/*namespace Exercise_1
{
    // Ask user for two numbers and add them

    public class Add_two_numbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter two numbers:");

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            int sum = one + two;
            Console.WriteLine("Result:\n" + sum);
        }
    }

}*/
// ================================================================================================================================================


/*namespace Exercise_2
{
    // Ask the user for a integer (n) and output the sum of all numbers up to n

    public class Add_n_numbers
    {
        public static void Main()
        {   
            int i, sum = 0, n;
            Console.WriteLine("Enter an integer:");
            n = int.Parse(Console.ReadLine());

            for (i =0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Result:\n" + sum);
        }
    }

}*/
// ================================================================================================================================================


/*namespace Exercise_3
{
    // Ask the user for a integer (n) and list all prime numbers up to that number

    public class Prime_Number
    {
        public static void Main()
        {
            Console.WriteLine("Input a number to find Prime numbers\n");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Prime Numbers are:\n------------------------------");
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 2; j < i; j++) 
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2))
                {
                    Console.Write(i + "\t");
                }

                count = 0;
            }

        }
    }


}*/

// ================================================================================================================================================


/*namespace Exercise_4
{
    // Fibonacci Sequence

    public class Fibonacci
    {
        static int f1 = 0, f2 = 1, f3;
        public static void Main()
        {
            Console.WriteLine("Fibonacci Sequence\nEnter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write(f1+" "+f2);
            for (int i = 2; i <= number; i++)
            {
                f3 = f1 + f2;
                Console.Write(" " + f3);
                f1 = f2;
                f2 = f3;
            }
        }

    }

}*/


// ================================================================================================================================================


namespace Exercise_5
{
    // Factorial
    public class Factorial
    {
        public static void Main()
        {
            Console.WriteLine("Provide an integer for its factorial: ");
            int fact_num = Int32.Parse(Console.ReadLine());

            int fact_result = 1;
            for (int i = 1; i <= fact_num; i++)

            {
                fact_result = fact_result * i;
            }

            Console.WriteLine("Factorial of {0}, is {1}", fact_num, fact_result);
           
        }

    }
}

// ================================================================================================================================================

namespace Exercise_6
{
    // FizzBuzz; if number is divisible by 3 (Fizz), divisible by 5 (Buzz), divisible by both 3 & 5 (FIZZBUZZ)

    public class Fizzbuzz
    {
        public static void Main()
        {
            Console.Write("Input an integer and play FizzBuzz: ");
            int integer = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= integer; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ - {0}" , i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ - {0}", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ - {0}", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}

// ================================================================================================================================================

namespace Exercise_7
{
    // Narcissistic Number; a numbers that's digits powered by its length and sumed are equal to itself e.g. 

    public class NarcissisticNumber
    {
        public static void Main()
        {
            Console.Write("Input an integer and check if it's a Narcissisistic Number: ");
            int integer = int.Parse(Console.ReadLine());

            int num_length = 0;
            string num_str = integer.ToString();
            for (int i = 1; i <= num_str.Length; i++)
            {
                num_length += 1;
            }

            int nar_num = 0;
            for (int i = 1; i <= num_str.Length; i++)
            {
                double powered = Math.Pow(i, num_length);
                int digit = (int)powered;
                nar_num += digit;
                Console.WriteLine(nar_num);
            }

            if (nar_num == (int)integer)
            {
                Console.WriteLine("{0} IS a Narcissistic Number", integer);
            }

            else if (nar_num != integer)
            {
                Console.WriteLine("{0} is NOT a Narcissistic Number", integer);
            }

        }
    }
}
// ================================================================================================================================================

namespace Exercicse_8
{
    /*Write a program that prompts for an integer — let’s call it X — and then finds the
    sum of X consecutive integers starting at 1. That is, if X = 5, you will find the sum
    of 1 + 2 + 3 + 4 + 5 = 15.*/

}
public class Consecutive_sum
{
    public static void Main()
    {
        Console.Write("Enter an integer:");
        int integer = Int32.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= integer; i++)
        {
            sum += i;
            for (int j = 1; j <= sum; j++)
                Console.WriteLine("{} + {} = {}", i, j, sum);

        }

        Console.WriteLine(integer);

    }
}
