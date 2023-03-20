using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29BitwiseAND
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                if (((k - 1) | k) > n && k % 2 == 0)
                {
                    Console.WriteLine(k - 2);
                }
                else
                {
                    Console.WriteLine(k - 1);
                }
            }
        }
    }
}
