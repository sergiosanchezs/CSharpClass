using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp2
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calcBtn_Click(object sender, EventArgs e)
      {
         Class1 disc = new Class1();
         bool isNumber = false;
         string name = nameTBox.Text;
         string age = ageTBox.Text;

         try
         {
            double fare = Convert.ToDouble(fareTBox.Text);
            double discount = Convert.ToDouble(discountTBox.Text);
            disc.setFare(fare);
            disc.setDiscount(discount);
            isNumber = true;
         }
         catch (Exception ex)
         {
            MessageBox.Show("Please fill out the fare and discount fields or put only numbers");
         }

         if (isNumber)
            MessageBox.Show("Hi " + name + "\n" +
               "The total Cost is " + disc.getTotalCost());

      }
   }
}
