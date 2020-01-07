using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    /*
        Matrix 6x6
        [
            [-9 -9 -9 0 1 2]
            [ 1 -9  1 8 0 5]
            [-9 -9 -9 5 1 3]
            [ 0  0  0 1 2 3]
            [ 2  0  9 1 6 3]
            [ 0  0  0 3 4 7]
        ]

        -9<=n<=9
    */
    public class FindHourGlassMaxSum
    {
        public int FindMaxSum(int[][] nums)
        {
            int maxHourGlassSum = -63;
            int rows = nums.Length;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int sum = nums[i][j] + nums[i][j + 1] + nums[i][j + 2] + +nums[i + 1][j + 1] + nums[i + 2][j] + nums[i + 2][j + 1] + nums[i + 2][j + 2];
                    maxHourGlassSum = Math.Max(sum, maxHourGlassSum);
                }
            }

            return maxHourGlassSum;

        }

        
    }
}
