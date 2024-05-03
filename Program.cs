using test_task;

public class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            Task1.solve(n);
        }
    }
}