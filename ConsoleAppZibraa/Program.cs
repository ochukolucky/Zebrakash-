using System;

namespace ConsoleAppZubra
{

    public class Program
    {
        
        public static void Main(string[] args)
        {
         // ReverseMethod("Zebrakash");
            reverseString("backword");
        }


        // using for loop
        private static void ReverseMethod(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();

            string reverse = string.Empty;

            for (int i = charArray.Length - 1; i > 0; i--)
            {
                reverse += charArray[i];
            }

            Console.WriteLine(reverse);

            Console.ReadLine();
        }

        // With Inbuilt Method Array.Reverse Method 
        private static void reverseString(string input)
        {
           char[] charArray = input.ToCharArray();
           Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }


    }
}

