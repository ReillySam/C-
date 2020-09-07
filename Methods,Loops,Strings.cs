namespace Methods_Loops_Strings
// How many 3 digit numbers are divisible by 17. Print them.
{
    class Program
    {
        static void Main(string[] args)
        {
      
            List<int> divisible_list = new List<int>();
            int count = 0;
            for (int i = 100; i < 1000; i++)
            {  
                if (i % 17 == 0)
                {
                    divisible_list.Add(i);
                    count += 1;
                }
            }

            foreach (int element in divisible_list)
            {
                Console.WriteLine(element);
            }    

            Console.WriteLine("All 3 digit numbers divisible by 17");
            Console.WriteLine("Total = {0}", count);

        }

    }
}

// ====================================================================================================================================================================================================

// Exercise 2
// Suppose you have a string ab_string = 'abababababababab' . Write an expression to remove all the b’s and create a string a string = 'aaaaaaaa' .
class Program
{
    static void Main(string[] args)
    {
        string str = "abababababababab";
        Console.WriteLine(str);

        Console.WriteLine(str.Replace("b", ""));
    }
}

// ====================================================================================================================================================================================================

// Exercise 3
// Write a Python program that will swap two random letters in a string. Hint: Random letters means “letters with random index”

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string string_1 = Console.ReadLine();

        // Console.WriteLine(string_1.Replace(string_1[0], string_1[^1]));

        for (var i = 1; i < string_1.Length; i++)
        {
            if (string_1[i] == "a")
            {
                string_1.Replace("a", "b");
            }
            else if (string_1[i] == "b")
            {
                string_1.Replace("b", "a");
            }
            else
            {
                continue;
            }

        }
        Console.WriteLine(string_1);

    }
}
