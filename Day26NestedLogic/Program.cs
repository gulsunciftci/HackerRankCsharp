using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26NestedLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int fine = 0;
            var actual = Console.ReadLine().Split(' ');
            var daya = int.Parse(actual[0]);
            var montha = int.Parse(actual[1]);
            var yeara = int.Parse(actual[2]);

            var expected = Console.ReadLine().Split(' ');
            var daye = int.Parse(expected[0]);
            var monthe = int.Parse(expected[1]);
            var yeare = int.Parse(expected[2]);

            if (yeara > yeare)
            {
                fine = 10000;
            }
            else if (yeara == yeare)
            {
                if (montha > monthe)
                {
                    fine = 500 * (montha - monthe);
                }
                else if (monthe == montha && daya > daye)
                {
                    fine = 15 * (daya - daye);
                }
            }
            Console.WriteLine(fine);
        }
    }
}
