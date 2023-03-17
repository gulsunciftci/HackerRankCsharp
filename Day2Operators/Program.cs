using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            solve(meal_cost, tip_percent, tax_percent);
        }

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double newtip_percent = Convert.ToDouble(meal_cost * (Convert.ToDouble(tip_percent) / 100));
            double newtax_percent = Convert.ToDouble(meal_cost * (Convert.ToDouble(tax_percent) / 100));
            double totalCost = meal_cost + newtip_percent + newtax_percent;
            Console.WriteLine(Math.Round(totalCost));
        }
    }
}
