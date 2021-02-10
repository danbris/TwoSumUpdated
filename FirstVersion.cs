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
        public static string GetResult(int[] input, int sum)
        {
            var result = string.Empty;

            var inputLength = input.Length - 1;
            var lastIndex = inputLength;

            for (int i = inputLength; i > 0; i--)
            {
                if (input[i] <= sum)
                {
                    lastIndex = i;
                    break;
                }
            }

            return GetResultText(lastIndex, input, sum);
        }

        private static string GetResultText(int lastIndex, int[] input, int sum)
        {
            for (int firstIdx = 0; firstIdx <= lastIndex - 1; firstIdx++)
            {
                for (int secondIdx = firstIdx + 1; secondIdx <= lastIndex; secondIdx++)
                {
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
