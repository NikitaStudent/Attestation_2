namespace _7._48
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OneOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(65, 64);
            this.CalcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(240, 38);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "посчитать значения ";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(20, 32);
            this.ArrInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(335, 22);
            this.ArrInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "введите массив";
            // 
            // OneOutput
            // 
            this.OneOutput.AutoSize = true;
            this.OneOutput.Location = new System.Drawing.Point(17, 123);
            this.OneOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OneOutput.Name = "OneOutput";
            this.OneOutput.Size = new System.Drawing.Size(12, 17);
            this.OneOutput.TabIndex = 10;
            this.OneOutput.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Больше хотя бы одного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Больше всех";
            // 
            // Alloutput
            // 
            this.AllOutput.AutoSize = true;
            this.AllOutput.Location = new System.Drawing.Point(17, 169);
            this.AllOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllOutput.Name = "Alloutput";
            this.AllOutput.Size = new System.Drawing.Size(12, 17);
            this.AllOutput.TabIndex = 12;
            this.AllOutput.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OneOutput);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "7.48";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OneOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AllOutput;
    }
}

