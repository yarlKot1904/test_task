namespace test_task
{
    internal class Task4
    {
        public static void Solve(int number)
        {
            Console.Write("    ");
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();

            Console.WriteLine(new string('-', 4 * (number + 1)));

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{i,2} |");

                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}
