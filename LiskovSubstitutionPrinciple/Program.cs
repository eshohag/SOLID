using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Apple();
            Fruit orange = new Orange();

            Console.WriteLine(apple.GetDetails());
            Console.WriteLine(orange.GetDetails());

            Console.ReadKey();
        }
    }
}
