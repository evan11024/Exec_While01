using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;
            while (sum < 105)
            {
                sum+=n;
                n++;
            }
            Console.WriteLine(n);
        }
    }
}
