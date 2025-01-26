namespace FactoryMethod;

/// Creator
public abstract class Factory
{
    public void CreatDoor()
    {
        Door door= this.GetDoor();

        door.Design();

        door.Build();

        door.Coloring();

        Console.WriteLine("Your Door is Ready");
    }
    public abstract Door GetDoor();
}