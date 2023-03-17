using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3IntrotoConditionalStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            string sonuc = string.Empty;
            if (1 <= N && N <= 100)
            {
                if ((N % 2) != 0)
                {
                    sonuc = "Weird";
                }
                else
                {
                    if (2 <= N && N <= 5)
                    {
                        sonuc = "Not Weird";
                    }
                    else if (6 <= N && N <= 20)
                    {
                        sonuc = " Weird";
                    }
                    else if (N > 20)
                    {
                        sonuc = "Not Weird";
                    }
                }

                Console.WriteLine(sonuc.Trim());
            }
        }
    }
}
