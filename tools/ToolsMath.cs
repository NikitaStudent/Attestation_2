using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsMath
    {
        public double X { get; set; }
        public double E { get; set; }
        public ToolsMath(double x, double e)
        {
            if (Math.Abs(x) > 1)
                throw new Exception("некорректные данные");
            X = x;
            E = e;
        }
        public double Left()
        {
            return 1 / (1 - X);
        }
        public double GetAn(double a, int n)
        {
            if (n == 1)
                return 1;
            return a * X ;
        }
        public double Right(out int n)
        {
            n = 0;
            double a = 1;
            double sum = 0;
            while (Math.Abs(a)>E)
            {
                a = GetAn(a, ++n);
                sum += a;
            }
            return sum;
        }
    }
}
