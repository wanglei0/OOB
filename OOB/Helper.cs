using System;

namespace OOB
{
    public class Helper
    {
        public static void Question()
        {
            var input = Console.ReadLine();
            if (!Validate(input))
            {
                Console.WriteLine("invalid");
                Question();
            }
            var result = FizzBuzz(Convert.ToInt32(input));
            Console.WriteLine(result);
            Question();
        }
        

        public static bool Validate(string input)
        {
            try
            {
                Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                return false;
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