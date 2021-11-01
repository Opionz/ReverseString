using System;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly insert any word ");
            string word = Console.ReadLine();
            string output = ReverseString(word);

            Console.WriteLine($"The reverse of the word \"{word }\" is {output}");
        }

        static string ReverseString(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {

                result += word[i];

            }
            return result;
        }
    }
}
