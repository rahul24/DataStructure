using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    public class FindNumberWithEvenNumberOfDigit
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (int item in nums)
            {
                int length = (int)Math.Floor(Math.Log10(item)) + 1;
                if (length % 2 == 0)
                    count++;
            }

            return count;
        }
    }
}
