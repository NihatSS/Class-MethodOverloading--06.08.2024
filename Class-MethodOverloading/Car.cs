
namespace Class_MethodOverloading
{
    internal class Car
    {
        public string name;
        public int speed;
        public string color;


        public Car()
        {
            Console.WriteLine("Empty");
        }

        public Car(string name):this(name, 200)
        {
            Console.WriteLine(name);
        }

        public Car(string name , int speed)
        {
            Console.WriteLine(speed+ " " + name);
        }
    }
}
