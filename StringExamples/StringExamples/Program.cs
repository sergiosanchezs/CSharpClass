using System;
using System.Collections.Generic;

namespace StringExamples
{
   class Program
   {
      static void Main(string[] args)
      {
         concatPractice();
         separator();
         containsPractice();
         separator();
         lenghtPractice();
         separator();
         substringPractice();
         separator();
         comparePractice();
         separator();
         copyToPractice();
         separator();
         endsWithPractice();
         separator();
         equalsPractice1();
         separator();
         equalsPractice2();
         separator();
         formatPractice();
         separator();
         indexOfPractice();
         separator();
         indexOfAnyPractice();
         separator();
         insertPractice();
         separator();
         isNullOrEmptyPractice();
         separator();
         joinPractice();
         separator();
         lastIndexOfPractice();
         separator();
         removePractice();
         separator();
         replacePractice();
         separator();
         splitPractice();
         separator();
         startsWithPractice();
         separator();
         lowerUpperAndTrimPractice();
         separator();
         toCharArrayPractice();
         separator();
      }

      private static void concatPractice()
      {
         string fname, lname;
         fname = "Sergio";
         lname = "Sanchez";
         string fullname = fname + " " + lname;
         Console.WriteLine($"Full Name: {fullname}");
      }

      private static void containsPractice()
      {
         string example = "This is c# class";
         if (example.Contains("c#"))
         {
            Console.WriteLine("The word 'c#' was found.");
         }
      }

      private static void lenghtPractice()
      {
         string myName = "Sergio Sanchez";
         for (int i = 0; i < myName.Length; i++)
            Console.Write(myName[i]);
         Console.WriteLine("\n-----");
         Console.WriteLine("total number of letter {0}", myName.Length);
      }

      private static void substringPractice()
      {
         string str = "We have Final exam coming up!!!!!";
         Console.WriteLine(str);
         string substr = str.Substring(13);
         string substr2 = str.Substring(5);
         Console.WriteLine(substr);
      }

      private static void comparePractice()
      {
         string str1 = "This is red color";
         string str2 = "This is red color";
         if (String.Compare(str1, str2) == 1)
            Console.WriteLine(str1 + " and " + str2 + " are equal.");
         else
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
      }

      private static void copyPractice()
      {
         string str1 = "This is red color";
         string str2 = String.Copy(str1);
         Console.WriteLine(str2);
      }

      private static void copyToPractice()
      {
         string strSource = "changed";
         char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };
         Console.WriteLine(destination);
         strSource.CopyTo(0, destination, 4, strSource.Length);
         Console.WriteLine(destination);
      }

      private static void endsWithPractice()
      {
         String str = "This is a regular string.";

         if (str.EndsWith("."))
            Console.WriteLine("The string ends in a period.");
         else
            Console.WriteLine("The string doens't ends in a period.");
      }

      private static void equalsPractice1()
      {
         string str1 = "This is red color";
         string str2 = "This is red color";
         if ( str1.Equals(str2) )
            Console.WriteLine(str1 + " and " + str2 + " are equal.");
         else
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
      }
      private static void equalsPractice2()
      {
         string str1 = "This is green color";
         string str2 = "This is green color";
         if (String.Equals(str1, str2))
            Console.WriteLine(str1 + " and " + str2 + " are equal.");
         else
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
      }

      private static void formatPractice()
      {
         Decimal pricePerOunce = 17.36m;
         String s = String.Format("The current price is {0:C2} per ounce.",
                                  pricePerOunce);
         Console.WriteLine(s);
      }

      private static void indexOfPractice()
      {
         string str = "This is green color";
         int idx = str.IndexOf('g');
         Console.WriteLine($"The index of g in \"{str}\" is {idx}");
         idx = str.IndexOf("color");
         Console.WriteLine($"The index of \"color\" in \"{str}\" is {idx}");
         idx = str.IndexOf('g', 4);
         Console.WriteLine($"The index of g starting looking from index 4 in \"{str}\" is {idx}");
         idx = str.IndexOf("color", 10);
         Console.WriteLine($"The index of color starting looking from index 10 in \"{str}\" is {idx}");
      }

