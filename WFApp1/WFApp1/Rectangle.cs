using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFApp1
{
   public class Rectangle
   {
      public int newWidth;
      public int newLength;
      public int newHeight;

      public Rectangle()
      {
         newWidth = 0;
         newLength = 0;
         newHeight = 0;
      }

      public Rectangle(int length, int width)
      {
         newWidth = width;
         newLength = length;
      }

      public Rectangle(int length, int width, int height)
      {
         newWidth = width;
         newLength = length;
         newHeight = height;
      }

      public int getLength()
      {
         return newLength;
      }
      public void setLength(int length)
      {
         newLength = length;
      }

      public int getWidth()
      {
         return newWidth;
      }

      public void setWidth(int width)
      {
         newWidth = width;
      }

      public int getHeight()
      {
         return newHeight;
      }
      public void setHeight(int height)
      {
         newHeight = height;
      }

      public int calculateArea()
      {
         return (newLength * newWidth);
      }
   }
}
