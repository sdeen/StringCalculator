using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter maximum 2 numbers using a comma delimiter to add the numbers. For Example: 1,1 = 1+1=2:");
                string number = "";
                number = Convert.ToString(Console.ReadLine());
                int length = String.IsNullOrEmpty(number) ? 0 : number.Length;
                int count = number.Count(c => c == ',');
                if (count > 1)
                {
                    Console.WriteLine("Error:Input must be maximum 2 numbers using a comma delimiter");
                }
                else
                {
                    int result = Calculator.AddNumber(number);
                    Console.WriteLine($"Result: {result}");
                }


                Console.WriteLine("Enter quite to close the Calculator console. OR Enter to continue");
                string input = Console.ReadLine();
                if (input == "quite")
                {
                    break;
                }
            }

        }

    }
}
