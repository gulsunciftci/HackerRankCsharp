using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetsReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string oddStr = string.Empty;
                string evenStr = string.Empty;
                string str = Console.ReadLine();
                for (int j = 0; j < str.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        oddStr += str[j];
                    }
                    else if (j % 2 == 0)
                    {
                        evenStr += str[j];
                    }

                }
                Console.WriteLine(evenStr + " " + oddStr);

            }

        }
    }
}
