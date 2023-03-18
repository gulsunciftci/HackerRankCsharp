using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day112DArrays
{  
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                list.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            var sum = -10000;
            for (int a = 0; a <= 3; a++)
            {
                for (int b = 0; b <= 3; b++)
                {
                    var currentSum = (list[a][b] + list[a][b + 1] + list[a][b + 2] + list[a + 1][b + 1]
                       + list[a + 2][b] + list[a + 2][b + 1] + list[a + 2][b + 2]);
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }

            Console.WriteLine(sum);


        }
    }
}
