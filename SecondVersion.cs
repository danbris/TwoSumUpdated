using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    /// <summary>
    /// Done at the end of the meeting
    /// </summary>
    public class SecondVersion
    {
        public static string GetResults(int[] input, int sum)
        {
            var processedItems = new Dictionary<int, int>();
            for (var i = 0; i < input.Length; i++)
            {
                var rightValue = sum - input[i];

                if (processedItems.ContainsKey(rightValue))
                {
                    return processedItems[rightValue] + "-" + i;
                }

                processedItems.Add(input[i], i);
            }

            return "n-am gasit";
        }
    }
}
