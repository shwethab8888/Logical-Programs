using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class CouponNumber
    {
        public static void Main(string[] args)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            int max = 100000000;
            Random random = new Random();
            int randomNumber = random.Next(max);
            StringBuilder sb = new StringBuilder();

            while (randomNumber > 0)
            {
                sb.Append(chars[randomNumber % chars.Length]);
                randomNumber /= chars.Length;
            }

            string couponCode = sb.ToString();
            Console.WriteLine("Coupon Code: " + couponCode);
        }
    }


}

