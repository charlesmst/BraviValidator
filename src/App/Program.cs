using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid input: Please inform the input string in first argument");

            }
            var input = args[0];

            IValidator validator = new Validator();
            try
            {
                if (validator.IsSequenceValid(input))
                {
                    Console.Write("Valid Sequence");
                }
                else
                {
                    Console.Write("Invalid Sequence");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid Sequence: {ex.Message}");
            }
        }
    }
}
