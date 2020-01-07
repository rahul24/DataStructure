using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    public class SortArrayByParity2
    {
        /*
         A = [4,2,8,5,7,9]
         */ 


        public int[] SortArrayByParityII(int[] A)
        {
            if (A.Length <= 1)
                return A;

            int oddStartIndex = 1;
            int oddEndIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    if (oddStartIndex < A.Length)
                    {
                        int t = A[oddStartIndex];
                        A[oddStartIndex] = A[i];
                        A[i] = t;
                        oddStartIndex += 2;
                    }                    
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
