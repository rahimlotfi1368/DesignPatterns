namespace FactoryMethod;

public class IronDoor : Door
{
    public override void Build()
    {
        Console.WriteLine($"The {this.GetType().Name} Build Is Ready");
    }

    public override void Coloring()
    {
        Console.WriteLine($" The {this.GetType().Name} Coloring Is Ready");
    }

    public override void Design()
    {
        Console.WriteLine($"The {this.GetType().Name} Design Is Ready");
    }
}