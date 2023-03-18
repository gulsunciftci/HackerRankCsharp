using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictionariesandMaps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameNum = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            if ((n >= 1) && (n <= 100000))
            {
                for (int i = 0; i < n; i++)
                {
                    List<string> arr = Console.ReadLine().TrimEnd().Split(' ').ToList();
                    nameNum.Add(arr[0], arr[1]);
                }
                for (int j = 0; j < n; j++)
                {
                    string search = Console.ReadLine();

                    if (nameNum.ContainsKey(search))
                    {
                        Console.WriteLine(search + "={0}", nameNum[search]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }

                }
            }
        }
    }
}
