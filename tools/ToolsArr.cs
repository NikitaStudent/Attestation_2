using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr
    {
        public int[] Arr { get; set; }
        public ToolsArr(int[] arr)
        {
            Arr = arr;
        }
        public int[] SeriesCount()
        {
            int count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] != Arr[i - 1])
                    count++;
            }
            int[] counts = new int[count];
            counts[0] = 1;
            int index = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] != Arr[i - 1])
                    index++;
                counts[index]++;
            }
            return counts;
        }
        public void GetMoreCount(out int one, out int all)
        {
            int Lcount = (Arr.Length + 1) / 2;
            int min = Arr[0];
            int max = Arr[0];
            for (int i = 0; i < Lcount; i++)
            {
                if (Arr[i] > max)
                    max = Arr[i];
                if (Arr[i] < min)
                    min = Arr[i];
            }
            one = 0;
            all = 0;
            for (int i = Lcount; i < Arr.Length; i++)
            {
                if (Arr[i] >= min)
                    one++;
                if (Arr[i] >= max)
                    all++;
            }
        }
    }
}
