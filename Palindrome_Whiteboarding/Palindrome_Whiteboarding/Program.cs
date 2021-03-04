using System;

namespace Palindrome_Whiteboarding
{
    class Program      
    {
        static void Main(string[] args)
        {
            PalindromeMethod("", "");
         
        }

        public static void PalindromeMethod(string stringa, string revstring)
        {
            //Implement a method to determine whether a string is a palindrome.
            // Racecar

            Console.WriteLine("Insert String Here: ");            
            stringa = Console.ReadLine();
            char[] charArray = stringa.ToCharArray();
            Array.Reverse(charArray);
            revstring = new string(charArray);
           


            if (stringa.Equals(revstring))
            {

                Console.WriteLine("Palindrome");

            }

            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            
        }
    }
}
