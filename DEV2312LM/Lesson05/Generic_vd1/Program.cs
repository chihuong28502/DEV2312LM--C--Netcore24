using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Generic_vd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            Console.WriteLine("ArrayList!");
            // khởi tạo 1 collection ArrayList
            ArrayList arr = new ArrayList();
            //properties
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("==============================================");
            arr.Add("xin chào");
            arr.Add(111);

            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("==============================================");
            arr.Insert(1, "devmaster");
            printArrayList(arr);
            // add range Insert Range
            string[] names = { "Tung", "Cuc", "Truc", "Mai" };
            arr.AddRange(names);
            printArrayList(arr);

            arr.InsertRange(0, names);
            printArrayList(arr);
            // remove removeAt removeRange clear
            arr.Remove(111);
            printArrayList(arr);
            arr.RemoveAt(1);
            printArrayList(arr);

            // sort and Search
            // sort up,
            arr.Sort();
            printArrayList(arr);
            arr.Sort(new SortDesc()) ;
            printArrayList(arr);

            if (arr.Contains("Cuc"))
            {
                int index = arr.IndexOf("Cuc");
                Console.WriteLine("thấy tại"+ index);
            }
            else
            {
                Console.WriteLine("0 thấy ");

            }
        }
        static void printArrayList(ArrayList arr)
        {
            Console.WriteLine("=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>. danh sách phàn tử trong mảng");
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            };
        }
        class SortDesc: IComparer
        {
            public int Compare(object x, object y)
            {
                string a = x as string;
                string b = y as string;
                return b.CompareTo(a);

            }
        }
    }
}