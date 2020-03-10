using System;

namespace Test2Q2
{
   class Program
   {
      static void Main(string[] args)
      {
         trianglePattern();
      }

      public static void trianglePattern()
      {
         int line, spaces, j,
            totalLines = 4,
            totalSpaces = totalLines - 1,
            symbol = 1;

         for (line = 1; line <= totalLines; line++)
         {
            for(spaces = totalSpaces; spaces >= 1; spaces--)
            {
               Console.Write(" ");
            }
            for (j = 1; j <= line; j++)
            {
               Console.Write(symbol + " ");
               symbol++;
            }
            totalSpaces--;
            Console.WriteLine();
         }
      }
   }
}
