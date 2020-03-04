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
         diamondV5(userSize, symbol);
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
      /// <summary>
      /// This method prints a Diamond pattern specifying the 
      /// size of the wide section and the the symbol of your
      /// keyboard that you want to be printed.
      /// </summary>
      /// <param name="userSize">This is the size of the wide section of the diamond</param>
      /// <param name="symbol">This is the symbol to be printed. For example, bydefault is '*'.</param>
      private static void diamondV5(int userSize, string symbol = "* ")
      {
         int lineNo, spaces, symbolQty, leftSpaces;
         bool isIncrementing;

         isIncrementing = true;
         leftSpaces = userSize - 1;

         for (lineNo = isIncrementing ? 1 : leftSpaces;
            (isIncrementing && lineNo <= userSize) || 
            (!isIncrementing && lineNo >= 1);
            lineNo = isIncrementing ? lineNo + 1 : lineNo - 1, 
            leftSpaces = isIncrementing ? leftSpaces - 1 : leftSpaces + 1)
         {
            for (spaces = leftSpaces; spaces >= 1; spaces--)
               Console.Write(" ");

            for (symbolQty = isIncrementing ? 1 : lineNo;
               (isIncrementing && symbolQty <= lineNo) || 
               (!isIncrementing && symbolQty >= 1);
               symbolQty = isIncrementing ? symbolQty + 1 : symbolQty - 1)
               Console.Write(symbol);

            if (lineNo == userSize)
               isIncrementing = false;

            Console.WriteLine();
         }
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
