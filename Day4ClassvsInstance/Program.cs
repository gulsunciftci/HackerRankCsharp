using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ClassvsInstance
{
    public class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
    class Person
    {
        public int _age;

        public Person(int age)
        {
            // Add some more code to run some checks on initialAge
            if (age < 0)
            {
                _age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }

            _age = age;
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (_age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (_age >= 13 && _age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }

        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            _age++;
        }
    }
}
