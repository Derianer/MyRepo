using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace FindNextBiggerNumber
{
    public class Find
    {
        public static int FindNextBiggerNumber(int number)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();           
            int[] arr = ConvertToArray(number);
            int[] arrtemp = new int[arr.Length];
            CopyArray(arrtemp, arr);
            List<int> variants = new List<int>();
            
            for(int index =0; index < arr.Length; index++)
            {
                for (int index2 = index; index2 < arr.Length; index2++)
                {
                    if (arrtemp[index] < arrtemp[index2])
                    {
                        arrtemp[index] = arrtemp[index] ^ arrtemp[index2];
                        arrtemp[index2] = arrtemp[index2] ^ arrtemp[index];
                        arrtemp[index] = arrtemp[index] ^ arrtemp[index2];
                    }
                    int point = ConvertToNumber(arrtemp);

                    if (point > number)
                        variants.Add(point);


                    CopyArray(arrtemp, arr);
                }
            }
            if (!variants.Any())
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);
               
                return -1;              
            }
            while (true)
            {
                int minNum = variants.Min();
                arr = ConvertToArray(minNum);
                CopyArray(arrtemp, arr);
                variants.Clear();
                for (int index = 0; index < arr.Length; index++)
                {
                    for (int index2 = index; index2 < arr.Length; index2++)
                    {
                        if (arrtemp[index] > arrtemp[index2])
                        {
                            arrtemp[index] = arrtemp[index] ^ arrtemp[index2];
                            arrtemp[index2] = arrtemp[index2] ^ arrtemp[index];
                            arrtemp[index] = arrtemp[index] ^ arrtemp[index2];
                        }
                        int point = ConvertToNumber(arrtemp);

                        if (point > number && point < minNum)
                            variants.Add(point);


                        CopyArray(arrtemp, arr);
                    }
                }
                if (!variants.Any())
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                    Console.WriteLine("RunTime " + elapsedTime);
                    return minNum;
                }

            }
       
        }

        public static int[] ConvertToArray(int number)
        {           
            int count = (int)(Math.Log10(number)) + 1;
            int[] arr = new int[count];

            for (int index = arr.Length-1; index >= 0; index--)
            {
                arr[index] = number % 10;
                number = number / 10;
            }

            return arr;
        }


        public static int ConvertToNumber(int [] arr)
        {
            int number = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                number = number + arr[index];
                if (index != (arr.Length-1))
                    number *= 10;

            }
            return number;
        }

        public static void CopyArray(int[] arrtemp, int [] arr)
        {
            for (int index=0; index< arrtemp.Length; index++ )
            {
                arrtemp[index] = arr[index];
            }

        }

    }
}
