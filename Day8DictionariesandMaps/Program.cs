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
            Dictionary<string, int> phones = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            if ((n >= 1) && (n <= 100000))
            {
                for (int i = 0; i < n; i++)
                {
                    List<string> arr = Console.ReadLine().Trim().Split(' ').ToList();
                    phones[arr[0].Trim()] = int.Parse(arr[1].Trim());

                }
                string search = string.Empty;
                while ((search = Console.ReadLine()) != null)
                {

                    if (phones.ContainsKey(search))
                    {

                        Console.WriteLine(search + "={0}", phones[search]);


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
