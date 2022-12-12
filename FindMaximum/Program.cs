using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = FindMaximum.FindIntMax(2332, 4002, 4595);
            Console.WriteLine(max);
            float floatmax = FindMaximum.FindfloatMax(42.25f, 56.23f, 58.23f);
            Console.WriteLine(floatmax);
        }
    }
}