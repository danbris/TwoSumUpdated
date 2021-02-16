using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    /// <summary>
    /// From Razvan
    /// </summary>
    public class FirstVersion
    {
        private static int _iterationCount = 0;
        public static string GetResult(int[] input, int sum, out int iterationCount)
        {
            _iterationCount = 0;
               var inputLength = input.Length - 1;
            var lastIndex = inputLength;

            for (int i = inputLength; i > 0; i--)
            {
                _iterationCount++;
                if (input[i] <= sum)
                {
                    lastIndex = i;
                    break;
                }
            }

            var result = GetResultText(lastIndex, input, sum);
            iterationCount = _iterationCount;

            return result;
        }

        private static string GetResultText(int lastIndex, int[] input, int sum)
        {
            for (int firstIdx = 0; firstIdx <= lastIndex - 1; firstIdx++)
            {
                for (int secondIdx = firstIdx + 1; secondIdx <= lastIndex; secondIdx++)
                {
                    _iterationCount++;
                    var computedSum = input[firstIdx] + input[secondIdx];
                    if (computedSum == sum)
                    {
                        return $"[{firstIdx},{secondIdx}] - indecsii pentru {input[firstIdx]} si {input[secondIdx]}";
                    }
                }
            }
            return "Nu s-a gasit nicio pereche de elemente";
        }
    }
}
