using System;

namespace OOB
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.Read();
            
            
            
            var result = FizzBuzz(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static bool ValidInput(string input)
        {
            try
            {
                Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return true;
        }

        public static string FizzBuzz(int number)
        {
            if (number < 1 || number > 100)
                return "invalid";

            else if(number % 3 == 0 && number % 5 != 0)
            {
                return "Fizz";
            }
            else if(number % 5 == 0 && number % 3 != 0)
            {
                return "Buzz";
            }
            else if(number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else 
                return number.ToString();
            
        }
    }
}