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
            bool askToContinue = false; //do while to ask user to continue
            do
           {

                Console.Write("Please enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++) //counts up to value entered

                {
                    double squared = Math.Pow(i, 2); //value squared
                    double cubed = Math.Pow(i, 3); //value cubed
                    Console.WriteLine("For Number {0}\n", i);
                    Console.WriteLine("Your number squared is {0}\n", squared);
                    Console.WriteLine("Your number cubed is {0}\n", cubed);

    


                }
                Console.WriteLine("Type YES to continue");

                   if (Console.ReadLine().ToUpper() == "YES")
                        askToContinue = true;

                } while (askToContinue); //added boolean expression to prompt user to continue (will need to update it to y/n option and include validation once I improve)

            }
        
    }
}
