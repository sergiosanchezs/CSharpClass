using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp1
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calcBtn_Click(object sender, EventArgs e)
      {

         Square mySquare = new Square();
         bool isNumber = false;
         try
         {
            int length = Convert.ToInt32(lengthTBox.Text);
            int width = Convert.ToInt32(widthTBox.Text);
            int height = Convert.ToInt32(heightTBox.Text);
            mySquare.setLength(length);
            mySquare.setWidth(width);
            mySquare.setHeight(height);
            isNumber = true;
         }
         catch (Exception ex)
         {
            MessageBox.Show("Please fill out the length and width fields or put only numbers");
         }

         if (isNumber)
            MessageBox.Show("The variables are \n\n"
               + "Length: " + mySquare.getLength() + "\n"
               + "Width: " + mySquare.getWidth() + "\n"
               + "Height: " + mySquare.getHeight() + "\n\n"
               + "The Area is " + mySquare.calculateSquareArea());
      }
   }
}
