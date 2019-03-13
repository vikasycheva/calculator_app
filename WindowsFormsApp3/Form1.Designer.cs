namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstArgument = new System.Windows.Forms.TextBox();
            this.secondArgument = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.hyperbola = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.geometric = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arithmetic = new System.Windows.Forms.Button();
            this.integerDivision = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.tenPowerOf = new System.Windows.Forms.Button();
            this.twoPowerOf = new System.Windows.Forms.Button();
            this.naturalLogarithm = new System.Windows.Forms.Button();
            this.logTwo = new System.Windows.Forms.Button();
            this.logTen = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(33, 37);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(75, 20);
            this.firstArgument.TabIndex = 0;
            this.firstArgument.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondArgument
            // 
            this.secondArgument.Location = new System.Drawing.Point(114, 37);
            this.secondArgument.Name = "secondArgument";
            this.secondArgument.Size = new System.Drawing.Size(75, 20);
            this.secondArgument.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(230, 37);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(157, 20);
            this.result.TabIndex = 2;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(33, 102);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(33, 130);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 23);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(114, 102);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(114, 130);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(131, 224);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 10;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(50, 224);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 11;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // remainder
            // 
            this.remainder.Location = new System.Drawing.Point(311, 102);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(75, 23);
            this.remainder.TabIndex = 12;
            this.remainder.Text = "mod";
            this.remainder.UseVisualStyleBackColor = true;
            this.remainder.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(293, 224);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 13;
            this.ctan.Text = "cotan";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // hyperbola
            // 
            this.hyperbola.Location = new System.Drawing.Point(293, 284);
            this.hyperbola.Name = "hyperbola";
            this.hyperbola.Size = new System.Drawing.Size(75, 23);
            this.hyperbola.TabIndex = 14;
            this.hyperbola.Text = "1/x";
            this.hyperbola.UseVisualStyleBackColor = true;
            this.hyperbola.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(212, 224);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(50, 254);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 16;
            this.arctan.Text = "arctan";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(230, 131);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 17;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // geometric
            // 
            this.geometric.Location = new System.Drawing.Point(311, 160);
            this.geometric.Name = "geometric";
            this.geometric.Size = new System.Drawing.Size(75, 23);
            this.geometric.TabIndex = 18;
            this.geometric.Text = "geometric";
            this.geometric.UseVisualStyleBackColor = true;
            this.geometric.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(293, 254);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 23);
            this.negative.TabIndex = 19;
            this.negative.Text = "-x";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(131, 254);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 20;
            this.arcsin.Text = "arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(212, 254);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 21;
            this.arccos.Text = "arccos";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // arithmetic
            // 
            this.arithmetic.Location = new System.Drawing.Point(230, 159);
            this.arithmetic.Name = "arithmetic";
            this.arithmetic.Size = new System.Drawing.Size(75, 23);
            this.arithmetic.TabIndex = 22;
            this.arithmetic.Text = "arithmetic";
            this.arithmetic.UseVisualStyleBackColor = true;
            this.arithmetic.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // integerDivision
            // 
            this.integerDivision.Location = new System.Drawing.Point(230, 102);
            this.integerDivision.Name = "integerDivision";
            this.integerDivision.Size = new System.Drawing.Size(75, 23);
            this.integerDivision.TabIndex = 23;
            this.integerDivision.Text = "div";
            this.integerDivision.UseVisualStyleBackColor = true;
            this.integerDivision.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(311, 131);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 24;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(50, 284);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 25;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // tenPowerOf
            // 
            this.tenPowerOf.Location = new System.Drawing.Point(293, 313);
            this.tenPowerOf.Name = "tenPowerOf";
            this.tenPowerOf.Size = new System.Drawing.Size(75, 23);
            this.tenPowerOf.TabIndex = 26;
            this.tenPowerOf.Text = "10^x";
            this.tenPowerOf.UseVisualStyleBackColor = true;
            this.tenPowerOf.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // twoPowerOf
            // 
            this.twoPowerOf.Location = new System.Drawing.Point(212, 313);
            this.twoPowerOf.Name = "twoPowerOf";
            this.twoPowerOf.Size = new System.Drawing.Size(75, 23);
            this.twoPowerOf.TabIndex = 27;
            this.twoPowerOf.Text = "2^x";
            this.twoPowerOf.UseVisualStyleBackColor = true;
            this.twoPowerOf.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // naturalLogarithm
            // 
            this.naturalLogarithm.Location = new System.Drawing.Point(131, 284);
            this.naturalLogarithm.Name = "naturalLogarithm";
            this.naturalLogarithm.Size = new System.Drawing.Size(75, 23);
            this.naturalLogarithm.TabIndex = 28;
            this.naturalLogarithm.Text = "ln";
            this.naturalLogarithm.UseVisualStyleBackColor = true;
            this.naturalLogarithm.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // logTwo
            // 
            this.logTwo.Location = new System.Drawing.Point(212, 284);
            this.logTwo.Name = "logTwo";
            this.logTwo.Size = new System.Drawing.Size(75, 23);
            this.logTwo.TabIndex = 29;
            this.logTwo.Text = "log2";
            this.logTwo.UseVisualStyleBackColor = true;
            this.logTwo.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // logTen
            // 
            this.logTen.Location = new System.Drawing.Point(50, 313);
            this.logTen.Name = "logTen";
            this.logTen.Size = new System.Drawing.Size(75, 23);
            this.logTen.TabIndex = 30;
            this.logTen.Text = "log10";
            this.logTen.UseVisualStyleBackColor = true;
            this.logTen.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(131, 313);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(75, 23);
            this.sqr.TabIndex = 31;
            this.sqr.Text = "x^2";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "One Argument operations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Two argument operations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Basic arithmetic operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.logTen);
            this.Controls.Add(this.logTwo);
            this.Controls.Add(this.naturalLogarithm);
            this.Controls.Add(this.twoPowerOf);
            this.Controls.Add(this.tenPowerOf);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.max);
            this.Controls.Add(this.integerDivision);
            this.Controls.Add(this.arithmetic);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.geometric);
            this.Controls.Add(this.min);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.hyperbola);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondArgument);
            this.Controls.Add(this.firstArgument);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArgument;
        private System.Windows.Forms.TextBox secondArgument;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;

        

       

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button remainder;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button hyperbola;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button geometric;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arithmetic;
        private System.Windows.Forms.Button integerDivision;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button tenPowerOf;
        private System.Windows.Forms.Button twoPowerOf;
        private System.Windows.Forms.Button naturalLogarithm;
        private System.Windows.Forms.Button logTwo;
        private System.Windows.Forms.Button logTen;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

