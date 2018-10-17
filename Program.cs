using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;
            do
            {

                Console.WriteLine("Which student (1-10) would you like to learn about");
                int studentInput = int.Parse(Console.ReadLine());
                studentInput = studentInput - 1;
                

                List<string> students = new List<string>() { "Andrew", "Chuck", "Joseph", "Jon", "Jeremy", "Katie", "Sean", "Justin", "Tommy", "Kelsey" };
                List<string> hometown = new List<string>() { "Grand Haven", "Ripon", "Grand Rapids", "Alger", "Milwaukee", "Grand Rapids", "Grand Rapids", "Wyoming", "Raleigh", "Grand Rapids" };
                List<string> food = new List<string>() { "Chicken Wings", "Almonds", "Burritos", "Tres Leche", "Peanut Butter", "Indian cuisine", "BBQ", "Burgers", "Buttered Chicken", "Grits" };
                List<string> colors = new List<string>() { "Blue", "White", "Black", "Grey", "Yellow", "Red", "Green", "Orange", "Purple", "Indigo" };

                Console.WriteLine("This student's name is: " + students[studentInput]);


            
                Console.WriteLine("What would you like to know about this student? (hometown, favorite food, or favorite color)");
                string inputChoice = Console.ReadLine();


                if (inputChoice.ToLower() == "hometown")
                {
                    Console.WriteLine("This students hometown is: " + hometown[studentInput]);
                }

                else if (inputChoice.ToLower() == "favorite food")
                {
                    Console.WriteLine("This students favorite food is: " + food[studentInput]);
                }

                else if (inputChoice.ToLower() == "favorite color")
                {
                    Console.WriteLine("This students favorite color is: " + colors[studentInput]);
                }
                else
                {
                    Console.WriteLine("That is not valid input");
                }
                Console.WriteLine("Do you wish learn about another student? (Y or N");
                restart = Console.ReadLine();
            }while (restart.ToLower() == "y");



        }
    }
}
