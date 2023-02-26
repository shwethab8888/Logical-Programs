using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
        public class StopwatchProgram
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Press any key to start the stopwatch");
                Console.ReadKey();
                DateTime startTime = DateTime.Now;

                Console.WriteLine("Press any key to stop the stopwatch");
                Console.ReadKey();
                DateTime stopTime = DateTime.Now;

                TimeSpan elapsed = stopTime - startTime;
                Console.WriteLine("Elapsed time: {0} milliseconds", elapsed.TotalMilliseconds);
            }
        }
    

}
