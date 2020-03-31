using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFApp2
{
   class Class1
   {
      public double fare;
      public double discount;
      public Class1()
      {
         fare = 0;
         discount = 0;
      }

      public Class1(double fare, double discount)
      {
         this.fare = fare;
         this.discount = discount;
      }

      public double getFare()
      {
         return fare;
      }

      public void setFare(double fare)
      {
         this.fare = fare;
      }

      public double getDiscount()
      {
         return discount;
      }

      public void setDiscount(double discount)
      {
         this.discount = discount;
      }

      public double getTotalCost()
      {
         return (fare - discount);
      }
   }
}
