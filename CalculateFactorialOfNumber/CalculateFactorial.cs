using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialOfNumber
{
    public class CalculateFactorial
    {
       public int FactorialFunction(int factorialNumber)
        {
            int factorialResult = 1;
            for(int iterator = factorialNumber ; iterator >= 1;iterator--)
            {
                factorialResult *= iterator;
            }
            return factorialResult;
        }
    }
}
