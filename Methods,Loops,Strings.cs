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
// Write a program that will swap two random letters in a string. Hint: Random letters means “letters with random index”

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string string_1 = Console.ReadLine();

        // index first and last elements and swap them using replace
        Console.WriteLine(string_1.Replace(string_1[0], string_1[^1]), string_1.Replace(string_1[^1], string_1[0]));
    }
}


// ====================================================================================================================================================================================================

// Exercise 4 
/*Pig Latin program
Pig Latin is a game of alterations played on words. To make the Pig Latin form of an English word the initial consonant sound is transposed to the end of the word and an
“ay” is affixed. Specifically there are two rules:
(a) If a word begins with a vowel, append “yay” to the end of the word.
(b) If a word begins with a consonant, remove all the consonants from the beginning up to the first vowel and append them to the end of the word. Finally, append “ay”
to the end of the word*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();

        while (word != "/")
        {

            // find the vowel index
            int vowel_position = -1;
            foreach (char letter in word)
            {
                vowel_position += 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    break;
                }
            }

            // apply rules
            string piglatin_word = "";
            string consonants = "";
            switch (vowel_position)
            {
                case 0:
                    piglatin_word = word + "yay";
                    break;
                case 1:
                    consonants = word.Substring(0, vowel_position);
                    piglatin_word = word + consonants + "ay";
                    break;
                default:
                    piglatin_word = "Unable to translate";
                    break;

            }

            Console.WriteLine("Translation: " + piglatin_word);
            Console.WriteLine("Enter another word (type '/' to exit): ");
            word = Console.ReadLine();

        }
    }
}
