﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFApp1
{
   class Square : Rectangle
   {
      public int calculateSquareArea()
      {
         return (newLength * newWidth * newHeight);
      }
   }
}
