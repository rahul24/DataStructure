using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Array
{
    public class ThirdMaxNumber
    {
        public int ThirdMax(int[] nums)
        {
            int? firstMax = null;
            int? secondMax = null;
            int? thirdMax = null;


            foreach (var item in nums)
            {
                if(firstMax == null || (firstMax < item))
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = item;
                }
                else if ((secondMax == null || secondMax < item) && firstMax != item)
                {
                    thirdMax = secondMax;
                    secondMax = item;
                }
                else if ((thirdMax == null || thirdMax < item) && firstMax != item && secondMax != item)
                {
                    thirdMax = item;
                }
            }

            if (thirdMax.HasValue)
                return thirdMax.Value;
            //else if (secondMax != -999)
            //    return secondMax;
            else
                return firstMax.Value;
        }
    }    
}
