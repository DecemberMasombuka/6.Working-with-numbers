using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writes a number
            Console.WriteLine(5);
            //Adds 6+5 and prints
            Console.WriteLine(6+5);
            //Modulo operator (%),  returns the remainder of division
            Console.WriteLine(41%2);
            //BODMAS applied,  placements of brackets will change the order of BODMAS
            Console.WriteLine(4 + 2 * 3);
            //Interges always return integers, not doubles
            Console.WriteLine(5/2);
            //Double and integer always returns a double
            Console.WriteLine(5+2.3);

            //Declare and initialise a variable
            int num = 8;
            num++; //increment the variable by 1
            Console.WriteLine(num);
            //Abs from the Math method will return an absolute value 
            Console.WriteLine(Math.Abs(-49));
               //returns the Min and Max
            Console.WriteLine(Math.Min(Math.Abs(-23),4));
            //raise to powers
            Console.WriteLine("3 raised to the power 3 =  " + Math.Pow(3,3));
            //Freeze console
            Console.Read();
        }
    }
}
