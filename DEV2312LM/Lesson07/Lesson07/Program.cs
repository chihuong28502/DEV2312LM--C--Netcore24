namespace Lesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "to", "ve", "hon" ,"nguoi","se","tro","to"};
            IEnumerable<string> result1 = from m in data select m;
            //foreach (var item in result1)
            //{
            //    Console.WriteLine("item" + item);
            //}
            IEnumerable<string> result2 = from m in data where m.Equals("to") select m;
            //foreach (var item in result2)
            //{
            //    Console.WriteLine("item" + item);
            //}
            IEnumerable<string> result3 = from m in data orderby m select m;
            //foreach (var item in result3)
            //{
            //    Console.WriteLine("item" + item);
            //}
            var ds = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };
            foreach (var item in ds)
            {
                Console.WriteLine("item" + item);
            }
        }

    }
}