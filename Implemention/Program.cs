using FactoryMethod;

namespace Implemention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new GenericFactory<WoodenDoor>(); //new FactoryMethod.blacksmith();//Carpenter();
            factory.CreatDoor();
            Console.ReadKey();
        }
    }
}
