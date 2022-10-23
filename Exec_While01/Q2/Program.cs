using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 300; i++)
            {
                while (300 % i == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
