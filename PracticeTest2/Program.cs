using System;

namespace PracticeTest2
{
   class Program
   {
      static void Main(string[] args)
      {
         diamondV3();
         //test26();
         //int n = 1;
         //Console.WriteLine(+n);
         //Console.WriteLine(n);
         //Console.WriteLine(0%3);
         //Console.WriteLine(Convert.ToBoolean(0.1));
      }
      private static void diamondV3()
      {
         int userInput, i, j, k, spaces;
         bool isIncrementing;

         Console.WriteLine("Size of the diamond");
         userInput = Convert.ToInt32(Console.ReadLine());

         isIncrementing = true;
         spaces = userInput - 1;

         for (i = isIncrementing ? 1 : spaces;
            (isIncrementing && i <= userInput) || (!isIncrementing && i >= 1);
            i = isIncrementing ? i + 1 : i - 1, spaces = isIncrementing ? spaces - 1 : spaces + 1)
         {
            for (j = spaces; j >= 1; j--)
               Console.Write(" ");

            for (k = isIncrementing ? 1 : i;
               (isIncrementing && k <= i) || (!isIncrementing && k >= 1);
               k = isIncrementing ? k + 1 : k - 1)
               Console.Write("* ");

            if (i == userInput)
               isIncrementing = false;

            Console.WriteLine();
         }
      }
      private static void diamondV2()
      {
         int i, j, k, spaces = 7;
         bool isIncrementing = true;

         i = isIncrementing ? 1 : 7;
         for (; 
            (isIncrementing && i <= 8) || (!isIncrementing && i >= 1); 
            i = isIncrementing ? i + 1 : i - 1, spaces = isIncrementing ? spaces - 1 : spaces + 1)
         {
            for (j = spaces; j >= 1; j--)
            {
               Console.Write(" ");
            }
           
            for (k = isIncrementing ? 1 : i;
               (isIncrementing && k <= i) || (!isIncrementing && k >= 1); 
               k = isIncrementing ? k + 1 : k - 1)
            {
               Console.Write("* ");
            }
            if (i == 8)
            {
               isIncrementing = false;
            }
            Console.WriteLine();
         }
      }

      private static void diamond()
      {
         int i, j, k, spaces = 7;
         for (i = 1; i <= 8; i++, spaces--)
         {
            for (j = spaces; j >= 1; j--)
            {
               Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
               Console.Write("* ");
            }
            Console.WriteLine();
         }

         spaces = 1;
         for (i = 7; i >= 1; i--, spaces++)
         {
            for (j = spaces; j >= 1; j--)
            {
               Console.Write(" ");
            }
            for (k = i; k >= 1; k--)
            {
               Console.Write("* ");
            }
            Console.WriteLine();
         }
      }
      private static void test26()
      {
         long x;
         x = 1234;
         do
         {
            Console.Write(x % 10);
         } while ((x = x / 10) != 0);
         Console.WriteLine();
      }
      private static void test25()
      {
         int i = 1, j = 5;
         do
         {
            Console.WriteLine(i = i++ * j);
         } while (i <= 10);
      }

      private static void test24()
      {
         int i = 1, j = 1;
         while (++i <= 10)
         {
            j++;
         }
         Console.WriteLine(i + "  " + j);
      }

      private static void test23()
      {
         int i = 0;
         while (i <= 50)
         {
            if (i % 10 == 0)
               continue;
            else
               break;
            i += 10;
            Console.WriteLine(i % 10);
         }
         Console.WriteLine("outside while");
      }

      private static void test22()
      {
         float i = 1.0f, j = 0.05f;
         while (i < 2.0f && j <= 2.0f)
         {
            Console.WriteLine(i++ - ++j);
         }
      }

      private static void test21()
      {
         // inverting the numbers
         int n, r;
         n = 5432;
         while (n > 0)
         {
            r = n % 10;
            n = n / 10;
            Console.Write(+r);
         }
         Console.WriteLine();
      }

      private static void test20()
      {
         int i, j;
         for (i = 1; i <= 3; i++)
         {
            j = 1;
            while (i % j == 2)
            {
               j++;
            }
            Console.WriteLine(i + " " + j);
         }
      }
      private static void test19()
      {
         int i, j;
         for (i = 1, j = i; i <= 3 && j >= 0; i++, j--)
         {
            if (i == j)
               continue;
            else
               Console.WriteLine(j);
         }
      }
      private static void test18()
      {
         int I, J = 0;
         for (I = 1; I < 10;) ;
         {
            J = J + I;
            I += 2;
         }
         Console.WriteLine("Sum of first 10 even numbers is:" + J);
      }
      private static void test17()
      {
         int i, s = 0;
         for (i = 1; i <= 10; s = s + i, i++) ;
         {
            Console.WriteLine(s);
         }
      }

      private static void test16()
      {
         float f;
         for (f = 0.1f; f <= 0.5; f += 1)
            Console.WriteLine(++f);
         Console.WriteLine(f++);
         Console.WriteLine(++f);
      }

