
namespace Class_MethodOverloading
{
    internal class Test
    {
        public void Sum() 
        {
            Console.WriteLine("Empty");
        }
        public void Sum(int a)
        {
            Console.WriteLine(a);
        }
        public void Sum(int a , int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
