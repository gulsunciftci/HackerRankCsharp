using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];
			string lastName = inputs[1];
			int id = Convert.ToInt32(inputs[2]);
			int numScores = Convert.ToInt32(Console.ReadLine());
			inputs = Console.ReadLine().Split();
			int[] scores = new int[numScores];
			for (int i = 0; i < numScores; i++)
			{
				scores[i] = Convert.ToInt32(inputs[i]);
			}

			Student s = new Student(firstName, lastName, id, scores);
			s.printPerson();
			Console.WriteLine("Grade: " + s.Calculate() + "\n");
		}
    }
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;
        public double result;
        public char s;
        public Student(string _firstName, string _lastName, int _identification, int[] _scores)
        {
            firstName = _firstName;
            lastName = _lastName;
            id = _identification;
            testScores = _scores;
        }
        public char Calculate()
        {
            var sum = 0;
            foreach (int i in testScores)
            {
                sum += i;
            }
            result = (sum / testScores.Length);

            if (result >= 90 && result <= 100)
            {
                s = 'O';
            }
            else if (result >= 80 && result < 90)
            {
                s = 'E';
            }
            else if (result >= 70 && result < 80)
            {
                s = 'A';
            }
            else if (result >= 55 && result < 70)
            {
                s = 'P';
            }
            else if (result >= 40 && result < 55)
            {
                s = 'D';
            }
            else if (result < 40)
            {
                s = 'T';
            }

            return s;

        }
    }
}
