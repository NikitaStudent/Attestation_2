using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsGrid;
using tools;

namespace _9._49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputA, 40, false, false, false, true, false,true);
            DataGridViewUtils.InitGridForArr(InputB, 40, false, false, false, true, false, true);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] Arr2A = DataGridViewUtils.GridToArray2<int>(InputA);
                int[,] Arr2B = DataGridViewUtils.GridToArray2<int>(InputB);
                ToolsArr2 toolsArr2 = new ToolsArr2(Arr2A);
                int A = toolsArr2.GetDiagSum();
                OutputA.Text = A.ToString();
                toolsArr2 = new ToolsArr2(Arr2B);
                int B = toolsArr2.GetDiagSum();
                OutputB.Text = B.ToString();
                OutputSum.Text = (A + B).ToString();
                save.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }

        private void OpenA_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToolsFile file = new ToolsFile(openFileDialog.FileName);
                    int[,] Arr2 = file.ReadArr2();
                    DataGridViewUtils.Array2ToGrid(InputA, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void OpenB_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToolsFile file = new ToolsFile(openFileDialog.FileName);
                    int[,] Arr2 = file.ReadArr2();
                    DataGridViewUtils.Array2ToGrid(InputB, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToolsFile file = new ToolsFile(saveFileDialog.FileName);
                    file.WriteStr(OutputA.Text + " " + OutputB.Text + " " + OutputSum.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }
    }
}
