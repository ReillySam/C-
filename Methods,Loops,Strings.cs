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
