namespace ArrayExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 7, 7, 8 };
                int mostFrequent = MostFrequent(arr);
                Console.WriteLine("The most frequent number is: " + mostFrequent);
            }

            static int MostFrequent(int[] arr)
            {
                Dictionary<int, int> freqDict = new Dictionary<int, int>();
                int maxFreq = 0;
                int maxNum = 0;

                foreach (int num in arr)
                {
                    if (!freqDict.ContainsKey(num))
                    {
                        freqDict[num] = 1;
                    }
                    else
                    {
                        freqDict[num]++;
                    }

                    if (freqDict[num] > maxFreq)
                    {
                        maxFreq = freqDict[num];
                        maxNum = num;
                    }
                }

                return maxNum;
            }
        }
    }
}