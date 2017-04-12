using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());
        


            for (int i=1; i <= number; i++)

            {
            double squared = Math.Pow(i, 2);
            double cubed = Math.Pow(i, 3);
            Console.WriteLine("For Number {0}\n", i);
            Console.WriteLine("Your number squared is {0}\n", squared);
            Console.WriteLine("Your number cubed is {0}\n", cubed);

            


            }




        }
    }
}
