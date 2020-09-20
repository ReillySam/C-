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
            int num = int.Parse(Console.ReadLine());
            var n = new Solution();
            Console.WriteLine(n.solution(num));

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

}
