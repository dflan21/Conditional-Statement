/* 
 Author: David Flannery 
 Date: 9/6/2022
 Description: Creating a grade calculator for ism 4300 
*/ 

using System; // calling system library
using System.Runtime.CompilerServices;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expected grade:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 100)// using IF/IFElse/ else to determine grade 
            {
                Console.WriteLine("Value entered is to high");
                Console.ReadKey(true);
            }
            else if ((n1 >= 98) && (n1 <= 100))
            {
                Console.WriteLine("congratulations you got an A+");
                Console.ReadKey(true);
            }
            else if ((n1 <= 97) && (n1 >= 92))
            {
                Console.WriteLine("A");
                Console.ReadKey(true);
            }
            else if ((n1 <= 91) && (n1 >= 90))
            {
                Console.WriteLine("A-");
                Console.ReadKey(true);

            }
            else if ((n1 <= 89) && (n1 >= 88))
            {
                Console.WriteLine("B+");
                Console.ReadKey(true);
            }
            else if ((n1 <= 87) && (n1 >= 82))
            {
                Console.WriteLine("B");
                Console.ReadKey(true);

            }
            else if ((n1 <= 81) && (n1 >= 80))
            {
                Console.WriteLine("B-");
                Console.ReadKey(true);
            }
            else if ((n1 <= 79) && (n1 >= 78))
            {
                Console.WriteLine("C+");
                Console.ReadKey(true);
            }
            else if ((n1 <= 77) && (n1 >= 72))
            {
                Console.WriteLine("C");
                Console.ReadKey(true);
            }
            else if ((n1 <= 71) && (n1 >= 70))
            {
                Console.WriteLine("C-");
                Console.ReadKey(true);
            }
            else if ((n1 <= 69) && (n1 >= 68))
            {
                Console.WriteLine("D+");
                Console.ReadKey(true);
            }
            else if ((n1 <= 67) && (n1 >= 62))
            {
                Console.WriteLine("D");
                Console.ReadKey(true);
            }
            else if ((n1 <= 61) && (n1 >= 60))
            {
                Console.WriteLine("D-");
                Console.ReadKey(true);
            }
            else if ((n1 < 60)&&(n1>=0))
            {
                Console.WriteLine("F");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Value entered is invalid");
                Console.ReadKey(true);
            }




        }
    }
}