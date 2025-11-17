namespace FactoryMethod;

public class Blacksmith : Factory
{
    public override Door GetDoor()
    {
        return new IronDoor();
    }
}