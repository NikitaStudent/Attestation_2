using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr2
    {
        private int[,] Temp;
        private bool[,] BoolTemp;
        public int[,] Arr2 { get; set; }
        public ToolsArr2(int[,] arr2)
        {
            Arr2 = arr2;
        }

        public bool[,] GetSaddlet()
        {
            int[] columns = new int[Arr2.GetLength(1)];
            int[] rows = new int[Arr2.GetLength(0)];
            for (int i = 0; i < columns.Length; i++)
                columns[i] = MaxInColumn(i);
            for (int i = 0; i < rows.Length; i++)
                rows[i] = MinInRow(i);
            bool[,] Arr2Bool = new bool[Arr2.GetLength(0), Arr2.GetLength(1)];
            for (int i = 0; i < Arr2.GetLength(0); i++)
                for (int j = 0; j < Arr2.GetLength(1); j++)
                    Arr2Bool[i, j] = (Arr2[i, j] == columns[j]) && (Arr2[i, j] == rows[i]);
            return Arr2Bool;
        }
        private int MaxInColumn(int index)
        {
            int max = Arr2[0, index];
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                if (Arr2[i, index] > max)
                    max = Arr2[i, index];
            }
            return max;
        }
        private int MinInRow(int index)
        {
            int min = Arr2[index, 0];
            for (int i = 0; i < Arr2.GetLength(1); i++)
            {
                if (Arr2[index, i] < min)
                    min = Arr2[index, i];
            }
            return min;
        }
        public int GetDiagSum()
        {
            if (Arr2.GetLength(1) != Arr2.GetLength(0))
                throw new InvalidOperationException();
            int sum = 0;
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                sum += Arr2[i, i];
            }
            return sum;
        }
    }
}