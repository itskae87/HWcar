using System;

namespace hwCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            cars firstOne = new cars(2019, "Subaru", "White");
            firstOne.CarType("Impreza WRX");

            cars secondOne = new cars(2019, "Acura", "Black");
            secondOne.CarType("TL");
        }
    }
    public class cars
    {
        public static int _year { set; get; }
        public static string _model { set; get; }
        public static string _color { set; get; }
        public cars(int year, string model, string color)
        {
            _year = year;
            _model = model;
            _color = color;
            Console.WriteLine("Let's get this dough so we buy {0}", model);
            Console.WriteLine("Of course I want to get the latest version {0}", year);
            Console.WriteLine("My car color is {0}", color);
        }
        public void CarType(string CT)
        {
            Console.WriteLine("My car type is {0}", CT);
        }
    }
}
