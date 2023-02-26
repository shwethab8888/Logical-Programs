using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class FibonacciSeries
    {
        public static int PreviousToPrevious = 0;
        public static int Previous = 0;
        public static int Next = 1;


        public static void GetSeries()
        {
            Console.WriteLine("Please Enter The Number To Find Fibonacciseries");
            int input = Convert.ToInt32(Console.ReadLine());
            while (Next < input)
            {
                PreviousToPrevious = Previous;
                Previous = Next;
                Next = PreviousToPrevious + Previous;
                Console.WriteLine(Previous);
            }
        }
    }
}
