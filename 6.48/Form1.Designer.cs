﻿namespace _6._48
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
            this.OutputN = new System.Windows.Forms.Label();
            this.OutputX2 = new System.Windows.Forms.Label();
            this.OutputX1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.InputE = new System.Windows.Forms.TextBox();
            this.InputX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputN
            // 
            this.OutputN.AutoSize = true;
            this.OutputN.Location = new System.Drawing.Point(181, 150);
            this.OutputN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputN.Name = "OutputN";
            this.OutputN.Size = new System.Drawing.Size(12, 17);
            this.OutputN.TabIndex = 21;
            this.OutputN.Text = " ";
            // 
            // OutputX2
            // 
            this.OutputX2.AutoSize = true;
            this.OutputX2.Location = new System.Drawing.Point(181, 134);
            this.OutputX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputX2.Name = "OutputX2";
            this.OutputX2.Size = new System.Drawing.Size(12, 17);
            this.OutputX2.TabIndex = 20;
            this.OutputX2.Text = " ";
            // 
            // OutputX1
            // 
            this.OutputX1.AutoSize = true;
            this.OutputX1.Location = new System.Drawing.Point(177, 113);
            this.OutputX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputX1.Name = "OutputX1";
            this.OutputX1.Size = new System.Drawing.Size(12, 17);
            this.OutputX1.TabIndex = 19;
            this.OutputX1.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "N=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "по правой формуле: x=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "по левой формуле: x =";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(23, 69);
            this.Calc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(100, 28);
            this.Calc.TabIndex = 15;
            this.Calc.Text = "посчитать";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // InputE
            // 
            this.InputE.Location = new System.Drawing.Point(51, 37);
            this.InputE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(311, 22);
            this.InputE.TabIndex = 14;
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(51, 5);
            this.InputX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(311, 22);
            this.InputX.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "E=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "X=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.OutputN);
            this.Controls.Add(this.OutputX2);
            this.Controls.Add(this.OutputX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.InputE);
            this.Controls.Add(this.InputX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "6.48";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputN;
        private System.Windows.Forms.Label OutputX2;
        private System.Windows.Forms.Label OutputX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox InputE;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

