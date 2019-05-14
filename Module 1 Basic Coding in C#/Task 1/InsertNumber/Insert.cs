using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    public static class Insert
    {
    
        public static void ConvertToBinary(int[] arr, int a)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (a > 1)
                {
                    arr[index] = a % 2;
                    a = (a - a % 2) / 2;
                }
                if (a == 1)
                {
                    index++;
                    arr[index] = 1;

                    break;
                }
            }
        }

      

        public static int ConvertToInt(int[] arr)
        {
            int value = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] != 0)
                    value = value + (arr[index] * Convert.ToInt32(Math.Pow(2, index)));

            }

            return value;
        }

        public static int InsertNumbers(int first, int second, int i, int j)
        {
            int dif = j - i + 1;
            int counter = 0;
            const int arraylenght = 32;
            int[] arrayres = new int[arraylenght];
            int[] array1 = new int[arraylenght];
            int[] array2 = new int[arraylenght];

            for (int index = 0; index < array1.Length; index++)
            {
                array1[index] = 0;
                array2[index] = 0;
            }
            ConvertToBinary(array1, first);
            ConvertToBinary(array2, second);
         
          
            for (int index = 0; index < arraylenght; index++)
            {
                arrayres[index] = array1[index];

            }

            while (i <= j)
            {
                arrayres[i] = array2[counter];
                i++;
                counter++;
            }
            return ConvertToInt(arrayres);
        }
        
    }
}
