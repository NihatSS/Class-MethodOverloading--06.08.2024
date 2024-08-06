
namespace Class_MethodOverloading
{
    internal class Manga
    {
        public string name;
        public int chapterCount;
        public int color;
        public string author;


        public Manga(string text)
        {
            Console.WriteLine(text);
        }
        public Manga(int a)
        {
            Console.WriteLine(a);
        }
        public Manga()
        {
            Console.WriteLine("Welcome to manga shop");
        }
    }
}
