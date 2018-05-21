using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsConsole;
using tools;

namespace _9._49_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Task();
            }
        }

        private static void Task()
        {
            int[,] Arr2A, Arr2B;
            do
            {
                Arr2A = ToolsConsoleArr2.ReadArr2();
                if (Arr2A.GetLength(0) != Arr2A.GetLength(1))
                    Console.WriteLine("не квадратный массив введите заново");
            } while (Arr2A.GetLength(0)!=Arr2A.GetLength(1));
            do
            {
                Arr2B = ToolsConsoleArr2.ReadArr2();
                if (Arr2B.GetLength(0) != Arr2B.GetLength(1))
                    Console.WriteLine("не квадратный массив введите заново");
            } while (Arr2B.GetLength(0) != Arr2B.GetLength(1));
            ToolsArr2 toolsArr2 = new ToolsArr2(Arr2A);
            int A = toolsArr2.GetDiagSum();
            toolsArr2 = new ToolsArr2(Arr2B);
            int B = toolsArr2.GetDiagSum();
            ToolsConsoleArr2.OutputStr(A + " " + B + " " + (A + B));
        }
    }
}
