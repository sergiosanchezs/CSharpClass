namespace WFApp1
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.lengthTBox = new System.Windows.Forms.TextBox();
         this.widthTBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.calcBtn = new System.Windows.Forms.Button();
         this.heightTBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(126, 38);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(40, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Length";
         // 
         // lengthTBox
         // 
         this.lengthTBox.Location = new System.Drawing.Point(186, 31);
         this.lengthTBox.Name = "lengthTBox";
         this.lengthTBox.Size = new System.Drawing.Size(100, 20);
         this.lengthTBox.TabIndex = 1;
         // 
         // widthTBox
         // 
         this.widthTBox.Location = new System.Drawing.Point(186, 71);
         this.widthTBox.Name = "widthTBox";
         this.widthTBox.Size = new System.Drawing.Size(100, 20);
         this.widthTBox.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(131, 74);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Width";
         // 
         // calcBtn
         // 
         this.calcBtn.Location = new System.Drawing.Point(173, 159);
         this.calcBtn.Name = "calcBtn";
         this.calcBtn.Size = new System.Drawing.Size(75, 23);
         this.calcBtn.TabIndex = 4;
         this.calcBtn.Text = "Calculate";
         this.calcBtn.UseVisualStyleBackColor = true;
         this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
         // 
         // heightTBox
         // 
         this.heightTBox.Location = new System.Drawing.Point(186, 114);
         this.heightTBox.Name = "heightTBox";
         this.heightTBox.Size = new System.Drawing.Size(100, 20);
         this.heightTBox.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(131, 117);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Height";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(435, 238);
         this.Controls.Add(this.heightTBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.calcBtn);
         this.Controls.Add(this.widthTBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lengthTBox);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthTBox;
        private System.Windows.Forms.TextBox widthTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcBtn;
      private System.Windows.Forms.TextBox heightTBox;
      private System.Windows.Forms.Label label3;
   }
}

