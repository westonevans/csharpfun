using System;

namespace csharpfun
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Random number and array
            Random r = new Random();
            int[] total = new int[11];

            //Ask how many rolls user wants
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine());


            //Results text
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS: \n " +
                               "Each '*' represents 1% of the total number of rolls. " +
                               "\n Total number of rolls = " + numRolls +".\n");


            //Simulate the random roll of two dice
            for (int i = 0; i < numRolls; i++)
            {
                int firstRoll = r.Next(6);
                int secondRoll = r.Next(6);
                int count = firstRoll + secondRoll;
                total[count]++;
            }
            

            //another loop to print the * for percent num rolls for each
            for (int i = 0; i < 11; i++)
            {
                Console.Write(i + 2 + ": ");
                int percentage = (int)((double)total[i] / numRolls * 100);
                for (int d = 0; d < percentage; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Adios!
            Console.WriteLine("\nThank you for using the dice throwing simulator.  Goodbye!");


        }
    } 
}
