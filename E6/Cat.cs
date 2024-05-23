namespace E6;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Miao");
    }

    public override void Eat()
    {
        Console.WriteLine("Munch Munch");
    }
}