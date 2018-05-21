using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsList
    {
        public List<int> list { get; set; }
        public ToolsList(List<int> list)
        {
            this.list = list;
        }
        public List<int> Process()
        {
            if(list.Count < 2)
            {
                List<int> t = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    t.Add(list[i]);
                }
                return t;
            }

            int first = list[0];
            int dif = list[1] - list[0];
            int minCount = GetCount(first, dif);
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if((list[j] - list[i])%(j-i) == 0)
                    {
                        int Tdif = (list[j] - list[i]) / (j - i);
                        int Tfirst = list[i] - Tdif * i;
                        int Count = GetCount(Tfirst, Tdif);
                        if(Count<minCount)
                        {
                            minCount = Count;
                            first = Tfirst;
                            dif = Tdif;
                        }
                    }
                }
            }
            List<int> NewList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                NewList.Add(first + i * dif);
            }
            return NewList;
        }
        private int GetCount(int start, int dif)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != start + i * dif)
                    count++;
            }
            return count;
        }
    }
}
