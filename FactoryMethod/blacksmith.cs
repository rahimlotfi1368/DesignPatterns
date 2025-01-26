namespace FactoryMethod;

public class blacksmith : Factory
{
    public override Door GetDoor()
    {
        return new IronDoor();
    }
}