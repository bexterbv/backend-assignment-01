using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Bexter.Interview.Assignment01
{
    class Program
    {

        private static int input;
        private static bool mustAskForInput = true;

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                mustAskForInput = !int.TryParse(args[0], out input);
            }
            if (mustAskForInput)
            {
                input = AskForInput();
            }

            // Welcome to your interview assignment. Do you know roman digits?
            // They are quite easy.
            // The M represents 1000
            // The D represents 500
            // The C represents 100
            // The L represents 50
            // The X represents 10
            // The V represents 5
            // The I represents 1
            //
            // Integers are written according to these two rules: If a letter is
            // immediately followed by one of equal or lesser value, the two values
            // are added; thus, XX equals 20, XV equals 15, VI equals 6. If a letter
            // is immediately followed by one of greater value, the first is
            // subtracted from the second; thus, IV equals 4, XL equals 40, CM
            // equals 900.
            //
            // Your assignment is to format the input integer, to a roman digit.

            // Print roman notation here

            Console.ReadKey();

        }

        static int AskForInput(bool showError = false)
        {
            Console.Clear();
            if (showError)
            {
                Console.WriteLine("Your input is invalid!");
            }

            Console.WriteLine("Please enter a number between 1 and 3999");
            var response = Console.ReadLine();
            if (int.TryParse(response, out int responseInt))
            {
                if (responseInt >= 1 && responseInt <= 3999)
                {
                    return responseInt;
                }
            }

            return AskForInput(true);
        }

    }
}