using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Scope
{
    public class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] _a)
        {
            elements = _a;
        }

        public void computeDifference()
        {
            maximumDifference = -1000000;
            for (int j = 0; j < elements.Length - 1; j++)
            {
                for (int i = j + 1; i < elements.Length; i++)
                {
                    int difference = Math.Abs(elements[j] - elements[i]);
                    if (difference > maximumDifference)
                    {
                        maximumDifference = difference;
                    }
                }
            }
        }
    }
}