      private static void test15()
      {
         int i;
         for (i = 0; ;)
         {
            Console.WriteLine("hello");
         }
      }

      private static void test14()
      {
         char ch = Convert.ToChar('a' | 'b' | 'c');
         Console.WriteLine(Convert.ToChar('a' | 'b'));
         switch (ch)
         {
            case 'A':
            case 'a':
               Console.WriteLine("case A|case a");
               break;
            case 'B':
            case 'b':
               Console.WriteLine("case B|case b");
               break;
            case 'C':
            case 'c':
            case 'D':
            case 'd':
               Console.WriteLine("case D|case d");
               break;
         }
      }
      private static void test13()
      {
         int i = 2, j = 3, k = 4;
         switch (i + j - k)
         {
            case 0:
            case 2:// 3:        --- Compile error
            case 4:
               ++i;
               k += j;
               break;
            case 1:
            case 3:
            case 5:
               --i;
               k -= j;
               break;
            default:
               i += j;
               break;
         }
         Console.WriteLine(i + "\n" + j + "\n" + k);
      }

      private static void test12()
      {
         const int p = 0;
         //Console.WriteLine(3 * 5 / 16);
         switch (3 * 5 / 6)
         {
            case p:
               Console.WriteLine("A");
               break;
            //case p * 1:        // Compile error
            //   Console.WriteLine("B");
            //   break;
            case p - 2:
               Console.WriteLine("C");
               break;
               //default:     // compile error
               //   Console.WriteLine("D");
         }
      }

      private static void test11()
      {
         int i = 2, k = 3;
         switch (i - k)
         {
            case -1:
               ++i;
               ++k;
               break;
            case 2:
               --i;
               ++k;
               break;
            default:
               i += 3;
               k += i;
               break;
         }
         Console.WriteLine(i + "\n" + k);
      }

      private static void test10()
      {
         int i = 2, j = 4;
         switch (i + j * 2)
         {
            case 1:
            case 2:
               Console.WriteLine("1 and 2");
               break;
               //case 3 to 10:      // ; expected
               //   Console.WriteLine("3 to 10");
               //   break;
         }
      }

      private static void test1()
      {
         int i = 30;
         int j = 25 % 25;
         string s = "1";
         //Console.WriteLine(Convert.ToBoolean(Convert.ToInt32(j)));
         if (Convert.ToBoolean(Convert.ToInt32(i = j)))
         {
            Console.WriteLine("In if");
         }
         else
         {
            Console.WriteLine("In else");
         }
         Console.WriteLine("In main");
      }

      private static void test2()
      {
         int i;
         int b = 8, a = 32;
         for (i = 0; i <= 10; i++)
         {
            Console.WriteLine(a / b * 2);
            if ((a / b * 2) == 2)
            {
               Console.WriteLine(i + " ");
               continue;
            }
            else if (i != 4)
               Console.Write(i + " ");
            else
               break;
         }
      }

      private static void test3()
      {
         int i, j;
         for (i = 2; i >= 0; i--)
         {
            for (j = 0; j <= 2; j++)
            {
               if (i == j)
               {
                  Console.Write("1");
               }
               else
               {
                  Console.Write("0");
               }
            }
            Console.WriteLine();
         }
      }

      private static void test4()
      {
         int a = 15, b = 10, c = 1;
         if (Convert.ToBoolean(a) && (b > c))
         {
            Console.WriteLine("cquestionbank");
         }
         else
         {
            //break;    // Compile Error
         }
      }

      private static void test5()
      {
         int a = 5;
         if (Convert.ToBoolean((.002f) - (0.1f)))  // True because its different from 0
            Console.WriteLine("Sachin Tendulkar");
         else if (a == 5)
            Console.WriteLine("Rahul Dravid");
         else
            Console.WriteLine("Ms Dhoni");
      }

      private static void test6()
      {
         int a = -1;
         int b = -1;
         //if (Convert.ToBoolean(++a = ++b)) // Compile Error
         //   Console.WriteLine("a");
         //else
         //   Console.WriteLine("b");
      }

      private static void test7()
      {
         int a = 5, b = 10;
         if (Convert.ToBoolean(Convert.ToInt32(0xB)))
            if (Convert.ToBoolean(Convert.ToInt32(022)))
               if (Convert.ToBoolean(Convert.ToInt32('\xeb')))
                  Console.WriteLine("java");
               else;
            else;
         else;
      }

      private static void test8()
      {
         int a = 5, b = 10;
         if (Convert.ToBoolean(Convert.ToInt32(++a)) || Convert.ToBoolean(Convert.ToInt32(++b)))
         {
            Console.WriteLine(a + "\n" + b);
         }
         else
            Console.WriteLine(" C# ");
      }

      private static void test9()
      {
         int movie = 1;
         switch (movie << 2 + movie)
         {
            default:
               Console.WriteLine("3 Idiots");
               break;
            case 4:
               Console.WriteLine("Ghazini");
               break;
            case 5:
               Console.WriteLine("Krishh");
               break;
            case 8:
               Console.WriteLine("Race");
               break;
         }
      }

   }
}
