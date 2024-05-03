
namespace test_task
{
    internal class Task2
    {
        public static uint[] Solve(uint[] inputArray)
        {
            HashSet<uint> answerSet = new HashSet<uint>();
            uint first = inputArray[0];
            for (uint i = 2; i <= Math.Sqrt(first); i++)
            {
                if(first % i == 0)
                    answerSet.Add(i);
            }

            for(int i = 1; i < inputArray.Length; i++)
            {
                for(int j = 0; j < answerSet.Count; j++)
                {
                    uint dev = answerSet.ElementAt(j);
                    if (inputArray[i] % dev != 0)
                    {
                        answerSet.Remove(dev);
                        j--;
                        continue;
                    }
                }
            }

            return answerSet.ToArray();
            
        }
    }
}
