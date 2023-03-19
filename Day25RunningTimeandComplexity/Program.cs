using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25RunningTimeandComplexity
{
    public class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            string outPut = string.Empty;
            while (T-- > 0)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i <= data / i; i++)
                {
                    if (data % i == 0)
                    {
                        data = 1;
                    }
                }
                outPut = (data == 1) ? "Not prime" : "Prime";
                Console.WriteLine(outPut);
            }
        }
    }
}
