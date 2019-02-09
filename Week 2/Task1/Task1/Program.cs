using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, reverse = string.Empty;
            input = Console.ReadLine();
            if( input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i].ToString();
                }
                if ( reverse == input)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            Console.ReadLine();
        }
    }
}
