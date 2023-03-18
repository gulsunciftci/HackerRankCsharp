using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16ExceptionsStringtoInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
