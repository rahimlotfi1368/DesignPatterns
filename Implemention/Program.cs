using FactoryMethod;

namespace Implemention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod.Factory factory = new FactoryMethod.GenericFactory<IronDoor>(); //new FactoryMethod.blacksmith();//Carpenter();
            factory.CreatDoor();
            Console.ReadKey();
        }
    }
}
