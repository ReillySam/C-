using System;

/*
    Collection of exercises about the fundamentals of C# for revision and prep.Includes basic algorithms and
    Codility algorithm exercises.A mix of easy and medium.
    They are prep interview questions for technical skill development and understanding.
*/



/*    =========================================================================================================================================================== #
                                                                        # Exercise 1 - Binary Gap

    A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded
    by ones at both ends in the binary representation of N.For example, number 9 has binary representation 1001 
    and contains a binary gap of length 2, given N = 1041 the function should return 5, because N has binary
    representation 10000010001 and so its longest binary gap is of length 5  

*/

namespace CodilityExercises.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number and find its maximum binary gap length: ");
            int integer = int.Parse(Console.ReadLine());
            var n = new Solution();
            Console.WriteLine(n.solution(integer));

        }
    }

    class Solution
    {

        public int solution(int num)
        {
            string binary = Convert.ToString(num, 2);
            // Console.WriteLine(binary);

            int max_gap = 0;
            int gap = 0;
            int current_gap = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    if (current_gap > 0) current_gap++;
                    else current_gap = 1;

                }
                else current_gap = 0;

                if (current_gap > max_gap) max_gap = current_gap;
                if (binary[i] == '1' && gap > max_gap) max_gap = gap;
            }
            Console.WriteLine(binary);
            return max_gap;
        }
    }


/*    =========================================================================================================================================================== #
                                                                        # Exercise 2 - Smallest Positive Integer

    You are given an unsorted array with both positive and negative elements. You have to find the smallest positive 
    number missing from the array in O(n) time using constant extra space. You can modify the original array.

    Example:
    Input:  {2, 3, 7, 6, 8, -1, -10, 15}
    Output: 1

*/

    class Program
    {
        static void Main(int[] args)
        {
            int[] num_array = new int[] { 2, 3, 7, 6, 8, -1, -10, 15 };
            var n = new Solution();
            Console.WriteLine(n.Smallest(num_array));
        }

    }
    class Solution
    {
        public int Smallest(int[] numbers)
        {

            int smallest_pos_int = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 0) return 0;
                if (i == smallest_pos_int)
                {
                    smallest_pos_int += 1;
                }

            }
            Console.WriteLine("Smallest Positive inetger = {}", smallest_pos_int);
            return smallest_pos_int;

        }

    }
}

/*    =========================================================================================================================================================== #
                                                                        # Exercise 3 - Product of Knumbers
      
        Implement the class ProductOfNumbers that supports two methods:

        1. add(int num)
        Adds the number num to the back of the current list of numbers.

        2. getProduct(int k)
        Returns the product of the last k numbers in the current list.
        You can assume that always the current list has at least k numbers
*/

class ProductOfNumbers
// Add number(k) to end of array. Multiply array ending k numbers by k.
{
    static List<int> num_list = new List<int>{5, 2, 8, 5, 9, 1};
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Product of Numbers");
        Console.WriteLine(" ", string.Join(", ", num_list.ToString()));
        Console.WriteLine("Input a number: ");
        int num = Int32.Parse(Console.ReadLine());
        
        add(num);
        getProduct(num);
        
        Console.WriteLine(" ", string.Join(", ", num_list));
        Console.Write("Updated array: ");
        
    }
    
    private static void add(int num)
    // Add number(k) to end of array.
    {
        if (num == 0)
        {
            num_list.Clear();
            Console.WriteLine(" ", string.Join(", ", num_list));
        }
        
        else
        {
            num_list.Add(num_list[num_list.Count - 1] * num);
            Console.WriteLine("Add {0}} > {1}", num, string.Join(", ", num_list));    
        }
        
    }
    
    private static void getProduct(int k)
    // Multiply array ending k numbers by k.
    {
        int size = num_list.Count;
        
        if (k == size)
        {
            return (int) num_list[size - 1];
        }
        
        else if (k > size)
        {
            return 0;
        }
        
        else
        {
            var prev_index = num_list[num_list.Count - k - 1];
            if (prev_index == 0)
            {
                return (int) (num_list[num_list.Count - 1]);
            }
            
            return (int) (num_list[num_list.Count - k - 1] / prev_index);
        }

        // for (int i = k; i <= size; i++)
        // {
        //     num_list[num_list.Count - i] = num_list[num_list.Count - i] * k;
        // }
        
        // return (int) num_list;
    }
}
