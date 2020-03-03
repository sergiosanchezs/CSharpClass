using System;

namespace DiamondPattern
{
   class Program
   {
      static void Main(string[] args)
      {
         int userSize;
         string symbol;
         userSize = getSize();
         symbol = getSymbol();
         diamondV4(userSize, symbol);
      }

      private static int getSize()
      {
         Console.WriteLine("Size of wide in the diamond");
         return Convert.ToInt32(Console.ReadLine());
      }

      private static string getSymbol()
      {
         String symbol;
         Console.WriteLine("Which symbol do you want to use in the diamond pattern:");
         symbol = (char)Console.Read() + " ";
         return symbol;
      }

      private static void diamondV4(int userSize, string symbol)
      {
         int i, j, k, spaces;
         bool isIncrementing;

         isIncrementing = true;
         spaces = userSize - 1;

         for (i = isIncrementing ? 1 : spaces;
            (isIncrementing && i <= userSize) || (!isIncrementing && i >= 1);
            i = isIncrementing ? i + 1 : i - 1, spaces = isIncrementing ? spaces - 1 : spaces + 1)
         {
            for (j = spaces; j >= 1; j--)
               Console.Write(" ");

            for (k = isIncrementing ? 1 : i;
               (isIncrementing && k <= i) || (!isIncrementing && k >= 1);
               k = isIncrementing ? k + 1 : k - 1)
               Console.Write(symbol);

            if (i == userSize)
               isIncrementing = false;

            Console.WriteLine();
         }
      }
   }
}
