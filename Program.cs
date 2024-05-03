using test_task;

public class Program
{
    static void Main()
    {
        FourthTaskTest();

    }

    private static void FourthTaskTest()
    {
        Task4.Solve(30);
    }

    private static void ThirdTaskTest()
    {
        int[] result = Task3.GetPrimeNumbersInRange(11, 20);
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    private static void SecondTaskTest()
    {
        uint[] arr = { 42, 12, 18 };

        uint[] result = Task2.Solve(arr);
        foreach (uint val in result)
        {
            Console.Write(val + " ");
        }
    }

    private static void FirstTaskTest()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Task1.Solve(n));
    }
}