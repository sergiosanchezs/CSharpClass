using System;

namespace Chapter2
{
   class Program
   {
      static void Main(string[] args)
      {
         double taxRate = 0.06;
         double itemPrice;
         double taxPrice;
         double totalPrice;
         Console.WriteLine("Please enter the price of the item that you want to buy: ");
         itemPrice = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Now enter the tax percentage from 1 to 100 in your region: ");
         taxRate = Convert.ToDouble(Console.ReadLine()) / 100;
         taxPrice = itemPrice * taxRate;
         totalPrice = itemPrice * (1 + taxRate);
         Console.WriteLine("With {0}% tax, a {1} item costs {2} more\n" + 
            "So the total Cost is {3}", 
            taxRate*100, itemPrice.ToString("C"), taxPrice.ToString("C"), totalPrice.ToString("C"));

      }
   }
}
