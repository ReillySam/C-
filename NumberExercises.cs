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