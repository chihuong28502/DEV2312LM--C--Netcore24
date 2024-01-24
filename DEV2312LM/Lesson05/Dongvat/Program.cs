namespace Dongvat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dongvat.AnCo.Bo bo = new Dongvat.AnCo.Bo(1,"x");
            bo.Display();
        }
    }
}
namespace Dongvat.AnCo
{
    internal class Bo {
        public int id{ get; set; }
        public string name{ get; set; }
        public Bo() { }
        public Bo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten"+name);
        }
    }
    internal class Trau {
        public int id { get; set; }
        public string name { get; set; }
        public Trau() { }
        public Trau(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten" + name);
        }
    }
    internal class De {
        public int id { get; set; }
        public string name { get; set; }
        public De() { }
        public De(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten" + name);
        }
    }
}
namespace Dongvat.AnThit
{
    internal class CaSau {
        public int id { get; set; }
        public string name { get; set; }
        public CaSau() { }
        public CaSau(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten" + name);
        }
    }
    internal class Ho{
        public int id { get; set; }
        public string name { get; set; }
        public Ho() { }
        public Ho(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten" + name);
        }
    }
    internal class SuTu {
        public int id { get; set; }
        public string name { get; set; }
        public SuTu() { }
        public SuTu(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ten" + name);
        }
    }
}
namespace Dongvat.AnTap
{
}