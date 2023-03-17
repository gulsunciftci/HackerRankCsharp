using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            int j = Convert.ToInt32(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            string newStr = Console.ReadLine();

            Console.WriteLine("{0}\n{1:F1}\n{2}", i + j, d + e, s + newStr);

        }
    }
}
