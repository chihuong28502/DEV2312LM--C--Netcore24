using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Example
{
        // cài đặt tính đa hình trong OOP c#
        // cùng tên
        // danh sách tham số # nhau || danh sách tham số # datatype
    internal class OverloadingDemo
    {
        public int Sum(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++) {
                tong += i;
            }
            return tong;
        }
        public int Sum(int a, int b)
        {
            int tong = 0;
            for (int i = a; i <= b; i++)
            {
                tong += i;
            }
            return tong;
        }
        public double Sum(double a, double b) {
            return a + b;
        }
    }
}
