using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    public class Task3
    {
        public static int[] GetPrimeNumbersInRange(int min, int max)
        {
            List<int> primes = new List<int>();

            for (int number = min; number <= max; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            return primes.ToArray();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
