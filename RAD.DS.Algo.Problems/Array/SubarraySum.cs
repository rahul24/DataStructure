using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    
    public class SubarraySumItem
    {

        /// <summary>
        /// Sliding Window Technique
        /// </summary>
        public int SubarraySum(int[] nums, int k)
        {

            if (nums.Length - 1 <= 0)
                return k;


            int x = 0;
            int no_of_elements = 0;
            int head = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                x = x + nums[i];
                //no_of_elements++;


                while ((x > k || (i != 0 && x < k && k <= 0)) && head != i)
                {
                    x = x - nums[head];
                    head++;
                    //no_of_elements--;             
                }


                if (x == k)
                    no_of_elements++;
            }
            
            return no_of_elements;

        }
    }
}
