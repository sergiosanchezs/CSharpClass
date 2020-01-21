using System;

namespace Assignment2
{
   class Program
   {
      static void Main(string[] args)
      {
         const int LAST_READING_KWH = 39803;
         const double CHARGE_KWH = 0.095, STANDARD_FEE_PERCENTAGE = 7.1;
         int actual_reading_kwh;
         int total_kwh;
         double totalEnergyCharge, standardMonthlyFee, totalBill;

         Console.WriteLine("Please enter the current meter reading in kWh: ");
         actual_reading_kwh = Convert.ToInt32(Console.ReadLine());

         total_kwh = actual_reading_kwh - LAST_READING_KWH;
         totalEnergyCharge = total_kwh * CHARGE_KWH;
         standardMonthlyFee = (STANDARD_FEE_PERCENTAGE/100.0) * totalEnergyCharge;
         totalBill = totalEnergyCharge + standardMonthlyFee;

         Console.WriteLine("\nCurrent meter reading: {0}\n" + 
                           "Meter reading reported on last month's bill: {1}\n" + 
                           "Total kWh's used: {2}\n\n" +
                           
                           "Total kWh's used: {2}\n" + 
                           "Charge per kWh: ${3}\n" + 
                           "Total energy charge: {4}\n\n" +

                           "Total energy charge: {4}\n" + 
                           "Standard monthly fees({7}%): {5}\n" + 
                           "Total Bill: {6} ",
                           actual_reading_kwh.ToString("N0"),
                           LAST_READING_KWH.ToString("N0"),
                           total_kwh,
                           CHARGE_KWH,
                           totalEnergyCharge.ToString("C"),
                           standardMonthlyFee.ToString("C"),
                           totalBill.ToString("C"),
                           (STANDARD_FEE_PERCENTAGE*1.00).ToString());


      }
   }
}
