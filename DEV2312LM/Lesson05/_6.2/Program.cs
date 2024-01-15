using System.Collections;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HastTable!");
            Hashtable ht = new Hashtable() {
                {1,"thu2" },
                {2,"thu3" },
                {3,"thu4" },
                {4,"thu5" },
                {5,"thu6" },
                {6,"thu7" },
                {7,"thuCN" },
            };
            foreach (var item in ht.Values)
            {
                if (item == "thu4")
                {
                    Console.WriteLine("thứ 4 có tồn tại");
                }
                else
                {
                    Console.WriteLine("0 có thứ 4");
                }
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("key:{0} || value: {1}", item, ht[item]);
            }
        }
    }
}