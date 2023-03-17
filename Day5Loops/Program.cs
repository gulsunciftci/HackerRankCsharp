using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            if (2 <= n && n <= 20)
            {
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("{0} x {1} = {2}", n, i, i * n);
                }
            }
        }
    }
 }

