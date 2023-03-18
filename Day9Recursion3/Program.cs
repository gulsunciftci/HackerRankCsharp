using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Recursion3
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = File.CreateText("d:\\Recursion.txt");
           
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = 0;
            if (n >= 2 && n <= 12)
            {
                result = Result.factorial(n);
            }

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    class Result
    {

        /*
         * Complete the 'factorial' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int factorial(int n)
        {

            if (n >= 2)
            {
                return n * factorial(n - 1);
            }
            return 1;
        }

    }

}
