namespace FactoryMethod;

/// Concreate Creators
public class Carpenter : Factory
{
    public override Door GetDoor()
    {
        return new WoodenDoor();
    }
}