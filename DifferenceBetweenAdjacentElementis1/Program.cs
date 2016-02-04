using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenAdjacentElementis1
{
    class Program
    {
        /***Search an element in an array where difference between adjacent elements is 1.   
        For example: arr[] = {8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3}   
        Search for 3 and Output: Found at index 7 ***/ 


        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 };
            int end = arr.Length - 1;
            int i = 0;
            int x = 3;
            //int x = 8;
            //comparing from the leftmost element
            while(i < end)
            {
                //if equal then x is found at index i
                if(arr[i] == x )
                {
                    Console.WriteLine("Element {0} is found at index {1}", x, i);
                    break;
                }
                else
                //Since difference between adjacent element is 1 we can jump the difference then searching one by one
                {
                    i = i + (arr[i] - x);
                }
                
            }
        }

        
    }
}