      private static void indexOfAnyPractice()
      {
         char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };
         String s = "The long and winding road...";
         Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                           s, s.IndexOfAny(chars) + 1);
         Console.WriteLine($"The first vowel in {s}\nand starting form position 13 is found at position {s.IndexOfAny(chars, 13) + 1}");
      }

      private static void insertPractice()
      {
         string str1 = "This is color";
         string str2 = str1.Insert(7, " yellow");
         Console.WriteLine($"Original string: {str1}\nInserted String: {str2}");
      }
      private static void isNullOrEmptyPractice()
      {
         string str1 = null;
         string str2 = "";
         if (String.IsNullOrEmpty(str1))
            Console.WriteLine($"Is string 1 is null or empty");
         if (String.IsNullOrEmpty(str2))
            Console.WriteLine($"Is string 2 is null or empty");
      }

      private static void joinPractice()
      {
         List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
         Console.WriteLine($"Primes less than 50:");
         Console.WriteLine($"{String.Join(" ", primes)}");

         string[] primeStr = { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47" };
         Console.WriteLine($"Primes less than 50:");
         string str2 = string.Join(" - ", primeStr, 3, 5);
         Console.WriteLine($"{str2}");
      }

      private static void lastIndexOfPractice()
      {
         string str = "This is green color";
         int position = str.LastIndexOf('s');
         Console.WriteLine($"The last s letter in \"{str}\" is {position}");
         str = "The coconut is brown color";
         position = str.LastIndexOf("co");
         Console.WriteLine($"The last s letter in \"{str}\" is {position}");
      }

      private static void removePractice()
      {
         string str = "The coconut is brown color";
         Console.WriteLine($"Original Str: {str}");
         Console.WriteLine($"Remove 1: {str.Remove(11)}");
         Console.WriteLine($"Remove 2: {str.Remove(11, 3)}");
      }

      private static void replacePractice()
      {
         String str = "1 2 3 4 5 6 7 8 9";
         Console.WriteLine("Original string: \"{0}\"", str);
         Console.WriteLine("Modified string by char:      \"{0}\"", str.Replace(' ', '-'));
         Console.WriteLine("Modified string by string:      \"{0}\"", str.Replace(" ", " - "));
      }

      private static void splitPractice()
      {

         string phrase = "The quick brown fox jumps over the lazy dog.";
         string[] words = phrase.Split(' ');
         Console.WriteLine("The first split function: ");
         foreach (var word in words)
            Console.WriteLine($"[{word}]");
         separator();
         Console.WriteLine("The second split function: ");
         string[] words2 = phrase.Split(' ', 4);
         foreach (var word in words2)
            Console.WriteLine($"[{word}]");
      }

      private static void startsWithPractice()
      {
         string str = "The coconut is brown color";
         string strStart = "The";
         if (str.StartsWith(strStart))
            Console.WriteLine($"The string \"{str}\"\nmath at the beginning with the word \"{strStart}\"");
         else
            Console.WriteLine($"The string \"{str}\"\ndoes NOT math at the beginning with the word \"The\"");
      }

      private static void toCharArrayPractice()
      {
         string str = "012wxyz789";
         char[] arr, arr2;

         arr = str.ToCharArray(3, 4);
         arr2 = str.ToCharArray();
         Console.WriteLine("The first toCharArray");
         Console.Write($"The letters in '{str}' are: '");
         Console.Write(arr2);
         Console.WriteLine("'");
         Console.WriteLine($"Each letter in '{str}' is:");
         foreach (char c in arr2)
            Console.WriteLine(c);
         separator();
         Console.WriteLine("The second toCharArray");
         Console.Write($"The letters in '{str}' are: '");
         Console.Write(arr);
         Console.WriteLine("'");
         Console.WriteLine($"Each letter in '{str}' is:");
         foreach (char c in arr)
            Console.WriteLine(c);

      }

      private static void lowerUpperAndTrimPractice()
      {
         string phrase = "          The Quick Brown Fox Jumps Over The Lazy Dog.         ";
         Console.WriteLine($"Original: [{phrase}]");
         Console.WriteLine($"all lower case: [{phrase.ToLower()}]");
         Console.WriteLine($"all upper case: [{phrase.ToUpper()}]");
         Console.WriteLine($"removing whitespaces: [{phrase.Trim()}]");
      }

      private static void separator()
      {
         Console.WriteLine(" ---------------------------------------");
      }

      
   }
}
