namespace Multi_Tool
{
    partial class Calculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox = new System.Windows.Forms.TextBox();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(428, 190);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 42);
            this.button12.TabIndex = 43;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(329, 190);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 42);
            this.button11.TabIndex = 42;
            this.button11.Text = "<";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // equals
            // 
            this.equals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equals.Location = new System.Drawing.Point(530, 190);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(221, 42);
            this.equals.TabIndex = 41;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Simple Calculator with History";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 238);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 186);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(329, 131);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(422, 22);
            this.textBox.TabIndex = 36;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(658, 382);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(93, 42);
            this.divide.TabIndex = 35;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(658, 334);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(93, 42);
            this.multiply.TabIndex = 34;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(658, 238);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(93, 42);
            this.plus.TabIndex = 33;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(658, 286);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(93, 42);
            this.minus.TabIndex = 32;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(431, 382);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 42);
            this.button10.TabIndex = 31;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(530, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 42);
            this.button9.TabIndex = 30;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(431, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 42);
            this.button8.TabIndex = 29;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(329, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 42);
            this.button7.TabIndex = 28;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(530, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 42);
            this.button6.TabIndex = 27;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(431, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 42);
            this.button4.TabIndex = 25;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(329, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(777, 500);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
