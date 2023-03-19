using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day28RegExPatternsandIntrotoDatabases
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> list = new List<string>();
            while (N-- > 0)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];

                if (Regex.IsMatch(emailID, @".+@gmail\.com$"))
                {
                    list.Add(firstName);
                }
            }
            list.Sort();
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
