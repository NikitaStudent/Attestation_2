using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;

namespace _7._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoArrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ConvertArr.StrToArray<int>(ArrInput.Text);
                ToolsArr toolsArr = new ToolsArr(arr);
                int[] ArrNew = toolsArr.SeriesCount();
                Output.Text = ConvertArr.ArrayToStr(ArrNew);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
