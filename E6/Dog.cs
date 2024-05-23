namespace E6;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }


    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }

    public override void Eat()
    {
        Console.WriteLine("Munch");
    }
}