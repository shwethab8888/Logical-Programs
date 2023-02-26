using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PrimeNumber
    {
        public static void PrimeCheck()
        {
            Console.WriteLine("Enter The Number to Check:");
            int input = Convert.ToInt32(Console.ReadLine());
            bool ifEnteredCheck = false;

            for (int i = 2; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("The Number is not a Prime Number");
                    ifEnteredCheck = true;
                    break;
                }
            }
            if (ifEnteredCheck == false)
            {
                Console.WriteLine("The Number is Prime");
            }

        }
    }
}
