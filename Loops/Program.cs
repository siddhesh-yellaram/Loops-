using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string secretWord = "kite";
            //string guess = "";

            //while (guess != secretWord)
            //{
            //    Console.Write("Enter your guess: ");
            //    guess = Console.ReadLine();
            //}

            //Console.WriteLine("You Win!!!");

            //for(int i = 1; i<=5; i++)
            //{
            //    Console.WriteLine("Square of  " + i + " is "+(i * i));
            //}

            //foreach(int n in nums)
            //{
            //    Console.WriteLine("Cube of " + n + " is " + (n * n * n));
            //}

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Cube of " + nums[i] + " is " + ( nums[i]* nums[i] * nums[i]));
            //}

            char[] vowels = { 'a', 'i', 'e', 'o', 'u' };
            int i = 0;
            
            while(i < vowels.Length)
            {
                Console.WriteLine("Value at index " + i + " is " + vowels[i]);
                i++;
            }
            
            Console.ReadLine();
        }
    }
}
