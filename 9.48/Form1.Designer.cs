namespace _9._49
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenA = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenB = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.OutputA = new System.Windows.Forms.Label();
            this.InputB = new System.Windows.Forms.DataGridView();
            this.OutputB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputB)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            this.openFileDialog.Tag = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // Open
            // 
            this.Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenA,
            this.OpenB});
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(227, 26);
            this.Open.Text = "открыть";
            // 
            // OpenA
            // 
            this.OpenA.Name = "OpenA";
            this.OpenA.Size = new System.Drawing.Size(94, 26);
            this.OpenA.Text = "A";
            this.OpenA.Click += new System.EventHandler(this.OpenA_Click);
            // 
            // OpenB
            // 
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(94, 26);
            this.OpenB.Text = "B";
            this.OpenB.Click += new System.EventHandler(this.OpenB_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(227, 26);
            this.save.Text = "сохранить результат";
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите мтарицы";
            // 
            // InputA
            // 
            this.InputA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputA.Location = new System.Drawing.Point(16, 59);
            this.InputA.Margin = new System.Windows.Forms.Padding(4);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(424, 281);
            this.InputA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "сумма диагонали первой матрицы";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(16, 347);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 28);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "посчитать сумму диаганалей";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // OutputA
            // 
            this.OutputA.AutoSize = true;
            this.OutputA.Location = new System.Drawing.Point(254, 379);
            this.OutputA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputA.Name = "OutputA";
            this.OutputA.Size = new System.Drawing.Size(0, 17);
            this.OutputA.TabIndex = 8;
            // 
            // InputB
            // 
            this.InputB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputB.Location = new System.Drawing.Point(457, 59);
            this.InputB.Margin = new System.Windows.Forms.Padding(4);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(424, 281);
            this.InputB.TabIndex = 9;
            // 
            // OutputB
            // 
            this.OutputB.AutoSize = true;
            this.OutputB.Location = new System.Drawing.Point(254, 406);
            this.OutputB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputB.Name = "OutputB";
            this.OutputB.Size = new System.Drawing.Size(0, 17);
            this.OutputB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "сумма диагонали второй матрицы";
            // 
            // OutputSum
            // 
            this.OutputSum.AutoSize = true;
            this.OutputSum.Location = new System.Drawing.Point(254, 441);
            this.OutputSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputSum.Name = "OutputSum";
            this.OutputSum.Size = new System.Drawing.Size(0, 17);
            this.OutputSum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "сумма диагоналей двух матриц";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 503);
            this.Controls.Add(this.OutputSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OutputB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.OutputA);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InputA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label OutputA;
        private System.Windows.Forms.DataGridView InputB;
        private System.Windows.Forms.ToolStripMenuItem OpenA;
        private System.Windows.Forms.ToolStripMenuItem OpenB;
        private System.Windows.Forms.Label OutputB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OutputSum;
        private System.Windows.Forms.Label label6;
    }
}

