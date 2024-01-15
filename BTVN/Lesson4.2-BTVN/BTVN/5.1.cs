using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class _5
    {
        public void ArrayNumber()
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 ,0};
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++) {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int sum = 0;
            int count = 0;

            Console.WriteLine(min);
            Array.Reverse(arr);
            Array.Sort(arr);
            foreach(var num in arr){ if (Check(num)){
                    Console.WriteLine(num);}}
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            double avg = sum / count;
            Console.WriteLine(avg);

        }
        
        static bool Check(int number)
        {

            if(number <= 1) { return false; }
            for(int i = 2; i <= Math.Sqrt(number); i++) { 
                if(number%i == 0) { return false; }
            }
            return true;
        }
    }
}
