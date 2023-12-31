namespace FactoryMethod
{
    /// Product
    public abstract class Door
    {
        public abstract void Design();
        public abstract void Build();
        public abstract void Coloring();
    }

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

    /// Concreate Creators
    public class Carpenter : Factory
    {
        public override Door GetDoor()
        {
            return new WoodenDoor();
        }
    }

    public class blacksmith : Factory
    {
        public override Door GetDoor()
        {
            return new IronDoor();
        }
    }

    public class GenericFactory<T> : Factory where T : Door, new()
    {
        public override T GetDoor()
        {
            return new T();
        }
    }
    /// Concreate Products
    public class WoodenDoor : Door
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
}
