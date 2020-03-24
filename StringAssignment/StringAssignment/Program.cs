using System;

namespace StringAssignment
{
   class Program
   {
      static void Main(string[] args)
      {
         exercise1();
         separator();
         exercise2();
         separator();
         exercise3();
         separator();
         exercise4();
         separator();
         exercise5();
         separator();
      }

      private static string userInput(String displayMessage)
      {
         Console.WriteLine(displayMessage);
         String str = Console.ReadLine().Trim();
         return str;
      }

      // 1.	Write a C# program, user will enter String and display string in reverse order 
      private static void exercise1()
      {
         
         string str, reverseStr;

         Console.WriteLine("This program receive a string to display it in reverse order.");
         str = userInput("Please enter a string:");

         reverseStr = "";
         for (int i = str.Length - 1; i >= 0; i--)
            reverseStr += str[i];
         Console.WriteLine($"The reverse string is: {reverseStr}");
      }
      
      // 2.	Write a C# program, user will enter a string then count total 
      //    number of words and characters (make two methods one for each).
      private static void exercise2()
      {
         string str;
         Console.WriteLine("This program calculate the number of words and characters in a string.");
         str = userInput("Please enter a string:");

         int numChar = calculateNumberOfCharacters(str);
         string isOrAreChar = numChar > 1 ? "are" : "is";

         int numWords = calculateNumberOfWords(str);
         string isOrAreWords = numWords > 1 ? "are" : "is";

         Console.WriteLine($"The number of words in the string {isOrAreWords} {numWords}");
         Console.WriteLine($"The number of characters in the string {isOrAreChar} {numChar}");

      }

      private static int calculateNumberOfCharacters(string str)
      {
         char[] arrayChar = str.ToCharArray();
         return arrayChar.Length;
      }

      private static int calculateNumberOfWords(string str)
      {
         string[] words = str.Split(' ');
         return words.Length;
      }

      // 3.	Write a C# program, user will enter a string then 
      //    calculate total number of alphabets, characters, spaces, numbers 
      private static void exercise3()
      {
         string str;
         Console.WriteLine("This program calculate the number of alphabets, characters, spaces, and numbers in a string.");
         str = userInput("Please enter a string:");

         int numAlphabets = calculateNumberOfAlphabets(str);
         string isOrAreAlphabets = numAlphabets > 1 ? "are" : "is";

         int numChar = calculateNumberOfCharacters(str);
         string isOrAreChar = numChar > 1 ? "are" : "is";

         int numSpaces = calculateNumberOfSpaces(str);
         string isOrAreSpaces = numSpaces > 1 ? "are" : "is";

         int numNumbers = calculateNumberOfNumbers(str);
         string isOrAreNumbers = numNumbers > 1 ? "are" : "is";

         Console.WriteLine($"The number of alphabets in the string {isOrAreAlphabets} {numAlphabets}");
         Console.WriteLine($"The number of characters in the string {isOrAreChar} {numChar}");
         Console.WriteLine($"The number of spaces in the string {isOrAreSpaces} {numSpaces}");
         Console.WriteLine($"The number of numbers in the string {isOrAreNumbers} {numNumbers}");

      }

      private static int calculateNumberOfAlphabets(string str)
      {
         char[] arrayChar = str.ToCharArray();
         int numAlphabets = 0;
         foreach (int ch in arrayChar)
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
               numAlphabets++;

         return numAlphabets;
      }

      private static int calculateNumberOfSpaces(string str)
      {
         char[] arrayChar = str.ToCharArray();
         int numSpaces = 0;
         foreach (int ch in arrayChar)
            if (ch == ' ')
               numSpaces++;

         return numSpaces;
      }

      private static int calculateNumberOfNumbers(string str)
      {
         char[] arrayChar = str.ToCharArray();
         int numNumbers = 0;
         foreach (int ch in arrayChar)
            if (ch >= '0' && ch <= '9')
               numNumbers++;

         return numNumbers;
      }

      // 4.	Write a C# program, user will enter a string in UPPERCASE, display that in lower case
      private static void exercise4()
      {
         string str;
         Console.WriteLine("This program convert your UPPERCASE string to lowercase.");
         str = userInput("Please enter a string:");
         Console.WriteLine($"The string in lowercase \"{str.ToLower()}\"");
      }

      // 5.	Write a C# program, with email and password and allow user to enter 
      //    in if they match otherwise display message user id blocked 
      private static void exercise5()
      {
         const string USERNAME = "ssanchez";
         const string PASSWORD = "Abc123";
         
         string username = userInput("Please enter your username:");

         string password = userInput("Please enter your password:");

         if (username.ToLower().Equals(USERNAME) && password.Equals(PASSWORD))
            Console.WriteLine("Congratulations! Access Granted.");
         else
            Console.WriteLine("User ID has been blocked!");
            
      }
      private static void separator()
      {
         Console.WriteLine(" ---------------------------------------");
      }

   }
}
