using Exercise_10;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone something = new Phone();
            Phone something2 = new Phone("Samsung", "A21");
            Phone something3 = new Phone("Iphone", "Pro Max 13", "9th of November");
            something.Introduce();
            something2.Introduce();
            something3.Introduce();
        }
    }
}
