using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    public class StringActions
    {
        public static string concat(string text1, string text2)
        {
           
            int i = 1;
            while (text1.ElementAt(text1.Length -i) == text2.First())
            {
                char ch1 = text1.ElementAt(text1.Length - i);
                char ch2 = text2.First();
               
                text2 = text2.Remove(0,1);
                i++;

            }
            return text1 + text2;
         }
            
            
                 
        }
            

    }

