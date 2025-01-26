namespace FactoryMethod;

public class GenericFactory<T> : Factory where T : Door, new()
{
    public override T GetDoor()
    {
        return new T();
    }
}