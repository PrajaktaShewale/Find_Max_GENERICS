using System;
using System.Collections.Generic;
using System.IO;
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
            float floatmax = FindMaximum.FindfloatMax(256.23f, 388.23f, 422.25f);
            Console.WriteLine(floatmax);
            string stringMax = FindMaximum.FindStringMax("Apple", "Peach", "Banana");
            Console.WriteLine(stringMax);
        }
    }
}