using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        public int GetPower(int Base, int Power)
        {
            int Answer = 1;
            
            for (int i = 1; i <= Power; i++)
            {
                Answer *= Base;
            }
            return Answer;

        }

        static void Main(string[] args)
        {
            int UserNumber, TableNumbers, UserSquared, UserCubed;
            bool Exit = false;
            string Numbers, Squares, Cubes, Header1, Header2, Header3, DoAgain;

            Console.WriteLine("Hello! This program will display a table of powers for all the numbers up to a specified number." + Environment.NewLine + "It will show you the square and the cube of each integer value up to the number you tell me.");

            while (!Exit)
            {
                Program MyProgram = new Program();
                Console.WriteLine("At what whole number should the table of powers finish?");

                UserNumber = int.Parse(Console.ReadLine());

                Header1 = "Number";
                Header2 = "Squared";
                Header3 = "Cubed";

                Console.Write(string.Format("{0,-10} {1,-10} {2,-10}",Header1,Header2,Header3));
                Console.Write(Environment.NewLine);
                Console.WriteLine("==================================" + Environment.NewLine);

                

                for (TableNumbers = 1; TableNumbers <= UserNumber; TableNumbers++)
                {
                    UserSquared = MyProgram.GetPower(TableNumbers, 2);
                    UserCubed = MyProgram.GetPower(TableNumbers, 3);
                    Numbers = string.Format("{0}", TableNumbers);
                    Squares = string.Format("{0}", UserSquared);
                    Cubes = string.Format("{0}", UserCubed);
                    Console.Write(string.Format("{0,-10} {1,-10} {2,-10}",TableNumbers,Squares,Cubes));
                    Console.Write(Environment.NewLine);
                }

                Console.WriteLine(Environment.NewLine + "Would you like to see a table with a different max number? (Y or N)");

                DoAgain = Console.ReadLine();

                if (DoAgain == "Y" || DoAgain == "y")
                {
                    Exit = false;
                }
                else if (DoAgain == "N" || DoAgain == "n")
                {
                    Exit = true;
                    Console.WriteLine("Thanks for using the program! Goodbye!");
                    Console.Read();
                }
                else
                {
                    Exit = true;
                    Console.WriteLine("You did not enter Y or N. Goodbye!");
                    Console.Read();
                }

            }
        }
    }
}
