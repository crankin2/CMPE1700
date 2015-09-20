using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;
            bool check;

            if(args.Count() < 1) //if no arguments are passed
            {
                //print error and exit
                PrintError("Invalid number of arguments (" + args.Count() + ")", "", true, true, -1);
            }

            check = int.TryParse(args[0], out tmp);//check if the first argument is an int

            if (check == false)//if first argument isn't an int
            {
                //print error and exit
                PrintError("Invalid first argument", "", true, true, -2);
            }

            for(int i = 0; i < tmp; i++)//repeat the loop tmp times, where tmp is the first argument
            {
                foreach (string arg in args.Skip(1))//write each element in the array, skipping the first
                {
                    Console.Write(arg + " ");
                }
                Console.WriteLine();
            }         
        }
        //General print error message
        static void PrintError(string Err = "Unknown Failure", string Dbg = "",
                                    bool printUsage = true, bool exit = false, int exitVal = 1)
        {
            //1 Print out error message
            ConsoleColor currBackColour = Console.BackgroundColor;
            ConsoleColor currForeColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Error: " + Err);
            if (Dbg.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Error.WriteLine(Dbg);
            }
            Console.ForegroundColor = currForeColour;
            Console.BackgroundColor = currBackColour;
            if (printUsage)
                PrintUsage();

            Console.ReadKey();

            if (exit)
                Environment.Exit(exitVal);
        }

        //General usage message
        static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + " <val>" +
                    " where <val> is a \npositive integer greater than zero. Prints \nevery arguement" +
                    " after the integer, repeating \nn number of times, where n is the integer");
        }
    }
}
