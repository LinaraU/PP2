using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool isPrime(int a)
        {
            if (a == 0 || a == 1) // 1 and 0 are not prime numbers 
                return false;
            for (int i = 2; i < Math.Sqrt(a); i++) //starting i with 2 because it is first prime number
                                                   // using Math.Sqrt to find square root of a
            {
                if (a % i == 0) //if the number devides without reminder to numbers other than itself then it is not a prime number
                    return false;
            }
            return true; //if it does not devide by any other number then it is prime
        }
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt"); //
            string line = file.ReadLine();
            file.Close();
            string[] s = line.Split();
            int[] numbers = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                numbers[i] = int.Parse(s[i]);
            }
            StreamWriter file2 = new StreamWriter("output.txt");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isPrime(numbers[i]) == true)
                {
                    file2.Write(numbers[i] + " ");
                }
            }
            file2.Close();
            Console.ReadKey();
        }
    }
}
