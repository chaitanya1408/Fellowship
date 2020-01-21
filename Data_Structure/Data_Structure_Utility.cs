using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Data_Structure
{
    public class Data_Structure_Utility
    {
        public static void PalindromeCheckerWorking(String string1)
        {
            Deque deque = new Deque();
            int i,flag=0; 
            char[] array1 = string1.ToCharArray();
            char[] array2 = string1.ToCharArray();
            int left = 0, right =array1.Length ;
            for (i=left;i<array1.Length;left++,right--)
            {
               if(left>=right)
                {
                    array1[i] = array1[right];
                }
            }
            for(i=0;i<array1.Length;i++)
            {
                if (array1[i] != array2[i])
                {
                    flag++;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("String is Pallindrome");
            }
        }
    }
}
