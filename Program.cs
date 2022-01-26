/*
    C# Sharp Exercises: Compare two 
    string whether they are equal 
    or not.
 */
using System;

namespace Compare2StringsProj
{
    class Program
    {
        static bool IsSame(string text1, string text2)
        {
            text1 = text1.Trim();
            text2 = text2.Trim();
            if (text1.Length == text2.Length)
            {
                for (int i = 0; i < text1.Length - 1; i++)
                {
                    if (text1[i] != text2[i]) return false;
                }
                return true;
            }
            return false;           
           
        }
        static void Main(string[] args)
        {
            string testWord1 = "This is a test string";
            string testWord2 = "This is a test string ";
            string testWord1b = "This is a bunch of words";
            string testWord2b = "This is nonsense-words: kibbers nz biztz";

            Console.WriteLine(IsSame(testWord1, testWord2));
            Console.WriteLine(IsSame(testWord1b, testWord2b));

        }
    }
}
