namespace WFApp2
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
         this.calcBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.nameTBox = new System.Windows.Forms.TextBox();
         this.ageTBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.fareTBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.discountTBox = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // calcBtn
         // 
         this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.calcBtn.Location = new System.Drawing.Point(189, 246);
         this.calcBtn.Name = "calcBtn";
         this.calcBtn.Size = new System.Drawing.Size(160, 60);
         this.calcBtn.TabIndex = 0;
         this.calcBtn.Text = "Calculate";
         this.calcBtn.UseVisualStyleBackColor = true;
         this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(162, 46);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(45, 17);
         this.label1.TabIndex = 1;
         this.label1.Text = "Name";
         // 
         // nameTBox
         // 
         this.nameTBox.Location = new System.Drawing.Point(226, 43);
         this.nameTBox.Name = "nameTBox";
         this.nameTBox.Size = new System.Drawing.Size(100, 22);
         this.nameTBox.TabIndex = 2;
         // 
         // ageTBox
         // 
         this.ageTBox.Location = new System.Drawing.Point(226, 89);
         this.ageTBox.Name = "ageTBox";
         this.ageTBox.Size = new System.Drawing.Size(100, 22);
         this.ageTBox.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(174, 89);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(33, 17);
         this.label2.TabIndex = 3;
         this.label2.Text = "Age";
         // 
         // fareTBox
         // 
         this.fareTBox.Location = new System.Drawing.Point(226, 135);
         this.fareTBox.Name = "fareTBox";
         this.fareTBox.Size = new System.Drawing.Size(100, 22);
         this.fareTBox.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(170, 138);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(37, 17);
         this.label3.TabIndex = 5;
         this.label3.Text = "Fare";
         // 
         // discountTBox
         // 
         this.discountTBox.Location = new System.Drawing.Point(226, 181);
         this.discountTBox.Name = "discountTBox";
         this.discountTBox.Size = new System.Drawing.Size(100, 22);
         this.discountTBox.TabIndex = 8;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(144, 181);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(63, 17);
         this.label4.TabIndex = 7;
         this.label4.Text = "Discount";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(170, 332);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(179, 17);
         this.label5.TabIndex = 9;
         this.label5.Text = "Design by: Sergio Sanchez";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(536, 358);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.discountTBox);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.fareTBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.ageTBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.nameTBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.calcBtn);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.TextBox ageTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fareTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discountTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

