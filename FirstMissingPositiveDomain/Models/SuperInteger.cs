namespace FirstMissingPositiveDomain.Models
{
    public class SuperInteger
    {
        /// <summary>Returns the first missing positive number in the list</summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Integer</returns>
        public static int GetFirstMissingPositive(int[] numbers)
        {
            var best = 1;
            var succession = 0;
            var max = 0;
            var previousBest = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] > 0) max = numbers[j];
            }

            while (best > previousBest)
            {
                previousBest = best;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] <= 0) continue;

                    if (numbers[i] == (best + succession + 1))
                    {
                        succession++;
                        continue;
                    }

                    if (numbers[i] == best)
                    {
                        best = best + succession + 1;
                        succession = 0;
                        continue;
                    }
                }

                if (best == max) return best + 1;
            }

            return best;
        }
    }
}