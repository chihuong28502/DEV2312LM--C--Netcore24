namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caar");
            List<Car> cars = new List<Car>() {

            new Car("name1","Hong1"),
            new Car("name2","red"),
            new Car("name3","red"),
            new Car("name4","Hong4"),
            new Car("name5","red"),
            new Car("name6","Hong6"),
            new Car("name7","red"),
            new Car("name8","Hon8g"),
            new Car("name9","red"),
            new Car("name10","Hong10"),
            };
            cars.RemoveAll(car => car.Color.Contains("red"));
            foreach (var item in cars)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}