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

            if (exit)
                Environment.Exit(exitVal);
        }

        //General usage message
        static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + " <val>" +
                    " where <val> is a \npositive integer greater than zero. Prints \nevery arguement"
                    " after the integer, repeating n number of times, where n is the integer");

        }
    }
}
