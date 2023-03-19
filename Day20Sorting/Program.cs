using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberInput = Convert.ToInt32(Console.ReadLine());

            string[] arrayInput = Console.ReadLine().Split(' ');
            int[] numbersArray = Array.ConvertAll(arrayInput, element => int.Parse(element));

            // Write Your Code Here
            int numberOfSwaps = 0;
            for (int i = 0; i < numberInput; i++)
            {
                for (int j = 0; j < numberInput - 1; j++)
                {
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        Array.Reverse(numbersArray, j, 2);
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            int firstPosition = numbersArray[0];
            int lastPosition = numbersArray[numbersArray.Length - 1];

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {firstPosition}");
            Console.WriteLine($"Last Element: {lastPosition}");
        }
    }
}
