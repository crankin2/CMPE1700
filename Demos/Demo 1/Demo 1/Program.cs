using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    class Program
    {
        /********************************************
        *
        * Accepts one argument which must be a positive integer > 0
        * Outputsspace delimited list of prime factors of arg 1
        *
        ********************************************/
        static void Main(string[] args)
        {
            //Confirm I have one argument (exactly)
            //Confirm that it is a positive integer
            //Generate factors (if possible)
            if(args.Count()!=1)
            {
                //print error and exit
                PrintError("Invalid number of arguments (" + args.Count() + ")", "", true, true, -1);
            }

            //DEBUG!!!
            Console.ReadKey();
        }

        static void PrintError(string Err = "Error", string Dbg = "",
                                    bool printUsage = true, bool exit = false, int exitVal = 1)
        {
            //1 Print out error message
            ConsoleColor currBackColour = Console.BackgroundColor;
            ConsoleColor currForeColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Error: " + Err);
            if(Dbg.Length>0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Error.WriteLine(Dbg);
            }
            Console.ForegroundColor = currForeColour;
            Console.BackgroundColor = currBackColour;
            if(printUsage)
            {
                PrintUsage();
            }
            Console.ForegroundColor = currForeColour;
            Console.BackgroundColor = currBackColour;
            //DEBUG!!!
            Console.ReadKey();
            if (exit)
            {
                Environment.Exit(exitVal); //By convention, exit with a value != 0 for error
            }
        }

        //general usage message
        static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + "<val>" +
                "where val is a \npositive integer greater than zero. Prints a \nspace-delimited " +
                "list of factors of only \nargument");
        }
    }
}
