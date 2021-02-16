using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoSum
{
    /// <summary>
    /// Ruben's idea with divide and conquer - only works with sorted arrays, so make sure and sort before using it.
    /// </summary>
    class ThirdVersion
    {
        public static string GetResultsByDivide(int[] input, int sum, out int iterationCount)
        {
            iterationCount = 0;
            if (input[0] >= sum)
                return string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                iterationCount++;
                var rightValue = sum - input[i];
                var idxOfRightValue = Array.BinarySearch(input, i + 1, input.Length - i - 1, rightValue);
                if (idxOfRightValue >= 0)   
                {
                    return $"{i} - {idxOfRightValue}";
                }
            }

            return "Nothing found";

        }
    }
}
