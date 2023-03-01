using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class PerfectNumber
    {
        public static void Perfect_Number()
        {
            Console.WriteLine("Enter The Number To Check:");
            int input = Convert.ToInt32(Console.ReadLine());

            int accumulator = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    accumulator += i;
                }
            }
            if (accumulator == input)
            {
                Console.WriteLine("The Number" + input + "is Perfect");
            }
            else
            {
                Console.WriteLine("The Number" + input + "is not Perfect");
            }
        }
    }
}
