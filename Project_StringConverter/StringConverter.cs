using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_StringConverter
{
    public static class StringConverter
    {
        // Reverse Method
        public static void Reverse()
        {
            // Get user input
            string userInput = Program.GetUserInput();

            // With Inbuilt Method Array.Reverse Method  
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            // Show the result
            Console.WriteLine(" Your reversed string: {0}", result);


            //If user would try this Method again
            string userChoice = Program.TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                Reverse();
            }
            else
            {
                Program.MainManu();
            }
        }


        // Palindrome Method
        public static void IsPalindrome()
        {
            // Get user input
            string userInput = Program.GetUserInput();

            // Remove all characters that are not digit or letter
            var strippedText = StripText(userInput);

            // Reverse the stripped text
            var textReversed = ReverseText(strippedText);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            // Show the result
            if (strippedText.ToLower() == textReversed.ToLower())
            {
                Console.WriteLine($" Output: {textReversed} \n\n This is a palindrome!");
            }
            else
            {
                Console.WriteLine($" Output: {textReversed} \n\n This is NOT a palindrome!");

            }

            //If user would try this Method again
            string userChoice = Program.TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                IsPalindrome();
            }
            else
            {
                Program.MainManu();
            }
        }


        // Pig Latin Method
        public static void PigLatinate()
        {
            // Get user input
            string userInput = Program.GetUserInput();

            const string vowels = "AEIOUaeio";
            string[] words = userInput.Split(' ');

            List<string> pigLatin = new List<string>();
            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                string lastLetter = word.Substring(word.Length - 1);
                int firstLetterIsAVowel = vowels.IndexOf(firstLetter); 
                // If the first letter does not have an index in vowels string, then it is less than Zero, otherwise it is equal or bigger than Zero

                if (!ContainsVowel(word))
                {
                    pigLatin.Add(StripText(word) + "ay");
                }
                else if (firstLetterIsAVowel >= 0)
                {
                    pigLatin.Add(StripText(word) + "yay");
                } 
                else if (firstLetterIsAVowel == -1 && ContainsVowel(word))
                {
                    pigLatin.Add(StripText(restOfWord) + firstLetter + "ay");
                }
                else
                {
                    pigLatin.Add(word + " ");
                }
            }

            string result = string.Join(" ", pigLatin);
            string firstWord = pigLatin.ElementAt(0);

            // This makes captilized the first letter of the first word
            firstWord = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstWord.ToLower());

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;
            Console.WriteLine(" Pig Latin form of your input: {0}", firstWord + result.Substring(firstWord.Length));


            //If user would try this Method again
            Console.CursorTop = Console.CursorTop + 1;
            string userChoice = Program.TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                PigLatinate();
            }
            else
            {
                Program.MainManu();
            }
        }

        // Shorthand Method
        public static void Shorthand()
        {
            // Get user input
            string userInput = Program.GetUserInput();

            string[] words = userInput.Split(' ');

            List<string> shorthand = new List<string>();

            //loop 
            foreach (string word in words)
            {
                // If the first letter does not have an index in vowels string, then it is less than Zero, otherwise it is equal or bigger than Zero
                string temp = word.ToLower();
                if (!ContainsSpecificTerms(temp))
                {
                    shorthand.Add(word.Replace("i", "").Replace("o", "").Replace("a", "").Replace("u", "").Replace("e", ""));
                }
                else
                {
                    // multiple word replacements
                    shorthand.Add(temp.Replace("to", "2").Replace("you", "U").Replace("for", "4").Replace("be", "B").Replace("are", "R").Replace("and", "&").Replace("i", "").Replace("o", "").Replace("a", "").Replace("u", "").Replace("e", "").Replace("y", ""));
                }
            }

            string result = string.Join(" ", shorthand);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;
            Console.WriteLine(" Shorthand form of your input: {0}", result);


            //If user would try this Method again
            Console.CursorTop = Console.CursorTop + 1;
            string userChoice = Program.TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                Shorthand();
            }
            else
            {
                Program.MainManu();
            }
        }

        // String Checker Method
        private static string[] specificTerms = new[] { "to", "you", "for", "be", "are", "and"};
        public static bool ContainsSpecificTerms(string word)
        {
            foreach (string term in specificTerms)
            {
                if (word.Contains(term))
                {
                    return true;
                }
            }
            return false;
        }


        // Vowel Checker Method
        private static char[] vowels = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        public static bool ContainsVowel(string word)
        {
            foreach (char vowel in vowels)
            {
                if (word.Contains(vowel))
                {
                    return true;
                }
            }
            return false;
        }

        // This is the method to get strip of the text
        private static string StripText(string input)
        {

            var strippedText = "";
            foreach (var c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    strippedText = strippedText + c.ToString().ToLower();
                }
            }
            return strippedText;
        }

        // Reverse Method (Additional)
        private static string ReverseText(string input)
        {
            var textReversed = "";
            for (var i = 0; i < input.Length; i++)
            {

                string letter = input[i].ToString();
                textReversed = letter + textReversed;
            }
            return textReversed;
        }

    }
}
