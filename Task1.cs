using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    internal class Task1
    {
        public static void solve(int number)
        {
            byte last_digit = (byte)(number % 10);

            if(number > 10 && number < 20)
            {
                Console.WriteLine(number + " компьютеров");
                return;
            }

            switch (last_digit)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(number + " компьютеров");
                    break;
                case 1:
                    Console.WriteLine(number + " компьютер");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(number + " компьютера");
                    break;
                
            }
        }
    }
}
