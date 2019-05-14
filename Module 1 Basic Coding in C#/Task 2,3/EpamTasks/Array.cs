using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTasks
{
    public class Array
    {

        public static int FindMax(int[] arr, int i = 0)
        {
            
            if (i == (arr.Length - 1))
            {
                if (arr[i] > arr[i - 1])
                    return arr[i];
                else
                    return arr[i - 1];
            }
            else
            {
                int max = FindMax(arr, ++i);
                if (i != 0)
                {
                    if (arr[i - 1] > max)
                        return arr[i - 1];
                    else
                        return max;
                }
                else
                    return max;
            }  
        }

        public static int EqualSumIndex(int[] arr)
        {
                     
        for (int index =0; index < arr.Length; index++)
            {
                int lSum = 0;
                int rSum = 0;
                for (int indexL = index-1; indexL >=0; indexL--)
                {
                    lSum = lSum + arr[indexL];
                }

                for (int indexR = index + 1; indexR < arr.Length; indexR++)
                {
                    rSum = rSum + arr[indexR];
                }

                if (rSum == lSum)
                    return index;

            }
            return -1;

        }

    }
}
