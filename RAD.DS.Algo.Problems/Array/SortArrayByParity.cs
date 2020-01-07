using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    public class SortArrayByParitySolutuion
    {
        /*
          A = [3,1,2,4]
         
         */


        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length <= 1)
                return A;

            int oddStartIndex = 0;
            int oddEndIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    int t = A[oddStartIndex];
                    A[oddStartIndex] = A[i];
                    A[i] = t;
                    oddStartIndex++;
                }
                else
                {
                    oddEndIndex = i;
                }
            }

            return A;
        }
    }
}
