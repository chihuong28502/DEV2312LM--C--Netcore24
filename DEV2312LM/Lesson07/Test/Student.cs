using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal  class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }
        int[] MarkList = new int[3];
        public Student() { }
        public Student(int studID, string studName,
            string studGender, int studAge,
            string studClass,
            float studAvgMark
            )
        {
            StudID = studID;
            StudName = studName;
            StudGender = studGender;
            StudAge = studAge;
            StudClass = studClass;
            StudAvgMark = studAvgMark;
        }
        public override string ToString()
        {
            // Định dạng cách hiển thị mỗi cuốn sách
            return $"ID: {StudID}, Tên sinh viên: {StudName}, Giới tính: {StudGender}, Tuổi: {StudAge}, Lớp: {StudClass}, Điểm tb:{StudAvgMark}";
        }
        public void SetMarkList()
        {
            Console.WriteLine("Enter marks for 3 subjects:");
            for (int i = 0; i < MarkList.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                MarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Print() {
            Console.WriteLine("StudID:{0} | StudName:{1} | StudGender:{2} | StudAge:{3} | " +
                "StudClass:{4} | StudAvgMark:{5}",StudID,StudName,StudGender, StudAge, StudClass, StudAvgMark);
        }
        public float CalAvg()
        {
            foreach (var i in MarkList)
            {
                StudAvgMark += i;
            }
            return StudAvgMark/3;
        }
    }
}
