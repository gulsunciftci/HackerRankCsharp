﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18QueuesandStacks
{
    public class Program
    {
        public Stack<char> charS = new Stack<char>();
        public Queue<char> charQ = new Queue<char>();

        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }

        public char dequeueCharacter()
        {
            return charQ.Dequeue();
        }
        public void enqueueCharacter(char c)
        {
            charQ.Enqueue(c);
        }

        public void pushCharacter(char c)
        {
            charS.Push(c);
        }


        public char popCharacter()
        {
            return charS.Pop();
        }

       
        
    }
}
