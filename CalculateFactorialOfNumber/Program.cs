using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumber;
            
            Console.WriteLine("Enter The Number");
            userInputNumber = Convert.ToInt32(Console.ReadLine());
            CalculateFactorial calculateFactorialObject = new CalculateFactorial();
            Console.WriteLine("Factorial of {0} is : {1}",userInputNumber,calculateFactorialObject.FactorialFunction(userInputNumber));
            Console.WriteLine("Thankyou\nPress Any key to Exit the Application...");
            Console.ReadLine();
        }
    }
}
