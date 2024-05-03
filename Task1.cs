using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    internal class Task1
    {
        public static string Solve(int number)
        {
            byte last_digit = (byte)(number % 10);

            if(number > 10 && number < 20)
            {
                return number + " компьютеров";
            }

            switch (last_digit)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return number + " компьютеров";
                case 1:
                    return number + " компьютер";
                case 2:
                case 3:
                case 4:
                    return number + " компьютера";                
            }
            throw new Exception("incorrect value");
        }
    }
}
