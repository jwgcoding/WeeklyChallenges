using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var sub = (minuend - subtrahend);
            return sub;
           

        }

        public int Add(int number1, int number2)
        {
            var add = (number1 + number2);
            return add;
           
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int var = number1;
            int var2 = number2;
            return Math.Min(number1, number2);
            
        }

        public long Multiply(long factor1, long factor2)
        {
            long multi = (factor1 * factor2);
            return multi;
            
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }

        }

        public string GetHey()

        {
            return "HEY!";
            
        }
    }
}
