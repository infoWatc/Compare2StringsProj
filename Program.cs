/*
    C# Sharp Exercises: Compare two 
    string whether they are equal 
    or not.
    Remove whitespace and ignore case

 */
using System;

namespace Compare2StringsProj
{
    class Program
    {
        static void IsSame(string text1, string text2)
        {
            text1 = text1.Trim().ToLower();
            text2 = text2.Trim().ToLower();
            if (text1.Length == text2.Length)
            {
                Console.Write("The length of both strings are equal");
                for (int i = 0; i < text1.Length - 1; i++)
                {
                    if (text1[i] != text2[i])
                    {
                        Console.Write(", and both strings are not equal.\n");
                        Console.WriteLine($"\t{text1}\n \t{text2}");
                        return;
                    }
                }
                Console.Write(" and also, both strings are equal.\n");
                Console.WriteLine($"\t{text1}\n \t{text2}");
                return;
                
            }
            Console.Write("The length of both strings are not equal and also, both strings are not equal.\n");
            Console.WriteLine($"\t{text1}\n \t{text2}");
            return;                    
           
        }
        static void Main(string[] args)
        {
            string testWord1 = "This Is a test string";
            string testWord2 = "This is a test string ";
            string testWord3 = "This is a test strung ";
            string testWord1b = "This is a bunch of words";
            string testWord2b = "This is nonsense-words: kibbers nz biztz";

            IsSame(testWord1, testWord2);
            IsSame(testWord1, testWord3);
            IsSame(testWord1b, testWord2b);

        }
    }
}
