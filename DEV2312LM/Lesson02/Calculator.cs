using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    /// <summary>
    /// Lớp tính toán; static method; ref;out
    /// 
    /// </summary>
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y) {
            return x - y;
        }
        // method non static
        public int Mul(int x, int y) { return x * y; }
        // out parameter
        public void Cal(int x ,int y, out int cong,out int tru){
            cong= x+y;
            tru = x-y;
            }
        //ref parameter
        public void Swap(ref int a,ref int b) {
            int temp = a;
            a= b;
            b= temp;
        }
        public void Swap( int a,  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
