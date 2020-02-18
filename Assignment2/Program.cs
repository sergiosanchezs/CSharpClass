using System;


namespace Assignment2
{
   class Program
   {
      static void Main(string[] args)
      {
         //===================================================
         /* Enter grades from user */
         //String graded;
         //int gradePercentage = 0;

         //Console.WriteLine("Please enter your grade: ");
         //gradePercentage = Convert.ToInt32(Console.ReadLine());

         //if (gradePercentage > 90)
         //{
         //   graded = "A";
         //}
         //else if (gradePercentage > 80)
         //{
         //   graded = "B";
         //}
         //else if (gradePercentage > 70)
         //{
         //   graded = "C";
         //}
         //else if (gradePercentage > 60)
         //{
         //   graded = "D";
         //}
         //else
         //{
         //   graded = "failed";
         //}

         //if (graded.Length > 1)
         //{
         //   Console.WriteLine("Sorry! You have {0}", graded);
         //}
         //else
         //{
         //   Console.WriteLine("Great! you've pass the course. You got {0} grade!", graded);
         //}

         // ------- 
         //char l = 'k';
         //float b = 19.0f;
         //int c;
         //c = (l / Convert.ToInt32(b));
         //Console.WriteLine(c);
         //c = Convert.ToInt32(l / b);
         //Console.WriteLine(c);

         //----------------
         //float sum;
         //int i;
         //sum = 0.0F;
         //for (i = 1; i <= 10; i++)
         //{
         //   sum = sum + 1 / (float)i;
         //}
         //Console.WriteLine("sum =" + sum);

         //---------------
         int i, j;
         i = (j = 5) + 10;
         Console.WriteLine(i);
         Console.WriteLine(j);

         i = 2;
         j = 4;

         switch (i + j * 2)
         {
            case 1:
            case 2:
               Console.WriteLine("Case 2");
            case > 3:

         }

      }
   }
}
